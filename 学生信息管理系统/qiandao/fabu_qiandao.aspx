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
        .style1 {
            font-family: 华文宋体;
            text-align: left;
            float: left;
            border-width: 3px;
            border:2px solid #A3C2E2;
            padding: 2px;
            margin-left: 5%;
            margin-top:30px;
            height: 155px;
            width: 400px;
        }
       
        ..style1 {
            width: 1100px;
        }
       
        .auto-style2 {
            font-family: 楷体;
            font-size: x-large;
        }
        .auto-style3 {
            font-family: 楷体;
            font-size: large;
        }
        .srow {
            text-align: center;
        }
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="width:430px; background-color:#ACDCE4; height: 176px;">
            <span class="auto-style2">课程名：</span><asp:Label  ID="Label2" runat="server" Text="" style="font-size: large; font-family: 楷体">python</asp:Label>
            <br />
            <br />
            <span class="auto-style2">设置签到时间</span>：<asp:TextBox ID="TextBox1" runat="server" Width="85px" Height="30px"></asp:TextBox><span class="auto-style3">分钟</span>
            
            
        &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="发布" OnClick="Button1_Click" BackColor="#ECD4EC" BorderColor="White" BorderStyle="Ridge" CssClass="srow" Width="143px" Font-Names="楷体" Font-Size="X-Large" />
        </div>
        <br />
       
       
    </div>
    
        
    </form>
</body>
</html>
