<%@ Page Title="" Language="C#" MasterPageFile="GeneralAccessMasterPage.master" AutoEventWireup="true" CodeFile="ClassGuidelines.aspx.cs" Inherits="ClassGuidelines" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ClassID" HeaderText="ClassID" SortExpression="ClassID" />
            <asp:BoundField DataField="ClassCode" HeaderText="ClassCode" SortExpression="ClassCode" />
            <asp:BoundField DataField="Day" HeaderText="Day" SortExpression="Day" />
            <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
            <asp:BoundField DataField="Semester" HeaderText="Semester" SortExpression="Semester" />
            <asp:BoundField DataField="TutorID" HeaderText="TutorID" SortExpression="TutorID" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllClasses" TypeName="Business.ClassList"></asp:ObjectDataSource>
    
</asp:Content>

