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
    /// StuToExcel 的摘要说明
    /// </summary>
    public class StuToExcel : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/x-excel";
            //将HTTP头添加到输出流，设置默认导出的文件名
            int StuId = Convert.ToInt32(context.Request.QueryString["StuId"]);
            string StuName = context.Request.QueryString["StuName"].ToString();
            string filename = HttpUtility.UrlEncode(StuId+ StuName + "成绩表.xls");
            context.Response.AddHeader("Content-Disposition", "attachment;filename=" + filename);
            //创建Excel工作簿和工作表
            HSSFWorkbook workbook = new HSSFWorkbook();
            ISheet newsheet = workbook.CreateSheet("学生成绩表");
            //创建工作表的标题
            IRow rowHeader = newsheet.CreateRow(0);
            rowHeader.CreateCell(0, CellType.Numeric).SetCellValue("课程名");
            rowHeader.CreateCell(1, CellType.String).SetCellValue("课程性质");
            rowHeader.CreateCell(2, CellType.String).SetCellValue("学分");
            rowHeader.CreateCell(3, CellType.Numeric).SetCellValue("学院");
            rowHeader.CreateCell(4, CellType.Numeric).SetCellValue("教师");
            rowHeader.CreateCell(5, CellType.Numeric).SetCellValue("学期");
            rowHeader.CreateCell(6, CellType.Numeric).SetCellValue("平时成绩");
            rowHeader.CreateCell(7, CellType.Numeric).SetCellValue("期末成绩");
            rowHeader.CreateCell(8, CellType.Numeric).SetCellValue("总成绩");

            //查询数据
            List<Model.Score> sclist = new ScoreManage().queryScore(StuId);
            for (int i = 0; i < sclist.Count; i++)
            {
                IRow newRow = newsheet.CreateRow(i + 1);
                newRow.CreateCell(0, CellType.Numeric).SetCellValue(sclist[i].CourseName);
                newRow.CreateCell(1, CellType.Numeric).SetCellValue(sclist[i].courseproperty);
                newRow.CreateCell(2, CellType.Numeric).SetCellValue(sclist[i].Xuefen);
                newRow.CreateCell(3, CellType.Numeric).SetCellValue(sclist[i].CollegeName);
                newRow.CreateCell(4, CellType.Numeric).SetCellValue(sclist[i].TeaName);
                newRow.CreateCell(5, CellType.Numeric).SetCellValue(sclist[i].Season);
                newRow.CreateCell(6, CellType.Numeric).SetCellValue(sclist[i].ClassScore);
                newRow.CreateCell(7, CellType.Numeric).SetCellValue(sclist[i].MatchScore);
                newRow.CreateCell(8, CellType.Numeric).SetCellValue(sclist[i].FinalScore);
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