<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjetoWebSolar.Account.Login" %>

    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

    <html>
    <head>

        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <!-- Descrição do Logo-->
        <meta name="description" content="" />
        <meta name="author" content="" />
        <link rel="icon" href="../Imagens/logovetor2.png" />
        <style type="">
            body { background-image: url("../Imagens/masterpage1.png"); background-attachment: fixed; background-position: center; background-repeat: no-repeat; background-size: 100% 100%; padding-top: 100px; /*painel de login se movimenta*/ } }
        </style>
        <%--<title></title>--%>

            <link rel='stylesheet prefetch' href="../bootstrap-3.3.7-dist/css/bootstrap.min.css" />
            <link rel="stylesheet" href="../bootstrap-3.3.7-dist/css/style.css" />
    </head>
    <body>
        <div id="Div1" class="wrapper" runat="server">
            <form id="Form1" class="form-signin" runat="server">
                <br />

                <fieldset style="height: 230px">
                    <legend style="width: 253px">Pré Cadastro de Visitantes</legend>
                    <asp:TextBox ID="txtuser1" runat="server" placeholder="User" CssClass="form-control input-lg"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txtpassword2" runat="server" placeholder="Password" CssClass="form-control input-lg" TextMode="Password"></asp:TextBox>
                    <br />
                    <asp:Button class="btn btn-lg btn-primary btn-block" ID="btnLogin" runat="server" Text="Login" onclick="btnLogin_Click" />
                    <br />
                    
                </fieldset>
                <br />
                                <asp:ScriptManager ID="ScriptManager1" runat="server">

                </asp:ScriptManager>
                <asp:Label ID="lblVersao" runat="server" Text="Label"></asp:Label>
                <asp:Button ID="btnMnensagem" runat="server" Text="Button" style="display: none;" />
                <asp:Button ID="btnFecharMsgMP" runat="server" Text="Button" style="display: none;" />
                <asp:ModalPopupExtender ID="mpMensagemMP" runat="server" TargetControlID="btnMnensagem" PopupControlID="pnpMensagemMP" CancelControlID="btnFecharMsgMP" BackgroundCssClass="modalBackground" DropShadow=true></asp:ModalPopupExtender>

                <asp:Panel ID="pnpMensagemMP" runat="server" BackColor="White" BorderStyle="Solid" BorderWidth="1px" style="position:absolute; margin-left:auto;margin-right:auto; height: 145px; width: 288px; display:none">

                    <asp:Label ID="lblMensagem" runat="server" Text="Label" style="position:absolute; top: 20px; left: 101px; width: 171px; height: 60px;"></asp:Label>
                    <asp:Button ID="btnFecharMensagem" runat="server" Text="OK" style="position:absolute; top: 107px; left: 117px; bottom: 12px; width: 91px;" onclick="btnFecharMensagem_Click" />

                    <asp:Image ID="imgMensagem" runat="server" style="position:absolute; top: 9px; left: 9px; width: 72px; height: 74px;" />

                </asp:Panel>

            </form>
        </div>
    </body>
    </html>