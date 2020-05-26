using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using BLL;
using Model;
using NPOI.SS.UserModel;

namespace 学生信息管理系统.Handler
{
    /// <summary>
    /// TeaToExcel 的摘要说明
    /// </summary>
    public class TeaToExcel : IHttpHandler
    {


        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/x-excel";
            //将HTTP头添加到输出流，设置默认导出的文件名
            string CourseName = context.Request.QueryString["CourseName"].ToString();
            string filename = HttpUtility.UrlEncode(CourseName + "学生信息表.xls");
            context.Response.AddHeader("Content-Disposition", "attachment;filename=" + filename);
            //创建Excel工作簿和工作表
            HSSFWorkbook workbook = new HSSFWorkbook();
            ISheet newsheet = workbook.CreateSheet("学生成绩表");
            //创建工作表的标题
            IRow rowHeader = newsheet.CreateRow(0);
            rowHeader.CreateCell(0, CellType.Numeric).SetCellValue("学号");
            rowHeader.CreateCell(1, CellType.String).SetCellValue("姓名");
            rowHeader.CreateCell(2, CellType.String).SetCellValue("班级");
            rowHeader.CreateCell(3, CellType.Numeric).SetCellValue("联系方式");

            //查询数据
            int CourseId = Convert.ToInt32(context.Request.QueryString["CourseId"]);
            List<Students> stulist = new StudentManage().queryStudentByCourseId(CourseId);
            for (int i = 0; i < stulist.Count; i++)
            {
                IRow newRow = newsheet.CreateRow(i + 1);
                newRow.CreateCell(0, CellType.Numeric).SetCellValue(stulist[i].StuId);
                newRow.CreateCell(1, CellType.Numeric).SetCellValue(stulist[i].StuName);
                newRow.CreateCell(2, CellType.Numeric).SetCellValue(stulist[i].ClassId);
                newRow.CreateCell(3, CellType.Numeric).SetCellValue(stulist[i].StuPhoneNum);
            }
            //将输出流写入Excel工作簿
            workbook.Write(context.Response.OutputStream);

        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}