<%@ Page Title="" Language="C#" MasterPageFile="~/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="CxPeferenceUi.aspx.cs" Inherits="myWeb.CxPeferenceUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
        height: 413px;
    }
    .auto-style2 {
        width: 465px;
    }
    .auto-style3 {
        width: 465px;
        height: 24px;
    }
    .auto-style4 {
        height: 24px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table cellpadding="0" cellspacing="0" class="auto-style1">
    <tr>
        <td class="auto-style2">Customer ID</td>
        <td>
            <asp:DropDownList ID="drpID" runat="server" DataSourceID="SqlDataSource1" DataTextField="CustomerId" DataValueField="CustomerSerial" Height="16px" Width="131px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString %>" SelectCommand="SELECT [CustomerSerial], [CustomerId] FROM [CustomerDetails]"></asp:SqlDataSource>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">Customer Like</td>
        <td>
            <asp:TextBox ID="txtLike" runat="server" Width="197px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">Customer Dislike</td>
        <td>
            <asp:TextBox ID="txtDisLike" runat="server" Width="197px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">Customer FeedBack</td>
        <td>
            <asp:TextBox ID="txtFeedBack" runat="server" Width="196px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="64px" />
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3"></td>
        <td class="auto-style4"></td>
        <td class="auto-style4"></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:GridView ID="dgvCxLike" runat="server" AutoGenerateColumns="False" Width="352px">
                <Columns>
                    <asp:BoundField DataField="CustomerPreferenceSerial" HeaderText="CustomerPreferenceSerial" />
                    <asp:BoundField DataField="CustomerSerial" HeaderText="CustomerSerial" />
                    <asp:BoundField DataField="CustomerLike" HeaderText="CustomerLike" />
                    <asp:BoundField DataField="CustomerDisLike" HeaderText="CustomerDisLike" />
                    <asp:BoundField DataField="CustomerFeedBack" HeaderText="CustomerFeedBack" />
                </Columns>
            </asp:GridView>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btnSave" runat="server" Text="Save" Width="63px" OnClick="btnSave_Click" />
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            &nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>

</asp:Content>
