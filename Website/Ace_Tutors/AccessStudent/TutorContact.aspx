<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TutorContact.aspx.cs" Inherits="AccessStudent_TutorContact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1">
            <ItemTemplate>
                GivenName:
                <asp:Label ID="GivenNameLabel" runat="server" Text='<%# Eval("GivenName") %>' />
                <br />
                Surname:
                <asp:Label ID="SurnameLabel" runat="server" Text='<%# Eval("Surname") %>' />
                <br />
                Address:
                <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                <br />
                Email:
                <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                <br />
                Phone1:
                <asp:Label ID="Phone1Label" runat="server" Text='<%# Eval("Phone1") %>' />
                <br />
                Phone2:
                <asp:Label ID="Phone2Label" runat="server" Text='<%# Eval("Phone2") %>' />
                <br />
                Role:
                <asp:Label ID="RoleLabel" runat="server" Text='<%# Eval("Role") %>' />
                <br />
<br />
            </ItemTemplate>
        </asp:DataList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="getAllStaff" TypeName="Business.StaffList"></asp:ObjectDataSource>
        partially working</p>
</asp:Content>

