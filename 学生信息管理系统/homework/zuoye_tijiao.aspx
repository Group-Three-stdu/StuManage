<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zuoye_tijiao.aspx.cs" Inherits="学生信息管理系统.homework.zuoye_tijiao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="../../resource/ckeditor/ckeditor.js"></script>
    <script type="text/javascript" src="../../resource/My97DatePicker/WdatePicker.js"></script>    
    <script type="text/javascript" src="ckfinder/ckfinder.js"></script>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="col-md-12  auto-style1  "style="text-align:center; line-height:65px; background-color: #C8C5F5;">
             <span class="auto-style1">选择课程</span>：<asp:DropDownList ID="DropDownList1" runat="server" Height="32px">
            <asp:ListItem>机械设计</asp:ListItem>
            <asp:ListItem>古典诗文名篇选读</asp:ListItem>
            <asp:ListItem>数据库原理</asp:ListItem>
        </asp:DropDownList>
        
             选择未提交作业<span class="auto-style2">：</span><asp:DropDownList ID="DropDownList2" runat="server" Height="31px">
                 <asp:ListItem>作业一</asp:ListItem>
                 <asp:ListItem>作业二</asp:ListItem>
                 <asp:ListItem>作业三</asp:ListItem>
                 <asp:ListItem>作业四</asp:ListItem>
             </asp:DropDownList>
        
        提交日期：<asp:TextBox ID="TextBox2" runat="server" Width="282px" OnClick="WdatePicker()" Height="27px"></asp:TextBox>
             </div>   
             <br>
             </br>
      
         <span class="auto-style1">作业内容：</span><br/>
      <textarea name="editor1" id="editor1" rows="10" cols="80" runat="server">
                This is my homework.
            </textarea>
            <script>
                // Replace the <textarea id="editor1"> with a CKEditor
                // instance, using default configuration.
                CKEDITOR.replace('editor1', {
                    filebrowserBrowseUrl: '/resource/ckfinder/ckfinder.html',
                    filebrowserUploadUrl: '/resource/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files'
                });
            </script>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确认提交" BackColor="#8E9CDD" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium" ForeColor="White" Height="52px" Width="93px" />
    </form>
</body>
</html>