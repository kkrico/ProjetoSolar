<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Webformulariovisitante.aspx.cs" Inherits="ProjetoWebSolar.Webformulariovisitante2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <div style="height: 177px; width: 197px">
        
        <asp:Image ID="Image1" style="position:relative; top: 39px; left: 113px; height: 201px; width: 164px;"  
                runat="server" 
                src="../Imagens/logo1.png"/>
                      
            <br />
            <br />
            <br />
            <br />
            </div>
              <div >
        <fieldset style="position:absolute; top: 53px; left: 300px; height: 385px; width: 642px; text-align: center;"
                height: 394px; text-align: center; ">
                <legend style="text-align: left">Cadastro</legend>
                   <asp:Label ID="lblnome" runat="server" Text="Nome" 
                        
                    style="position:absolute; top: 40px; left: 17px; height: 18px; width: 54px; right: 536px; margin-top: 0px; text-align: justify;"></asp:Label>
                    &nbsp;<asp:TextBox 
                ID="TextBox1" runat="server" 
                
                    
                style="position:absolute; top: 64px; left: 13px; height: 21px; width: 263px; right: 362px; margin-top: 0px; text-align: justify;"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" style="position:absolute; top: 108px; left: -4px; height: 20px; width: 84px; right: 527px; margin-top: 0px;" 
        runat="server" Text="CPF"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"  
              style="position:absolute; top: 130px; left: 15px; height: 23px; width: 105px; right: 487px; margin-top: 5px;"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="RG" 
           style="position:absolute; top: 108px; left: 157px; height: 20px; width: 84px; right: 366px; margin-top: 0px;"></asp:Label>
                        
        <asp:Label ID="Label4" runat="server" Text="Nascimento"  
         
                    style="position:absolute; top: 109px; left: 299px; height: 20px; width: 84px; right: 224px; margin-top: 0px;" >
        </asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"  
         
              style="position:absolute; top: 128px; left: 294px; height: 22px; width: 135px; right: 178px; margin-top: 5px;"></asp:TextBox>
         <asp:Label ID="Label5" runat="server" Text="Tipo Visitante"  
                  style="position:absolute; top: 174px; left: 9px; height: 18px; width: 105px; right: 524px; margin-top: 5px;"></asp:Label>
         <asp:DropDownList ID="DropDownList1" runat="server" 
                style="position:absolute; top: 200px; left: 15px; height: 19px; width: 259px; margin-top: 5px; bottom: 133px;" 
                >
        </asp:DropDownList>
        <asp:Label ID="Label6" runat="server" Text="Telefone Fixo"  
            
             
                style="position:absolute; top: 246px; left: 12px; height: 18px; width: 105px; right: 521px; margin-top: 5px;"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"  
            
                style="position:absolute; top: 273px; left: 17px; height: 23px; width: 132px; right: 458px; margin-top: 5px;"></asp:TextBox>
            <asp:Label ID="Label7" runat="server" Text="Telefone Celular"  
            
              
                style="position:absolute; top: 250px; left: 298px; height: 15px; width: 128px; right: 212px; margin-top: 5px;"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server"  
             
               style="position:absolute; top: 274px; left: 313px; height: 23px; width: 132px; right: 162px; margin-top: 5px;"></asp:TextBox>
             <asp:Label ID="Label8" runat="server" Text="E-mail"  
             
               
                style="position:absolute; top: 302px; left: 6px; height: 20px; width: 77px; margin-top: 5px; bottom: 56px;"></asp:Label>
                            
                     <asp:TextBox ID="TextBox2" runat="server" 
              style="position:absolute; top: 135px; left: 153px; height: 21px; width: 106px; right: 348px; margin-top: 0px;"></asp:TextBox>
             <asp:TextBox ID="TextBox3" runat="server" 
                              
              
                style="position:absolute; top: 327px; left: 15px; height: 20px; width: 264px; right: 359px; margin-top: 5px;"></asp:TextBox>
                                 
              <br/>
                       </fieldset>
         </div>
               <div style="border-style: none; height: 528px; width: 1523px; margin-top: 0px">
         <fieldset style="width: 41%; position: absolute; top: 464px; left: 296px; height: 358px;" >
         <legend style="text-align: left">Dados da Autorização</legend>
        <br />
             <asp:DropDownList ID="dpldatainicio" runat="server"  
             
                 
                 
                 style="position:absolute; top: 44px; left: 5px; height: 16px; width: 107px; margin-top: 5px; bottom: 285px;">
             </asp:DropDownList>
             <asp:DropDownList ID="dpldatafim" runat="server" 
             
                 
                 
                 style="position:absolute; top: 43px; left: 449px; height: 29px; width: 108px; margin-top: 5px; bottom: 286px;">
             </asp:DropDownList>
        </fieldset>
        <asp:Label ID="Label9" runat="server" Text="Autorizante " 
           
              
                       style="position:absolute; top: 553px; left: 317px; height: 17px; width: 105px; margin-top: 5px; bottom: 297px;"></asp:Label>
            <asp:TextBox ID="TextBox8" runat="server" 
            
                 
                       style="position:absolute; top: 575px; left: 317px; height: 21px; width: 260px; margin-top: 5px; bottom: 271px;"></asp:TextBox>
            <asp:TextBox ID="TextBox9" runat="server" 
             
                 
                       
                       style="position:absolute; top: 556px; left: 608px; height: 53px; width: 62px; margin-top: 5px; bottom: 258px;"></asp:TextBox>
              <asp:GridView ID="grvautorizacoes" runat="server" 
                style="position:absolute; top: 615px; left: 326px;  width: 159px; right: 1046px; margin-top: 5px; height: 65px;" 
                  AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                  GridLines="None" ViewStateMode="Enabled" 
                       >
                  <AlternatingRowStyle BackColor="White" />
                  <Columns>
                      <asp:TemplateField>
                          <EditItemTemplate>
                              <asp:CheckBox ID="CheckBox1" runat="server" />
                          </EditItemTemplate>
                          <ItemTemplate>
                              <asp:CheckBox ID="CheckBox1" runat="server" />
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:BoundField HeaderText="Nome" DataField="Nome" />
                      <asp:BoundField HeaderText="Local" DataField="Local" />
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
        <asp:Button ID="Button1" runat="server" Text="&gt;&gt;" 
          
            
                       
                       style="position:absolute; top: 642px; left: 576px; height: 24px; width: 50px; right: 924px; margin-top: 5px;"/>
          <asp:Button ID="Button2" runat="server" Text="&lt;&lt;" 
           
            
                       
                       style="position:absolute; top: 699px; left: 575px; height: 24px; width: 50px; right: 925px; margin-top: 5px;" />
            <asp:GridView ID="grvautorizacaoselecionada" runat="server" 
            
                  style="position:absolute; top: 618px; left: 671px; height: 35px; width: 152px; margin-top: 5px; bottom: 77px;" 
                  CellPadding="4" ForeColor="#333333" GridLines="None" 
                  AutoGenerateColumns="False" ViewStateMode="Enabled" 
                       onselectedindexchanged="grvautorizacaoselecionada_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField>
                        <EditItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="Nome" DataField="Nome" />
                    <asp:BoundField HeaderText="Local" DataField="Local" />
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
            <asp:Label ID="Label11" runat="server" Text="Data Inicial"  
            
               
                       
                       style="position:absolute; top: 487px; left: 315px; height: 14px; width: 93px; margin-top: 5px; bottom: 366px;"></asp:Label>
            <asp:Label ID="Label12" runat="server" Text="Data Fim" 
                                              
             
                       
                       style="position:absolute; top: 489px; left: 757px; height: 15px; width: 93px; margin-top: 5px; bottom: 363px;"></asp:Label>
        </div>
                <br />
               <br />
                  <br />
        &nbsp;<br />
        <br />
    
    </div>
</asp:Content>
