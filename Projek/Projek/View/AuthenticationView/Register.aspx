<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster2.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Projek.View.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="DivRegis">
    <div runat="server" >
    <p>
        Register</p>
    <p>
        Email:<asp:TextBox ID="RegisEmail" runat="server"></asp:TextBox>

    </p>
    <p>
        Name:<asp:TextBox ID="RegisNama" runat="server"></asp:TextBox>
    </p>
    <p>
        Password:<asp:TextBox ID="RegisPassword" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        Confirm Password:<asp:TextBox ID="ConfirmPass" TextMode="Password" runat="server"></asp:TextBox>
</p>
    <p>
        Gender:<asp:RadioButtonList ID="RegisGender" runat="server">
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
        </asp:RadioButtonList>

        <asp:Label ID="LabelRegister" runat="server"></asp:Label>
</p>
<p>
        <asp:Button ID="BtnInsertRegister" runat="server" OnClick="BtnInsertRegister_Click" Text="Submit" />
</p>
        </div>
        </div>
</asp:Content>
