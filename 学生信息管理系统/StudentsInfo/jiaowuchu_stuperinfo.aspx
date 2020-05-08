<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jiaowuchu_stuperinfo.aspx.cs" Inherits="学生信息管理系统.StudentsInfo.jiaowuchu_stuperinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>教务处管理学籍信息</title>
    <link href="css/command.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery.js" type="text/javascript"></script>
    <script>
       
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="top">
            <asp:DropDownList ID="ddlxueyuan" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlxueyuan_SelectedIndexChanged">
                <asp:ListItem>请选择</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlmajor" class="select" runat="server" AutoPostBack="True">
                <asp:ListItem>请选择</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlclass" class="select" runat="server" AutoPostBack="True">
                <asp:ListItem>请选择</asp:ListItem>
            </asp:DropDownList>
            

            <%--<select name="" id="selProvince" class="select">
                <option value="">----学院----</option>
            </select>
            <select name="" id="selCity" class="select">
                <option value="">----专业----</option>
            </select>
            <select name="" id="selCountry" class="select">
                <option value="">----班级----</option>
            </select>
            <select name="" id="selSex" class="select">
                <option value="">----性别----</option>
                <option value="">男</option>
                <option value="">女</option>
            </select>--%>
            <asp:TextBox ID="txt_Stuid" runat="server" class="input" placeholder="学号或姓名"></asp:TextBox>
            <asp:Button ID="btn_searchstu" runat="server" class="btn" Text="查询" OnClick="btn_searchstu_Click" style="height: 23px" />
            <br>
            <%--<asp:Button ID="btn_addstu" class="btn_right" runat="server" Text="添加学生信息" />
            <asp:Button ID="btn_daochustu" class="btn_right" runat="server" Text="导出学生信息" />
            <asp:Button ID="btn_piliangstu" class="btn_right" runat="server" Text="批量编辑" />--%>
            <asp:Label ID="lb_count" runat="server" Text=""></asp:Label>
        </div>
        
        <div class="content">
            
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table width="100%">
                        <tbody>
                            <tr>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" height="25px" width="300">学号</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="10%">姓名</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="10%">性别</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="10%">学院编号</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="20%">专业编号</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="15%">班级</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="10%">手机号</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="15%">操作</th>
                            </tr>
                </HeaderTemplate>
                <FooterTemplate>
                   
                        </tbody>
                    </table>
                </FooterTemplate>
                <ItemTemplate>
                    <tr>
                        <td style="text-align:center;background-color:#f5f5f5;height:20px;">
                            <%# Eval("StuId")%></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:20px;">
                            <%# Eval("StuName")%></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:20px;">
                            <%# Eval("StuSex")%></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:20px;">
                            <%# Eval("College")%></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:20px;">
                            <%# Eval("Major")%></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:20px;">
                            <%# Eval("ClassId")%></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:20px;">
                            <%# Eval("StuPhoneNum")%></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:20px;">
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#Eval("StuId","~/StudentsInfo/look_StudentInfo.aspx?StuId={0}") %>'
                runat="server" ForeColor="Blue">查看</asp:HyperLink>
                        </td>
                        <td style="text-align:center;background-color:#f5f5f5;height:30px;">
                            </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            
        </div>
       
    </div>
    </form>
</body>
</html>
