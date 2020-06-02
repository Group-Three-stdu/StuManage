<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClassDetails.aspx.cs" Inherits="学生信息管理系统.Class.ClassDetails"  EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <script src="../js/jquery.min.js"></script>
     <link rel="stylesheet" href="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/css/bootstrap.min.css">
	<script src="https://cdn.staticfile.org/jquery/2.1.1/jquery.min.js"></script>
	<script src="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <title></title>
    <style>
        .btn{
            width:10%;
            height:24px;
            padding-top:2px;
        }
    </style>
</head>
<body>
    <script type="text/javascript">
        function StuInfo() {
            document.getElementById('StuInfo').style.display = "block";
            document.getElementById('CourseInfo').style.display = "none";
        }
        function CourseInfo() {
            document.getElementById('StuInfo').style.display = "none";
            document.getElementById('CourseInfo').style.display = "block";
        }

    </script>
    <script type="text/javascript">
            $(function(){
                $('.modleDailog').modal("hide");
            });
            function values(ID){
                $('#ggcontent').html(ID);
            }
        </script>
    <div id="Classinfo">
        <h3><asp:Literal ID="classid" runat="server"></asp:Literal>班</h3>
    </div>
        <div class="box" >
            <button id="Button1" class="btn btn-warning"  onclick="StuInfo()" >查看学生信息</button>
            <button id="Button2" class="btn btn-warning"  onclick="CourseInfo()" >查看学习情况</button>
        </div>
    <hr />
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" enablepartialrendering="true"></asp:ScriptManager>
        <div id="StuInfo" >
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="True">
            <ContentTemplate>
             <div class="top">          
                姓名：<asp:TextBox ID="txt_name" runat="server" class="input"></asp:TextBox>
                <asp:Button ID="btn_searchstu" runat="server" class="btn" Text="查询" OnClick="btn_searchstu_Click" />
                学号：<asp:TextBox ID="txt_StuId" runat="server" class="input"></asp:TextBox>
                <asp:Button ID="btn_SearchStuId" runat="server" class="btn" Text="查询" Onclick ="btn_SearchStuId_Click"/>
                 <asp:Button ID="ToExcel" runat="server" Text="导出到excel" OnClick="ToExcel_Click"  />
            </div>
             <div>
              <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center col-8" style="width:90%">
                        <tr class="table-bordered table-condensed info text-center"  >
                             <th style="text-align:center">学号</th>
                            <th style="text-align:center">姓名</th>
                            <th style="text-align:center">班级</th>
                            <th style="text-align:center">联系方式</th>
                            <th style="text-align:center">挂科数目</th>
                            <th style="text-align:center">优秀科目数</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                             <td><%# Eval("StuId")%></td>
                             <td><%# Eval("StuName")%></td>
                             <td><%# Eval("ClassId")%></td>
                             <td><%# Eval("StuPhoneNum")%></td>
                             <td><%# Eval("GKNum")%></td>
                             <td><%# Eval("YXNum")%></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
                </div>
                </ContentTemplate>
        </asp:UpdatePanel>
         </div>
        <div id ="CourseInfo" style="display:none;">
            <asp:DataList ID="DataList2" runat="server" RepeatColumns="4">
            <ItemTemplate>
                <div style="box-shadow:2px 2px 1px rgba(128, 128, 128,0.5);width:300px;height:182px;background-color:#F4F4F4;margin:5px;" >
                    <h1><span style=""><%# Eval("CourseName")%></span></h1>
                    <div style="background-color:#FFF5EE; height:130px;text-align:right; ">
                        <div style="margin-right:20px; margin-top:10px;">
                            <div style:"width:80px">教师：<%# Eval("TeaName")%></div> 
                            <div style:"width:80px">学院：<%# Eval("CollegeName")%></div>
                            <div style:"width:80px">学期：<%# Eval("Season")%></div>
                        </div>             
                    <div class="style2" style="height: 51px;  ">
                        <asp:Button ID="Button2" runat="server"  Font-Size="Medium" Height="32px" style="text-align: center;background-color:#ff9966;" Text="详情" Width="82px" BorderStyle="None" 
                                CommandArgument='<%# Eval("CourseId")%>' OnClick="Button2_Click"  />
                    </div>   
                </div> 
            </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>