<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="UpdateProductType.aspx.cs" Inherits="Projek.View.UpdateProductType1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p>
        Update Product Type</p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="ProductTypeID" HeaderText="ProductTypeID" />
            <asp:BoundField DataField="ProductTypeName" HeaderText="ProductTypeName" />
            <asp:BoundField DataField="ProductTypeDesc" HeaderText="Description" />
            <asp:ButtonField ButtonType="Button" CommandName="UpdateType" Text="Update" />
        </Columns>
    </asp:GridView>
    <br />
    </asp:Content>
