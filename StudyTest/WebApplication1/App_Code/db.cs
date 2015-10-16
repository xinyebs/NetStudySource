using System;
using System.Web;
using System.Data.OleDb;
using System.Data;
namespace mdb
{
	/// <summary>
	/// db 的摘要说明。
	/// </summary>
	public class db
	{
		public db()
		{
		}
		/// <summary>
		/// 创造一个数据库连接函数
		/// ex:CreateConnetion()
		/// </summary>
		/// <returns>返回一个数据库连接对象</returns>

		private static OleDbConnection CreateConnection()
		{
			string databasestr=System.Configuration.ConfigurationSettings.AppSettings["connstr"];
			string constr;
			constr="provider=Microsoft.Jet.OleDb.4.0;data source="
				+System.Web.HttpContext.Current.Server.MapPath(@databasestr);
			OleDbConnection con = new OleDbConnection(constr);
			return con;
		}

		/// </summary>
		/// 构造一个通用的OleDbParameter
		/// ex:PrepareCommand(new OleDbparameter("@me","你们好"),true,sqlstr,conn)
		/// <param name="conn">数据库连接对象</param>
		/// <param name="sqlstr">sql操作字符串</param>
		/// <param name="typed">是否使用OleDbParameters的参数数据</param>
		/// <param name="parm">OleDbParameters的参数娄组</param>
		/// <returns>返回一个数据库操作对象</returns>

		private static OleDbCommand PrepareCommand(OleDbConnection conn,string sqlstr,bool typed,OleDbParameter[] parm)
		{
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			OleDbCommand com = new OleDbCommand("",conn);
			
			com.CommandText=sqlstr;
			if (typed)
			{
				foreach (OleDbParameter parmitem in parm)
				{
					com.Parameters.Add(parmitem);
				}
			}
			return com;
		}

		/// <summary>
		/// 返回查询数据的第一行第一列
		/// </summary>
		/// <param name="conn">同上</param>
		/// <param name="sqlstr">同上</param>
		/// <param name="typed">同上</param>
		/// <param name="parm">同上</param>
		/// <returns>返回一个object对象</returns>
		public static object ExecuteScalar(string sqlstr,OleDbParameter[] parm)
		{
		
			OleDbConnection conn = CreateConnection();
			OleDbCommand com = PrepareCommand(conn,sqlstr,true,parm);
			object show = com.ExecuteScalar();
			
			conn.Close();
			com.Parameters.Clear();
			return show;
		}

		public static object ExecuteScalar(string sqlstr)
		{
		
			OleDbConnection conn = CreateConnection();
			OleDbCommand com = PrepareCommand(conn,sqlstr,false,null);
			object show = com.ExecuteScalar();
			
			conn.Close();
			com.Parameters.Clear();
			return show;
		}

		/// <summary>
		/// </summary>
		/// <param name="conn">同上</param>
		/// <param name="sqlstr">同上</param>
		/// <param name="typed">同上</param>
		/// <param name="parm">同上</param>
		/// <returns>返回受影响的行数</returns>
		public static int ExecuteNonQuery(string sqlstr,OleDbParameter[] parm)
		{
			OleDbConnection conn = CreateConnection();
			OleDbCommand com = PrepareCommand(conn,sqlstr,true,parm);
			int show = com.ExecuteNonQuery();
		
			conn.Close();
			com.Parameters.Clear();
			return show;
		}

		public static int ExecuteNonQuery(string sqlstr)
		{
			OleDbConnection conn = CreateConnection();
			OleDbCommand com = PrepareCommand(conn,sqlstr,false,null);
			int show = com.ExecuteNonQuery();
		
			conn.Close();
			com.Parameters.Clear();
			return show;
		}
        /// <summary> 
        /// 执行Sql更新语句 
        /// </summary> 
        /// <param name="sqlstr">传入的Sql语句</param>
        /// <returns>布尔值</returns>
        public static bool ExecuteUpdate(string sqlstr)
        {
            int isUpdateOk = 0;
            OleDbConnection conn = CreateConnection();
            OleDbCommand com = PrepareCommand(conn, sqlstr, false, null);
            try
            {
                isUpdateOk = com.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                com.Parameters.Clear();
            }
            if (isUpdateOk > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		/// <summary>
		/// 构造一个datareader的函数
		/// </summary>
		/// <param name="conn">同上</param>
		/// <param name="sqlstr">同上</param>
		/// <param name="typed">同上</param>
		/// <param name="parm">同上</param>
		/// <returns>返回一个向前读的流的对象OleDbDataReader</returns>
		public static OleDbDataReader ExecuteDataReader(string sqlstr,OleDbParameter[] parm)
		{
			OleDbConnection conn = CreateConnection();
			OleDbCommand com = PrepareCommand(conn,sqlstr,true,parm);
			OleDbDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection);
			return dr;
		}

		public static OleDbDataReader ExecuteDataReader(string sqlstr)
		{
			OleDbConnection conn = CreateConnection();
			OleDbCommand com = PrepareCommand(conn,sqlstr,false,null);
			OleDbDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection);
			com.Parameters.Clear();
			return dr;
		}
        public static string SearchValue(string sqlstr)
        {
            //查找
            OleDbConnection conn = CreateConnection();
            OleDbCommand com = PrepareCommand(conn, sqlstr, false, null);
            OleDbDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection);
            com.Parameters.Clear();
            if (dr.Read())
                return dr[0].ToString();
            else
                return "";

        }
        public static DataRow GetDataRow(string strSQL)
        {
            //查询数据，取得数据行
            try
            {
                OleDbConnection conn = CreateConnection();
                OleDbCommand com = PrepareCommand(conn, strSQL, false, null);
                OleDbDataAdapter pter = new OleDbDataAdapter(com);
                DataSet ds = new DataSet();
                pter.Fill(ds, "datasource");
                if (ds.Tables[0].Rows.Count != 0)
                    return ds.Tables[0].Rows[0];
                else
                    return null;
            }
            catch
            {
                return null;
            }

        }
        public static DataTable GetDataTable(string strSQL)
        {
            //查询数据，取得数据行
            try
            {
                OleDbConnection conn = CreateConnection();
                OleDbCommand com = PrepareCommand(conn, strSQL, false, null);
                OleDbDataAdapter pter = new OleDbDataAdapter(com);
                DataSet ds = new DataSet();
                pter.Fill(ds, "datasource");
                return ds.Tables[0];
            }
            catch
            {
                return null;
            }

        }
		/// <summary>
		/// 构造一个dataview的函数
		/// </summary>
		/// <param name="sqlstr">同上</param>
		/// <param name="typed">同上</param>
		/// <param name="parm">同上</param>
		/// <returns>返回一个dataview的对象</returns>
		public static DataView ExecuteDataview(string sqlstr,OleDbParameter[] parm)
		{
		
			OleDbConnection conn = CreateConnection();
			OleDbCommand com= PrepareCommand(conn,sqlstr,true,parm);
			OleDbDataAdapter pter = new OleDbDataAdapter(com);
			DataSet ds = new DataSet();
			pter.Fill(ds,"datasource");
			DataView dataShow = ds.Tables["datasource"].DefaultView;
			conn.Close();
			com.Parameters.Clear();
			return dataShow;
			
		}

		public static DataView ExecuteDataview(string sqlstr)
		{
		
			OleDbConnection conn = CreateConnection();
			OleDbCommand com= PrepareCommand(conn,sqlstr,false,null);
			OleDbDataAdapter pter = new OleDbDataAdapter(com);
			DataSet ds = new DataSet();
			pter.Fill(ds,"datasource");
			DataView dataShow = ds.Tables["datasource"].DefaultView;
			conn.Close();
			com.Parameters.Clear();
			return dataShow;
			
		}
	}
}
