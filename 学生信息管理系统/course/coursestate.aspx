<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="coursestate.aspx.cs" Inherits="学生信息管理系统.course.coursestate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" CssClass="btn btn-success " runat="server" Text="开启选课" OnClick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" CssClass="btn btn-danger " runat="server" Text="关闭选课" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
