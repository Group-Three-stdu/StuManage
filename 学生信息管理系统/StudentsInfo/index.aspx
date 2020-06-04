<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="学生信息管理系统.StudentsInfo.index1"  EnableEventValidation="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>主页</title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <script src="../js/jquery.min.js"></script>
     <link rel="stylesheet" href="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/css/bootstrap.min.css">
	<script src="https://cdn.staticfile.org/jquery/2.1.1/jquery.min.js"></script>
	<script src="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <script type="text/javascript">
            $(function(){
                $('.modleDailog').modal("hide");
            });
            
            function show(ID) {
                $('#ggcontent').html(ID);
            }
        </script>
    <form id="form1" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server" enablepartialrendering="true"></asp:ScriptManager>
    <div>
            <div>
              <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-hover text-center col-8" style="width:90%;margin-left:20px;">
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
                             <td><%# Eval("xh")%></td>
                             <td><%# Eval("GGHead")%></td>
                             <td><%# Eval("GGauthor")%></td>
                            <td><%# Eval("GGdateTime")%></td>
                        <td><asp:LinkButton ID="LinkButton2" CommandName="past" CommandArgument='<%# Eval("GGId")%>'
                            runat="server" OnClick="LinkButton2_Click">查看详情</asp:LinkButton></td>
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
    </form>
</body>
</html>
