using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoWebSolar
{
    public partial class Site : System.Web.UI.MasterPage
    {
        public string Titulo { get; set; }
        public enum WarningType
        {
            Success,
            Info,
            Warning,
            Danger
        }
        public enum TipoMensagem { Erro, Informacao, Salvar }

        public void ShowNotification(string message, WarningType type)
        {
            var mainContentHolder = Master.FindControl("ContentPlaceHolder1") as ContentPlaceHolder;
            Panel notificationPanel = new Panel();
            {
                LiteralControl closeButton = new LiteralControl();
                closeButton.Text = "<a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>";

                Label notificationMessage = new Label() { Text = message };

                notificationPanel.Controls.Add(closeButton);
                notificationPanel.Controls.Add(notificationMessage);
            }
            notificationPanel.CssClass = string.Format("alert alert-{0} alert-dismissable", type.ToString().ToLower());
            notificationPanel.Attributes.Add("role", "alert");

            mainContentHolder.Controls.AddAt(0, notificationPanel);
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
            pnpMensagemMP.Visible = true;
            Session.Add("Redirecionar",redirecionar);
            lblMensagem.Text = msg;
            lblMensagem.ToolTip = tipomsg.ToString();
            mpMensagemMP.Show();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Login"] == null)
            //{
            //    this.Response.Redirect("~/Account/Login.aspx");
            //}
        }

        protected void btnFecharMensagem_Click(object sender, EventArgs e)
        {
            //string redirecionar = Session["Redirecionar"].ToString();
            //if (string.IsNullOrEmpty(redirecionar) == false)
            //{
            //    pnpMensagemMP.Visible = false;
            //    this.Response.Redirect(redirecionar);
            //}
        }

    }
}