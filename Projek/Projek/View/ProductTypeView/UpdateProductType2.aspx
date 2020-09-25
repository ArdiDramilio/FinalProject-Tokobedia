<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="UpdateProductType2.aspx.cs" Inherits="Projek.View.UpdateProductType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Update Product Type<br />
    <br />
    Product Type Name:<asp:TextBox ID="BoxTypeName" runat="server"></asp:TextBox>
    <br />
    <br />
    Product Description:<asp:TextBox ID="BoxDescription" runat="server" Height="79px" Width="164px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="LabelUpdateProduct" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="BtnUpdateProductType" runat="server" Text="Submit" OnClick="BtnUpdateProductType_Click"/>
    <br />
</asp:Content>
