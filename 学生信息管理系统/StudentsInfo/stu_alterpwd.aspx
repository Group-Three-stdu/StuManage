<%@ Page Language="C#" AutoEventWireup="true" CodeFile="stu_alterpwd.aspx.cs" Inherits="stu_alterpwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style>
    .body
    {
        border:1px solid #ccc;
        background:#f5f5f5;
        }
    .box
    {
        width:100%;
        height:300px;
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
    <title>修改密码</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="box">
            <div class="lable">原密码：</div>
            <asp:TextBox ID="txt_pwd" runat="server" class="input"></asp:TextBox>
            <br />
            <div class="lable">新密码：</div>
            <asp:TextBox ID="txt_newpwd" runat="server" class="input"></asp:TextBox>
            <br />
            <div class="lable">确认新密码：</div>
            <asp:TextBox ID="txt_renewpwd" runat="server" class="input"></asp:TextBox>
            <asp:CompareValidator
                ID="CompareValidator1" runat="server" ErrorMessage="两次密码不相同" Font-Strikeout="False" ControlToCompare="txt_newpwd" ControlToValidate="txt_renewpwd" Font-Size="Smaller"></asp:CompareValidator>
            <br />
            <asp:Button ID="btn_alterpass" class="btn" runat="server" Text="保存" />
        </div>
        
    </div>
    </form>
</body>
</html>
