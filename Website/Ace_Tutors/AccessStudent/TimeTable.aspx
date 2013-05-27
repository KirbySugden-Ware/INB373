<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TimeTable.aspx.cs" Inherits="AccessStudent_TimeTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getClasses" TypeName="Business.ClassList">
        <SelectParameters>
            <asp:SessionParameter Name="username" SessionField="UserName" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1">
        <ItemTemplate>
            ClassID:
            <asp:Label ID="ClassIDLabel" runat="server" Text='<%# Eval("ClassID") %>' />
            <br />
            ClassCode:
            <asp:Label ID="ClassCodeLabel" runat="server" Text='<%# Eval("ClassCode") %>' />
            <br />
            Day:
            <asp:Label ID="DayLabel" runat="server" Text='<%# Eval("Day") %>' />
            <br />
            Time:
            <asp:Label ID="TimeLabel" runat="server" Text='<%# Eval("Time") %>' />
            <br />
            Semester:
            <asp:Label ID="SemesterLabel" runat="server" Text='<%# Eval("Semester") %>' />
            <br />
            TutorID:
            <asp:Label ID="TutorIDLabel" runat="server" Text='<%# Eval("TutorID") %>' />
            <br />
<br />
        </ItemTemplate>
    </asp:DataList>
    </asp:Content>

