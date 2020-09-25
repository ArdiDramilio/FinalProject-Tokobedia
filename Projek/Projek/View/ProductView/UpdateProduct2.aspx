<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="UpdateProduct2.aspx.cs" Inherits="Projek.View.UpdateProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Update Product<br />
    <br />
    Product Name:<asp:TextBox ID="BoxProductName" runat="server"></asp:TextBox>
    <br />
    <br />
    Product Stock:<asp:TextBox ID="BoxProductStock" runat="server" Height="25px"></asp:TextBox>
    <br />
    <br />
    Product Price:<asp:TextBox ID="BoxProductPrice" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="labelUpdateProduct" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="BtnUpdateProduct" runat="server" Text="Submit" OnClick="BtnUpdateProduct_Click"/>
    <br />
</asp:Content>
