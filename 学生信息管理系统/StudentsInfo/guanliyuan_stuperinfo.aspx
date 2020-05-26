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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="UserName,StuId" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" ReadOnly="True" />
                <asp:BoundField DataField="PassWord" HeaderText="PassWord" SortExpression="PassWord" />
                <asp:BoundField DataField="StuName" HeaderText="StuName" SortExpression="StuName" />
                <asp:BoundField DataField="StuPhoneNum" HeaderText="StuPhoneNum" SortExpression="StuPhoneNum" />
                <asp:BoundField DataField="StuId" HeaderText="StuId" ReadOnly="True" SortExpression="StuId" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StulnfoConnectionString4 %>" SelectCommand="SELECT * FROM [guanlistudent]"></asp:SqlDataSource>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="UserName,StuId" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="UserName" HeaderText="UserName" ReadOnly="True" SortExpression="UserName" />
                <asp:BoundField DataField="PassWord" HeaderText="PassWord" SortExpression="PassWord" />
                <asp:BoundField DataField="StuName" HeaderText="StuName" SortExpression="StuName" />
                <asp:BoundField DataField="StuPhoneNum" HeaderText="StuPhoneNum" SortExpression="StuPhoneNum" />
                <asp:BoundField DataField="StuId" HeaderText="StuId" ReadOnly="True" SortExpression="StuId" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
