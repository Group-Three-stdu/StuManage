<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jiaowuchu_lookscore.aspx.cs" Inherits="学生信息管理系统.Score.jiaowuchu_lookscore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>教务处查询学生成绩</title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .ddl{
            width:10%;
            height:30px;
            margin-left:2%;
            margin-top:10px;
            float:left;
        }
        .button{
            width:4%;
            height:30px;
            margin-left:1%;
            margin-top:10px;
            float:left;
        }
        .box{
            height:50px;
            width:100%;
            background-color:#f1f1f1;
        }
        .content{
            width:100%;
            height:auto;
            margin-top:10px;
        }
        .data{
            width:100%;
            margin-top:0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="box">
            <asp:DropDownList ID="DropDownList1" CssClass="ddl form-control" runat="server" DataSourceID="SqlDataSource1" DataTextField="classId" DataValueField="classId">
                <asp:ListItem>请选择班级</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" CssClass="ddl form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="CourseName" DataValueField="CourseName">
                <asp:ListItem>请选择课程</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:StulnfoConnectionString %>" SelectCommand="SELECT [CourseName] FROM [CoursesMes]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StulnfoConnectionString %>" SelectCommand="SELECT [classId] FROM [Class]"></asp:SqlDataSource>
            <asp:TextBox ID="TextBox1" CssClass="ddl form-control" placeholder="请输入学号" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" CssClass="button btn btn-info" Text="查询" />
        </div>
        <div class="content">
            <asp:DataList ID="DataList1" CssClass="data" runat="server" DataSourceID="SqlDataSource3">
                <HeaderTemplate>
                    <table class="table table-bordered table-striped table-hover">
                        <tr style="background-color:#99cccc">
                            <td style="width:0px;"></td>
                            <td>学号</td>
                            <td>班级</td>
                            <td>平时成绩</td>
                            <td>期末成绩</td>
                            <td>最终成绩</td>
                            <td>操作</td>
                </HeaderTemplate>
                <ItemTemplate>
                        
                            <td><asp:Label ID="StuIdLabel" runat="server" Text='<%# Eval("StuId") %>' /></td>
                            <td><asp:Label ID="CourseIdLabel" runat="server" Text='<%# Eval("CourseId") %>' /></td>
                            <td><asp:Label ID="ClassScoreLabel" runat="server" Text='<%# Eval("ClassScore") %>' /></td>
                            <td><asp:Label ID="MatchScoreLabel" runat="server" Text='<%# Eval("MatchScore") %>' /></td>
                            <td><asp:Label ID="FinalScoreLabel" runat="server" Text='<%# Eval("FinalScore") %>' /></td>
                            <td>
                                <asp:Button ID="Button2" runat="server" Text="编辑" CommandArgument='<%# Eval("StuId") %>' /></td>
                        
                </ItemTemplate>
                <FooterTemplate>
                    </tr>
                    </table>
                </FooterTemplate>
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:StulnfoConnectionString %>" SelectCommand="SELECT [StuId], [ClassScore], [CourseId], [MatchScore], [FinalScore] FROM [Score]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
