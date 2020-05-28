using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Model;

namespace DAL
{
    public class TeaService
    {
        //查询教师信息
        public Teacher queryTeainfoById(int TeaId)
        {
            string sql = "select TeaId,TeaName, TeaSex, TeaBirth, TeaNoId, TeaPhoneNum, TeaAdd, TeaHonor, Teachers.College,PoliticalStatus, Education,job,office,CollegeName " +
                " from Teachers join XY on Teachers.College = XY.College " +
                " where TeaId = @TeaId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@TeaId",TeaId)
            };
            Teacher tea = new Teacher();
            SqlDataReader res = new Helper.SQLHelper().queryAllResult(sql, param, false);
            while (res.Read())
            {
                tea.TeaId = Convert.ToInt32(res["TeaId"]);
                tea.TeaName = res["TeaName"].ToString();
                tea.TeaSex = res["TeaSex"].ToString();
                tea.TeaBirth = Convert.ToDateTime(res["TeaBirth"]);
                tea.TeaNoId = res["TeaNoId"].ToString();
                tea.Phone = res["TeaPhoneNum"].ToString();
                tea.TeaAdd = res["TeaAdd"].ToString();
                tea.TeaHonor = res["TeaHonor"].ToString();
                tea.College = res["College"].ToString();
                tea.PoliticalStatus = res["PoliticalStatus"].ToString();
                tea.Education = res["Education"].ToString();
                tea.Job = res["job"].ToString();
                tea.Office = res["office"].ToString();
                tea.CollegeName = res["CollegeName"].ToString();
            }
            return tea;
        }

        //修改信息
        public int alterTeainfo(Teacher tea)
        {
            string sql = "update Teachers set TeaPhoneNum = @Phone ,TeaAdd = @TeaAdd,Office = @Office where TeaId =@TeaId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Phone",tea.Phone),
                new SqlParameter("@TeaAdd",tea.TeaAdd),
                new SqlParameter("@Office",tea.Office),
                new SqlParameter("@TeaId",tea.TeaId)
            };
            return new Helper.SQLHelper().update(sql, param, false);
        }
    }
}
