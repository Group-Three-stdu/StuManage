<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jiaowuchu_stuperinfo.aspx.cs" Inherits="学生信息管理系统.StudentsInfo.jiaowuchu_stuperinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>教务处管理学籍信息</title>
    <link href="css/command.css" rel="stylesheet" type="text/css" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/jquery.js" type="text/javascript"></script>
    <script>
       
    </script>
    <style>
        .drop{
            width:12%;
            height:25px;
            margin-left:1%;
            font-size:13px;
        }
        .form-control{
            display:inline-block;
            padding-top:2px;
        }
        .input{
            width:12%;
            height:25px;
            margin-left:1%;
        }
        .btn{
            padding-top:2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="top">
            <asp:DropDownList ID="ddlxueyuan" runat="server" AutoPostBack="True" CssClass="drop form-control" OnSelectedIndexChanged="ddlxueyuan_SelectedIndexChanged">
                <asp:ListItem>请选择</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlmajor" class="select" CssClass="drop form-control" runat="server" AutoPostBack="True">
                <asp:ListItem>请选择</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlclass" class="select" CssClass="drop form-control" runat="server" AutoPostBack="True">
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
            <asp:TextBox ID="txt_Stuid" runat="server" class="input form-control" placeholder="学号或姓名"></asp:TextBox>
            <asp:Button ID="btn_searchstu" runat="server" class="btn btn-success" Text="查询" OnClick="btn_searchstu_Click" style="height: 25px" />
            <br>
            <%--<asp:Button ID="btn_addstu" class="btn_right" runat="server" Text="添加学生信息" />
            <asp:Button ID="btn_daochustu" class="btn_right" runat="server" Text="导出学生信息" />
            <asp:Button ID="btn_piliangstu" class="btn_right" runat="server" Text="批量编辑" />--%>
            <asp:Label ID="lb_count" runat="server" Text=""></asp:Label>
        </div>
        
        <div class="content">
            
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table style="margin-top:15px;" class="table table-striped table-hover text-center">
                        <tbody>
                            <tr class="table-bordered table-condensed info">
                              <th class="table-bordered" style="text-align:center;" >学号</th>
                              <th class="table-bordered" style="text-align:center;" >姓名</th>
                              <th class="table-bordered" style="text-align:center;" >性别</th>
                              <th class="table-bordered" style="text-align:center;" >学院编号</th>
                              <th class="table-bordered" style="text-align:center;" >专业编号</th>
                              <th class="table-bordered" style="text-align:center;" >班级</th>
                              <th class="table-bordered" style="text-align:center;" >手机号</th>
                              <th class="table-bordered" style="text-align:center;" >操作</th>
                            </tr>
                </HeaderTemplate>
                <FooterTemplate>
                   
                        </tbody>
                    </table>
                </FooterTemplate>
                <ItemTemplate>
                    <tr>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("StuId")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("StuName")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("StuSex")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("College")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("Major")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("ClassId")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <%# Eval("StuPhoneNum")%></td>
                        <td class="table-bordered" style="text-align:center;">
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#Eval("StuId","~/StudentsInfo/look_StudentInfo.aspx?StuId={0}") %>'
                runat="server" ForeColor="Blue">查看</asp:HyperLink>
                        </td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            
        </div>
       
    </div>
    </form>
</body>
</html>
