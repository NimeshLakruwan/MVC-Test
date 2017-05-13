<%@ Page Title="" Language="C#" MasterPageFile="~/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="myWeb.Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="dgvReports" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="373px">
        <Columns>
            <asp:BoundField DataField="CustomerId" HeaderText="Customer Id" />
            <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
            <asp:BoundField DataField="CustomerAddress" HeaderText="Customer Address" />
            <asp:BoundField DataField="CustomerTelephone" HeaderText="Customer Telephone" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString %>" SelectCommand="SELECT [CustomerId], [CustomerName], [CustomerAddress], [CustomerTelephone] FROM [CustomerDetails]"></asp:SqlDataSource>
</asp:Content>
