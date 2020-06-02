<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jiaowuchu_index.aspx.cs" Inherits="学生信息管理系统.StudentsInfo.jiaowuchu_index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>教务处登录首页</title>
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
        <div class="header" style="background-color:#99cccc;">
            <div class="logo">
                <img src="../image/school.jpg" style="width:60px;height:60px" />
            </div>
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
                    <div class="now_back" style="background-color:#99cccc">
                        
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
        <div class="header_bottom" style="background-color:#ccffff;">
        &nbsp;
            <span class="iconfont icon-guanli"></span>
            <i style="line-height:30px;font-style:normal;font-weight:800;color:#666"> 欢迎您：</i>
            <asp:Label ID="lb_user" runat="server" class="lb" Text="123456"></asp:Label>
            <%--<span class="iconfont icon-shijian"></span>--%>
            <%--<i style="line-height:30px;font-style:normal;font-weight:800;color:#666"> 当前时间：</i>
            <asp:Label ID="lb_time" runat="server" class="lb" Text="54654456"></asp:Label>--%>
        </div>
        <div class="left-nav" style="background-color:#f5f5f5">
            <div class="title">
                <span class="iconfont icon-xuesheng"></span>
                <i style="font-style:normal;font-weight:800;color:#666;font-size:16px;">学生信息管理系统</i>
            </div>
            <ul class="menu">
                
          
                <li class="one">
                     <div><i class="iconfont icon-kecheng"></i>课程管理</div>
                    <ul class="sub">
                         <li>
                            <a id="A1" href="~/course/coursestate.aspx" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                开启选课
                            </a>
                        </li>
                        <li>
                            <a id="A2" href="~/course/reviewcourse.aspx" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                审核课程
                            </a>
                        </li>
                        <li>
                            <a id="A3" href="~/course/lookcourse.aspx" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                查看课程
                            </a>
                        </li>
                        
                    </ul>
                </li>
           
                <%--<li class="one">
                     <div><i class="iconfont icon-yihupaixu"></i>成绩信息</div>
                        <ul class="sub">
                            <li>
                            <a id="A4" href="" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                查询成绩
                            </a>
                            </li>
                            <li>
                                <a id="A5" href="" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                成绩管理
                            </a>
                            </li>
                        
                        </ul>
                </li>--%>
          
               <%-- <li class="one"><div><i class="iconfont icon-quanyuanxuanjiao"></i>教学日常</div>
                    <ul class="sub">
                        <li>
                            <a id="A9" href="" runat="server" target="right">
                                <i class="iconfont icon-wenjuantiaocha"></i>
                                公告管理
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
