<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Projek.View.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Change Password</p>
    <p>
        Old Password:<asp:TextBox ID="UpdateOldPassword" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        New Password:<asp:TextBox ID="UpdateNewPassword" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        Confirm Password:<asp:TextBox ID="UpdateConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="LabelChangePassword" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="BtnChangePassword" runat="server" OnClick="BtnChangePassword_Click" Text="Submit" />
    </p>
</asp:Content>
