<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stu_xuanke.aspx.cs" Inherits="学生信息管理系统.StudentsInfo.stu_xuanke" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="../css/bootstrap.css" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <title></title>
    <style type="text/css">
        .text-white {
            height: 40px;
            background-color: #B6BCC9;
        }
        .auto-style1 {
            font-size: large;
            background-color: #c4e3f3;
            height: 50px;
        }
        .col-3 {
            width: 105px;
            height: 45px;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
  <%--<div class="col-md-12">
      <h4><asp:Literal ID="StuId" runat="server"></asp:Literal><asp:Literal ID="StuName" runat="server"></asp:Literal>，当前选课学期：2020年夏</h4></div>--%>
  <div class="col-md-12  auto-style1  "style="text-align:center; line-height:50px">
      
      <span class="auto-style2">课程</span>：<asp:DropDownList ID="DropDownList1" runat="server" Height="30px" style="margin-top: 0px">
          <asp:ListItem>按课程名称查询</asp:ListItem>
          <asp:ListItem>按课程代码查询</asp:ListItem>
          <asp:ListItem>按授课教师查询</asp:ListItem>
          <asp:ListItem>按学分查询</asp:ListItem>
      </asp:DropDownList>
&nbsp;
      <asp:TextBox ID="TextBox1" runat="server" ForeColor="Gray" placeholder="请输入关键字" Height="30px"></asp:TextBox>
&nbsp;<asp:DropDownList ID="DropDownList2" runat="server" Height="30px" Width="90px">
          <asp:ListItem>全部</asp:ListItem>
          <asp:ListItem>必修</asp:ListItem>
          <asp:ListItem>限选</asp:ListItem>
          <asp:ListItem>选修</asp:ListItem>
      </asp:DropDownList>
&nbsp;
      <asp:DropDownList ID="DropDownList3" runat="server" Height="30px">
          <asp:ListItem>全部学院</asp:ListItem>
          <asp:ListItem>土木</asp:ListItem>
          <asp:ListItem>机械</asp:ListItem>
          <asp:ListItem>外语</asp:ListItem>
          <asp:ListItem>文法</asp:ListItem>
          <asp:ListItem>信息</asp:ListItem>
          <asp:ListItem>交通</asp:ListItem>
          <asp:ListItem>材料</asp:ListItem>
          <asp:ListItem>建艺</asp:ListItem>
      </asp:DropDownList>

                &nbsp;
      <asp:Button ID="Button1" class="btn btn-info auto-style3" runat="server" Text="确认查询" OnClick="Button1_Click" />
                </div>
</div>
             <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table width="100%" style="margin-top:10px;" class="table table-bordered table-hover table-responsive">
                        <tbody>
                            <tr class="info">                            
                              <th style="text-align:center;border-bottom:1px solid #ccc;" width="10%">课程编号</th>
                              <th style="text-align:center;border-bottom:1px solid #ccc;" width="20%">课程名称</th>
                              <th style="text-align:center;border-bottom:1px solid #ccc;" width="10%">学分</th>
                              <th style="text-align:center;border-bottom:1px solid #ccc;" width="10%">性质</th>
                              <th style="text-align:center;border-bottom:1px solid #ccc;" width="15%">教师</th>
                              <th style="text-align:center;border-bottom:1px solid #ccc;" width="10%">开课学期</th>
                              <th style="text-align:center;border-bottom:1px solid #ccc;" width="15%">开课学院</th>
                              <th style="text-align:center;border-bottom:1px solid #ccc;" width="15%">操作</th>
                            </tr>
                </HeaderTemplate>
                <FooterTemplate>
                   
                        </tbody>
                    </table>
                </FooterTemplate>
                <ItemTemplate>
                    <tr>                      
                        <td style="text-align:center;height:20px;">
                            <%# Eval("CourseId")%></td>
                        <td style="text-align:center;height:20px;">
                            <%# Eval("CourseName")%></td>
                        <td style="text-align:center;height:20px;">
                            <%# Eval("Xuefen")%></td>
                        <td style="text-align:center;height:20px;">
                            <%# Eval("courseproperty")%></td>
                        <td style="text-align:center;height:20px;">
                            <%# Eval("TeaName")%></td>
                        <td style="text-align:center;height:20px;">
                            <%# Eval("Season")%></td>
                        <td style="text-align:center;height:20px;">
                            <%# Eval("CollegeName")%></td>
                        <td style="text-align:center;height:20px;">
                            <asp:LinkButton ID="btnAdd" CommandArgument='<%#Eval("CourseId")%>'   OnClick="btnAdd_Click"
                                         runat="server">添加</asp:LinkButton>
                        </td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
 
</div>
        <asp:Literal ID="Itamsg" runat="server"></asp:Literal>
    </form>
</body>
</html>
