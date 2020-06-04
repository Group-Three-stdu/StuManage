<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GGDetail.aspx.cs" Inherits="学生信息管理系统.GG.GGDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="gghead" style="text-align:center;">
                <h2><asp:Label ID="GGHead" runat="server"></asp:Label></h2>
        </div>
        <div class="gginfo" style="text-align:right; color:gray;">
                <asp:Label ID="Time" runat="server" style="margin:50px 160px;"></asp:Label>
        </div>
        <hr />
        <div class="ggcontent" style="margin:2px 80px;">
                <asp:Label ID="GGcontent" runat="server" style="margin:2px 80px;"></asp:Label>
        </div>
        <div class="ggauthor" style="text-align:right;margin:100px 160px;">
                <asp:Label ID="author" runat="server" style=""></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
