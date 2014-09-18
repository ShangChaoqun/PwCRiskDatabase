using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PwCRiskDatabase.IDAL;
using PwCRiskDatabase.Models;

namespace PwCRiskDatabase.SQLServerDAL
{
    public class Risk:IRisk
    {
        private const string PARM_ID = "@ID";
        private const string SQL_SELECT_CONTENT = "Select * From newsContent Where ID = @ID";


        public RiskInfor GetRiskInfor(int Id)
        {
            RiskInfor Ri = null;

            //创建一个参数
            SqlParameter parm = new SqlParameter(PARM_ID, SqlDbType.BigInt, 8);
            //赋上ID值
            parm.Value = Id;

            using (SqlDataReader sdr = SqlHelper.ExecuteReader(SqlHelper.CONN_STR, CommandType.Text, SQL_SELECT_CONTENT, parm))
            {
                if (sdr.Read())
                {
                    Ri = new RiskInfor(sdr.GetInt32(0), sdr.GetString(1), sdr.GetString(2));
                }
            }
            return ci;
        }
    }
}