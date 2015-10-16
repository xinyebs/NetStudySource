using System;
using System.Web;
using System.Data.OleDb;
using System.Data;
namespace mdb
{
	/// <summary>
	/// db ��ժҪ˵����
	/// </summary>
	public class db
	{
		public db()
		{
		}
		/// <summary>
		/// ����һ�����ݿ����Ӻ���
		/// ex:CreateConnetion()
		/// </summary>
		/// <returns>����һ�����ݿ����Ӷ���</returns>

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
		/// ����һ��ͨ�õ�OleDbParameter
		/// ex:PrepareCommand(new OleDbparameter("@me","���Ǻ�"),true,sqlstr,conn)
		/// <param name="conn">���ݿ����Ӷ���</param>
		/// <param name="sqlstr">sql�����ַ���</param>
		/// <param name="typed">�Ƿ�ʹ��OleDbParameters�Ĳ�������</param>
		/// <param name="parm">OleDbParameters�Ĳ���¦��</param>
		/// <returns>����һ�����ݿ��������</returns>

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
		/// ���ز�ѯ���ݵĵ�һ�е�һ��
		/// </summary>
		/// <param name="conn">ͬ��</param>
		/// <param name="sqlstr">ͬ��</param>
		/// <param name="typed">ͬ��</param>
		/// <param name="parm">ͬ��</param>
		/// <returns>����һ��object����</returns>
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
		/// <param name="conn">ͬ��</param>
		/// <param name="sqlstr">ͬ��</param>
		/// <param name="typed">ͬ��</param>
		/// <param name="parm">ͬ��</param>
		/// <returns>������Ӱ�������</returns>
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
        /// ִ��Sql������� 
        /// </summary> 
        /// <param name="sqlstr">�����Sql���</param>
        /// <returns>����ֵ</returns>
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
		/// ����һ��datareader�ĺ���
		/// </summary>
		/// <param name="conn">ͬ��</param>
		/// <param name="sqlstr">ͬ��</param>
		/// <param name="typed">ͬ��</param>
		/// <param name="parm">ͬ��</param>
		/// <returns>����һ����ǰ�������Ķ���OleDbDataReader</returns>
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
            //����
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
            //��ѯ���ݣ�ȡ��������
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
            //��ѯ���ݣ�ȡ��������
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
		/// ����һ��dataview�ĺ���
		/// </summary>
		/// <param name="sqlstr">ͬ��</param>
		/// <param name="typed">ͬ��</param>
		/// <param name="parm">ͬ��</param>
		/// <returns>����һ��dataview�Ķ���</returns>
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
