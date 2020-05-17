<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stu_qiandao.aspx.cs" Inherits="学生信息管理系统.qiandao.stu_qiandao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>学生签到界面</title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .box{
            width:23%;
            height:150px;
            border:1px solid #ff6a00;
            background-color:white;
            float:left;
            margin-left:1%;
            margin-top:20px;
            border-radius:10px;
        }
        .box .srow{
            width:100%;
            height:20px;
        }
        .box span{
            display:block;
            height:20px;
            width:30%;
            margin-left:2%;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            font-size:15px;
            background-color:white;
        }
        .box .button{
            width:100%;
            height:50px;
            background-color:red;
            margin-bottom:0;
        }
        .box .button .inbutton{
            width:20%;
            height:30px;
            float:right;
            margin-top:10px;
            margin-right:3%;
        }
         .box .srow .lb{
            width:65%;
            height:20px;
            float:right;
            font-size:15px;
            margin-top:-20px;
            background-color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="box">
                    <div class="srow">
                        <span>签到编号：</span><asp:Label CssClass="lb" ID="Label1" runat="server" Text="">1</asp:Label>
                    </div>
                    <div class="srow">
                        <span>课程名：</span><asp:Label CssClass="lb" ID="Label2" runat="server" Text="">java语言</asp:Label>
                    </div>
                    <div class="srow">
                        <span>班级编号：</span><asp:Label CssClass="lb" ID="Label3" runat="server" Text="">1702</asp:Label>
                    </div>
                    <div class="srow">
                        <span>签到时间：</span><asp:Label CssClass="lb" ID="Label4" runat="server" Text="">2019-12-09-12-19</asp:Label>
                    </div>
                    <div class="srow">
                        <span>签到状态：</span><asp:Label CssClass="lb" ID="Label5" runat="server" Text="">已签到</asp:Label>
                    </div>
                    <div class="button">
                        <asp:Button ID="btn_qiandao" runat="server" CssClass="inbutton btn btn-info" Text="签到" />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
