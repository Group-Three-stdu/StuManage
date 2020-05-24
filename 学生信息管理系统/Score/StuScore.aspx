<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StuScore.aspx.cs" Inherits="学生信息管理系统.Score.StuScore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" enablepartialrendering="true"> </asp:ScriptManager>
    <div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="True">
            <ContentTemplate>
                 <div class="top">          
                学期：<asp:DropDownList ID="ddlseason" class="select" runat="server" AutoPostBack="True" >
                            <asp:ListItem>请选择</asp:ListItem>
                        </asp:DropDownList>
                课程名：<asp:TextBox ID="txt_name" runat="server" class="input"></asp:TextBox>
                <asp:Button ID="btn_searchstu" runat="server" class="btn" Text="查询" OnClick="btn_searchstu_Click" />              
                 <asp:Button ID="ToExcel" runat="server" Text="导出到excel"/>
            </div>
            <div>
              <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center col-8" style="width:70%">
                        <tr class="table-bordered table-condensed info text-center"  >
                            <th style="text-align:center">课程名</th>
                            <th style="text-align:center">学院</th>
                            <th style="text-align:center">学时</th>
                            <th style="text-align:center">教师</th>
                            <th style="text-align:center">性质</th>
                            <th style="text-align:center">学分</th>
                            <th style="text-align:center">考试成绩</th>
                            <th style="text-align:center">平时成绩</th>
                            <th style="text-align:center">最终成绩</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                            <td><%# Eval("CourseName")%></td>
                            <td><%# Eval("CollegeName")%></td>
                            <td><%# Eval("CourseNum")%></td>
                            <td><%# Eval("TeaName")%></td>
                            <td><%# Eval("courseproperty")%></td>
                            <td><%# Eval("Xuefen")%></td>
                            <td><%# Eval("MatchScore")%></td>
                            <td><%# Eval("CourseNum")%></td>
                            <td><%# Eval("FinalScore")%></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
                </asp:Repeater>
             </div>
             </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
