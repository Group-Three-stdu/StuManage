<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseDetails.aspx.cs" Inherits="学生信息管理系统.homework.CourseDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
    
        <div class="box" >
            <button id="Button0"  onclick="GG()" >课程公告</button>
            <button id="Button1"  onclick="StuInfo()" >查看学生信息</button>
            <button id="Button2"  onclick="HwInfo()" >查看作业情况</button>
            <button id="Button3"  onclick="KqInfo()" >查看考勤情况</button>
        </div>
    <hr />
    <form id="form1" runat="server">
        <div id="GG"></div>
        <div id="StuInfo" style="display:none;">
             <div class="top">          
                班级：<asp:DropDownList ID="ddlclass" class="select" runat="server" >
                <asp:ListItem>请选择</asp:ListItem>
            </asp:DropDownList>
            姓名：<asp:TextBox ID="txt_name" runat="server" class="input"></asp:TextBox>
            <asp:Button ID="btn_searchstu" runat="server" class="btn" Text="查询" OnClick="btn_searchstu_Click" />
            学号：<asp:TextBox ID="txt_StuId" runat="server" class="input"></asp:TextBox>
            <asp:Button ID="btn_SearchStuId" runat="server" class="btn" Text="查询" OnClick="btn_searchStuId_Click" />
        </div>
            <div class="content">
             <table>
                 <tr>
                     <th>学号</th>
                     <th>姓名</th>
                     <th>班级</th>
                     <th>联系方式</th>
                 </tr>
                     <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
                      <ItemTemplate>
                          <tr>
                         <td><%# Eval("StuId")%></td>
                         <td><%# Eval("StuName")%></td>
                         <td><%# Eval("ClassId")%></td>
                         <td><%# Eval("StuPhoneNum")%></td> </tr>
                     </ItemTemplate>
                    </asp:DataList>
                 </table>
            </div>
        </div>
        <div id ="HwInfo" style="display:none;">
            <asp:DataList ID="DataList2" runat="server" RepeatColumns="3">
            <ItemTemplate>
                <div style="box-shadow:2px 2px 1px rgba(128, 128, 128,0.5);width:300px;height:182px;background-color:#F4F4F4" >
                    <h1><span style=""> 1</span></h1>
                    <%--<%# Eval("HwHead")%>--%>
                    <div style="background-color:#FFF5EE; height:130px;text-align:right; ">
                        <div style="margin-right:20px; margin-top:10px;">
                            <div style:"width:80px">开始时间： 1</div> 
                            <div style:"width:80px">截止时间： 1 </div>
                            <div style:"width:80px">应交人数： 1</div> 
                            <div style:"width:80px">实交人数： 1 </div>
                        </div>             
                    <div class="style2" style="height: 51px;  ">
                        <asp:Button ID="Button2" runat="server"  Font-Size="Medium" Height="32px" style="text-align: center;background-color:#3cf;" Text="作业详情" Width="82px" BorderStyle="None" 
                                CommandArgument='1' OnClick="Button2_Click"  />
                    </div>   
                </div> 
        </ItemTemplate>
        </asp:DataList>
        </div>
        <div id ="KqInfo" style="display:none;">
             <div class="top">          
                班级：<asp:DropDownList ID="DropDownList1" class="select" runat="server" >
                <asp:ListItem>请选择</asp:ListItem>
            </asp:DropDownList>
            姓名：<asp:TextBox ID="TextBox1" runat="server" class="input"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" class="btn" Text="查询"  />
            学号：<asp:TextBox ID="TextBox2" runat="server" class="input"></asp:TextBox>
            <asp:Button ID="Button5" runat="server" class="btn" Text="查询" />
            <asp:Button ID="fabu_qiandao" runat="server" Text="发布签到" OnClick="fabu_qiandao_click" />
        </div>
        <div class="content">
             <table>
                 <tr>
                     <th>序号</th>
                     <th>开始时间</th>
                     <th>结束时间</th>
                     <th>签到人数</th>
                 </tr>
                     <asp:DataList ID="DataList3" runat="server" RepeatColumns="3">
                      <ItemTemplate>
                          <tr>
                         <td><%# Eval("KQXh")%></td>
                         <td><%# Eval("KqTime")%></td>
                         <td><%# Eval("EndTime")%></td>
                         <td><%# Eval("StuNum")%></td> </tr>
                     </ItemTemplate>
                    </asp:DataList>
                 </table>
            </div>
        </div>
    </form>
</body>
</html>
