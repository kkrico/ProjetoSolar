<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ProjetoWebSolar.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<script src="bootstrap-3.3.7-dist/Mascara/jquery.maskedinput.js" type="text/javascript"></script>
    <script src="bootstrap-3.3.7-dist/Mascara/jquery.maskedinput.min.js" type="text/javascript"></script>--%>

      <%--  <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
        <script src="bootstrap-3.3.7-dist/jquery/jquery.maskedinput.min.js" type="text/javascript"></script>--%>

  <%--       <script type="text/javascript">
             jQuery(function ($) {
                 $("#ContentPlaceHolder1_TextBox1").mask("99/99/9999");
             });
    </script>--%>

<%--       <script src="Mascara/jquery-1.8.3.min.js" type="text/javascript"></script>
    <script src="Mascara/jquery.maskedinput.js" type="text/javascript"></script>
    <script src="Mascara/jquery.maskedinput.min.js" type="text/javascript"></script>--%>

<script type="text/javascript">
    $(function () {
        $("#ContentPlaceHolder1_TextBox1").mask("(999) 999-9999");

        $("input").blur(function () {
            $("#info").html("Unmasked value: " + $(this).mask());
        }).dblclick(function () {
            $(this).unmask();
        });
    });
	
</script>
<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control input-sm"></asp:TextBox>
</asp:Content>

