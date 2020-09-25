<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="Projek.View.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Transaction History</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" />
                <asp:BoundField DataField="PaymentTypeName" HeaderText="Payment Type Name" />
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                <asp:BoundField DataField="ProductQuantity" HeaderText="Product Quantity" />
                
                <asp:BoundField DataField="SubTotal" HeaderText="Sub Total" />
                
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="BtnReport" runat="server" Text="View Transaction Report" OnClick="BtnReport_Click" />
    </p>
</asp:Content>
