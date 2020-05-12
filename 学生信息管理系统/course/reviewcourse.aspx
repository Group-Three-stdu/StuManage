<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reviewcourse.aspx.cs" Inherits="学生信息管理系统.course.reviewcourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="../css/bootstrap.min.css" />
    <title>教务处审核课程</title>
    <style>
        .box{
            width:100%;
            height:65px;
            background-color:#c4e1ff;
        }
        .button{
            width:12%;
            text-align:center;
            height:25px;
            margin-left:1%;
            margin-top:20px;
            border-radius:5px;
            margin-bottom:20px;
        }
        .content{
            margin-top:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="box">
            <asp:Button ID="Button1" runat="server" CssClass="button btn-info" Text="查看全部课程" />
            <asp:Button ID="Button2" runat="server" CssClass="btn-danger button " Text="查看未通过审核课程" />
            <asp:Button ID="Button3" runat="server" CssClass="btn-success button" Text="查看已通过审核课程" />
        </div>
        <div class="content">

            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center">
                        <tr class="table-bordered table-condensed info">
                        <td width="10%" class="table-bordered">课程编号</td>
                        <td class="table-bordered">课程名</td>
                        <td class="table-bordered">学分</td>
                        <td class="table-bordered">学时数</td>
                        <td class="table-bordered">课程性质</td>
                        <td class="table-bordered">开课学院</td>
                        <td class="table-bordered">状态</td>
                        <td class="table-bordered">操作</td>
                </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                        <td class="table-bordered"><%# Eval("CourseID")%></td>
                        <td class="table-bordered"><%# Eval("CourseName")%></td>
                        <td class="table-bordered"><%# Eval("Xuefen")%></td>
                        <td class="table-bordered"><%# Eval("CourseNum")%></td>
                        <td class="table-bordered"><%# Eval("courseproperty")%></td>
                        <td class="table-bordered"><%# Eval("college")%></td>
                        <td class="table-bordered"><%# Eval("zhuangtai")%></td>
                        <td class="table-bordered">
                            <asp:HyperLink ID="success" runat="server">通过</asp:HyperLink>
                            &nbsp;
                            <asp:HyperLink ID="failed" runat="server">不通过</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
