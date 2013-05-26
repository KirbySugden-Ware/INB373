<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="AccessGeneral_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:LoginView ID="DefaultLoginView" runat="server">
        <AnonymousTemplate>
            Welcome to Ace Tutoring Services!
        </AnonymousTemplate>
        <LoggedInTemplate>
            Welcome <asp:LoginName ID="LoggedInName" runat="server"></asp:LoginName>
        </LoggedInTemplate>
        
        <RoleGroups>
            <asp:RoleGroup Roles="Student">
                
                <ContentTemplate>
                    Deaf
                </ContentTemplate>
                
            </asp:RoleGroup>
            <asp:RoleGroup Roles="Tutor">
                
                <ContentTemplate>
                    After
                </ContentTemplate>
                
            </asp:RoleGroup>
            <asp:RoleGroup Roles="Admin">
                
                <ContentTemplate>
                    Dark
                </ContentTemplate>
                
            </asp:RoleGroup>
        </RoleGroups>
        
    </asp:LoginView>
</asp:Content>

