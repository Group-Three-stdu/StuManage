<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HwDetails.aspx.cs" Inherits="学生信息管理系统.homework.HwDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <script type="text/javascript">
        function submit() {
            document.getElementById('submit').style.display = "block";
            document.getElementById('unsubmit').style.display = "none";
        }
        function unsubmit() {
            document.getElementById('submit').style.display = "none";
            document.getElementById('unsubmit').style.display = "block";
        }
    </script>
    <div class="box" >
            <button id="Button0" class="btn btn-info"  onclick="submit()" >已提交</button>
            <button id="Button1" class="btn btn-info"  onclick="unsubmit()" >未提交</button>
        </div>
    <hr />
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" enablepartialrendering="true"></asp:ScriptManager>
    <div>       
        <div id="submit" >
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
            </div>
             <div>
              <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center col-8" style="width:70%">
                        <tr class="table-bordered table-condensed info text-center"  >
                             <th style="text-align:center">学号</th>
                            <th style="text-align:center">姓名</th>
                            <th style="text-align:center">班级</th>
                            <th style="text-align:center">提交时间</th>
                            <th style="text-align:center">分数</th>
                            <th style="text-align:center">操作</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                             <td><%# Eval("StuId")%></td>
                             <td><%# Eval("StuName")%></td>
                             <td><%# Eval("ClassId")%></td>
                             <td><%# Eval("Time")%></td>
                             <td>0</td>
                            <td><asp:LinkButton ID="btnLook" CommandArgument='<%#Eval("StuId")%>'  runat="server" OnClick="btnLook_Click">详情</asp:LinkButton></td>
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
        <div id="unsubmit" style="display:none;"> 
            <div>
              <asp:Repeater ID="Repeater2" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center col-8" style="width:70%">
                        <tr class="table-bordered table-condensed info text-center"  >
                             <th style="text-align:center">学号</th>
                            <th style="text-align:center">姓名</th>
                            <th style="text-align:center">班级</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                             <td><%# Eval("StuId")%></td>
                             <td><%# Eval("StuName")%></td>
                             <td><%# Eval("ClassId")%></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
                </div>
        </div>
    </div>
    </form>
</body>
</html>
