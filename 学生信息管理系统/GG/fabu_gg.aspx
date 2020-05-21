<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fabu_gg.aspx.cs" Inherits="学生信息管理系统.GG.fabu_gg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="GGHead">
        <div class="GGTitile">
            <span>公告标题</span><asp:TextBox ID="GGHead" runat="server"></asp:TextBox>
        </div>
        <div class="GGContent">
            <p>公告内容</p>
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
            <asp:Button ID="btn_submit" runat="server" Text="发布" OnClick="btn_submit_Click" />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
    </div>
    </div>
    </form>
</body>
</html>
