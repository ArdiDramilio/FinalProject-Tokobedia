<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="ViewProductType.aspx.cs" Inherits="Projek.View.ViewProductType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        View Product Type</p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="ProductTypeID" HeaderText="ProductTypeID" />
            <asp:BoundField DataField="ProductTypeName" HeaderText="ProductTypeName" />
            <asp:BoundField DataField="ProductTypeDesc" HeaderText="Description" />
            <asp:ButtonField ButtonType="Button" CommandName="UpdateType" Text="Update" />
            <asp:ButtonField ButtonType="Button" CommandName="DeleteType" Text="Delete" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="BtnInsertProductType" runat="server" OnClick="BtnInsertProductType_Click" Text="Insert Product Type" />
    <br />
    <br />
    <asp:Label ID="LabelViewProductType" runat="server"></asp:Label>
    </asp:Content>
