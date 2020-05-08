<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login2.aspx.cs" Inherits="学生信息管理系统.login2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
       
        .left{
            margin:0 auto;
            width:25%;
            height:250px;
            background-color:black;
            float:left;
        }
        .right{
            width:25%;
            height:250px;
            background-color:#f1f1f1;
            float:left;
        }
        .box .right .title{
            width:30%;
            height:30px;
            text-align:right;
            line-height:30px;
            float:left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <div class="left">

            </div>
            <div class="right">
                <div class="title">用户名：</div>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <div class="title">密码：</div>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <div class="title">验证码：</div>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </div>
    </div>
    </form>
</body>
</html>
