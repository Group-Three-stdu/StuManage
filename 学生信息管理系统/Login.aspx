<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="学生信息管理系统.Login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>登录界面</title>
    <script src="js/jquery.js" type="text/javascript"></script>
    <link href="css/login.css" rel="stylesheet" />
    <script src="js/code.js"></script>
</head>
<body style="background-image:url(image/loginbg.jpg);background-size:100%;">
    
   <form id="form1" class="login-form" runat="server">
    <div>

        <div class="login-pic" style="border-radius:10px;">
            <img runat="server" src="~/image/logo.jpg" style="width:20%;height:65px;border-radius:10px;"/>
            <img runat="server" src="~/image/logo_right.png" style="width:70%;height:65px;margin-left:-6%;"/>
            <br />
            <img runat="server" src="~/image/logo_bottom.png" style="width:100%;height:120px;"/>
             <%--&nbsp;&nbsp;welcome <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            学生信息管理系统--%>
            <hr style="height:240px;width:0.5px;margin-left:100%;margin-top:-190px;color:aqua;" />
        </div>
        <div style="background-color:white;height:250px;width:100%;border-radius:10px;">
            <br />
            <div class="txtb">
            用户名：<asp:TextBox ID="txt_username" class="input" placeholder="Username" runat="server"></asp:TextBox>
            
            <%--<span data-placehoder="Username" runat="server"></span>--%>
            
        </div>
        <div class="txtb">
            密&nbsp;&nbsp;&nbsp;码：<asp:TextBox ID="txt_password" class="input" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
           <%-- <span data-placehoder="Password" runat="server"></span>--%>
        </div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        验证码：<asp:TextBox ID="intxt_code" CssClass="input3" placeholder="验证码" runat="server"></asp:TextBox>
        <div id="v_container">

        </div>
        <%--<asp:DropDownList ID="ddl_loginid" class="drop" runat="server">
            <asp:ListItem Value="student">学生</asp:ListItem>
            <asp:ListItem Value="teacher">教师</asp:ListItem>
            <asp:ListItem Value="teaching">教学秘书</asp:ListItem>
            <asp:ListItem Value="helper_stu">学生处</asp:ListItem>
            <asp:ListItem Value="academy">学院办公室</asp:ListItem>
            <asp:ListItem Value="admin">系统管理员</asp:ListItem>
        </asp:DropDownList>--%>

        <%--<div id="check-code" style="overflow: hidden;">
            <asp:TextBox ID="data_code"   runat="server" class="code"  BorderWidth="0"></asp:TextBox>
	        <%--<div class="code" id="data_code"></div>--%>
        <%--<asp:TextBox ID="txt_code" runat="server" class="input2"></asp:TextBox>--%>

        <asp:Button ID="btn_login" runat="server" class="logbtn" Text="登录" OnClientClick="yanzheng()"
            onclick="btn_login_Click"  />
       <asp:Button ID="reset" runat="server" CssClass="logbtn2" Text="重置" />
        </div>
        
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>

    </div>
    </form>
    <script type="text/javascript">
        $(".txtb .input").on("focus", function () {
            $(this).addClass("focus");
        });
        $(".txtb .input").on("blur", function () {
            if ($(this).val() == "")
                $(this).removeClass("focus");
        });
    </script>
    
</body>
    <script type="text/javascript">
        var verifyCode = new GVerify("v_container");
        document.getElementById("btn_login").onclick = function yanzheng () {
            var res = verifyCode.validate(document.getElementById("intxt_code").value);
            if (res) {
                return true;
            }else{
                alert("验证码错误");
                return false;
            }
        }
    </script>
</html>
