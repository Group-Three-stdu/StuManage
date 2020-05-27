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
 
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="编号" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="232px" Width="698px">
            <Columns>
                <asp:BoundField DataField="编号" HeaderText="编号" SortExpression="编号" ReadOnly="True" />
                <asp:BoundField DataField="密码" HeaderText="密码" SortExpression="密码" />
                <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                <asp:BoundField DataField="电话" HeaderText="电话" SortExpression="电话" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StulnfoConnectionString4 %>" SelectCommand="SELECT * FROM [guanlistudent]"></asp:SqlDataSource>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
