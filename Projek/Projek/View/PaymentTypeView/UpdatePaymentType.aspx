<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="UpdatePaymentType.aspx.cs" Inherits="Projek.View.UpdatePaymentType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p>
        Update Payment Type</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="PaymentTypeID" HeaderText="PaymentTypeID" />
                <asp:BoundField DataField="PaymentTypeName" HeaderText="PaymentTypeName" />
                <asp:ButtonField ButtonType="Button" CommandName="UpdatePaymentType" Text="Update" />
            </Columns>
        </asp:GridView>
    </p>
</asp:Content>
