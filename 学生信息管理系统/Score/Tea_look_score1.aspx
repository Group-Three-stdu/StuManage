<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tea_look_score1.aspx.cs" Inherits="学生信息管理系统.Score.Tea_look_score" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>教师查询学生成绩</title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />    
    <style type="text/css">
        .auto-style1 {
            font-family: 新宋体;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>   
        <div class="auto-style1" style=" line-height:65px; background-color: #C8C5F5;">
            
            学号：<asp:TextBox ID="TextBox1" runat="server" BorderColor="White" BorderStyle="Solid">全部</asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" BackColor="#B0ADF1" Text="查询" />
            </div>
            
       
        </div>
        
        <div class="content">
            
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                <HeaderTemplate>
                    <table style="margin-top:15px;" class="table table-striped table-hover text-center">
                        <tbody>
                            <tr class="table-bordered table-condensed info">
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
                <FooterTemplate>
                   
                        </tbody>
                    </table>
                </FooterTemplate>
                <ItemTemplate>
                    <tr>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("CourseName")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("StuId")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("StuName")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("ClassID")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("College")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("Xuefen")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("ClassScore")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("MatchScore")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("FinalScore")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#Eval("StuId","~/StudentsInfo/look_StudentInfo.aspx?StuId={0}") %>'
                runat="server" ForeColor="Blue">修改</asp:HyperLink>
                        </td>                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>            
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StulnfoConnectionString %>" SelectCommand="SELECT [StuId], [StuName], [College], [ClassScore], [MatchScore], [FinalScore], [ClassId], [Xuefen], [CourseName] FROM [V_tea_score]"></asp:SqlDataSource>
        </div>       
    </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BackColor="#C8C5F5" Font-Names="新宋体" Font-Size="X-Large" Text="打印" />
        </form>
</body>
</html>
