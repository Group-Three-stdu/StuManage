<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fabu_zuoye.aspx.cs" Inherits="学生信息管理系统.homework.fabu_zuoye"  validateRequest="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <script src="../js/My97DatePicker/WdatePicker.js"></script>
    <script src="../resource/ckeditor/ckeditor.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="HwHead">
        <div class="HwTitile">
            <span>作业标题</span><asp:TextBox ID="HwHead" Width="30%" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="HwInfo">
            <span>截至日期：</span> 
            <asp:TextBox ID="EndTime" runat="server" Width="100px" onclick="WdatePicker()"></asp:TextBox>
                (请点击文本框选择日期)<asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                    runat="server" ControlToValidate="EndTime" ErrorMessage="请选择日期!" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div class="HwContent">
            <p>作业内容</p>
            <asp:TextBox name="editor1" id="editor1" rows="10" cols="80" runat="server" Height="203px" TextMode="MultiLine" Width="1062px"></asp:TextBox>
            <script>
                // Replace the <textarea id="editor1"> with a CKEditor
                // instance, using default configuration.
                CKEDITOR.replace('editor1', {
                    filebrowserBrowseUrl: '/resource/ckfinder/ckfinder.html',
                    filebrowserUploadUrl: '/resource/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files'
                });
            </script>
        </div>
        <div class="btn">
            <asp:Button ID="btn_submit" CssClass="btn btn-info" runat="server" Text="发布" OnClick="btn_submit_Click" />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
    </div>
    </div>
    </form>
</body>
</html>
