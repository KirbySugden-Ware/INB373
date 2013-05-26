<%@ Page Title="" Language="C#" MasterPageFile="GeneralAccessMasterPage.master" AutoEventWireup="true" CodeFile="ClassGuidelines.aspx.cs" Inherits="ClassGuidelines" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllClassRosters" TypeName="Business.ClassRoster"></asp:ObjectDataSource>
    
</asp:Content>

