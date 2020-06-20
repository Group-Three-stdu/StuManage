<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangeScore.aspx.cs" Inherits="学生信息管理系统.Score.ChangeScore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="info" style="margin:10px;" >
            学号：<asp:Label ID="StuId" runat="server" ></asp:Label>
            姓名：<asp:Label ID="StuName" runat="server" ></asp:Label>
            课程名：<asp:Label ID="CourseName" runat="server" ></asp:Label><br />
            成绩占比： 平时：<asp:Label ID="ClassRatio" runat="server"></asp:Label> &nbsp; &nbsp; &nbsp; &nbsp;
                             期末：<asp:Label ID="MatchRatio" runat="server"></asp:Label>
        </div>
        <div class="old" style="display:inline-block;width:200px;margin:10px;">
            平时成绩：<asp:Label ID="old_ClassScore" runat="server" ></asp:Label><br />
            考试成绩：<asp:Label ID="old_MatchScore" runat="server" ></asp:Label><br />
            最终成绩：<asp:Label ID="old_FinalScore" runat="server" ></asp:Label><br />
        </div>
        <div class="new"  style="display:inline-block;width:300px;margin:10px;">
            平时成绩：<asp:TextBox ID="new_ClassScore" runat="server" OnTextChanged="new_ClassScore_TextChanged" AutoPostBack="True"></asp:TextBox><br />
            考试成绩：<asp:TextBox ID="new_MatchScore" runat="server" OnTextChanged="new_MatchScore_TextChanged" AutoPostBack="True" ></asp:TextBox><br />
            最终成绩：<asp:TextBox ID="new_FinalScore" runat="server" ReadOnly="true"></asp:TextBox><br />
        </div>
        <div class="btn">
            <asp:Button ID="btn_change" CssClass="btn btn-info" runat="server" Text="确认修改" OnClick="btn_change_Click"/>&nbsp; &nbsp; &nbsp; &nbsp;
            <asp:Button ID="btn_back" CssClass="btn btn-info" runat="server" Text="返回"  OnClientClick="javascript:window.history.go(-1);" />
        </div>
    </div>
    </form>
    </body>
</html>
