<%@ Page Title="" Language="C#" MasterPageFile="GeneralAccessMasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="AccessGeneral_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:LoginView ID="LoginView1" runat="server">
        <AnonymousTemplate>
            <asp:Login ID="LoginPanel" runat="server" OnAuthenticate="LoginPanel_Authenticate"></asp:Login>
        </AnonymousTemplate>
        <LoggedInTemplate>
            Sorry, you are trying to navigate to a page you do not have permission to access.<br /> Please return to the
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Default.aspx">home page</asp:HyperLink>
            .
        </LoggedInTemplate>
    </asp:LoginView>
</asp:Content>

