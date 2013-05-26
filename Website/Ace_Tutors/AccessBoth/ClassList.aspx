<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ClassList.aspx.cs" Inherits="AccessBoth_ClassList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <asp:LoginView ID="LoginView1" runat="server">
        <RoleGroups>
            <asp:RoleGroup Roles="Tutor">
                <ContentTemplate>
                    This will be altered to allow student details to be shown for each class a tutor teaches<asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1">
                    </asp:DataList>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllClassRosters" TypeName="Business.ClassRoster"></asp:ObjectDataSource>
                </ContentTemplate>
            </asp:RoleGroup>
            <asp:RoleGroup Roles="Student">
                <ContentTemplate>
                    <asp:DataList ID="DataList2" runat="server" DataSourceID="ObjectDataSource2">
                    </asp:DataList>
                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllClassRosters" TypeName="Business.ClassRoster"></asp:ObjectDataSource>
                </ContentTemplate>
            </asp:RoleGroup>
        </RoleGroups>
    </asp:LoginView>

</asp:Content>

