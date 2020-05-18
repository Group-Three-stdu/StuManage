<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StuCourseDeatils.aspx.cs" Inherits="学生信息管理系统.homework.StuCourseDeatils" EnableEventValidation="false" %>

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
    <script type="text/javascript">
        function GG() {
            document.getElementById('GG').style.display = "block";
            document.getElementById('HwInfo').style.display = "none";
            document.getElementById('KqInfo').style.display = "none";
        }
        function HwInfo() {
            document.getElementById('GG').style.display = "none";
            document.getElementById('HwInfo').style.display = "block";
            document.getElementById('KqInfo').style.display = "none";
        }
        function KqInfo() {
            document.getElementById('GG').style.display = "none";
            document.getElementById('HwInfo').style.display = "none";
            document.getElementById('KqInfo').style.display = "block";
        }
    </script>
    
        <div class="box" >
            <button id="Button1"  onclick="GG()" >课程公告</button>
            <button id="Button2"  onclick="HwInfo()" >查看作业信息</button>
            <button id="Button3"  onclick="KqInfo()" >查看考勤信息</button>
        </div>
    <hr />
    <form id="form1" runat="server">       
        <div id="GG" style="display:none;">课程公告</div>
        <div  id="HwInfo" style="display:none;">               
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
                    <asp:Button ID="Button2" runat="server"  Font-Size="Medium" Height="32px" style="text-align: center;background-color:#3cf;" Text="查看" Width="82px" BorderStyle="None" 
                        CommandArgument='<%#Eval("HwId")%>' OnClick="Button2_Click"  />
                </div>   
            </div> 
                    </ItemTemplate>
            </asp:DataList>
        </div>     
        <div  id="KqInfo"  style="display:none;">               
       <asp:DataList ID="DataList2" runat="server" RepeatColumns="3">
            <ItemTemplate>
                <div style="box-shadow:2px 2px 1px rgba(128, 128, 128,0.5);width:300px;height:182px;background-color:#F4F4F4" >
                    
                    <h1><span style=""> <%# Eval("KQXh")%></span></h1>
                    <div style="background-color:#FFF5EE; height:130px;text-align:right; ">
                        <div style="margin-right:20px; margin-top:10px; ">
                            <div style:"width:80px">开始时间： <%# Eval("KqTime")%></div> 
                            <div style:"width:80px">截止时间： <%# Eval("EndTime")%>  
                            <div style:"width:80px">签到状态：<span style="color:red;">未签到</span>                  
                        </div>
                    </div>             
            <br />                    

            <div class="style2" style="height: 51px;  ">
                <asp:Button ID="Button2" runat="server"  Font-Size="Medium" Height="32px" style="text-align: center;background-color:#3cf;" Text="签到" Width="82px" BorderStyle="None" 
                    CommandArgument='<%#Eval("KQId")%>' OnClick="Button3_Click"  />
            </div>   
        </div> 
                </ItemTemplate>
        </asp:DataList>
    </div>      
    </form>
</body>
</html>
