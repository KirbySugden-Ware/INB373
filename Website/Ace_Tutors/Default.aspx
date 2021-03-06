﻿<%@ Page Title="" Language="C#" MasterPageFile="~/GeneralAccessMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:LoginView ID="LoginView1" runat="server">
        <AnonymousTemplate>
            Welcome to our site!  If you are a current student or staff member, please log in to access your options.<br />
            If not, feel free to take a look around and contact us if you are interesting in enroling or becoming a tutor!
        <br />
        </AnonymousTemplate>
        <LoggedInTemplate>
            Welcome to Ace Tutors, what would you like to do?<br />
            <asp:LoginView ID="LoginView2" runat="server">
                <RoleGroups>
                    <asp:RoleGroup Roles="Tutor,Admin">
                        <ContentTemplate>
                            <asp:Button ID="btnClassT" runat="server" Text="View class list" OnClick="btnClass_Click" />
                            <asp:Button ID="btnTimeTableT" runat="server" Text="View class times" OnClick="btnTimeTable_Click" />
                            <asp:Button ID="btnEnrole" runat="server" Text="Register/deregister students from class" OnClick="btnEnrole_Click" />
                            <br />
                            <asp:LoginView ID="LoginView3" runat="server">
                                <RoleGroups>
                                    <asp:RoleGroup Roles="Admin">
                                        <ContentTemplate>
                                            <asp:Button ID="btnTutorInfoA" runat="server" Text="View contact details for tutors" OnClick="btnTutorInfo_Click" />
                                            <asp:Button ID="btnTimeTableA" runat="server" Text="View class times" OnClick="btnTimeTableS_Click" />
                                            <asp:Button ID="btnClassA" runat="server" Text="View class list" OnClick="btnClass_Click" />
                                        </ContentTemplate>
                                    </asp:RoleGroup>
                                </RoleGroups>
                            </asp:LoginView>
                        </ContentTemplate>
                    </asp:RoleGroup>
                    <asp:RoleGroup Roles="Student">
                        <ContentTemplate>
                            <asp:Button ID="btnTutorInfo" runat="server" Text="View contact details for tutors" OnClick="btnTutorInfo_Click" />
                            <asp:Button ID="btnTimeTableS" runat="server" Text="View class times" OnClick="btnTimeTableS_Click" />
                            <asp:Button ID="btnClassS" runat="server" Text="View class list" OnClick="btnClass_Click" />
                        </ContentTemplate>
                    </asp:RoleGroup>
                </RoleGroups>
            </asp:LoginView>
        </LoggedInTemplate>
    </asp:LoginView>
</asp:Content>

