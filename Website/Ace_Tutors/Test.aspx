<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
    <Columns>
        <asp:BoundField DataField="GivenName" HeaderText="GivenName" SortExpression="GivenName" />
        <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname" />
        <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
        <asp:BoundField DataField="Phone1" HeaderText="Phone1" SortExpression="Phone1" />
        <asp:BoundField DataField="Phone2" HeaderText="Phone2" SortExpression="Phone2" />
        <asp:BoundField DataField="PassHash" HeaderText="PassHash" SortExpression="PassHash" />
    </Columns>
</asp:GridView>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllStudents" TypeName="Business.StudentList"></asp:ObjectDataSource>
</asp:Content>

