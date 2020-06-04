<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="guanliyuan_stuperinfo.aspx.cs" Inherits="学生信息管理系统.StudentsInfo.gunaliyuan_stuinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>教务处管理学籍信息</title>
    <link href="css/command.css" rel="stylesheet" type="text/css" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/jquery.js" type="text/javascript"></script>
    <script>
       
    </script>
    <style>
        .drop{
            width:12%;
            height:25px;
            margin-left:1%;
            font-size:13px;
        }
        .form-control{
            display:inline-block;
            padding-top:2px;
        }
        .input{
            width:12%;
            height:25px;
            margin-left:1%;
        }
        .btn{
            padding-top:2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
 
    </div >
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="编号" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" Height="232px" Width="80%" AllowPaging="True" AllowSorting="True" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" style="text-align:center;">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="编号" HeaderText="编号" SortExpression="编号" ReadOnly="True" >
                <HeaderStyle HorizontalAlign="Center" CssClass="text-center" />
                </asp:BoundField>
                <asp:BoundField DataField="密码" HeaderText="密码" SortExpression="密码" >
                <HeaderStyle CssClass="text-center" />
                </asp:BoundField>
                <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" >
                <HeaderStyle CssClass="text-center" />
                </asp:BoundField>
                <asp:BoundField DataField="电话" HeaderText="电话" SortExpression="电话" >
                <HeaderStyle CssClass="text-center" />
                </asp:BoundField>
                <asp:BoundField DataField="CollegeName" HeaderText="CollegeName" SortExpression="CollegeName" >
                <HeaderStyle CssClass="text-center" />
                </asp:BoundField>
                <asp:BoundField DataField="MajorName" HeaderText="MajorName" SortExpression="MajorName" >
                <HeaderStyle CssClass="text-center" />
                </asp:BoundField>
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StulnfoConnectionString4 %>" SelectCommand="SELECT [编号], [密码], [姓名], [电话], [CollegeName], [MajorName] FROM [guanlistudent]"></asp:SqlDataSource>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
