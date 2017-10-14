using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoWebSolar
{
    public class clBootStrap:Page
    {
        public enum WarningType
        {
            Success,
            Info,
            Warning,
            Danger
        }

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
        public void MensagemBox(string message, WarningType type)
        {
            var mainContentHolder = Master.FindControl("ContentPlaceHolder1") as ContentPlaceHolder;
            Panel pnl1=new Panel();
            pnl1.ID="Pn1";
            pnl1.CssClass="modal fade";

            Panel pnl2=new Panel();
            pnl2.ID="modal-dialog";
            pnl2.CssClass="modal fade";
            pnl1.Controls.Add(pnl2);

            Panel pnl3 =new Panel();
            pnl3.ID="Pn3";
            pnl3.CssClass="modal-content";
            pnl2.Controls.Add(pnl3);

            Panel pnl4=new Panel();
            pnl4.ID="Pn4";
            pnl4.CssClass="modal-header";
            pnl3.Controls.Add(pnl4);

            Panel pnl5=new Panel();
            pnl5.ID="Pn5";
            pnl5.CssClass="modal-body";
            pnl3.Controls.Add(pnl5);

            Panel pnl6=new Panel();
            pnl6.ID="Pn6";
            pnl6.CssClass="modal-footer";
            pnl3.Controls.Add(pnl6);

    //  <div class="modal fade" id="modalLogin" runat="server" role="dialog">
    //    <div class="modal-dialog">
    //        <div class="modal-content">
    //            <div class="modal-header">
    //                <h4>Warning</h4>
    //            </div>
    //            <div class="modal-body">
    //                <p>Watch out! Your about to be locked out.</p>
    //            </div>
    //            <div class="modal-footer">
    //                <a class="btn btn-primary" data-dismiss="modal">Close</a>
    //            </div>
    //        </div>
    //    </div>
    //</div>

          
            mainContentHolder.Controls.AddAt(0, pnl1);
        }
    }
}