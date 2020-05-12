<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paike.aspx.cs" Inherits="学生信息管理系统.course.paike" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>教务处排课</title>
    <link rel="stylesheet" href="../css/bootstrap.min.css" />
    <style>
        .box
    {
        width:100%;
        height:600px;
        margin-top:10px;
        border:1px solid #ccc;
        }
     .input
     {
         width:20%;
         height:35px;
         padding-left:5px;
         border-radius:5px;
         border-width:none;
         margin-top:20px;
         border-width:1.5px;
         }
     .box .lable
     {
         width:10%;
         height:35px;
         color:#666;
         font-size:15px;
         margin-top:20px;
         text-align:right;
         float:left;
         line-height:35px;
         }
     .box .btn
     {
         width:8%;
         height:35px;
         border-radius:5px;
         border:none;
         color:White;
         background:#54a0ff;
         margin-top:20px;
         margin-left:10%;;
         }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="box">
            <div class="lable">课程编号：</div>
            <asp:DropDownList ID="DropDownList1" CssClass="input form-control" runat="server">
                <asp:listitem>请选择</asp:listitem>
            </asp:DropDownList>
            <br />
            <div class="lable">教师编号：</div>
            <asp:DropDownList ID="DropDownList2" CssClass="input form-control" runat="server">
                <asp:listitem>请选择</asp:listitem>
            </asp:DropDownList>
            <br />
            <div class="lable">开课学期：</div>
            <asp:DropDownList ID="DropDownList3" CssClass="input form-control" runat="server">
                <asp:listitem>请选择</asp:listitem>
            </asp:DropDownList>
            <br />
            <div class="lable">课程时间：</div>
            <asp:DropDownList ID="DropDownList4" CssClass="input form-control" runat="server">
                <asp:listitem>请选择</asp:listitem>
            </asp:DropDownList>
            <br />
            <div class="lable">上课地点：</div>
            <asp:DropDownList ID="ddl_coursexingzhi" CssClass="input form-control" runat="server">
                <asp:listitem>请选择</asp:listitem>
            </asp:DropDownList>
            <br />
            <div class="lable">平时成绩占比：</div>
            <asp:TextBox ID="TextBox1" CssClass="input form-control " runat="server"></asp:TextBox>
            <br />
            <div class="lable">期末成绩占比：</div>
            <asp:TextBox ID="TextBox2" CssClass="input form-control " runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btn_alterpass" class="btn" runat="server" Text="保存" />
        </div>
    </div>
    </form>
</body>
</html>
