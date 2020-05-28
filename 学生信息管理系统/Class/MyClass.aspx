<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyClass.aspx.cs" Inherits="学生信息管理系统.Score.fudaoyuan_Score" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>辅导员查询学生成绩</title>
   <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div>
           <asp:DataList ID="DataList1" runat="server" RepeatColumns="4">
            <ItemTemplate>
                <div style="box-shadow:2px 2px 1px rgba(128, 128, 128,0.5);width:280px;height:182px;background-color:#F4F4F4; margin: 10px 10px" >
                    
                    <h1><span style=""> <%# Eval("ClassId")%></span></h1>
                    <div style="background-color:#FFF5EE; height:50px;text-align:right; ">
                        <div style="margin-right:20px; margin-top:10px;">
                            <div style:"width:80px"><%# Eval("MajorName")%></div>     
                            <div style:"width:80px"><%# Eval("CollegeName")%></div>  
                            <div style:"width:80px"> 班级人数：</div>                
                        </div>
                    </div>             
            <br />                    
            <div class="style2" style="height: 51px;  ">
                <asp:Button ID="Button2" runat="server"  Font-Size="Medium" Height="32px" style="text-align: center;background-color:#ff9966;" Text="查看详情" Width="82px" BorderStyle="None" 
                    CommandArgument='<%#Eval("ClassId")%>' OnClick="Button2_Click"  />
                
            </div>   
        </div> 
                </ItemTemplate>
        </asp:DataList>
       </div>
        </form>
</body>
</html>
