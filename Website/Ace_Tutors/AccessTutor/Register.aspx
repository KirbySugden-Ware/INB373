<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="AccessTutor_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataSourceID="ObjectDataSource1">
        <PagerSettings Position="TopAndBottom" />
    </asp:FormView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Business.ClassRoster" DeleteMethod="deleteClassRoster" InsertMethod="insertClassRoster" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllClassRosters" TypeName="Business.ClassRoster"></asp:ObjectDataSource>
    
</asp:Content>

