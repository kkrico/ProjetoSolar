using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using hzLibSolar;
using System.Diagnostics;

namespace ProjetoWebSolar.Account
{
    public partial class Login : System.Web.UI.Page
    {
        public enum TipoMensagem { Erro, Informacao, Salvar }
        protected void Page_Load(object sender, EventArgs e)
        {
            string msg = "";
            double ver = getInternetExplorerVersion();
            if (ver > 0.0)
            {
                if (ver < 10.0)
                {
                    msg = "Para o funcionamento adequado da aplicação recomendamos o versão do  Internet Explorer 10 ou superior. Ou utilize outros navegadores Firefox ou Google Crome.";
                    Response.Write("<script>alert('" + msg + "');</script>");
                }
            }
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;

            lblVersao.Text = "v:" + version;
        }
        private float getInternetExplorerVersion()
        {
            // Returns the version of Internet Explorer or a -1
            // (indicating the use of another browser).
            float rv = -1;
            System.Web.HttpBrowserCapabilities browser = Request.Browser;
            if (browser.Browser == "IE" || browser.Browser == "InternetExplorer")
                rv = (float)(browser.MajorVersion + browser.MinorVersion);
            return rv;
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Logar();


            //Response.Redirect("../Visitante/webConsultaVisitante.aspx");

        }
        private void Logar()
        {
            try
            {
                //if (string.IsNullOrEmpty(txtuser1.Text) == true)
                //{
                //    Mensagem("O login não foi preenchido!", TipoMensagem.Erro, "");
                //    return;
                //}
                //if (txtuser1.Text.IndexOf(@"\") == -1)
                //{
                //    Mensagem("O domínio deve ser preenchido!", TipoMensagem.Erro, "");
                //    return;
                //}
                //if (string.IsNullOrEmpty(txtpassword2.Text) == true)
                //{
                //    Mensagem("A senha não foi preenchida!", TipoMensagem.Erro, "");
                //    return;
                //}

                string dominioUsuario = txtuser1.Text;
                dominioUsuario = dominioUsuario.Replace(@"\", "|");
                string[] arrayDominio = dominioUsuario.Split('|');
                string usu = arrayDominio[1];
                string domi = arrayDominio[0];


                if (tblPERMISSOES.LoginRede(usu, txtpassword2.Text, domi) == true)
                {
                    if (tblPERMISSOES.LoginBIS(Global.GetConnection(), usu) == false)
                    {
                        Mensagem("Não encontramos o seu cadastro no BIS!", TipoMensagem.Erro, "");
                        return;
                    }
                    Session.Add("Login", usu);
                    Session.Add("cmpAutoPERSID", tblPERMISSOES.AuthoBIS(Global.GetConnection(), usu));
                    Response.Redirect("../Visitante/webConsultaVisitante.aspx");
                }
                else
                {
                    Mensagem("A senha ou login estão errados!", TipoMensagem.Erro, "");
                    return;
                }
            }
            catch (Exception ex)
            {

                Mensagem(ex.Message, TipoMensagem.Erro, "");
            }

        }
        public void Mensagem(string msg, TipoMensagem tipomsg, string redirecionar)
        {
            switch (tipomsg)
            {
                case TipoMensagem.Erro:
                    imgMensagem.ImageUrl = "/Content/images/error.png";
                    break;
                case TipoMensagem.Informacao:
                    imgMensagem.ImageUrl = "/Content/images/get_info.png";
                    break;
                case TipoMensagem.Salvar:
                    imgMensagem.ImageUrl = "/Content/images/get_info.png";
                    break;
                default:
                    break;
            }

            Session.Add("Redirecionar", redirecionar);
            lblMensagem.Text = msg;
            lblMensagem.ToolTip = tipomsg.ToString();
            mpMensagemMP.Show();
        }
        protected void btnFecharMensagem_Click(object sender, EventArgs e)
        {

        }

    }
}