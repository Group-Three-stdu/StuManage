<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stu_yixuan.aspx.cs" Inherits="学生信息管理系统.StudentsInfo.stu_yixuan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <link rel="stylesheet" href="../css/bootstrap.css" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <title>学生查看已选课程</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="col-md-12">
      <h4 class="">操作提示：<asp:Literal ID="StuId" runat="server"></asp:Literal><asp:Literal ID="StuName" runat="server"></asp:Literal>以下为您的的选课，如有问题请与教务部门联系
            </h4>           
            
        </div>
         <asp:Repeater ID="Repeater1" runat="server" >
                <HeaderTemplate>
                    <table width="100%" class="table table-bordered table-hover">
                        <tbody>
                            <tr class="info">
                              <th style="width:7%;text-align:center;border-bottom:1px solid #ccc;" width="10%">课程编号</th>                             
                              <th style="width:12%;text-align:center;border-bottom:1px solid #ccc;" width="10%">课程名称</th>
                              <th style="width:12%;text-align:center;border-bottom:1px solid #ccc;" width="10%">开课学期</th>
                              <th style="width:10%;text-align:center;border-bottom:1px solid #ccc;" width="15%">开课学院</th>
                              <th style="width:12%;text-align:center;border-bottom:1px solid #ccc;" width="10%">任课教师</th>
                              <th style="width:10%;text-align:center;border-bottom:1px solid #ccc;" width="10%">学分</th>
                              <th style="width:12%;text-align:center;border-bottom:1px solid #ccc;" width="10%">性质</th>
                              <th style="width:10%;text-align:center;border-bottom:1px solid #ccc;" width="15%">上课地点</th>
                                <th style="width:10%;text-align:center;border-bottom:1px solid #ccc;" width="15%">上课时间</th>
                              <th style="text-align:center;border-bottom:1px solid #ccc;" width="10%">操作</th>
                            </tr>
                </HeaderTemplate>
                <FooterTemplate>
                   
                        </tbody>
                    </table>
                </FooterTemplate>
                <ItemTemplate>
                    <tr>
                        <td style="text-align:center;height:20px;">
                            <%# Eval("CourseID")%></td>                        
                        <td style="text-align:center;height:20px;">
                            <%# Eval("CourseName")%></td>
                        <td style="text-align:center;height:20px;">
                            <%# Eval("Season")%></td>
                        <td style="text-align:center;height:20px;">
                            <%# Eval("CollegeName")%></td>
                        <td style="text-align:center;height:20px;">
                            <%# Eval("TeaName")%></td>
                        <td style="text-align:center;height:20px;">
                            <%# Eval("Xuefen")%></td>                 
                        <td style="text-align:center;height:20px;">
                            <%# Eval("courseproperty")%></td>
                        <td style="text-align:center;width:30px;height:20px;">
                            <%# Eval("CourseAdd")%></td>
                        <td style="text-align:center;width:30px;height:20px;">
                            <%# Eval("Time")%></td>
                        <td style="text-align:center;height:20px;">
                             <asp:LinkButton ID="btn_Del" CommandArgument='<%#Eval("CourseId")%>' OnClientClick="return confirm('确认删除该课程么？')" OnClick="btn_Del_Click"
                runat="server" ForeColor="Blue">删除</asp:LinkButton>
                        </td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
    
    </div>
    </form>
</body>
</html>
