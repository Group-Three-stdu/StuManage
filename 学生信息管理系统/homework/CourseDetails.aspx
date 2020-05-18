<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseDetails.aspx.cs" Inherits="学生信息管理系统.homework.zuoye_xiangqing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="top">          
            班级：<asp:DropDownList ID="ddlclass" class="select" runat="server" >
                <asp:ListItem>请选择</asp:ListItem>
            </asp:DropDownList>
            姓名：<asp:TextBox ID="txt_name" runat="server" class="input"></asp:TextBox>
            <asp:Button ID="btn_searchstu" runat="server" class="btn" Text="查询" OnClick="btn_searchstu_Click" />
            学号：<asp:TextBox ID="txt_StuId" runat="server" class="input"></asp:TextBox>
            <asp:Button ID="btn_SearchStuId" runat="server" class="btn" Text="查询" OnClick="btn_searchStuId_Click" />
        </div>
        <div class="content">
             <table>
                 <tr>
                     <th>学号</th>
                     <th>姓名</th>
                     <th>班级</th>
                     <th>联系方式</th>
                 </tr>
                 
                     <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
                      <ItemTemplate>
                          <tr>
                         <td><%# Eval("StuId")%></td>
                         <td><%# Eval("StuName")%></td>
                         <td><%# Eval("ClassId")%></td>
                         <td><%# Eval("StuPhoneNum")%></td> </tr>
                     </ItemTemplate>
                    </asp:DataList>
                
             </table>
        </div>
    </div>
    </form>
</body>
</html>
