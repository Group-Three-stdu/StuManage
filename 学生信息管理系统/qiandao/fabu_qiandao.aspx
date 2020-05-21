<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fabu_qiandao.aspx.cs" Inherits="学生信息管理系统.qiandao.fabu_qiandao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
    <div class="box">
        <div class="srow">
            <span>课程名：</span><asp:Label CssClass="lb" ID="Label2" runat="server" Text="">python</asp:Label>
        </div>
        <br />
       设置签到时间：<asp:TextBox ID="TextBox1" runat="server" Width="50px"></asp:TextBox>分钟
       <div>
           <br />
            <br />
            
        &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="发布" OnClick="Button1_Click" BackColor="Red" BorderColor="Yellow" BorderStyle="Ridge" CssClass="srow" Width="143px" />
    </div>
    </div>
        
    </form>
</body>
</html>
