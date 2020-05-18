<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zuoye_tijiao.aspx.cs" Inherits="学生信息管理系统.homework.zuoye_tijiao" validateRequest="false"    %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="../../resource/ckeditor/ckeditor.js"></script>
    <script type="text/javascript" src="../../resource/My97DatePicker/WdatePicker.js"></script>    

    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="col-md-12  auto-style1 " style=" line-height:65px; background-color: #C8C5F5;">
           <div>
               <h1><asp:Literal ID="HwHead" runat="server"></asp:Literal></h1>         
               <h3><asp:Literal ID="HwContent" runat="server"></asp:Literal></h3>  
               <span style="margin:5px 20px;">开始时间：<asp:Literal ID="StartTime" runat="server"></asp:Literal></span>
               <span style="margin:5px 20px;">截止时间：<asp:Literal ID="EndTime" runat="server"></asp:Literal></span>                   
           </div>
         </div>

         <span class="auto-style1">你的答案：</span><br/>
      <asp:TextBox name="editor1" id="editor1" rows="10" cols="80" runat="server" Height="203px" TextMode="MultiLine" Width="1062px">
                This is my homework.
            </asp:TextBox>
            <script>
                // Replace the <textarea id="editor1"> with a CKEditor
                // instance, using default configuration.
                CKEDITOR.replace('editor1', {
                    filebrowserBrowseUrl: '/resource/ckfinder/ckfinder.html',
                    filebrowserUploadUrl: '/resource/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files'
                });
            </script>
        <br />
        <asp:Button ID="Button1" runat="server" OnClientClick="return confirm('确认提交么？提交后无法修改，请谨慎决定！')"  OnClick="Button1_Click" Text="确认提交" BackColor="#8E9CDD" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium" ForeColor="White" Height="52px" Width="93px" />
    </form>
</body>
</html>