<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebLogin.aspx.cs" Inherits="ProjetoWebSolar.Account.WebLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

    <div>
            <asp:Image ID="Image1" src="../Imagens/login.png" 
                style="position:absolute; top: 26px; left: 79px; height: 50px; width: 64px;" 
                runat="server" />
        
                <asp:Panel ID="Panel1" runat="server" style="text-align: left">                
            <br />
            <br />
                    <br />
            <br />
            <asp:Label ID="Lblnome" runat="server" Text="Email"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox1" placeholder="Username" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblsenha"  runat="server" Text="senha"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox2" placeholder="Password" runat="server"></asp:TextBox>



            <br />
            <br />
            <br />
           
            <asp:Button ID="btnpesquisar" runat="server" Text="Pesquisar" 
                style="position:absolute; top: 179px; left: 64px; z-index:1000" alt="" />
            <br />



        </asp:Panel>
     
    </div>



</asp:Content>
