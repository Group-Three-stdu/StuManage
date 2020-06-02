<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClassScore.aspx.cs" Inherits="学生信息管理系统.Class.ClassScore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" enablepartialrendering="true"></asp:ScriptManager>
        <div id="StuScore" >
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="True">
            <ContentTemplate>
             <div class="top">          
                姓名：<asp:TextBox ID="txt_name" runat="server" class="input"></asp:TextBox>
                <asp:Button ID="btn_searchstu" runat="server" class="btn" Text="查询"  />
                学号：<asp:TextBox ID="txt_StuId" runat="server" class="input"></asp:TextBox>
                <asp:Button ID="btn_SearchStuId" runat="server" class="btn" Text="查询"/>
            </div>
             <div>
              <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center col-8" style="width:90%">
                        <tr class="table-bordered table-condensed info text-center"  >
                             <th style="text-align:center">学号</th>
                            <th style="text-align:center">姓名</th>
                            <th style="text-align:center">班级</th>
                            <th style="text-align:center">平时成绩</th>
                            <th style="text-align:center">期末成绩</th>
                            <th style="text-align:center">总成绩</th>
                            <th style="text-align:center">签到</th>
                            <th style="text-align:center">作业</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                             <td><%# Eval("StuId")%></td>
                             <td><%# Eval("StuName")%></td>
                             <td><%# Eval("ClassId")%></td>
                             <td><%# Eval("ClassScore")%></td>
                             <td><%# Eval("MatchScore")%></td>
                             <td><%# Eval("FinalScore")%></td>
                             <td><%# Eval("KqNum")%></td>
                             <td><%# Eval("HwNum")%></td>
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
