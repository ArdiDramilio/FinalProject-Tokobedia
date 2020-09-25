<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="InsertPaymentType.aspx.cs" Inherits="Projek.View.InsertPaymentType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Insert Payment Type</p>
    Payment Type Name:<asp:TextBox ID="BoxPaymentTypeName" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="LabelInsertPaymentType" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="BtnInsertPaymentType" runat="server" Text="Submit" OnClick="BtnInsertPaymentType_Click" />
</asp:Content>
