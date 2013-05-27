<%@ Page Title="" Language="C#" MasterPageFile="~/GeneralAccessMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:LoginView ID="LoginView1" runat="server">
    <AnonymousTemplate>
        Please log in
    </AnonymousTemplate>
    <LoggedInTemplate>
        Welcome to Ace Tutors, what would you like to do?<br />
        <asp:LoginView ID="LoginView2" runat="server">
            <RoleGroups>
                <asp:RoleGroup Roles="Tutor">
                    <ContentTemplate>
                        <asp:Button ID="btnClass" runat="server" Text="View class list" OnClick="btnClass_Click" />
                        <asp:Button ID="btnTimeTableT" runat="server" Text="View class times" OnClick="btnTimeTable_Click" />
                        <asp:Button ID="btnEnrole" runat="server" Text="Register/deregister students from class" OnClick="btnEnrole_Click" />
                    </ContentTemplate>
                </asp:RoleGroup>
                <asp:RoleGroup Roles="Student">
                    <ContentTemplate>
                        <asp:Button ID="btnTutorInfo" runat="server" Text="View contact details for tutors" OnClick="btnTutorInfo_Click"/>
                        <asp:Button ID="btnTimeTableS" runat="server" Text="View class times" OnClick="btnTimeTableS_Click"/>
                        <asp:Button ID="btnEnrole" runat="server" Text="Register/deregister from class" OnClick="btnEnrole_Click1"/>
                    </ContentTemplate>
                </asp:RoleGroup>
            </RoleGroups>
        </asp:LoginView>
    </LoggedInTemplate>
</asp:LoginView>
</asp:Content>

