﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseDetails.aspx.cs" Inherits="学生信息管理系统.homework.CourseDetails" EnableEventValidation="false" %>

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
        function GG() {
            document.getElementById('GG').style.display = "block";
            document.getElementById('StuInfo').style.display = "none";
            document.getElementById('HwInfo').style.display = "none";
            document.getElementById('KqInfo').style.display = "none";
        }
        function StuInfo() {
            document.getElementById('GG').style.display = "none";
            document.getElementById('StuInfo').style.display = "block";
            document.getElementById('HwInfo').style.display = "none";
            document.getElementById('KqInfo').style.display = "none";
        }
        function HwInfo() {
            document.getElementById('GG').style.display = "none";
            document.getElementById('StuInfo').style.display = "none";
            document.getElementById('HwInfo').style.display = "block";
            document.getElementById('KqInfo').style.display = "none";
        }
        function KqInfo() {
            document.getElementById('GG').style.display = "none";
            document.getElementById('StuInfo').style.display = "none";
            document.getElementById('HwInfo').style.display = "none";
            document.getElementById('KqInfo').style.display = "block";
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
    <div id="courseinfo">
        <h3><asp:Literal ID="coursename" runat="server"></asp:Literal></h3>
    </div>
        <div class="box" >
            <button id="Button0" class="btn btn-info"  onclick="GG()" >课程公告</button>
            <button id="Button1" class="btn btn-info"  onclick="StuInfo()" >查看学生信息</button>
            <button id="Button2" class="btn btn-info"  onclick="HwInfo()" >查看作业情况</button>
            <button id="Button3" class="btn btn-info"  onclick="KqInfo()" >查看考勤情况</button>
        </div>
    <hr />
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" enablepartialrendering="true"></asp:ScriptManager>
        <div id="GG">
            <div>
                <asp:Button ID="fabu_GG" CssClass="btn btn-info" runat="server" Text="发布公告" OnClick="fabu_GG_Click" />
            </div>
             <div>
              <asp:Repeater ID="Repeater3" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center col-8" style="width:90%;margin-left:0px;">
                        <tr class="table-bordered table-condensed info text-center"  >
                             <th style="text-align:center">序号</th>
                            <th style="text-align:center">标题</th>
                            <th style="text-align:center">发布人</th>
                            <th style="text-align:center">发布时间</th>
                            <th style="text-align:center">详情</th>
                            <th style="text-align:center">操作</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                             <td><%# Eval("xh")%></td>
                             <td><%# Eval("GGHead")%></td>
                             <td><%# Eval("TeaName")%></td>
                            <td><%# Eval("Time")%></td>
                            <td><asp:LinkButton ID="LinkButton1" CommandName="past" CommandArgument='<%# Eval("GGContent")%>' data-toggle="modal" data-target="#exampleModal" runat="server" 
                                OnClientClick='<%#Eval("GGContent", "values(\"{0}\")")%>' >查看详情</asp:LinkButton></td>
                             <td><asp:LinkButton ID="btnDel" CommandArgument='<%#Eval("Id")%>' OnClientClick="return confirm('确认删除该记录么？')"  OnClick="btnDel_Click"
                runat="server">删除公告</asp:LinkButton></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
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

        </div>
        <div id="StuInfo" style="display:none;" >
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="True">
            <ContentTemplate>
             <div class="top">          
                班级：<asp:DropDownList ID="ddlclass" class="select" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlclass_SelectedIndexChanged" >
                            <asp:ListItem>请选择</asp:ListItem>
                        </asp:DropDownList>
                姓名：<asp:TextBox ID="txt_name" runat="server" class="input"></asp:TextBox>
                <asp:Button ID="btn_searchstu" runat="server" class="btn" Text="查询" OnClick="btn_searchstu_Click" />
                学号：<asp:TextBox ID="txt_StuId" runat="server" class="input"></asp:TextBox>
                <asp:Button ID="btn_SearchStuId" runat="server" class="btn" Text="查询" OnClick="btn_searchStuId_Click" />
                 <asp:Button ID="ToExcel" runat="server" Text="导出到excel" OnClick="ToExcel_Click" />
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
                            <th style="text-align:center">作业情况</th>
                            <th style="text-align:center">考勤情况</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                             <td><%# Eval("StuId")%></td>
                             <td><%# Eval("StuName")%></td>
                             <td><%# Eval("ClassId")%></td>
                             <td><%# Eval("StuPhoneNum")%></td>
                             <td>已提交：<%# Eval("HwNum")%></td>
                             <td>已提交：<%# Eval("KqNum")%></td>
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
        <div id ="HwInfo" style="display:none;">
            <asp:Button ID="btn_fabu_zuoye" CssClass="btn btn-info" runat="server" Text="发布作业" OnClick="btn_fabu_zuoye_Click" /><br />
            <asp:DataList ID="DataList2" runat="server" RepeatColumns="4">
            <ItemTemplate>
                <div style="box-shadow:2px 2px 1px rgba(128, 128, 128,0.5);width:300px;height:182px;background-color:#F4F4F4;margin:5px;" >
                    <h1><span style=""> <%# Eval("HwHead")%></span></h1>
                    <div style="background-color:#FFF5EE; height:130px;text-align:right; ">
                        <div style="margin-right:20px; margin-top:10px;">
                            <div style:"width:80px">开始时间： <%# Eval("StartTime")%></div> 
                            <div style:"width:80px">截止时间： <%# Eval("EndTime")%></div>
                            <div style:"width:80px">应交人数： <%=StuNum%></div> 
                            <div style:"width:80px">实交人数： <%# Eval("FinishNum")%></div>
                        </div>             
                    <div class="style2" style="height: 51px;  ">
                        <asp:Button ID="Button2" runat="server"  Font-Size="Medium" Height="32px" style="text-align: center;background-color:#3cf;" Text="作业详情" Width="82px" BorderStyle="None" 
                                CommandArgument='<%# Eval("HwId")%>' OnClick="Button2_Click"  />
                    </div>   
                </div> 
            </ItemTemplate>
            </asp:DataList>
        </div>
        <div id ="KqInfo" style="display:none;">
             <div class="top">          
               <%--  班级：<asp:DropDownList ID="DropDownList1" class="select" runat="server" >
                <asp:ListItem>请选择</asp:ListItem>
                </asp:DropDownList>
                姓名：<asp:TextBox ID="TextBox1" runat="server" class="input"></asp:TextBox>
                <asp:Button ID="Button4" runat="server" class="btn" Text="查询"  />
                学号：<asp:TextBox ID="TextBox2" runat="server" class="input"></asp:TextBox>
                <asp:Button ID="Button5" runat="server" class="btn" Text="查询" />--%>
            <asp:Button ID="fabu_qiandao" runat="server" CssClass="btn btn-info" Text="发布签到" OnClick="fabu_qiandao_click" />
        </div>
        <div class="content">
            <asp:Repeater ID="Repeater2" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center col-8" style="width:100%">
                        <tr class="table-bordered table-condensed info text-center"  >
                            <th style="text-align:center">序号</th>
                            <th style="text-align:center">开始时间</th>
                            <th style="text-align:center">结束时间</th>
                            <th style="text-align:center">签到人数</th>
                            <th style="text-align:center">操作</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                            <td><%# Eval("KQXh")%></td>
                            <td><%# Eval("KqTime")%></td>
                            <td><%# Eval("EndTime")%></td>
                            <td><%# Eval("StuNum")%></td>
                             <td><asp:LinkButton ID="btnDel" CommandArgument='<%#Eval("KQId")%>'  OnClick="btnDetail_Click"
                runat="server">详情</asp:LinkButton></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            </div>
        </div>
    </form>
</body>
</html>
