<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="UpdatePaymentType2.aspx.cs" Inherits="Projek.View.UpdatePaymentType2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p>
        Update Payment Type</p>
    Payment Type Name:<asp:TextBox ID="BoxPaymentTypeName" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="LabelUpdatePaymentType" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="BtnUpdatePaymentType" runat="server" Text="Submit" OnClick="BtnUpdatePaymentType_Click" />
</asp:Content>
