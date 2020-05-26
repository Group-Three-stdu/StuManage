<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tea_look_score.aspx.cs" Inherits="学生信息管理系统.Score.Tea_look_score1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
            <ItemTemplate>
                <div style="box-shadow:2px 2px 1px rgba(128, 128, 128,0.5);width:300px;height:182px;background-color:#F4F4F4; margin: 10px 30px" >
                    
                    <h1><span style=""> <%# Eval("CourseName")%></span></h1>
                    <div style="background-color:#FFF5EE; height:50px;text-align:right; ">
                        <div style="margin-right:20px; margin-top:10px;">
                            <div style:"width:80px"> <%# Eval("courseproperty")%></div> 
                            <div style:"width:80px"> <%# Eval("Time")%></div>                  
                           
                        </div>
                    </div>             
            <br />                    

            <div class="style2" style="height: 51px" >
                <asp:Button ID="Button2" runat="server"  Font-Size="Medium" Height="32px" style="text-align: center;background-color:#3cf;" Text="查看详情" Width="82px" BorderStyle="None" 
                    CommandArgument='<%#Eval("CourseId")%>' OnClick="Button2_Click"  />
                
            </div>   
        </div> 
                </ItemTemplate>
        </asp:DataList>
    
    </div>
    </form>
</body>
</html>
