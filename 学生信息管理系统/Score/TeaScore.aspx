<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tea_shuru_Score.aspx.cs" Inherits="学生信息管理系统.Score.TeaScore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../js/jquery.js"></script>
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 18px;
        }
    </style>
  
</head>
<body>
    <form id="form1" runat="server">
        <div class="top">          
                班级：<asp:DropDownList ID="ddlclass" class="select" runat="server" >
                <asp:ListItem>请选择</asp:ListItem>
            </asp:DropDownList>
            姓名：<asp:TextBox ID="txt_name" runat="server" class="input"></asp:TextBox>
            <asp:Button ID="btn_searchstu" runat="server" class="btn" Text="查询" OnClick="btn_searchstu_Click" />
            学号：<asp:TextBox ID="txt_StuId" runat="server" class="input"></asp:TextBox>
            <asp:Button ID="btn_SearchStuId" runat="server" class="btn" Text="查询"  />
        </div>
        <div class="content">
            <div>
                学生总数：<asp:Label ID="StuNum" runat="server" Text="Label"></asp:Label>
               平时成绩占比：<asp:TextBox ID="TextBox1" ClientID="classratio" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="True"></asp:TextBox>
               期末成绩占比：<asp:TextBox ID="TextBox2" ClientID="matchratio" runat="server" AutoPostBack="True" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="确定"  OnClick="Button1_Click" />
            </div>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center col-8" style="width:70%">
                        <tr class="table-bordered table-condensed info text-center"  >
                            <th class="auto-style1 text-center">学号</th>
                            <th class="auto-style1 text-center">姓名</th>
                            <th class="auto-style1 text-center">班级</th>
                            <th class="auto-style1 text-center">考试成绩</th>
                            <th class="auto-style1 text-center">平时成绩</th>
                            <th class="auto-style1 text-center">期末成绩</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                            <td><asp:Literal ID="StuId" runat="server" Text='<%# Eval("StuId")%>'></asp:Literal></td>
                             <td><asp:Literal ID="StuName" runat="server" Text='<%# Eval("StuName")%>'></asp:Literal></td>
                             <td><asp:Literal ID="ClassId" runat="server" Text='<%# Eval("ClassId")%>'></asp:Literal></td>
                             <td><asp:TextBox ID="matchScore" runat="server"></asp:TextBox></td>
                             <td><asp:TextBox ID="classScore" runat="server"></asp:TextBox></td>    
                             <td><asp:TextBox ID="AllScore" runat="server"></asp:TextBox></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            <asp:Button ID="Button2" runat="server" Text="提交" OnClick="Button2_Click" />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
