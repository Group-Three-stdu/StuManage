<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lookcourse.aspx.cs" Inherits="学生信息管理系统.course.lookcourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .top{
            width:100%;
            height:80px;
            background-color:#c4e1ff;
        }
        .top .drop{
            width:10%;
            height:35px;
            margin-left:1%;
            margin-top:22.5px;
        }
        .top .input{
            width:10%;
            height:35px;
            margin-left:12%;
            position:relative;
            top:-35.5px;
        }
        .form-control{
            display:inline-block;
        }
        form-control{
            display:inline-block;
        }
        .btn_size{
            width:4%;
            height:33px;
            margin-top:-157px;
            margin-left:23%;
        }
        .content{
            margin-top:10px;
            width:100%;
            overflow:hidden;
        }
    </style>
    <title>查看课程</title>
</head>
<body>
    <form runat="server">
        <div class="top">
            <asp:DropDownList ID="ddl_course" runat="server" CssClass="drop form-control">
                <asp:ListItem>课程名查找</asp:ListItem>
                <asp:ListItem>经济学</asp:ListItem>
                <asp:ListItem>经济学</asp:ListItem>
                <asp:ListItem>经济学</asp:ListItem>
                <asp:ListItem>经济学</asp:ListItem>
            </asp:DropDownList>
            <div class="form-group">
                <asp:TextBox ID="txt_key" class="input form-control" placeholder="课程关键字" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="btn_search" CssClass="btn_size btn btn-success" runat="server" Text="查询" />
        </div>
        <div class="content">
            <table class="table table-striped table-hover text-center">
                <tr class="table-bordered table-condensed info">
                    <td width="10%" class="table-bordered">课程编号</td>
                    <td class="table-bordered">课程名</td>
                    <td class="table-bordered">学分</td>
                    <td class="table-bordered">学时数</td>
                    <td class="table-bordered">课程性质</td>
                    <td class="table-bordered">操作</td>
                </tr>
                <tr class="table-responsive table-bordered table-condensed">
                    <td class="table-bordered">123</td>
                    <td class="table-bordered">123</td>
                    <td class="table-bordered"> 123</td>
                    <td class="table-bordered">123</td>
                    <td class="table-bordered">123</td>
                    <td class="table-bordered">123</td>
                </tr>
                <tr class="table-responsive table-bordered table-condensed">
                    <td class="table-bordered">123</td>
                    <td class="table-bordered">123</td>
                    <td class="table-bordered"> 123</td>
                    <td class="table-bordered">123</td>
                    <td class="table-bordered">123</td>
                    <td class="table-bordered">123</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
