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

        <div class="container">
            <div class="jumbotron" 
                style="border-style: groove; position:absolute; top:60px; left: 387px; height: 836px; width: 931px; bottom: -669px; background-color: #FFFFFF; margin-right: 21px;" 
                align="center">
                <asp:ImageButton ID="btnsalvar" autofocus="Salvar" class="card" 
                    style="position:absolute; top: 19px; left: 24px; height: 34px; width: 38px;" 
                    runat="server" src="../Imagens/disquete.png" onclick="btnsalvar_Click" />
                <fieldset>
                    <legend style="position:absolute; top: 26px; left: 210px; font-size: large; text-align: center;" 
                        align="right">Dados Visitantes</legend>
                    <div style="border-style: outset;  position:absolute; top:60px; left: 19px; height: 376px; width: 886px; bottom: 476px; background-color: #FFFFFF;">

                        <asp:Image ID="imgfoto" runat="server" 
                            Height="155px" Width="170px" 
                            style="position:absolute; top: 32px; left: 14px; height: 167px; width: 164px;" />
                        <asp:Label ID="lblnome" runat="server" Text="Nome" style="position:absolute; top: 0px; left: 191px; height: 18px; width: 54px; margin-top: 0px; text-align: justify;"></asp:Label>
                        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control input-sm" 
                            style="position:absolute; top: 20px; left: 191px;  height: 21px; width: 417px; text-align: justify; right: 103px;text-transform:uppercase" 
                            MaxLength="120"></asp:TextBox>
                        <asp:Label ID="lblcpf" runat="server" Text="CPF" style="position:absolute; top: 45px; left: 191px; height: 18px; width: 54px; margin-top: 0px; text-align: justify;"></asp:Label>
                        <asp:TextBox ID="txtCpf" runat="server" CssClass="form-control input-sm" style="position:absolute; top: 65px; left: 190px; height: 21px; width: 120px; right: 398px; text-align: justify;"></asp:TextBox>
                        <asp:Label ID="lblRG" runat="server" Text="RG" style="position:absolute; top: 45px; left: 340px; height: 18px; width: 54px; margin-top: 0px; text-align: justify;"></asp:Label>
                        <asp:TextBox ID="txtRG" runat="server" CssClass="form-control input-sm" style="position:absolute; top: 65px; left: 338px; height: 21px; width: 120px; right: 228px; text-align: justify;"></asp:TextBox>
                        <asp:Label ID="lblnascimento" runat="server" Text="Nascimento" style="position:absolute; top:45px; left: 490px; height: 18px; width: 50px; margin-top: 0px; text-align: justify; right: 161px;"></asp:Label>

                        <asp:TextBox ID="txtnascimento" runat="server" CssClass="form-control input-sm" style="position:absolute; top: 65px; left: 488px; height: 21px; width: 120px; right: 78px; text-align: justify;"></asp:TextBox>
                        
                        <asp:Label ID="lbltipovisitante" runat="server" Text="Tipo Visitante" 
                            
                            style="position:absolute; top: 90px; left: 191px; height: 27px; width: 96px; margin-top: 0px; text-align: justify;"></asp:Label>
                        <asp:DropDownList ID="ddltipovisitante" runat="server" 
                            CssClass="form-control input-sm" 
                            style="position:absolute; top: 110px; left: 195px; height: 26px; width: 268px; right: 423px; text-align: justify;" 
                            DataTextField="DISPLAYTEXTCUSTOMER" DataValueField="PERSCLASSID"></asp:DropDownList>
                        <asp:Label ID="lbltelfixo" runat="server" Text="Telefone Fixo" style="position:absolute; top: 139px; left: 191px; height: 27px; width: 96px; margin-top: 0px; text-align: justify;"></asp:Label>
                        <asp:TextBox ID="txtTelFixo" runat="server" CssClass="form-control input-sm" 
                            style="position:absolute; top: 158px; left: 191px; height: 21px; width: 120px; right: 575px; text-align: justify;"></asp:TextBox>
                        <asp:Label ID="lbltelcelular" runat="server" Text="Telefone Celular" style="position:absolute; top: 139px; left: 339px; height: 27px; width: 109px; margin-top: 0px; text-align: justify;"></asp:Label>
                        <asp:TextBox ID="txtTelCelular" runat="server" CssClass="form-control input-sm" 
                            style="position:absolute; top: 158px; left: 338px; height: 21px; width: 120px; text-align: justify;"></asp:TextBox>
                        <asp:Label ID="lblemail" runat="server" Text="E-Mail" 
                            style="position:absolute; top: 182px; left: 191px; height: 18px; width: 54px; margin-top: 0px; text-align: justify;"></asp:Label>
                        <asp:TextBox ID="txtemail" runat="server" CssClass="form-control input-sm" 
                            style="position:absolute; top: 202px; left: 191px; height: 25px; width: 417px; right: 278px; text-align: justify;"></asp:TextBox>
                        <asp:Label ID="lblempresa" runat="server" Text="Empresa" 
                            style="position:absolute; top: 230px; left: 191px; width: 54px; text-align: left; height: 18px;"></asp:Label>
                        <asp:DropDownList ID="ddlempresa" runat="server" 
                            CssClass="form-control input-sm" 
                            style="position:absolute; top: 250px; left: 191px; height: 26px; width: 417px;" 
                            DataTextField="COMPANYNO" DataValueField="COMPANYID">
                        </asp:DropDownList>
                        <fieldset>
                        <h5 align="left" style="position: absolute; top: 282px; left: 191px;">Dados do veículo</h5>
                           <%-- <legend style="position:absolute; top: 286px; left: 100px; font-size: large;">Dados do veículo</legend>--%>
                            <asp:Label ID="lblplaca" runat="server" Text="Placa" style="position:absolute; top: 318px; left: 191px;"></asp:Label>
                            <asp:TextBox ID="txtplaca" runat="server" CssClass="form-control input-sm" style="position:absolute; top: 338px; left: 191px; height: 21px; width: 120px; text-align: justify;"></asp:TextBox>
                            <asp:Label ID="lblmarca" runat="server" Text="Marca" style="position:absolute; top: 318px; left: 340px; height: 20px;"></asp:Label>
                            <asp:TextBox ID="txtmarca" runat="server" CssClass="form-control input-sm" style="position:absolute; top: 338px; left: 391px; left: 338px; height: 21px; width: 120px; right: 387px; text-align: justify;"></asp:TextBox>
                            <asp:Label ID="lblmodelo" runat="server" Text="Modelo" style="position:absolute; top: 318px; left: 490px;"></asp:Label>
                            <asp:TextBox ID="txtmodelo" runat="server" CssClass="form-control input-sm" style="position:absolute; top: 338px; left: 488px;height: 21px; width: 120px; right: 237px; text-align: justify;"></asp:TextBox>
                        </fieldset>
                    </div>
                </fieldset>
                <fieldset>
                    <legend style="position:absolute; top: 455px; left: 220px; font-size: large; text-align: center;" 
                        align="right">Autorização</legend>
                    <div style="border-style: outset;  position:absolute; top:491px; left: 22px; height: 310px; width: 886px; bottom: 111px; background-color: #FFFFFF;">
                        <asp:Panel ID="Panel1" runat="server" 
                            style="position:absolute; top: 110px; left: 17px;  width: 384px; right: 485px; height: 194px;" 
                            ScrollBars="Vertical">
                        <asp:GridView ID="grvautorizacoes" runat="server" 
                                CssClass="table table-hover table-striped" 
                                style="position:absolute; top: 0px; left: 5px;  width: 352px; right: 27px; height: 65px;" 
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                                GridLines="None" ViewStateMode="Enabled" 
                                DataKeyNames="cmpAUTHID ,SHORTNAME">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:TemplateField>
                                    <EditItemTemplate>
                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="ckSelecionar" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Nome" DataField="SHORTNAME" />
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
                         </asp:Panel>
                        <asp:Button ID="btnretornar" runat="server" Text="&lt;&lt;" class="btn btn-primary" 
                            style="position:absolute; top: 209px; left: 421px; height: 30px; width: 60px; right: 405px; margin-top: 5px; bottom: 66px;" 
                            onclick="btnretornar_Click" />
                        <asp:Button ID="btnproximo" runat="server" Text="&gt;&gt;" 
                            class="btn btn-primary" 
                            style="position:absolute; top: 153px; left: 421px; height: 30px; width: 60px; right: 405px; margin-top: 5px;" 
                            onclick="btnproximo_Click" />
                        <asp:Panel ID="Panel2" runat="server" 
                            style="position:absolute; top: 111px; left: 496px;  width: 384px; right: 11px; height: 194px;" 
                            ScrollBars="Vertical">
                        <asp:GridView ID="grvautorizacaoselecionada" runat="server" 
                                CssClass="table table-hover table-striped" 
                                style="position:absolute; top: -6px; left: 6px; height: 35px; width: 353px; margin-top: 5px; bottom: -47px;" 
                                CellPadding="4" ForeColor="#333333" GridLines="None" 
                                AutoGenerateColumns="False" ViewStateMode="Enabled" 
                                DataKeyNames="cmpAUTHID,SHORTNAME">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:TemplateField>
                                    <EditItemTemplate>
                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="ckSelecionar" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Nome" DataField="SHORTNAME" />
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
                        </asp:Panel>
                        <asp:Label ID="lblmotivodavisita" runat="server" Text="Motivo da Visita" style="position:absolute; top: 0px; left: 21px;"></asp:Label>
                        <asp:DropDownList ID="ddlmotivodavisita" runat="server" 
                            CssClass="form-control input-sm" 
                            style="position:absolute; top: 20px; left: 19px; height: 26px; width: 435px;">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>Visita Técnica</asp:ListItem>
                            <asp:ListItem>Reunião</asp:ListItem>
                            <asp:ListItem>Fiscalização</asp:ListItem>
                            <asp:ListItem>Entrega</asp:ListItem>
                            <asp:ListItem>Outros</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="lbldatainicio" runat="server" Text="Data Inicio" style="position:absolute; top: 50px; left: 6px; height: 14px; width: 93px; margin-top: 5px; bottom: 298px;"></asp:Label>
                        <asp:TextBox ID="txtdatainicio" runat="server" CssClass="form-control input-sm" 
                            style="position:absolute; top: 75px; left: 19px; height: 21px; width: 120px; bottom: 273px; " 
                            Enabled="False"></asp:TextBox>
                        <asp:Button ID="btncalendar2" runat="server" Text="*" class="btn btn-primary" 
                            style="position:absolute; top: 74px; left: 131px; width: 30px; height: 23px; right: 725px;" 
                            ForeColor="Black" onclick="btncalendar2_Click" />
                        <asp:Label ID="lbldatafim" runat="server" Text="Data Fim" 
                            style="position:absolute; top: 55px; left: 288px; height: 15px; width: 93px; bottom: 240px;"></asp:Label>
                        <asp:TextBox ID="txtdatafim" runat="server" CssClass="form-control input-sm" 
                            style="position:absolute; top: 74px; left: 307px; height: 23px; width: 120px;  bottom: 213px; " 
                            Enabled="False"></asp:TextBox>
                        <asp:Button ID="btncalendar3" runat="server" Text="*" class="btn btn-primary" 
                            style="position:absolute; top: 73px; left: 423px; width: 30px; height: 23px; right: 433px;" 
                            ForeColor="Black" onclick="btncalendar3_Click" />
                    </div>
                </fieldset>
                <asp:Button ID="Button5" runat="server" Text="Button" style="display: none;" />
                <asp:ModalPopupExtender ID="ModCentro" runat="server" TargetControlID="Button5" PopupControlID="divPop" CancelControlID="btnFecharCalendario" BackgroundCssClass="modalBackground"></asp:ModalPopupExtender>
                <asp:Panel ID="divPop" runat="server" BackColor="White" BorderStyle="Solid" 
                    BorderWidth="1px" 
                    style="position:absolute; top: 581px; left: -211px; height: 255px; width: 201px;">
                    <asp:Calendar ID="Calendar1" runat="server" 
                        style="position:absolute; top: 5px; left: 0px;" BackColor="White" 
                        BorderColor="#999999" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" 
                        Height="180px" Width="200px" CellPadding="4" DayNameFormat="Shortest" 
                        onselectionchanged="Calendar1_SelectionChanged">
                        <DayHeaderStyle Font-Bold="True" Font-Size="7pt" BackColor="#CCCCCC" />
                        <NextPrevStyle VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#808080" />
                        <SelectedDayStyle BackColor="#666666" ForeColor="White" Font-Bold="True" />
                        <SelectorStyle BackColor="#CCCCCC" />
                        <TitleStyle BackColor="#999999" Font-Bold="True" BorderColor="Black" />
                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <WeekendDayStyle BackColor="#FFFFCC" />
                    </asp:Calendar>
                    <asp:Button ID="btnFecharCalendario" runat="server" Text="Fechar" 
                        style="position:absolute; top: 200px; left: 77px; bottom: 29px;" />
                </asp:Panel>
            </div>
            </div>


    </asp:Content>