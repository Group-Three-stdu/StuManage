<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addcourse.aspx.cs" Inherits="学生信息管理系统.course.addcourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>添加课程</title>
    <style>
    .body
    {
        border:1px solid #ccc;
        background:#f5f5f5;
        }
    .box
    {
        width:100%;
        height:500px;
        margin-top:10px;
        border:1px solid #ccc;
        }
     .input
     {
         width:20%;
         height:35px;
         padding-left:5px;
         border-radius:5px;
         border-width:none;
         margin-top:20px;
         border-width:1.5px;
         }
     .box .lable
     {
         width:10%;
         height:35px;
         color:#666;
         font-size:15px;
         margin-top:20px;
         text-align:right;
         float:left;
         line-height:35px;
         }
     .box .btn
     {
         width:8%;
         height:35px;
         border-radius:5px;
         border:none;
         color:White;
         background:#54a0ff;
         margin-top:20px;
         margin-left:10%;;
         }
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="box">
            <div class="lable">课程编号：</div>
            <asp:TextBox ID="txt_pwd" runat="server" class="input"></asp:TextBox>
            <br />
            <div class="lable">课程名：</div>
            <asp:TextBox ID="txt_newpwd" runat="server" class="input"></asp:TextBox>
            <br />
            <div class="lable">课程学分：</div>
            <asp:TextBox ID="txt_renewpwd" runat="server" class="input"></asp:TextBox>
            <br />
            <div class="lable">学时数：</div>
            <asp:TextBox ID="TextBox1" runat="server" class="input"></asp:TextBox>
            <br />
            <div class="lable">课程性质：</div>
            <asp:DropDownList ID="ddl_coursexingzhi" CssClass="input" runat="server">
                <asp:ListItem Value="bixiu">必修</asp:ListItem>
                <asp:ListItem Value="xuanxiu">选修</asp:ListItem>
            </asp:DropDownList>
            
            <br />
            <asp:Button ID="btn_alterpass" class="btn" runat="server" Text="保存" />
        </div>
    </div>
    </form>
</body>
</html>
