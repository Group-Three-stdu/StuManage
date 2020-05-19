<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fabu_qiandao.aspx.cs" Inherits="学生信息管理系统.qiandao.fabu_qiandao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    设置签到时间：<asp:TextBox ID="TextBox1" runat="server" Width="50px"></asp:TextBox>分钟
    <div>
        <asp:Button ID="Button1" runat="server" Text="发布" OnClick="Button1_Click" />
    </div>
    </div>
        
    </form>
</body>
</html>
