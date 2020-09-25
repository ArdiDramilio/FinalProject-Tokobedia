<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Projek.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .BodyHome{
            margin-left:15px
        }
       .BtnNav{
           margin-left:10px;
           }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="BtnViewProduct" runat="server" Text="View Product" Width="9%" Height="29px" OnClick="BtnViewProduct_Click" />
    <asp:Button ID="BtnViewProfile" runat="server" Text="View Profile" Height="29px" style="margin-top: 6px" Width="9%" OnClick="BtnViewProfile_Click" CssClass="BtnNav"/>
    <asp:Button ID="BtnViewUser" runat="server" Text="View User" Width="9%" Height="29px" OnClick="BtnViewUser_Click" CssClass="BtnNav"/>
    <asp:Button ID="BtnInsertProduct" runat="server" Text="Insert Product" Width="10%" Height="29px" OnClick="BtnInsertProduct_Click" CssClass="BtnNav" />
    <asp:Button ID="BtnUpdateProduct" runat="server" Text="Update Product" Width="10%" Height="29px" OnClick="BtnUpdateProduct_Click" CssClass="BtnNav" />
    <asp:Button ID="BtnViewPaymentType" runat="server" Text="View Payment Type" Width="12%" Height="29px" OnClick="BtnViewPaymentType_Click" CssClass="BtnNav" />
    <asp:Button ID="BtnInsertPaymentType" runat="server" Text="Insert Payment Type" Width="12%" Height="29px" OnClick="BtnInsertPaymentType_Click" CssClass="BtnNav" />
    <asp:Button ID="BtnUpdatePaymentType" runat="server" Text="Update Payment Type" Width="12%" Height="29px" OnClick="BtnUpdatePaymentType_Click" CssClass="BtnNav" />
    <asp:Button ID="BtnViewProductType" runat="server" Text="View Product Type" Width="12%" Height="29px" OnClick="BtnViewProductType_Click" CssClass="BtnNav" />
    <asp:Button ID="BtnInsertProductType" runat="server" Text="Insert Product Type" Width="12%" Height="29px" OnClick="BtnInsertProductType_Click" CssClass="BtnNav" />
    <asp:Button ID="BtnUpdateProductType" runat="server" Text="Update Product Type" Width="13%" Height="29px" OnClick="BtnUpdateProductType_Click" CssClass="BtnNav" />
    <asp:Button ID="BtnViewTransactionReport" runat="server" Text="View Transaction Report" Width="13%" Height="29px" OnClick="BtnViewTransactionReport_Click" CssClass="BtnNav" />
    <asp:Button ID="BtnViewTransactionHistory" runat="server" Text="View Transaction History" Width="13%" Height="29px" OnClick="BtnViewTransactionHistory_Click" CssClass="BtnNav" />
    <asp:Button ID="BtnViewCart" runat="server" Text="View Cart" Width="13%" Height="29px" OnClick="BtnViewCart_Click" CssClass="BtnNav" />
    <p>
        Product View<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" style="margin-left: 0px">
            <Columns>
                <asp:BoundField HeaderText="ProductID" DataField="ProductID" />
                <asp:BoundField HeaderText="ProductName" DataField="ProductName" />
                <asp:BoundField HeaderText="ProductStock" DataField="ProductStock" />
                <asp:BoundField HeaderText="ProductType" DataField="ProductType" />
                <asp:BoundField HeaderText="ProductPrice" DataField="ProductPrice" />
                <asp:ButtonField ButtonType="Button" Text="AddToCart" CommandName="AddToCart" HeaderText="AddToCart" />
            </Columns>
        </asp:GridView>
    </p>
    <br />
</asp:Content>
