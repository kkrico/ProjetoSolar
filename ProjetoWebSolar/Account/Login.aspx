<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjetoWebSolar.Account.Login" %>


<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <title>Projeto Solar - Login</title>
    <link rel="icon" href="/Content/Images/logovetor2.png" />
    <link rel='stylesheet' href="/Content/styles/bootstrap/bootstrap.min.css" />
    <link rel="stylesheet" href="/Content/styles/projetosolar/site.css" />
    <link rel="stylesheet" href="/Content/styles/projetosolar/login.css" />
</head>
<body class="bg-conta bg-login">
    <form id="mainform" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Path="~/Content/scripts/jquery/jquery-3.2.1.min.js" ScriptMode="Auto" />
                <asp:ScriptReference Path="~/Content/scripts/bootstrap/bootstrap.min.js" ScriptMode="Auto" />
            </Scripts>
        </asp:ScriptManager>
        <div class="container">
            <div class="row">
                <div class="col-sm-6 col-sm-offset-3 col-xs-12">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            Pré Cadastro de Visitante
                        </div>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-sm-12">
                                    <div class="form-group">
                                        <label class="control-label">Usuário</label>
                                        <asp:TextBox ID="txtuser1" runat="server" placeholder="Usuário" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-12">
                                    <div class="form-group">
                                        <label class="control-label">Senha</label>
                                        <asp:TextBox ID="txtpassword2" runat="server" placeholder="Password" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel-footer">
                            <div class="pull-right">
                                <asp:Button class="btn btn-primary btn-block" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                            </div>
                            <div style="margin-top: 0.5em">
                                <asp:Label ID="lblVersao" runat="server" Text="Label"></asp:Label>
                            </div>
                            <div style="clear: both"></div>
                        </div>
                    </div>
                </div>
            </div>

            <asp:Button ID="btnMnensagem" runat="server" Text="Button" Style="display: none;" />
            <asp:Button ID="btnFecharMsgMP" runat="server" Text="Button" Style="display: none;" />
            <asp:ModalPopupExtender ID="mpMensagemMP" runat="server" TargetControlID="btnMnensagem" PopupControlID="pnpMensagemMP" CancelControlID="btnFecharMsgMP" BackgroundCssClass="modalBackground" DropShadow="true"></asp:ModalPopupExtender>
            <asp:Panel ID="pnpMensagemMP" runat="server" BackColor="White" BorderStyle="Solid" BorderWidth="1px" Style="position: absolute; margin-left: auto; margin-right: auto; height: 145px; width: 288px; display: none">
                <asp:Label ID="lblMensagem" runat="server" Text="Label" Style="position: absolute; top: 20px; left: 101px; width: 171px; height: 60px;"></asp:Label>
                <asp:Button ID="btnFecharMensagem" runat="server" Text="OK" Style="position: absolute; top: 107px; left: 117px;" OnClick="btnFecharMensagem_Click" CssClass="btn btn-sm btn-primary"/>
                <asp:Image ID="imgMensagem" runat="server" Style="position: absolute; top: 9px; left: 9px; width: 72px; height: 74px;" />
            </asp:Panel>

        </div>
    </form>
</body>
</html>
