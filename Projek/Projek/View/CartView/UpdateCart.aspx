<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="UpdateCart.aspx.cs" Inherits="Projek.View.UpdateCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Update Product On Cart</p>
    <p>
        Product Name:<asp:Label ID="LabelProductName" runat="server"></asp:Label>
    </p>
    <p>
        Product Price:<asp:Label ID="LabelProductPrice" runat="server"></asp:Label>
    </p>
    <p>
        Product Quantity:<asp:TextBox ID="BoxQuantity" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="LabelUpdateCart" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="BtnUpdateCart" runat="server" Text="Submit" OnClick="BtnUpdateCart_Click" />
    </p>
</asp:Content>
