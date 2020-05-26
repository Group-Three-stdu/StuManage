<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lookcheckedHw.aspx.cs" Inherits="学生信息管理系统.homework.lookcheckedHw" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
            <h3>你的答案：</h3>
            <div style="border:1px solid black; width:90%;padding:5px;">
                <asp:Label ID="answer" runat="server" ></asp:Label>
            </div>
        </div>
        <div id ="tearesist">
            <h3>教师评语：</h3>
            <div style="border :1px solid black; width:90%;padding:5px">
                <asp:Label ID="TeaResist" runat="server" ></asp:Label>
            </div>
        </div>
        <div id ="score">
            <h3>分数：</h3>
            <div style="border :1px solid black; width:90%;padding:5px">
                <asp:Label ID="Score" runat="server" ></asp:Label>
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="返回" OnClick="Button1_Click" style="height: 21px" />
    </div>
    </form>
</body>
</html>
