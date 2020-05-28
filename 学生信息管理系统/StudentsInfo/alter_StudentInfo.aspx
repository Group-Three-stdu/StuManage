<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alter_StudentInfo.aspx.cs" Inherits="学生信息管理系统.StudentsInfo.alter_StudentInfo" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>学生查看个人信息</title>
    <style>
        .box {
            margin:0 auto;
            width:100%;
            height:450px;
        }
        table{
            width:100%;
            border:1px solid #ccc;
            height:100%;
            font-size:15px;
        }
        tr{
            width:100%;
            height:40px;
            border:1px solid #ccc;
        }
        th{
            text-align:center;
            border:1px solid #ccc;
        }
        td{
            text-align:left;
            border:1px solid #ccc;
        }
        .earn{
            width:100%;
            height:50px;
            margin:0 auto;
            background-color:#f5f5f5;
            color:#666;
            line-height:50px;
            border:1px solid #ccc;
        }
     
        .btn .lbbtn{
            height:30px;
            line-height:14px;
        }
    </style>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="../js/jquery.min.js"></script>
</head>
<body >
    <script type="text/javascript">
        function change() {
            $('#btn_sub').show();
            $('#btn_alter').hide();
            $('#stuinfo input').css('border', 'solid 1px black');
        }
    </script>
    <form id="form1" runat="server">
    <div>
        
        <div class="box">
           
            <div style="width:96%;"class="m-auto"  >
                <table id="stuinfo" class="table table-striped ">
                    <tr>
                        <th colspan="5">个人信息</th>
                    
                    </tr>
                    <tr>
                        <th >学号</th><td ><asp:TextBox ID="Id" runat="server" Text="" BorderWidth="0px" ></asp:TextBox></td>
                        <th >姓名</th><td><asp:TextBox ID="Name" runat="server" Text="" BorderWidth="0px"  Width="80%"></asp:TextBox></td>
                        <th rowspan="4" colspan="3" style="width:11%">照片</th>
                    </tr>
                    <tr>
                        <th>性别</th><td><asp:TextBox ID="Sex" runat="server" Text="" BorderWidth="0px" BackColor="#f2f2f2"></asp:TextBox></td>
                        <th>出生日期</th><td><asp:TextBox ID="Birth" runat="server" Text="" BorderWidth="0px" BackColor="#f2f2f2"  Width="80%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <th>身份证号</th><td><asp:TextBox ID="IdNo" runat="server" Text="" BorderWidth="0px"></asp:TextBox></td>
                        <th>联系电话</th><td><asp:TextBox ID="Pho" runat="server" Text="" BorderWidth="0px"   Width="80%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <th>班级</th><td colspan="1"><asp:TextBox ID="ClassId" runat="server" Text="" BorderWidth="0px" BackColor="#f2f2f2" ></asp:TextBox></td>
                        <th>学院</th><td colspan="1"><asp:TextBox ID="ColName" runat="server" Text="" BorderWidth="0px" BackColor="#f2f2f2"  Width="80%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <th>专业</th><td><asp:TextBox ID="Maj" runat="server" Text="" BorderWidth="0px" ></asp:TextBox></td>
                        <th>家庭住址</th><td><asp:TextBox ID="Add" runat="server" Text="" BorderWidth="0px" ></asp:TextBox></td>
                    
                    </tr>
                    <tr>
                        <th>政治面貌</th><td><asp:TextBox ID="StupoState" runat="server" Text="" BorderWidth="0px" BackColor="#f2f2f2" ></asp:TextBox></td>
                        <th>状态</th><td colspan="2"><asp:TextBox ID="Stustate" runat="server" Text="" BorderWidth="0px" BackColor="#f2f2f2"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <th>荣誉</th><td colspan="4"><asp:TextBox ID="Stuhonor" runat="server" Text="" BorderWidth="0px" ></asp:TextBox></td>
                    </tr>
                    <tr>
                        <th>惩处</th><td colspan="4"><asp:TextBox ID="Stupun" runat="server" Text="" BorderWidth="0px" BackColor="#f2f2f2" ></asp:TextBox></td>
                    </tr>
                    <tr>
                        <th>备注</th><td colspan="4"><asp:TextBox ID="StuPS" runat="server" Text="" BorderWidth="0px"></asp:TextBox></td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="btn"style="width:90%;margin-top:60px;">
             <button type="button" id="btn_alter" class="btn lbbtn btn-success" onclick="change()">修改信息</button>
            <asp:LinkButton ID="btn_sub" CssClass="lbbtn btn btn-success" style="display:none;" runat="server" OnClick="btn_sub_Click">提交</asp:LinkButton>
        </div>
    </div>
        <div style="display:none">
            学院编号<asp:Label ID="CollegeID" runat="server" Text=""></asp:Label>专业编号<asp:Label ID="Major" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
