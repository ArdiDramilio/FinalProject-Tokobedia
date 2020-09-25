<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="Projek.View.ViewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        All User<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="UserID" HeaderText="UserID" />
                <asp:BoundField DataField="UserGender" HeaderText="UserGender" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" />
                <asp:BoundField DataField="UserRole" HeaderText="UserRole" />
                <asp:BoundField DataField="UserStatus" HeaderText="UserStatus" />
                <asp:ButtonField ButtonType="Button" Text="ChangeRole" CommandName="ChangeRole" />
                <asp:ButtonField ButtonType="Button" Text="ToggleStatus" CommandName="ToggleStatus" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Label ID="LabelViewUser" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;<asp:Label ID="LabelRole1" runat="server" Text="Masukan Role:"></asp:Label>
        <asp:TextBox ID="BoxUpdateRole" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="BtnUpdateRole" runat="server" Text="Submit" Onclick="BtnUpdateRole_Click"/>
    </p>
</asp:Content>
