<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Timetable.aspx.cs" Inherits="AccessTutor_Timetable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    <asp:DataList ID="DataList1" runat="server" DataKeyField="ClassID" DataSourceID="ObjectDataSource1">
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
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllClasses" TypeName="Business.ClassList"></asp:ObjectDataSource>
    
</asp:Content>

