<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zuoye_chakan.aspx.cs" Inherits="学生信息管理系统.homework.zuoye_chakan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="../css/bootstrap.css" />
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <style type="text/css">
        
        .style1 {
            font-family: 华文宋体;
            text-align: left;
            float: left;
            border-width: 3px;
            border:2px solid #A3C2E2;
            padding: 2px;
            margin-left: 5%;
            margin-top:30px;
            height: 155px;
            width: 90%;
        }
        .style2 {
            background-color: #A3C2E2;
            width:100%;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">        
    <div>               
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" style="margin-right: 546px" Width="1175px">
            <ItemTemplate>
                <div class="style1">
                    <a runat="server" href="~/homework/zuoye_tijiao.aspx">
                    作业（一）<br />
                    
                    <span>开始时间：</span><span style:"width=80px"> <%# Eval("StuId")%></span>
                    <br />
                    <span>截止时间：</span><span style:"width=80px"> <%# Eval("StuId")%></span>                    
                    <br />
                    <span>批阅状态：</span><span style:"width=80px"> <%# Eval("StuId")%></span>                    
                    <br />
            <br />                    

            <div class="style2" style="height: 51px; ">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Button ID="Button2" runat="server" Font-Bold="False" Font-Names="苹方 中等" Font-Size="Medium" ForeColor="White" Height="38px" style="text-align: right" Text="编辑" Width="82px" BackColor="#E1B1F8" BorderStyle="None" />
                </div>   

        </div> 
                </ItemTemplate>

        </asp:DataList>
        
    </div>     
    </form>
</body>
</html>
