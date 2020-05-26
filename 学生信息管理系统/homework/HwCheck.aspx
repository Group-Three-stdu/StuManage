<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HwCheck.aspx.cs" Inherits="学生信息管理系统.homework.HwCheck"  validateRequest="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="../../resource/ckeditor/ckeditor.js"></script>
    <script type="text/javascript" src="../../resource/My97DatePicker/WdatePicker.js"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class =" title" >
        <h3>题目：</h3>
        <div style="border :1px solid black; width:90%;padding:5px">
            <asp:Label ID="HwContent" runat="server" ></asp:Label>
        </div>
    </div>
    <div class="ans">
        <h3>学生答案：</h3>
        <div style="border:1px solid black; width:90%;padding:5px;">
            <asp:Label ID="answer" runat="server" ></asp:Label>
        </div>
    </div>
    <div class="Comment">
         <h3>教师评语：</h3>
        <asp:TextBox name="editor1" id="editor1" rows="10" cols="80" runat="server" Height="203px" TextMode="MultiLine" Width="90%">
            </asp:TextBox>
            <script>
                // Replace the <textarea id="editor1"> with a CKEditor
                // instance, using default configuration.
                CKEDITOR.replace('editor1', {
                    filebrowserBrowseUrl: '/resource/ckfinder/ckfinder.html',
                    filebrowserUploadUrl: '/resource/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files'
                });
            </script>
    </div>
     <div class="Score">
         分数：<asp:TextBox ID="Score" runat="server"></asp:TextBox>
     </div>
    <div>
        <asp:Button ID="btn_submit" runat="server" Text="确定" OnClick="btn_submit_Click" />
    </div>
    </div>
    </form>
</body>
</html>
