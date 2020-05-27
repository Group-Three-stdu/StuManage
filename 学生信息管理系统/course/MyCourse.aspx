<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyCourse.aspx.cs" Inherits="学生信息管理系统.course.MyCourse" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
         .style2 {
            background-color: #A3C2E2;
            width:100%;
        }
         .button{
             float:right;
             height:30px;
             margin-right:1%;
             margin-top:10px;
             color:white;
         }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="4">
            <ItemTemplate>
                <div style="box-shadow:2px 2px 1px rgba(128, 128, 128,0.5);width:300px;height:192px;background-color:#F4F4F4;margin-left:10px;" >
                    <h1><span style=""> <%# Eval("CourseName")%></span></h1>
                    <div style="background-color:#FFF5EE; height:80px;text-align:right; ">
                        <div style="margin-right:20px; margin-top:10px;">
                            <div style:"width:80px">课程性质： <%# Eval("courseproperty")%></div> 
                            <div style:"width:80px">学期： <%# Eval("Season")%></div>                  
                            <div style:"width:80px;text-align:right;">任课教师： <%# Eval("TeaName")%></div>      
                        </div>
                    </div>             
                     <div class="style2" style="height: 50px;width:100%;">
                        <asp:Button ID="Button2" CssClass="button" runat="server"  Font-Size="Medium" Height="32px" style="text-align: center;background-color:#3cf;" Text="查看" Width="82px" BorderStyle="None" 
                            CommandArgument='<%#Eval("CourseId")%>' OnClick="Button2_Click"  />
                    </div>             
                </div> 
                </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
