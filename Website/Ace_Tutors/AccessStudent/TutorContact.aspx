<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TutorContact.aspx.cs" Inherits="AccessStudent_TutorContact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1">
        </asp:DataList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllStaff" TypeName="Business.Staff"></asp:ObjectDataSource>
    </p>
</asp:Content>

