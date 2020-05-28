using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace 学生信息管理系统.StudentsInfo
{
    public partial class addStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //获取学院列表
                List<College> colList = new queryManage().queryAllCol();
                ddlxueyuan.DataSource = colList;
                ddlxueyuan.DataTextField = "collegeName";
                ddlxueyuan.DataValueField = "collegeId";
                ddlxueyuan.DataBind();
                ddlxueyuan.Items.Insert(0, new ListItem("请选择", ""));
                //获取专业列表
                List<Major> majlist = new queryManage().querAllMaj(" ");
                ddlmajor.DataSource = majlist;
                ddlmajor.DataTextField = "majorName";
                ddlmajor.DataValueField = "majorId";
                ddlmajor.DataBind();
                ddlmajor.Items.Insert(0, new ListItem("请选择", ""));
                //班级列表
                List<Model.Class> clalist = new queryManage().querAllCla(" ", " ");
                ddlclass.DataSource = clalist;
                ddlclass.DataTextField = "ClassId";
                ddlclass.DataBind();
                ddlclass.Items.Insert(0, new ListItem("请选择", ""));
            }
        }

        protected void btn_sub_Click(object sender, EventArgs e)
        {
            int StuId = Convert.ToInt32(Id.Text.Trim());
            if (!fulStuImage.HasFile)
            {
                ltaMsg.Text = "<script type='text/javascript'>alert('请选择图片!')</script>";
                return;
            }
            //判断文件大小
            double theMaxphotoSize = Convert.ToDouble(System.Configuration.ConfigurationManager.AppSettings["theMaxphotoSize"]) / 1024;
            double fileSize = fulStuImage.FileContent.Length / (1024 * 1024);
            if (fileSize > theMaxphotoSize)
            {
                ltaMsg.Text = "<script type='text/javascript'>alert('文件图片不能超过" + theMaxphotoSize + "MB')</script>";
                return;
            }
            //判断文件后缀名
            string filename = fulStuImage.FileName.ToLower();
            filename = filename.Substring(filename.LastIndexOf("."));
            if (filename != ".jpg")
            {
                ltaMsg.Text = "<script type='text/javascript'>alert('图片后缀名必须为jpg')</script>";
                return;
            }
            //更改文件名
            filename = Convert.ToString(StuId + ".jpg");
            //获取文件路径
            string filepath = Server.MapPath("~/Image/students");
            try
            {
                fulStuImage.SaveAs(filepath + "/" + filename);
            }
            catch (Exception ex)
            {
                ltaMsg.Text = "<script type='text/javascript'>alert('头像上传失败： " + ex.Message + "')</script>";
            }

            Students stu = new Students()
            {
                StuId = Convert.ToInt32(Id.Text.Trim()),
                StuName = Name.Text.Trim(),
                StuSex = Sex.Text.Trim(),
                StuBirth = Birth.Text.Trim(),
                Punish = Stupun.Text.Trim(),
                StuHonor = Stuhonor.Text.Trim(),
                StuPhoneNum = Pho.Text.Trim(),
                StuNoId = IdNo.Text.Trim(),
                StuState = StupoState.Text.Trim(),
                StuAdd = Add.Text.Trim(),
                PoliticalStatus = StupoState.Text.Trim(),
                College = ddlxueyuan.SelectedValue,
                Major = ddlmajor.SelectedValue,
                ClassId = ddlclass.SelectedValue
            };
            int res = new StudentManage().AddStudentById(stu);
            if (res > 0)
                Response.Write("<script>alert('添加成功')</script>");
            else if (res == -1)
                Response.Write("<script>alert('学号重复')</script>");
            else
                Response.Write("<script>alert('添加失败')</script>");
        }

        protected void ddlmajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string college = ddlxueyuan.SelectedItem.Value.Trim().ToString();
            string collegeId = ddlxueyuan.SelectedValue.Trim().ToString();
            string majorId = ddlmajor.SelectedValue.Trim().ToString();
            //班级下拉框联动
            List<Model.Class> clalist = new queryManage().querAllCla(collegeId, majorId);
            ddlclass.DataSource = clalist;
            ddlclass.DataTextField = "ClassId";
            ddlclass.DataBind();
            ddlclass.Items.Insert(0, new ListItem("请选择", ""));
        }

        protected void ddlxueyuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string college = ddlxueyuan.SelectedItem.Value.Trim().ToString();
            string collegeId = ddlxueyuan.SelectedValue.Trim().ToString();
            //专业下拉框联动
            List<Major> majlist = new queryManage().querAllMaj(collegeId);
            ddlmajor.DataSource = majlist;
            ddlmajor.DataTextField = "majorName";
            ddlmajor.DataValueField = "majorId";
            ddlmajor.DataBind();
            ddlmajor.Items.Insert(0, new ListItem("请选择", ""));
            //班级下拉框联动
            List<Model.Class> clalist = new queryManage().querAllCla(collegeId, " ");
            ddlclass.DataSource = clalist;
            ddlclass.DataTextField = "ClassId";
            ddlclass.DataBind();
            ddlclass.Items.Insert(0, new ListItem("请选择", ""));
        }

        protected void btnUpLoadImage_Click(object sender, EventArgs e)
        {

        }
    }
}