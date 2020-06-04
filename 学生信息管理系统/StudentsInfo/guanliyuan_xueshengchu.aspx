<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="guanliyuan_xueshengchu.aspx.cs" Inherits="学生信息管理系统.StudentsInfo.guanliyuan_qita" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="编号" DataSourceID="SqlDataSource1" CellPadding="4" Height="40px" Width="85%" ForeColor="#333333" GridLines="None" style="text-align:center;" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="编号" HeaderText="编号" ReadOnly="True" SortExpression="编号" />
                <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                <asp:BoundField DataField="密码" HeaderText="密码" SortExpression="密码" />
                <asp:BoundField DataField="电话" HeaderText="电话" SortExpression="电话" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StulnfoConnectionString4 %>" SelectCommand="SELECT * FROM [guanli_xueshengchu]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
