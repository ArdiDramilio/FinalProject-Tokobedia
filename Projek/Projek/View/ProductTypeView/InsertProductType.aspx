<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="InsertProductType.aspx.cs" Inherits="Projek.View.InsertProductType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Insert Product Type<br />
    <br />
    Product Type Name:<asp:TextBox ID="BoxTypeName" runat="server"></asp:TextBox>
    <br />
    <br />
    Product Description:<asp:TextBox ID="BoxDescription" runat="server" Height="79px" Width="164px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="LabelInsertProduct" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="BtnUpdateProductType" runat="server" Text="Submit" OnClick="BtnUpdateProductType_Click"/>
    <br />
</asp:Content>
