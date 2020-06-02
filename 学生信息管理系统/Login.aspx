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
    <div style="padding-top:40px;">

        <div class="login-pic" style="border-radius:10px;">
            <img runat="server" src="~/image/logo1.png" style="width:26%;border-radius:10px;"/>
            <img runat="server" src="~/image/logo_right.png" style="width:75%;height:80px;margin-left:-10%;margin-bottom:15px;"/>
            <br />
            <img runat="server" src="~/image/logo_bott.png" style="width:100%;height:120px; margin-top:20px;"/>

            <div style="height:300px;width:1px;margin-left:100%;margin-top:-270px;background-color:black"></div>
        </div>
        <div style="height:300px;width:100%;border-radius:10px;">
            <br />
            <div class="txtb" style="margin-top:20px;">
            用户名：<asp:TextBox ID="txt_username" class="input" placeholder="Username" runat="server"></asp:TextBox>
        </div>
            <div class="txtb" style="margin-top:20px;margin-bottom:20px;">
            密&nbsp;&nbsp;&nbsp;码：<asp:TextBox ID="txt_password" class="input" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
           <%-- <span data-placehoder="Password" runat="server"></span>--%>
        </div>
        <div class="txtb">
            验证码：<asp:TextBox ID="intxt_code" width="120px" CssClass="input3" placeholder="验证码" runat="server"></asp:TextBox>
            <div id="v_container" style="width:100px;">

        </div>
        </div>
            <div style="position:relative;top:80px;">
                <asp:Button ID="btn_login" runat="server" class="logbtn" Text="登录" OnClientClick="yanzheng()"
                    onclick="btn_login_Click"  />
                <asp:Button ID="reset" runat="server" CssClass="logbtn2" Text="重置" />
            </div>
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
