<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alter_stuperinfo.aspx.cs" Inherits="学生信息管理系统.StudentsInfo.alter_stuperinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>学生查看个人信息</title>
    <style>
        .box {
            margin:0 auto;
            width:100%;
            height:450px;
            border:1px solid #ccc;
        }
        table{
            width:100%;
            border:1px solid #ccc;
            height:100%;
            font-size:15px;
        }
        tr{
            width:100%;
            height:40px;
            border:1px solid #ccc;
        }
        th{
            text-align:center;
            border:1px solid #ccc;
        }
        td{
            text-align:left;
            border:1px solid #ccc;
        }
        .earn{
            width:100%;
            height:50px;
            margin:0 auto;
            background-color:#f5f5f5;
            color:#666;
            line-height:50px;
            border:1px solid yellow;
        }
        .btn{
            margin-left:1%;
        }
        .btn .lbbtn{
            width:10%;
            height:50px;
            margin-left:1%;
            line-height:50px;
        }
        .input{
            height:30px;
            color:#666;
            width:98%;
            font-size:15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="earn">
            以下为您的个人信息请核实，如有不正确进行修改
            <a runat="server" target="right" href="alter_stuperinfo.aspx">立即修改</a>
            <%--<asp:LinkButton ID="LinkButton1" runat="server">立即联系</asp:LinkButton>--%>
        </div>
        <div class="box">
            <table>
                <tr>
                    <th colspan="5">XX大学学籍信息表</th>
                    
                </tr>
                <tr>
                    <th width="15%">学号</th><td width="25%">
                        <asp:TextBox ID="txt_stuid" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="True"></asp:TextBox></td>
                    <th width="15%">姓名</th><td width="25%">
                        <asp:TextBox ID="txt_stuname" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="True"></asp:TextBox>
                                           </td>
                    <th rowspan="3" colspan="2">照片</th>
                </tr>
                <tr>
                    <th>性别</th><td><asp:TextBox ID="txt_sex" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="True"></asp:TextBox></td>
                    <th>出生日期</th><td>
                        <asp:TextBox ID="txt_birth" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="True"></asp:TextBox>
                                 </td>
                </tr>
                <tr>
                    <th>身份证号</th><td>
                        <asp:TextBox ID="txt_noid" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="True"></asp:TextBox>
                                 </td>
                    <th>联系电话</th><td>
                        <asp:TextBox ID="txt_phone" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="false"></asp:TextBox>
                                 </td>
                </tr>
                <tr>
                    <th>家庭住址</th><td>
                        <asp:TextBox ID="txt_address" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="false"></asp:TextBox>
                                 </td>
                    <th>学院</th><td colspan="2">
                        <asp:TextBox ID="txt_xueyuan" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="True"></asp:TextBox>
                               </td>
                </tr>
                <tr>
                    <th>专业</th><td>
                        <asp:TextBox ID="txt_major" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="True"></asp:TextBox>
                               </td>
                    <th>班级</th><td colspan="2">
                        <asp:TextBox ID="txt_class" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="True"></asp:TextBox>
                               </td>
                </tr>
                <tr>
                    <th>政治面貌</th><td>
                        <asp:TextBox ID="txt_mianmao" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="false"></asp:TextBox>
                                 </td>
                    <th>状态</th><td colspan="2">
                        <asp:TextBox ID="txt_zhuangtai" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="true"></asp:TextBox>
                               </td>
                </tr>
                <tr>
                    <th>荣誉</th><td colspan="4">
                        <asp:TextBox ID="txt_honor" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="True"></asp:TextBox>
                               </td>
                </tr>
                <tr>
                    <th>惩处</th><td colspan="4">
                        <asp:TextBox ID="txt_punish" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="True"></asp:TextBox>
                               </td>
                </tr>
                <tr>
                    <th>备注</th><td colspan="4">
                        <asp:TextBox ID="txt_ps" runat="server" CssClass="input" Text="" BorderWidth="0" ReadOnly="True"></asp:TextBox>
                               </td>
                </tr>
            </table>
        </div>
        <div class="btn">
            <asp:LinkButton ID="LinkButton2" CssClass="lbbtn" runat="server" OnClick="LinkButton2_Click">保存</asp:LinkButton>
        </div>
    </div>
    </form>
</body>
</html>
