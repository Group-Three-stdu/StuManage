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
    /// FDYToExcel 的摘要说明
    /// </summary>
    public class FDYToExcel : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/x-excel";
            //将HTTP头添加到输出流，设置默认导出的文件名
            string ClassId = context.Request.QueryString["ClassId"].ToString();
            string filename = HttpUtility.UrlEncode(ClassId + "班学生信息表.xls");
            context.Response.AddHeader("Content-Disposition", "attachment;filename=" + filename);
            //创建Excel工作簿和工作表
            HSSFWorkbook workbook = new HSSFWorkbook();
            ISheet newsheet = workbook.CreateSheet("学生信息表");
            //创建工作表的标题
            IRow rowHeader = newsheet.CreateRow(0);
            rowHeader.CreateCell(0, CellType.Numeric).SetCellValue("学号");
            rowHeader.CreateCell(1, CellType.String).SetCellValue("姓名");
            rowHeader.CreateCell(2, CellType.String).SetCellValue("班级");
            rowHeader.CreateCell(3, CellType.Numeric).SetCellValue("联系方式");
            rowHeader.CreateCell(4, CellType.String).SetCellValue("挂科数");
            rowHeader.CreateCell(5, CellType.Numeric).SetCellValue("优秀科目数");

            //查询数据
            List<Students> stulist = new StudentManage().queryStudentByClassId(ClassId);
            foreach (Students stu in stulist)
            {
                stu.GKNum = new ScoreManage().queryGKNum(stu.StuId);
                stu.YXNum = new ScoreManage().queryYXNum(stu.StuId);
            }
            for (int i = 0; i < stulist.Count; i++)
            {
                IRow newRow = newsheet.CreateRow(i + 1);
                newRow.CreateCell(0, CellType.Numeric).SetCellValue(stulist[i].StuId);
                newRow.CreateCell(1, CellType.Numeric).SetCellValue(stulist[i].StuName);
                newRow.CreateCell(2, CellType.Numeric).SetCellValue(stulist[i].ClassId);
                newRow.CreateCell(3, CellType.Numeric).SetCellValue(stulist[i].StuPhoneNum);
                newRow.CreateCell(4, CellType.Numeric).SetCellValue(stulist[i].GKNum);
                newRow.CreateCell(5, CellType.Numeric).SetCellValue(stulist[i].YXNum);
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