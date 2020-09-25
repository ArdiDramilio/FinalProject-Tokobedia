<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projek.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="DivLogin">
    <p class="auto-style1">Login</p>
    Email:<asp:TextBox ID="BoxEmailLogin" runat="server"></asp:TextBox>
    <br />
    Password<asp:TextBox ID="BoxPasswordLogin" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:CheckBox ID="RememberMe" runat="server" Text="Remember Me" />
        <br />
        <asp:Label ID="LabelMessage" runat="server"></asp:Label>
    <br />
     <asp:Button ID="BtnRegister" runat="server"  Onclick="BtnRegister_Click" CssClass="SBtnRegister" Text="Register" CausesValidation="False" />
    <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" CssClass="SBtnRegister" />
        </div>
</asp:Content>
