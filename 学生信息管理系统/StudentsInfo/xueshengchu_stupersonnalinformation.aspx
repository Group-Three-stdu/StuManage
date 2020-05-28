<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xueshengchu_stupersonnalinformation.aspx.cs" Inherits="学生信息管理系统.xueshengchu_stupersonnalinformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../js/jquery.min.js"></script>
</head>
<body>
    <script>
    </script>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" enablepartialrendering="true"></asp:ScriptManager>
    <div>
        <div class="top">
            学院：<asp:DropDownList ID="ddlxueyuan" class="select" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlxueyuan_SelectedIndexChanged">
                <asp:ListItem>请选择</asp:ListItem>
            </asp:DropDownList>
            
            专业：<asp:DropDownList ID="ddlmajor" class="select" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlmajor_SelectedIndexChanged" >
                <asp:ListItem>请选择</asp:ListItem>
            </asp:DropDownList>
            
            班级：<asp:DropDownList ID="ddlclass" class="select" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlclass_SelectedIndexChanged" >
                <asp:ListItem>请选择</asp:ListItem>
            </asp:DropDownList>
            姓名：<asp:TextBox ID="txt_name" runat="server" class="input" placeholder="学号或姓名"></asp:TextBox>
            学号：<asp:TextBox ID="txt_id" runat="server"></asp:TextBox>
            <asp:Button ID="btn_searchstu" runat="server" class="btn" Text="查询" OnClick="btn_searchstu_Click" />
            </div>     
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="True">
        <ContentTemplate>
                <div class="content">
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table width="100%">
                        <tbody>
                            <tr>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" height="35px" width="400">学号</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="7%">姓名</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="5%">性别</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="15%">学院编号</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="15%">专业编号</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="10%">班级</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="10%">手机号</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="15%">身份证号</th>
                              <th style="text-align:center;background-color:#ccc;border-bottom:1px solid #ccc;" width="15%">操作</th>
                            </tr>
                </HeaderTemplate>
            
                <ItemTemplate>
                    <tr>
                        <td style="text-align:center;background-color:#f5f5f5;height:30px;"><%#Eval("StuId") %></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:30px;"><%#Eval("StuName") %></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:30px;"><%#Eval("StuSex") %></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:30px;"><%#Eval("College") %></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:30px;"><%#Eval("Major") %></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:30px;"><%#Eval("ClassId") %></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:30px;"><%#Eval("StuPhoneNum") %></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:30px;"><%#Eval("StuNoId") %></td>
                        <td style="text-align:center;background-color:#f5f5f5;height:30px;">
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#Eval("StuId","~/StudentsInfo/alter_StudentInfo.aspx?StuId={0}") %>'
                runat="server" ForeColor="Blue">编辑</asp:HyperLink>
                            <asp:LinkButton ID="btn_Del" CommandArgument='<%#Eval("StuId")%>' OnClientClick="return confirm('确认删除该学生么？')" OnClick="btn_Del_Click"
                runat="server" ForeColor="Blue">删除</asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
