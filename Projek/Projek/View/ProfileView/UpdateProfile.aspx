<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="Projek.View.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Update Profile</p>
    <p>
        Email:<asp:TextBox ID="UpdateEmail" runat="server"></asp:TextBox>
    </p>
    <p>
        Name:<asp:TextBox ID="UpdateNama" runat="server"></asp:TextBox>
    </p>
    <p>
        Gender:<asp:RadioButtonList ID="UpdateGender" runat="server">
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        <asp:Label ID="LabelUpdateProfile" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Submit" />
    </p>
</asp:Content>
