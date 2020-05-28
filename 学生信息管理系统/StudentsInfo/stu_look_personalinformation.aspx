<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stu_look_personnalinformation.aspx.cs" Inherits="学生信息管理系统.stu_look_personnalinformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>学生处查看学生个人信息</title>
    <style>
        .box {
            margin:0 auto;
            width:100%;
            height:450px;
            border:1px solid #ccc;
        }
        table{
            width:100%;
            border:1px solid #ccc;
            height:100%;
            font-size:15px;
        }
        tr{
            width:100%;
            height:40px;
            border:1px solid #ccc;
        }
        th{
            text-align:center;
            border:1px solid #ccc;
        }
        td{
            text-align:left;
            border:1px solid #ccc;
        }
        .earn{
            width:100%;
            height:50px;
            margin:0 auto;
            background-color:#f5f5f5;
            color:#666;
            line-height:50px;
            border:1px solid yellow;
        }
        .btn{
            margin-left:1%;
        }
        .btn .lbbtn{
            width:10%;
            height:50px;
            margin-left:1%;
            line-height:50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="earn">
            以下为您的个人信息请核实，如有不正确请及时联系学生处进行修改
        </div>
        <div class="box">
            <table style="width:80%">
                <tr>
                    <th colspan="5">个人信息</th>
                    
                </tr>
                <tr>
                    <th>学号</th><td ><asp:Label ID="StuId" runat="server" Text=""></asp:Label></td>
                    <th >姓名</th><td><asp:Label ID="StuName" runat="server" Text=""></asp:Label></td>
                    <th rowspan="3" colspan="2">照片</th>
                </tr>
                <tr>
                    <th>性别</th><td><asp:Label ID="StuSex" runat="server" Text=""></asp:Label></td>
                    <th>出生日期</th><td><asp:Label ID="StuBirth" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th>身份证号</th><td><asp:Label ID="StuIdNo" runat="server" Text=""></asp:Label></td>
                    <th>联系电话</th><td><asp:Label ID="StuPho" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th>家庭住址</th><td><asp:Label ID="StuAdd" runat="server" Text=""></asp:Label></td>
                    <th>学院</th><td colspan="2"><asp:Label ID="Col" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th>专业</th><td><asp:Label ID="Label10" runat="Major" Text=""></asp:Label></td>
                    <th>班级</th><td colspan="2"><asp:Label ID="Class" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th>政治面貌</th><td><asp:Label ID="poState" runat="server" Text=""></asp:Label></td>
                    <th>状态</th><td colspan="2"><asp:Label ID="state" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th>荣誉</th><td colspan="4"><asp:Label ID="honor" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th>惩处</th><td colspan="4"><asp:Label ID="pun" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th>备注</th><td colspan="4"><asp:Label ID="PS" runat="server" Text=""></asp:Label></td>
                </tr>
            </table>
        </div>
        
        <div class="btn">
            <asp:LinkButton ID="LinkButton2" CssClass="lbbtn" runat="server">打印本页</asp:LinkButton>
            <asp:LinkButton ID="LinkButton3" CssClass="lbbtn" runat="server">打印学籍证明</asp:LinkButton>
        </div>
    </div>
    </form>
</body>
</html>
