<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="webConsultaVisitante.aspx.cs" Inherits="ProjetoWebSolar.Visitante.webConsultaVisitante" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
            <div class="jumbotron" 
                
                
                style="border-style: groove; position:absolute; top:90px; left: 454px; height: 567px; width: 741px; background-color: #FFFFFF;">
                <fieldset style="position:absolute; top: 10px; left: -3px; height: 24px; width: 735px;">
                    <legend style="position:absolute; top: 6px; left: 100px; font-size: large;">Pesquisa por Nome / Documento</legend>
                </fieldset>

                <div style="border-style: outset; position:absolute; top:61px; left: 67px; height: 59px; width: 600px; background-color: #FFFFFF; right: 96px;">
                    <%--<asp:Label ID="lblpesquisa" runat="server" Text="Pesquisa por Nome / Documento" style="position:absolute; top: 3px; left: 16px; height: 21px; width: 320px; right: 246px; text-align: left;"></asp:Label>--%>

                        <asp:Button ID="btnpesquisar" runat="server" Text="Pesquisar" 
                        class="btn btn-primary" 
                        style="position:absolute; top: 15px; left: 344px; height: 30px; width: 90px;" 
                        onclick="btnpesquisar_Click" />

                        <asp:Button ID="btnnovo" runat="server" Text="Novo" class="btn btn-primary" 
                        style="position:absolute; top: 15px; left: 445px; height: 30px; width: 90px;" 
                        onclick="btnnovo_Click" />

                        <asp:TextBox ID="txtpesquisa" runat="server" 
                        CssClass="form-control input-sm" 
                        
                        style="position:absolute; top: 15px; left: 15px; height: 27px; width: 300px; right: 285px;" 
                        AutoPostBack="True" ontextchanged="txtpesquisa_TextChanged"></asp:TextBox>

                        <asp:GridView ID="grvdocumentonome" runat="server" 
                        CssClass="table table-hover table-striped" 
                        style="position:absolute; top: 64px; left: -1px;  width: 600px;" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" BorderStyle="Ridge" AllowPaging="True" 
                        onrowcommand="grvdocumentonome_RowCommand" 
                        onrowdatabound="grvdocumentonome_RowDataBound" 
                        onpageindexchanging="grvdocumentonome_PageIndexChanging">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:TemplateField ShowHeader="False">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                                            CommandArgument='<%# Eval("ORIGEM") +  "_" + Eval("PERSID") + "_" + Eval("IDPERSON")  %>' CommandName="Select" Text="Editar"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="PASSPORTNO" HeaderText="Documento">
                                    <HeaderStyle Width="100px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="NOME" HeaderText="Nome">
                                    <HeaderStyle Width="600px" HorizontalAlign="Center" />
                                </asp:BoundField>
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
            </div>
            </div>
        
    </asp:Content>