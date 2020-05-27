<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tea_look_score1.aspx.cs" Inherits="学生信息管理系统.Score.Tea_look_score" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>教师查询学生成绩</title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />    
    <link rel="stylesheet" href="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/css/bootstrap.min.css"/>
	<script src="https://cdn.staticfile.org/jquery/2.1.1/jquery.min.js"></script>
	<script src="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            font-family: 新宋体;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" enablepartialrendering="true"></asp:ScriptManager>
        <div>   
         <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="True">
            <ContentTemplate>
             <div class="top">          
                班级：<asp:DropDownList ID="ddlclass" class="select" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlclass_SelectedIndexChanged" >
                            <asp:ListItem>请选择</asp:ListItem>
                        </asp:DropDownList>
                姓名：<asp:TextBox ID="txt_name" runat="server" class="input"></asp:TextBox>
                <asp:Button ID="btn_searchstu" runat="server" class="btn" Text="查询" OnClick="btn_searchstu_Click" />
                学号：<asp:TextBox ID="txt_StuId" runat="server" class="input"></asp:TextBox>
                <asp:Button ID="btn_SearchStuId" runat="server" class="btn" Text="查询" OnClick="btn_searchStuId_Click" />
            </div>
             <div>
               最终成绩占比：平时：<asp:Label ID="ClassRatio" runat="server"></asp:Label>&nbsp; &nbsp; &nbsp; &nbsp;  考试：<asp:Label ID="MatchRatio" runat="server"></asp:Label><br />
              <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center col-8" style="width:90%">
                        <tr class="table-bordered table-condensed info text-center"  >
                              <th class="table-bordered" style="text-align:center;">课程名</th>
                              <th class="table-bordered" style="text-align:center;">学号</th>
                              <th class="table-bordered" style="text-align:center;">姓名</th>
                              <th class="table-bordered" style="text-align:center;">班级</th>
                              <th class="table-bordered" style="text-align:center;">学院</th>
                              <th class="table-bordered" style="text-align:center;">学分</th>
                              <th class="table-bordered" style="text-align:center;">平时成绩</th>
                              <th class="table-bordered" style="text-align:center;">考试成绩</th>
                              <th class="table-bordered" style="text-align:center;">总成绩</th>
                              <th class="table-bordered" style="text-align:center;">操作</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                         <td class="table-bordered" style="text-align:center;"><%# Eval("CourseName")%></td>
                        <td class="table-bordered" style="text-align:center;"><%# Eval("StuId")%></td>
                        <td class="table-bordered" style="text-align:center;"><%# Eval("StuName")%></td>
                        <td class="table-bordered" style="text-align:center;"><%# Eval("ClassID")%></td>
                        <td class="table-bordered" style="text-align:center;"><%# Eval("College")%></td>
                        <td class="table-bordered" style="text-align:center;"><%# Eval("Xuefen")%></td>
                        <td class="table-bordered" style="text-align:center;"><%# Eval("ClassScore")%></td>
                        <td class="table-bordered" style="text-align:center;"><%# Eval("MatchScore")%></td>
                        <td class="table-bordered" style="text-align:center;"><%# Eval("FinalScore")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <asp:LinkButton ID="btnChange" CommandArgument='<%#Eval("StuId")%>'  runat="server" OnClick="btnChange_Click">详情</asp:LinkButton>
                        </td>                        
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
                </div>
                
        
            </div>
        </div>
                </ContentTemplate>
        </asp:UpdatePanel>
        </div>
        <asp:Button ID="Button1" runat="server" BackColor="#C8C5F5" Font-Names="新宋体" Font-Size="X-Large" Text="打印" />
        </form>
   </body>
</html>
