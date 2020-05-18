﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeaLookHw.aspx.cs" Inherits="学生信息管理系统.homework.TeaLookHw" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="../css/bootstrap.css" />
    <script type="text/javascript" src="js/bootstrap.js"></script>
</head>
<body>
     <form id="form1" runat="server">        
    <div>               
       <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
            <ItemTemplate>
                <div style="box-shadow:2px 2px 1px rgba(128, 128, 128,0.5);width:300px;height:182px;background-color:#F4F4F4" >
                    
                    <h1><span style=""> <%# Eval("HwHead")%></span></h1>
                    <div style="background-color:#FFF5EE; height:130px;text-align:right; ">
                        <div style="margin-right:20px; margin-top:10px;">
                            <div style:"width:80px">开始时间： <%# Eval("StartTime")%></div> 
                            <div style:"width:80px">截止时间： <%# Eval("EndTime")%>                  
                               
                        </div>
                    </div>             
            <br />                    

            <div class="style2" style="height: 51px;  ">
                <asp:Button ID="Button2" runat="server"  Font-Size="Medium" Height="32px" style="text-align: center;background-color:#3cf;" Text="查看详情" Width="82px" BorderStyle="None" 
                    CommandArgument='<%#Eval("HwId")%>' OnClick="Button2_Click"  />
            </div>   
        </div> 
                </ItemTemplate>
        </asp:DataList>
        
    </div>     
    </form>
</body>
</html>
