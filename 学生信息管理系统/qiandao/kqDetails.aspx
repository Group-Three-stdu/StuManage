<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kqDetails.aspx.cs" Inherits="学生信息管理系统.qiandao.kqDetails" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />

    <title></title>
    <style>
        .left_checked{
            display:inline-block;
            width:35%;
        }
        .right_uncheck{
            display:inline-block;
            width:30%;
            float:right;
            margin-right:250px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="left_checked">
        <h2>已签到：</h2>
        <asp:Repeater ID="Repeater1" runat="server" >
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center">
                        <tr class="table-bordered table-condensed info">
                        <td width="10%" class="table-bordered">学号</td>
                        <td class="table-bordered">姓名</td>
                        <td class="table-bordered">签到时间</td>
                </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                        <td class="table-bordered"><%# Eval("StuId")%></td>
                        <td class="table-bordered"><%# Eval("StuName")%></td>
                        <td class="table-bordered"><%# Eval("Time")%></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>

        <div class="right_uncheck">
                    <h2>未签到：</h2>
        <asp:Repeater ID="Repeater2" runat="server" >
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center">
                        <tr class="table-bordered table-condensed info">
                        <td width="10%" class="table-bordered">学号</td>
                        <td class="table-bordered">姓名</td>
                </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                        <td class="table-bordered"><%# Eval("StuId")%></td>
                        <td class="table-bordered"><%# Eval("StuName")%></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </div>
    </form>
</body>
</html>
