<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="Projek.View.AddToCart2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Product Name:<asp:Label ID="LabelProductName" runat="server"></asp:Label>
    </p>
    <p>
        Product Price:
        <asp:Label ID="LabelProductPrice" runat="server"></asp:Label>
    </p>
    <p>
        Product Stock:<asp:Label ID="LabelProductStock" runat="server"></asp:Label>
    </p>
    <p>
        Product Type:<asp:Label ID="LabelProductType" runat="server"></asp:Label>
    </p>
    <p>
        Quantity:<asp:TextBox ID="BoxQuantity" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="LabelAddToCart" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="BtnAdd" runat="server" Text="Submit" Onclick="BtnAdd_Click"/>
    </p>
</asp:Content>
