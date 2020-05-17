<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reviewcourse.aspx.cs" Inherits="学生信息管理系统.course.reviewcourse" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="../css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/css/bootstrap.min.css">
	<script src="https://cdn.staticfile.org/jquery/2.1.1/jquery.min.js"></script>
	<script src="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <title>教务处审核课程</title>
    <style>
        .box{
            width:100%;
            height:65px;
            background-color:#c4e1ff;
        }
        .button{
            width:12%;
            text-align:center;
            height:25px;
            margin-left:1%;
            margin-top:20px;
            border-radius:5px;
            margin-bottom:20px;
        }
        .content{
            margin-top:20px;
        }
        .btn{
            height:25px;
            padding-top:2px;
        }
        
    </style>
    <script type="text/javascript">
            $(function(){
                $('.modleDailog').modal("hide");
            });
            function values(ID){
                $('#courseId').val(ID);
            }
        </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="modal fade modleDailog" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
           <div class="modal-dialog" role="document">
              <div class="modal-content">
                <div class="modal-header">
                  <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
                  <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                  </button>
                </div>
                <div class="modal-body">
                    <asp:TextBox ID="courseId"  runat="server"></asp:TextBox>
                    <asp:TextBox ID="txt_season" placeholder="课程学期" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txt_time" placeholder="上课时间" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txt_add" placeholder="上课地点" runat="server"></asp:TextBox>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="Button4" class="btn btn-secondary" data-dismiss="modal" runat="server" Text="关闭" />
                    <asp:Button ID="btn_save" class="btn btn-primary" OnClick="btn_save_Click" runat="server" Text="保存" />
                  
                </div>
              </div>
            </div>
        </div>

        <div class="box">
            <asp:Button ID="Button2" runat="server" CssClass="btn-danger button " Text="查看待审核课程" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" CssClass="btn-success button" Text="查看已审核课程" OnClick="Button3_Click" />
        </div>
        <div class="content">

            <nav>
                <div class="nav nav-tabs" id="nav-tab" role="tablist">
                <asp:Repeater ID="Repeater1" runat="server" >
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center">
                        <tr class="table-bordered table-condensed info">
                        <td width="10%" class="table-bordered">课程编号</td>
                        <td class="table-bordered">课程名</td>
                        <td class="table-bordered">学分</td>
                        <td class="table-bordered">学时数</td>
                        <td class="table-bordered">课程性质</td>
                        <%--<td class="table-bordered">审核状态</td>--%>
<%--                        <td class="table-bordered">开课学院</td>
                        <td class="table-bordered">状态</td>--%>
                        <td class="table-bordered" width="15%">操作</td>
                </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="table-responsive table-bordered table-condensed">
                        <td class="table-bordered"><%# Eval("CourseID")%></td>
                        <td class="table-bordered"><%# Eval("CourseName")%></td>
                        <td class="table-bordered"><%# Eval("Xuefen")%></td>
                        <td class="table-bordered"><%# Eval("CourseNum")%></td>
                        <td class="table-bordered"><%# Eval("courseproperty")%></td>
                        <%--<td class="table-bordered"><%# Eval("SStatus")%></td>--%>
<%--                        <td class="table-bordered"><%# Eval("college")%></td>
                        <td class="table-bordered"><%# Eval("zhuangtai")%></td>--%>
                        <td class="table-bordered">
                        <asp:LinkButton ID="LinkButton1" CommandName="past" CommandArgument='<%# Eval("CourseID")%>' class="btn btn-primary" data-toggle="modal" data-target="#exampleModal" runat="server" OnClientClick='<%#Eval("CourseID", "values(\"{0}\")")%>' >通过</asp:LinkButton>
                             &nbsp;
                            <%--<asp:LinkButton ID="LinkButton2" CommandName="nopast" CommandArgument='<%# Eval("CourseID")%>' class="btn btn-primary" runat="server">不通过</asp:LinkButton>--%>
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            </div>
            </nav>
        </div>
        
    </form>
</body>
</html>
