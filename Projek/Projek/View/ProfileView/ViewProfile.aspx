<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="Projek.View.ViewProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <p>
        Profile</p>
    <p>
        Name: <asp:Label ID="LabelName" runat="server"></asp:Label>
    </p>
    <p>
        Email: <asp:Label ID="LabelEmail" runat="server"></asp:Label>
    </p>
    <p>
        Gender: <asp:Label ID="LabelGender" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="BtnUpdateProfile" runat="server" Text="Update Profile" OnClick="BtnUpdateProfile_Click" />
        <asp:Button ID="BtnUpdatePassword" runat="server" Text="Update Password" OnClick="BtnUpdatePassword_Click" />
    </p>
 
</asp:Content>
