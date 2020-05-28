<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xueshengchu_index.aspx.cs" Inherits="学生信息管理系统.xueshengchu_index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>学生处人员登陆主页</title>
    <link href="../css/StyleSheet.css" rel="stylesheet" type="text/css" />
    <link href="//at.alicdn.com/t/font_1678369_bfuewyh33xd.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery.min.js"></script>
    <script src="../js/JScript.js"></script>
        <script>
        $(function () {
            $(".one").click(function () {
                var $sub = $(this).children(".sub");
                //让二级菜单展开
                $sub.slideToggle(300);
                //拿到所有的非当前的二级菜单
                var othersub = $(this).siblings().children(".sub");
                //让所有的非当前的二级菜单收起
                othersub.slideUp(300);
            });
            $(".left-nav .menu .one .sub li").click(function () {
                $("#a_leader_txt").text($(this).text());
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
     <div>
        <div class="header" style="background-color:teal">
            <div class="title">
                <a runat="server" href="">学生管理系统</a>
            </div>
            
            <div class="header_nav">
                <asp:LinkButton ID="lb_tuichu" runat="server" PostBackUrl="~/Login.aspx"><i class="a iconfont icon-tuichu"></i></asp:LinkButton>
                <asp:LinkButton ID="lb_lianxi" runat="server"><i class="a iconfont icon-lianxi"></i></asp:LinkButton>
                <asp:LinkButton ID="lb_index" runat="server"><i class="a iconfont icon-shouye"></i></asp:LinkButton>
                <span id="changecolor" style="font-size:40px" class="a iconfont icon-tiaoseban"></span>
             </div>

            <div class="changecolor_menu">
                <div class="now">
                    <i style="line-height:30px;font-style:normal;font-weight:800;color:#666;">&nbsp;当前主题：</i>
                    <div class="now_back" style="background-color:teal;">
                        
                    </div>
                </div>
                <i style="line-height:30px;font-style:normal;font-weight:800;color:#666;">&nbsp;选择主题：</i>
                <div class="select_color">
                    <div id="theme1"></div>
                    <div id="theme2"></div>
                    <div id="theme3"></div>
                    <div id="theme4"></div>
                </div>
            </div>
        </div>
        <div class="header_bottom" style="background-color:rgb(240, 255, 255)">
        &nbsp;
            <span class="iconfont icon-guanli"></span>
            <i style="line-height:30px;font-style:normal;font-weight:800;color:#666"> 欢迎您：</i>
            <asp:Label ID="lb_user" runat="server" class="lb" Text="×××"></asp:Label>
            <span class="iconfont icon-shijian"></span>
            <i style="line-height:30px;font-style:normal;font-weight:800;color:#666"> 当前时间：</i>
            <asp:Label ID="lb_time" runat="server" class="lb" Text="54654456"></asp:Label>
        </div>
        <div class="left-nav" style="background-color:#f5f5f5">
            <div class="title">
                <span class="iconfont icon-xuesheng"></span>
                <i style="font-style:normal;font-weight:800;color:#666;font-size:16px;">学生信息管理

                </i>
            </div>
            <ul class="menu">
                <li class="one">
                <div><i class="iconfont icon-huanzheyilan"></i>查询信息</div>
                    <ul class="sub">
                        <li>
                            <a href="xueshengchu_stupersonnalinformation.aspx" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                学生信息
                            </a>
                        </li>
                       <%-- <li>
                            <a href="#" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                成绩信息
                            </a>
                        </li>
                        <li>
                            <a href="#" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                奖惩信息
                            </a>
                        </li>--%>
                    </ul>
                </li>
          
                <li class="one">
                     <div><i class="iconfont icon-kecheng"></i>录入信息</div>
                   <ul class="sub">
                            <li>
                            <a id="A1" href="~/StudentsInfo/addStudent.aspx" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                录入学生信息
                            </a>
                            </li>
                       </ul>
                </li>
           
                <%--<li class="one">
                     <div><i class="iconfont icon-yihupaixu"></i>修改信息</div>
                        <ul class="sub">
                            <li>
                            <a id="A4" href="" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                修改学籍
                            </a>
                            </li>
                            <li>
                                <a id="A5" href="" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                删除学籍
                            </a>
                            </li>
                        
                        </ul>
                </li>--%>
          
                <%--<li class="one"><div><i class="iconfont icon-quanyuanxuanjiao"></i>毕业处理</div>
                     <ul class="sub">
                            <li>
                            <a id="A2" href="" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                毕业处理
                            </a>
                            </li>
                         </ul>
                    
                </li>--%>
         
                <li class="one"><div><i class="iconfont icon-yonghuguanli"></i>系统设置</div>
                    <ul class="sub">
                        <li>
                            <a id="A10" href="stu_alterpwd.aspx" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                修改密码
                            </a>
                        </li>
                        <li>
                            <a id="A11" href="" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                退出登录
                            </a>
                        </li>
                    </ul>
                </li>
            </ul>
            
        </div>
        <ul class="bread">
            <li><a href="index.aspx" target="right" class="icon-home">首页</a></li>
            <li><a>/</a></li>
            <li><a href="##" id="a_leader_txt">网站信息</a></li>
        </ul>
        <div class="admin">
            <iframe frameborder="0" scrolling="auto" rameborder="0" src="index.aspx" name="right" width="100%" height="99.5%"></iframe>
        </div>
    </div>
    </form>
</body>
</html>
