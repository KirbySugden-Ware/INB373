<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ClassList.aspx.cs" Inherits="AccessBoth_ClassList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:LoginView ID="LoginView1" runat="server">
        <RoleGroups>
            <asp:RoleGroup Roles="Tutor">
                <ContentTemplate>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllClassRoster" TypeName="Business.ClassRosters"></asp:ObjectDataSource>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                    </asp:GridView>
                </ContentTemplate>
            </asp:RoleGroup>
            <asp:RoleGroup Roles="Student">
                <ContentTemplate>
                    <asp:DataList ID="DataList2" runat="server" DataSourceID="ObjectDataSource2">
                        <ItemTemplate>
                            Roster:
                            <asp:Label ID="RosterLabel" runat="server" Text='<%# Eval("Roster") %>' />
                            <br />
                            <br />
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllClassRoster" TypeName="Business.ClassRosters"></asp:ObjectDataSource>
                </ContentTemplate>
            </asp:RoleGroup>
        </RoleGroups>
    </asp:LoginView>
</asp:Content>

