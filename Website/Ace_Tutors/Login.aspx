<%@ Page Title="" Language="C#" MasterPageFile="GeneralAccessMasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="AccessGeneral_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Login ID="LoginPanel" runat="server" OnAuthenticate="LoginPanel_Authenticate">
</asp:Login>
</asp:Content>

