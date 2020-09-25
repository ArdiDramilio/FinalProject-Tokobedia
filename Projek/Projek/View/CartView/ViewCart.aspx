<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="Projek.View.ViewCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowFooter="True" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" />
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" />
            <asp:BoundField DataField="ProductPrice" HeaderText="ProductPrice" />
            <asp:BoundField DataField="ProductQuantity" HeaderText="Quantity" />
            <asp:BoundField HeaderText="SubTotal" DataField="ProductSubTotal"/>
            <asp:ButtonField ButtonType="Button" CommandName="UpdateProduct" Text="UpdateCart" />
            <asp:ButtonField ButtonType="Button" CommandName="DeleteProduct" Text="DeleteCart" />
        </Columns>
    </asp:GridView>


    <br />
    <asp:Label ID="LabelViewCart" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="BtnCheckout" runat="server" Text="Checkout" OnClick="BtnCheckout_Click"/>


    <br />
    <br />
    <asp:Label ID="LabelChoose" runat="server" Text="Choose Payment Type"></asp:Label>


    <br />
    <br />
     <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView2_RowCommand">
            <Columns>
                <asp:BoundField DataField="PaymentTypeID" HeaderText="PaymentTypeID" />
                <asp:BoundField DataField="PaymentTypeName" HeaderText="PaymentTypeName" />
                <asp:ButtonField ButtonType="Button" CommandName="SelectPaymentType" Text="Select" />
            </Columns>
        </asp:GridView>

</asp:Content>
