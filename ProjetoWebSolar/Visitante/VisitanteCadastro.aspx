<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VisitanteCadastro.aspx.cs" Inherits="ProjetoWebSolar.Visitante.VisitanteCadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script src="../Mascara/jquery-1.8.3.min.js" type="text/javascript"></script>
    <script src="../Mascara/jquery.maskedinput.js" type="text/javascript"></script>
    <script src="../Mascara/jquery.maskedinput.min.js" type="text/javascript"></script>

    <script type="text/javascript">
        $(function () {
            $("#ContentPlaceHolder1_txtnascimento").mask("99/99/9999");
            $("#ContentPlaceHolder1_txtCpf").mask("999.999.999-99");

            $("input").blur(function () {
                $("#info").html("Unmasked value: " + $(this).mask());
            }).dblclick(function () {
                $(this).unmask();
            });
        });

    </script>

    <div class="row">
        <div class="col-md-12">
            <div class="panel" style="border-radius: 0px">
                <div class="panel-body">
                    <div class="row">
                        <div class="text-center">
                            <h3>Dados Visitantes</h3>
                        </div>
                        <hr />
                    </div>
                    <div class="row">
                        <div class="col-md-2">
                            <asp:Image ID="imgfoto" runat="server" CssClass="img-responsive"/>
                        </div>
                        <div class="col-md-10">
                            <div class="row">
                                <div class="col-md-5">
                                    <div class="form-group">
                                        <asp:Label ID="lblnome" runat="server" Text="Nome" CssClass="control-label"></asp:Label>
                                        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control input-sm"
                                            Style="text-transform: uppercase"
                                            MaxLength="120"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <asp:Label ID="lblcpf" runat="server" Text="CPF"></asp:Label>
                                    <asp:TextBox ID="txtCpf" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                </div>
                                <div class="col-md-4">
                                    <asp:Label ID="lblRG" runat="server" Text="RG"></asp:Label>
                                    <asp:TextBox ID="txtRG" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4">
                                    <asp:Label ID="Label1" runat="server" Text="RG"></asp:Label>
                                    <asp:TextBox ID="txtnascimento" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                </div>
                                <div class="col-md-4">
                                    <asp:Label ID="lbltipovisitante" runat="server" Text="Tipo Visitante"></asp:Label>
                                    <asp:DropDownList ID="ddltipovisitante" runat="server"
                                        CssClass="form-control input-sm" DataTextField="DISPLAYTEXTCUSTOMER" DataValueField="PERSCLASSID">
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-4">
                                    <asp:Label ID="lbltelfixo" runat="server" Text="Telefone Fixo"></asp:Label>
                                    <asp:TextBox ID="txtTelFixo" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
