<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StuCourseDeatils.aspx.cs" Inherits="学生信息管理系统.homework.StuCourseDeatils" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="../css/bootstrap.css" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <link rel="stylesheet" href="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/css/bootstrap.min.css"/>
	<script src="https://cdn.staticfile.org/jquery/2.1.1/jquery.min.js"></script>
	<script src="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/js/bootstrap.min.js"></script>
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
            margin-top:20px;
        }
         .btn{
            width:10%;
            height:24px;
            padding-top:2px;
        }
         .button{
             height:30px;
             margin-top:10px;
             margin-right:1%;
         }
    </style>
    <script type="text/javascript">
            $(function(){
                $('.modleDailog').modal("hide");
            });
            function values(ID){
                $('#ggcontent').html(ID);
            }
        </script>
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
        function unfinished() {
            document.getElementById('unfinished').style.display = "block";
            document.getElementById('finished').style.display = "none";
            document.getElementById('checked').style.display = "none";
        }
         function finished() {
            document.getElementById('unfinished').style.display = "none";
            document.getElementById('finished').style.display = "block";
            document.getElementById('checked').style.display = "none";
        }
        function checked() {
            document.getElementById('unfinished').style.display = "none";
            document.getElementById('finished').style.display = "none";
            document.getElementById('checked').style.display = "block";
        }
    </script>
    
        <div class="box" >
            <button id="Button1" class="btn btn-info"  onclick="GG()" >课程公告</button>
            <button id="Button2" class="btn btn-info"  onclick="HwInfo()" >查看作业信息</button>
            <button id="Button3" class="btn btn-info"  onclick="KqInfo()" >查看考勤信息</button>
        </div>
    <hr />
    <form id="form1" runat="server">       
        <div id="GG">
             <div>
              <asp:Repeater ID="Repeater3" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center col-8" style="width:100%">
                        <tr class="table-bordered table-condensed info text-center"  >
                             <th style="text-align:center">序号</th>
                            <th style="text-align:center">标题</th>
                            <th style="text-align:center">发布人</th>
                            <th style="text-align:center">发布时间</th>
                            <th style="text-align:center">详情</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                             <td><%# Eval("Id")%></td>
                             <td><%# Eval("GGHead")%></td>
                             <td><%# Eval("TeaName")%></td>
                            <td><%# Eval("Time")%></td>
                            <td><asp:LinkButton ID="LinkButton1" CommandName="past" CommandArgument='<%# Eval("GGContent")%>' data-toggle="modal" data-target="#exampleModal" runat="server" OnClientClick='<%#Eval("GGContent", "values(\"{0}\")")%>' >查看详情</asp:LinkButton></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
                </div>
        </div>
              <%--模态框--%>
        <div class="modal fade modleDailog" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
           <div class="modal-dialog" role="document">
              <div class="modal-content">
                <div class="modal-header">
                  <h4 class="modal-title" style="display:inline-block;" id="exampleModalLabel">公告详情</h4>
                  <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                  </button>
                </div>
                <div class="modal-body">
                    <p id="ggcontent" style="text-indent:2em;font-size:16px;">

                    </p>    
                </div>
                <div class="modal-footer">
                    <asp:Button ID="Button4" class="btn btn-secondary" data-dismiss="modal" runat="server" Text="关闭" />
                </div>
              </div>
            </div>
        </div>

        <div  id="HwInfo" style="display:none;">       
             <div class="box" >
                <button type="button"  class="btn btn-info"  onclick="unfinished()" >查看未完成作业</button>
                <button type="button" class="btn btn-info"  onclick="finished()" >查看已完成作业</button>
                <button type="button" class="btn btn-info"  onclick="checked()" >查看已批阅作业</button>
            </div>          
            <div id="unfinished" >
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="4">
                <ItemTemplate>
                    <div style="box-shadow:2px 2px 1px rgba(128, 128, 128,0.5);width:300px;height:180px;background-color:#F4F4F4;margin:5px" >
                        <h1><span style=""> <%# Eval("HwHead")%></span></h1>
                        <div style="background-color:#FFF5EE; height:130px;text-align:right; ">
                            <div style="margin-right:20px; margin-top:10px;">
                                <div style:"width:80px">开始时间： <%# Eval("StartTime")%></div> 
                                <div style:"width:80px">截止时间： <%# Eval("EndTime")%></div>                 
                            </div>             
                            <br />                    
                            <div class="style2" style="height: 50px; margin-bottom:0; ">
                                <asp:Button ID="Button2" runat="server"  Font-Size="Medium" Height="32px" style="text-align: center;background-color:#3cf;" Text="查看" Width="82px" BorderStyle="None" 
                                    CommandArgument='<%#Eval("HwId")%>' OnClick="Button2_Click"  />
                            </div>   
                        </div> 
                    </div>
                    </ItemTemplate>
            </asp:DataList>
            </div>
             <div id="finished" style="display:none;">     
                    <asp:DataList ID="DataList3" runat="server" RepeatColumns="4">
                        <ItemTemplate>
                            <div style="box-shadow:2px 2px 1px rgba(128, 128, 128,0.5);width:300px;height:180px;background-color:#F4F4F4;margin:5px" >
                                <h1><span style=""> <%# Eval("HwHead")%></span></h1>
                                <div style="background-color:#FFF5EE; height:130px;text-align:right; ">
                                    <div style="margin-right:20px; margin-top:10px;">
                                        <div style:"width:80px">开始时间： <%# Eval("StartTime")%></div> 
                                        <div style:"width:80px">截止时间： <%# Eval("EndTime")%></div>                 
                                    </div>             
                                    <br />                    
                                    <div class="style2" style="height: 50px; margin-bottom:0; ">
                                        <asp:Button ID="finished" runat="server"  Font-Size="Medium" Height="32px" style="text-align: center;background-color:#3cf;" Text="查看" Width="82px" BorderStyle="None" 
                                            CommandArgument='<%#Eval("HwId")%>' OnClick="finished_Click"  />
                                    </div>   
                                </div> 
                            </div>
                        </ItemTemplate>
            </asp:DataList>
                </div>    
            <div id="checked" style="display:none;">
                <asp:DataList ID="DataList4" runat="server" RepeatColumns="4">
                        <ItemTemplate>
                            <div style="box-shadow:2px 2px 1px rgba(128, 128, 128,0.5);width:300px;height:180px;background-color:#F4F4F4;margin:5px" >
                                <h1><span style=""> <%# Eval("HwHead")%></span></h1>
                                <div style="background-color:#FFF5EE; height:130px;text-align:right; ">
                                    <div style="margin-right:20px; margin-top:10px;">
                                        <div style:"width:80px">开始时间： <%# Eval("StartTime")%></div> 
                                        <div style:"width:80px">截止时间： <%# Eval("EndTime")%></div>                 
                                    </div>             
                                    <br />                    
                                    <div class="style2" style="height: 50px; margin-bottom:0; ">
                                        <asp:Button ID="check" runat="server"  Font-Size="Medium" Height="32px" style="text-align: center;background-color:#3cf;" Text="查看" Width="82px" BorderStyle="None" 
                                            CommandArgument='<%#Eval("HwId")%>' OnClick="check_Click"  />
                                    </div>   
                                </div> 
                            </div>
                        </ItemTemplate>
            </asp:DataList>
            </div>
        </div>     
        <div  id="KqInfo"  style="display:none;">               
       <asp:DataList ID="DataList2" runat="server" RepeatColumns="4">
            <ItemTemplate>
                <div style="box-shadow:2px 2px 1px rgba(128, 128, 128,0.5);width:300px;height:180px;background-color:#F4F4F4;margin-left:10px;" >
                    
                    <h1><span style=""> <%# Eval("KQXh")%></span></h1>
                    <div style="background-color:#FFF5EE; height:130px;text-align:right; ">
                        <div style="margin-right:20px; margin-top:10px; ">
                            <div style:"width:80px">开始时间： <%# Eval("KqTime")%></div> 
                            <div style:"width:80px">截止时间： <%# Eval("EndTime")%></div>
                            <div style:"width:80px">签到状态： <asp:Label ID="Label1" ForeColor="Red" runat="server" Text="未签到"></asp:Label></div>                 
                        </div>             
                                           
                        <div class="style2" style="height: 50px;  ">
                            <asp:Button ID="Button2" runat="server" CssClass="button btn btn-info" Font-Size="Medium" Text="签到" Width="82px" BorderStyle="None" 
                                CommandArgument='<%#Eval("KQId")%>' OnClick="Button3_Click"  />
                        </div>   
                    </div> 
                 </div>
                </ItemTemplate>
        </asp:DataList>
    </div>      
    </form>
</body>
</html>
