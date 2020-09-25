<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="Projek.View.UpdateProduct1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Product Update List<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField HeaderText="ProductID" DataField="ProductID" />
                <asp:BoundField HeaderText="ProductName" DataField="ProductName" />
                <asp:BoundField HeaderText="ProductStock" DataField="ProductStock" />
                <asp:BoundField HeaderText="ProductType" DataField="ProductType" />
                <asp:BoundField HeaderText="ProductPrice" DataField="ProductPrice" />
                <asp:ButtonField ButtonType="Button" CommandName="UpdateProduct" HeaderText="UpdateProduct" Text="Update" />
            </Columns>
        </asp:GridView>
    </p>
</asp:Content>
