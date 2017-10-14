using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using hzLibSolar;
using System.Data;
using System.Configuration;
using System.IO;

namespace ProjetoWebSolar.Account
{
    public partial class WebCadastrologin : System.Web.UI.Page
    {
        private void ExibirMensagemErro(string msg)
        {
            Site master = (Site)this.Master;
            master.Mensagem(msg, ProjetoWebSolar.Site.TipoMensagem.Erro, "");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnpesquisar_Click(object sender, EventArgs e)
        {

            Pesquisar();
        }
        public void Pesquisar()
        {
            DataTable dtP = tblPERSONS.GETFuncionarios(Global.GetConnection(), txtPesquisa.Text);
            grvdocnome.DataSource = dtP;
            grvdocnome.DataBind();
        }
        protected void grvdocnome_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                tblPERSONS pers = new tblPERSONS(Global.GetConnection(), e.CommandArgument.ToString());
                txtNome.Text = pers.cmpFIRSTNAME + " " + pers.cmpLASTNAME;
                txtdocumento.Text = pers.PERSNO;
                Session.Add("PERSID", e.CommandArgument.ToString());

                tblPERMISSOES perm = new tblPERMISSOES(Global.GetConnection(), "", pers.cmpPERSID);
                txtLogin.Text = perm.cmpLOGINREDE;
                ckbadministrador.Checked =  perm.cmpADMINISTRADOR;

                //Fotos
                string diretorio = ConfigurationSettings.AppSettings["DirFotos"].ToString();
                diretorio += "//" + e.CommandArgument.ToString() + ".jpg";
                if (File.Exists(diretorio) == true)
                {
                    byte[] imageBytes = System.IO.File.ReadAllBytes(diretorio);
                    string base64String = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
                    //this.testImage.Src = "data:image/jpeg;base64," + base64String;

                    imgfoto.ImageUrl = "data:image/jpeg;base64," + base64String;
                }
                else
                {
                    string imgLocal = Server.MapPath("../Imagens/logo1.png");
                    byte[] imageBytes = System.IO.File.ReadAllBytes(imgLocal);
                    string base64String = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
                    //this.testImage.Src = "data:image/jpeg;base64," + base64String;

                    imgfoto.ImageUrl = "data:image/jpeg;base64," + base64String;
                }
            }

        }

        protected void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                tblPERMISSOES perm = new tblPERMISSOES(Global.GetConnection(), "", Session["PERSID"].ToString());
                perm.cmpLOGINREDE = txtLogin.Text; ;
                perm.cmpADMINISTRADOR = ckbadministrador.Checked;
                perm.cmpPERSID = Session["PERSID"].ToString();
                perm.Save(Global.GetConnection());

                Site master = (Site)this.Master;
                master.Mensagem("Registro salvo com sucesso!", ProjetoWebSolar.Site.TipoMensagem.Informacao, "");
            }
            catch (Exception ex)
            {
                ExibirMensagemErro("Erro ao salvar a permissão!");
                throw;
            }
        }

        protected void grvdocnome_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvdocnome.PageIndex = e.NewPageIndex;
            Pesquisar();
        }

        protected void btnsalvar_Click1(object sender, EventArgs e)
        {

        }

        protected void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
     

                Pesquisar();

        }


        protected void grvdocnome_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            grvdocnome.PageIndex = e.NewPageIndex;
            Pesquisar();
        }
    }
}