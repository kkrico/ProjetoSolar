<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebCadastrologin.aspx.cs" Inherits="ProjetoWebSolar.Account.WebCadastrologin" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
            .style1 {
                text-align: left;
            }
        </style>
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div class="container">
            <div class="jumbotron" 
                style="border-style: groove; position:absolute; top:117px; left: 199px; height: 572px; width: 1237px; bottom: -121px; background-color: #FFFFFF; text-align: left;">
                <asp:Image ID="imgfoto" runat="server" 
                    style="position:absolute; top: 116px; left: 997px; height: 325px; width: 225px;" />
                <h4 style="position:absolute; top: 66px; left: 37px;">Pesquisa</h4>
                <div class="style1">
                </div>
                <div style="border-style: outset; position:absolute; top: 102px; left: 31px; width: 484px; height: 442px;">
                    <asp:Label ID="lblnome" runat="server" Text="Nome" style="position:absolute; top: 35px; left: 10px;"></asp:Label>
                    <br />
                    <asp:Button ID="btnpesquisar" runat="server" Text="Pesquisar" class="btn btn-primary" style="position:absolute; top: 32px; left: 370px; height: 28px; width: 105px;" onclick="btnpesquisar_Click" />
                    <asp:TextBox ID="txtPesquisa" runat="server" CssClass="form-control input-sm" 
                        
                        style="position:absolute; top: 31px; left: 65px; height: 29px; width: 313px; right: 106px;" 
                        AutoPostBack="True" ontextchanged="txtPesquisa_TextChanged"></asp:TextBox>
                    <br />
                    <br />
                    <asp:GridView ID="grvdocnome" runat="server" 
                        CssClass="table table-hover table-striped" 
                        style="position:absolute; top: 77px; left: 11px; height: 307px;" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" onrowcommand="grvdocnome_RowCommand" AllowPaging="True" 
                        PageSize="7" onpageindexchanging="grvdocnome_PageIndexChanging1" >
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandArgument='<%# Eval("PERSID") %>' CommandName="Select" Text="Edit"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="PERSNO" HeaderText="Documento" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </div>
                <h4 style="position:absolute; top: 66px; left: 545px;">Cadastro</h4>
                <div style="border-style: outset; position:absolute; top: 102px; left: 541px; width: 428px; height: 442px;">
                    <asp:Label ID="lblnome1" runat="server" Text="Nome" style="position:absolute; top: 38px; left: 44px;"></asp:Label>
                    <asp:TextBox ID="txtLogin" runat="server" CssClass="form-control input-sm" style="position:absolute; top: 190px; left: 47px; height: 30px; width: 338px; right: 95px;"></asp:TextBox>
                    <asp:Label ID="lbldocumento" runat="server" Text="Documento" style="position:absolute; top: 104px; left: 46px;"></asp:Label>
                    <asp:Label ID="lbllogin" runat="server" Text="Login" style="position:absolute; top: 164px; left: 49px;"></asp:Label>
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control input-sm" style="position:absolute; top: 62px; left: 42px; height: 30px; width: 338px; right: 100px;"></asp:TextBox>
                    <asp:CheckBox ID="ckbadministrador" runat="server" style="position:absolute; top: 288px; left: 61px;" Text="  Administrador" />
                    <asp:Button ID="btnapagar" runat="server" Text="Apagar" class="btn btn-primary" style="position:absolute; top: 364px; left: 242px; height: 30px; width: 120px; right: 118px;" />
                    <asp:TextBox ID="txtdocumento" runat="server" CssClass="form-control input-sm" style="position:absolute; top: 126px; left: 44px; height: 30px; width: 338px; right: 98px;"></asp:TextBox>
                    <asp:Button ID="btnsalvar" runat="server" Text="Salvar" class="btn btn-primary" 
                        
                        style="position:absolute; top: 364px; left: 69px; height: 30px; width: 120px; right: 234px;" 
                        onclick="btnsalvar_Click" />
                </div>
            </div>
        </div>
    </asp:Content>