<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="ViewPaymentType.aspx.cs" Inherits="Projek.View.ViewPaymentType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        View Payment Type</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="PaymentTypeID" HeaderText="PaymentTypeID" />
                <asp:BoundField DataField="PaymentTypeName" HeaderText="PaymentTypeName" />
                <asp:ButtonField ButtonType="Button" CommandName="UpdatePaymentType" Text="Update" />
                <asp:ButtonField ButtonType="Button" CommandName="DeletePaymentType" Text="Delete" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="BtnInsertPaymentType" runat="server" Text="Insert Payment Type" OnClick="BtnInsertPaymentType_Click" />
    </p>
    <p>
        <asp:Label ID="LabelViewPaymentType" runat="server"></asp:Label>
    </p>
</asp:Content>
