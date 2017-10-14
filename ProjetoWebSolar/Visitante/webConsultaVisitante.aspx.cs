using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using hzLibSolar;
using HzLibConnection.Sql;

namespace ProjetoWebSolar.Visitante
{
    public partial class webConsultaVisitante : System.Web.UI.Page
    {
        private struct Dados
        {
            public string cmpAUTHID { get; set; }
            public string SHORTNAME { get; set; }
            public string NAME { get; set; }
        }
        private void ExibirMensagemErro(string msg)
        {
            Site master = (Site)this.Master;
            master.Mensagem(msg, ProjetoWebSolar.Site.TipoMensagem.Erro, "");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                List<Dados> lstDados = new List<Dados>();
                Dados d = new Dados();
            }
            catch (Exception ex)
            {

                ExibirMensagemErro(ex.Message);
            }

        }

        protected void btnpesquisar_Click(object sender, EventArgs e)
        {
            if (txtpesquisa.Text.Length <= 4)
            {
                Site master = (Site)this.Master;
                master.Mensagem("A consulta deve ter pelo menos 4 caracteres", ProjetoWebSolar.Site.TipoMensagem.Informacao,"");
            }
            else
            {
                Pesquisar();
            }
        }
        private void Pesquisar()
        {
            try
            {
                DataTable dtpesquisa = tblPERSONS.GETTBancos(Global.GetConnection(), txtpesquisa.Text);
                grvdocumentonome.DataSource = dtpesquisa;
                grvdocumentonome.DataBind();
            }
            catch (Exception ex)
            {

                ExibirMensagemErro("Erro na pesquisa!:" + ex.Message);
            }
        }
        protected void grvdocumentonome_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Select")
                {
                    string[] origens = e.CommandArgument.ToString().Split('_');

                    Response.Redirect("VisitanteCadastro.aspx?PersID=" + origens[1] + "&Origem=" + origens[0] + "&IDPERSON=" + origens[2]);
                }
            }
            catch (Exception ex)
            {
                ExibirMensagemErro(ex.Message);
            }
         }

        protected void btnnovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("VisitanteCadastro.aspx");
        }

        protected void grvdocumentonome_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    if (DataBinder.Eval(e.Row.DataItem, "ORIGEM").ToString().Trim() == "SQL")
                    {
                        e.Row.BackColor = System.Drawing.Color.LightSkyBlue;
                    }
                }
            }
            catch (Exception ex)
            {

                ExibirMensagemErro("Erro ao carregar a grid!:" + ex.Message);
            }
        }

        protected void grvdocumentonome_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                grvdocumentonome.PageIndex = e.NewPageIndex;
                Pesquisar();
            }
            catch (Exception ex)
            {
                ExibirMensagemErro("Erro na paginação!");
            }
        }

        protected void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtpesquisa.Text.Length <= 4)
            {
                Site master = (Site)this.Master;
                master.Mensagem("A consulta deve ter pelo menos 4 caracteres", ProjetoWebSolar.Site.TipoMensagem.Informacao, "");
            }
            else
            {
                Pesquisar();
            }
        }
    }
}