<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="Projek.View.InsertProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="BodyInProd">
    <p>
        Insert Product</p>
    Product Name:<asp:TextBox ID="BoxProductName" runat="server"></asp:TextBox>
    <br />
    <br />
    Product Stock:<asp:TextBox ID="BoxProductStock" runat="server" Height="25px"></asp:TextBox>
    <br />
    <br />
    Product Price:<asp:TextBox ID="BoxProductPrice" runat="server"></asp:TextBox>
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    Product Type ID:<asp:TextBox ID="BoxTypeID" runat="server"></asp:TextBox>
        <br />
    <asp:Label ID="LabelInsertProduct" runat="server"></asp:Label>
    <br />
    <asp:Button ID="BtnInsertProduct" runat="server" Text="Submit" OnClick="BtnInsertProduct_Click" />
        </div>
</asp:Content>
