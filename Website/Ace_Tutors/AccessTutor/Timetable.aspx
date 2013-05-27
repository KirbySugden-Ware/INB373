<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Timetable.aspx.cs" Inherits="AccessTutor_Timetable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ClassID" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="ClassID" HeaderText="ClassID" ReadOnly="True" SortExpression="ClassID" />
            <asp:BoundField DataField="ClassCode" HeaderText="ClassCode" SortExpression="ClassCode" />
            <asp:BoundField DataField="Day" HeaderText="Day" SortExpression="Day" />
            <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
            <asp:BoundField DataField="Semester" HeaderText="Semester" SortExpression="Semester" />
            <asp:BoundField DataField="TutorID" HeaderText="TutorID" SortExpression="TutorID" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllClasses" TypeName="Business.ClassList"></asp:ObjectDataSource>
    
    </asp:Content>

