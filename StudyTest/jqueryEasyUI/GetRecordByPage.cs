using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WheelsetSystem.DBUtility;
using System.Data.SqlClient;
using System.Data;

namespace DBUtility
{
    public  class GetRecordByPage
    {
        /// <summary>
        /// 执行分页存储过程
        /// </summary>
        /// <param name="tblName"></param>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="fldName"></param>
        /// <param name="OrderType"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public static DataSet GetList(string tblName, int PageSize, int PageIndex, string fldName, string OrderType, string strWhere)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
            parameters[0].Value = tblName;
            parameters[1].Value = fldName;
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 1;//返回记录总数, 非 0 值则返回
            parameters[5].Value = OrderType == "desc" ? 1 : 0;
            parameters[6].Value = strWhere;
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage", parameters, "ds");
        }


        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="no"></param>
        /// <param name="travel"></param>
        public static void ExecInsertProc(string no, string travel)
        {
            SqlParameter[] parameters = { new SqlParameter("@carNo", SqlDbType.VarChar, 20), new SqlParameter("@carTravel", SqlDbType.VarChar, 10) };
            parameters[0].Value = no; parameters[1].Value = travel;
            DbHelperSQL.RunProcedure("AddNowDayTravel",parameters);
        }


        public static void ExecBalProc(string No)
        {
            SqlParameter[] parameters = { new SqlParameter("@trainsetNo", SqlDbType.VarChar, 20) };
            parameters[0].Value = No;
            DbHelperSQL.RunProcedure("BakCarList",parameters);
        }

        /// <summary>
        /// 修改使用状态
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="stutas"></param>
        /// <param name="tableName"></param>
        public  void UpdateStutas(string ID, string stutas,string tableName)
        {
            string sqlStr = string.Format("Update {0} SET UserOrNot={1} WHERE ID='{2}'", tableName, stutas, ID);
            try
            {
                DbHelperSQL.ExecuteSql(sqlStr);
            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// 判断是否是数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int IsNumeric(string str)
        {
            int i;
            if (str != null && System.Text.RegularExpressions.Regex.IsMatch(str, @"^-?\d+(\.\d+)?$"))
                i = int.Parse(str);
            else
                i = -1;
            return i;
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="CarNo"></param>
        /// <returns></returns>
        public bool IsExecSql(string CarNo)
        {
            SqlParameter[] parameter={new SqlParameter("@CarNo", SqlDbType.VarChar, 20){ Value=CarNo}};
            try
            {
                DbHelperSQL.RunProcedure("DeleteTrian", parameter);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
