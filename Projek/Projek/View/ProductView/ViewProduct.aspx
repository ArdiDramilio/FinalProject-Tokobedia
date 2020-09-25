<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="Projek.View.ViewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .BodyViewProd{
            margin-left:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="BodyViewProd">

    <p>
        Product View<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField HeaderText="ProductID" DataField="ProductID" />
                <asp:BoundField HeaderText="ProductName" DataField="ProductName" />
                <asp:BoundField HeaderText="ProductStock" DataField="ProductStock" />
                <asp:BoundField HeaderText="ProductType" DataField="ProductType" />
                <asp:BoundField HeaderText="ProductPrice" DataField="ProductPrice" />
                <asp:ButtonField ButtonType="Button" CommandName="UpdateProduct" Text="Update" />
                <asp:ButtonField ButtonType="Button" CommandName="DeleteProduct" Text="Delete" />
                <asp:ButtonField ButtonType="Button" Text="AddToCart" CommandName="AddToCart" HeaderText="AddToCart" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="BtnInsertProduct" runat="server" Text="Insert Product" OnClick="BtnInsertProduct_Click" />
    </p>
        <p>
        <asp:Label ID="LabelViewProduct" runat="server"></asp:Label>
    </p>
        </div>
</asp:Content>
