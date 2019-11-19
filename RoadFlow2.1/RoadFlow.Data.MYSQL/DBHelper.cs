using System;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace RoadFlow.Data.MYSQL
{
    /// <summary>
    /// SQLSERVER助手类
    /// </summary>
    public class DBHelper
    {
        private string connectionString;

        public DBHelper()
        {
            this.connectionString = RoadFlow.Utility.Config.PlatformConnectionStringMYSQL;
        }
        public DBHelper(string connString)
        {
            this.connectionString = connString;
        }

        /// <summary>
        /// 连接字符串
        /// </summary>
        public string ConnectionString
        {
            get { return this.connectionString; }
        }

        /// <summary>
        /// 释放连接
        /// </summary>
        public void Dispose()
        {

        }

        /// <summary>
        /// 得到一个MySqlDataReader
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public MySqlDataReader GetDataReader(string sql)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Prepare();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        /// <summary>
        /// 得到一个MySqlDataReader
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public MySqlDataReader GetDataReader(string sql,MySqlParameter[] parameter)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                if (parameter != null && parameter.Length > 0)
                    cmd.Parameters.AddRange(parameter);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                cmd.Prepare();
                return dr;
            }
        }

        /// <summary>
        /// 得到一个DataTable
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public DataTable GetDataTable(string sql)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dr.Close();
                    dr.Dispose();
                    cmd.Prepare();
                    return dt;
                }
            }
        }

        /// <summary>
        /// 得到一个DataTable
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public DataTable GetDataTable(string sql, MySqlParameter[] parameter)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (parameter != null && parameter.Length > 0)
                        cmd.Parameters.AddRange(parameter);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dr.Close();
                    dr.Dispose();
                    cmd.Parameters.Clear();
                    cmd.Prepare();
                    return dt;
                }
            }
        }

        /// <summary>
        /// 得到数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string sql)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlDataAdapter dap = new MySqlDataAdapter(sql, conn))
                {
                    DataSet ds = new DataSet();
                    dap.Fill(ds);
                    return ds;
                }
            }
        }

        /// <summary>
        /// 执行SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Execute(string sql)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Prepare();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 执行SQL(事务)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Execute(List<string> sqlList)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int i = 0;
                    cmd.Connection = conn;
                    foreach (string sql in sqlList)
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;
                        cmd.Prepare();
                        i += cmd.ExecuteNonQuery();
                    }
                    return i;
                }
            }
        }

        /// <summary>
        /// 执行带参数的SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public int Execute(string sql, MySqlParameter[] parameter)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (parameter != null && parameter.Length > 0)
                        cmd.Parameters.AddRange(parameter);
                    int i = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.Prepare();
                    return i;
                }
            }
        }

        /// <summary>
        /// 执行SQL(事务)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Execute(List<string> sqlList, List<MySqlParameter[]> parameterList)
        {
            if (sqlList.Count > parameterList.Count)
            {
                throw new Exception("参数错误");
            }
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int i = 0;
                    cmd.Connection = conn;
                    for (int j = 0; j < sqlList.Count; j++)
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sqlList[j];
                        if (parameterList[j] != null && parameterList[j].Length > 0)
                        {
                            cmd.Parameters.AddRange(parameterList[j]);
                        }
                        i += cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        cmd.Prepare();
                    }
                    return i;
                }
            }
        }

        /// <summary>
        /// 得到一个字段的值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public string ExecuteScalar(string sql)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    object obj = cmd.ExecuteScalar();
                    cmd.Prepare();
                    return obj != null ? obj.ToString() : string.Empty;
                }
            }
        }

        /// <summary>
        /// 得到一个字段的值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public string ExecuteScalar(string sql, MySqlParameter[] parameter)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (parameter != null && parameter.Length > 0)
                        cmd.Parameters.AddRange(parameter);
                    object obj = cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    cmd.Prepare();
                    return obj != null ? obj.ToString() : string.Empty;
                }
            }
        }
        /// <summary>
        /// 得到一个字段的值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public string GetFieldValue(string sql)
        {
            return ExecuteScalar(sql);
        }
        /// <summary>
        /// 得到一个字段的值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public string GetFieldValue(string sql, MySqlParameter[] parameter)
        {
            return ExecuteScalar(sql, parameter);
        }

        /// <summary>
        /// 获取一个sql的字段名称
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public string GetFields(string sql, MySqlParameter[] param)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                System.Text.StringBuilder names = new System.Text.StringBuilder(500);
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (param != null && param.Length > 0)
                        cmd.Parameters.AddRange(param);
                    MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SchemaOnly);
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        names.Append("[" + dr.GetName(i) + "]" + (i < dr.FieldCount - 1 ? "," : string.Empty));
                    }
                    cmd.Parameters.Clear();
                    dr.Close();
                    dr.Dispose();
                    cmd.Prepare();
                    return names.ToString();
                }
            }
        }

        /// <summary>
        /// 获取一个sql的字段名称
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="tableName">表名 </param>
        /// <returns></returns>
        public string GetFields(string sql, MySqlParameter[] param, out string tableName)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                System.Text.StringBuilder names = new System.Text.StringBuilder(500);
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (param != null && param.Length > 0)
                        cmd.Parameters.AddRange(param);
                    MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SchemaOnly);
                    tableName = dr.GetSchemaTable().TableName;
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        names.Append("[" + dr.GetName(i) + "]" + (i < dr.FieldCount - 1 ? "," : string.Empty));
                    }
                    cmd.Parameters.Clear();
                    dr.Close();
                    dr.Dispose();
                    cmd.Prepare();
                    return names.ToString();
                }
            }
        }

        /// <summary>
        /// 得到分页sql
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public string GetPaerSql(string sql, int size, int number, out long count, MySqlParameter[] param = null)
        {
            string count1 = GetFieldValue(string.Format("select count(*) from ({0}) as a ", sql), param);
           // string count1 = GetFieldValue();
            long i;
            count = count1.IsLong(out i) ? i : 0;

            StringBuilder sql1 = new StringBuilder();
            sql1.Append("select * from (");
            sql1.Append(sql);
            sql1.AppendFormat(") as PagerTempTable");
            if (count > size)
            {
                sql1.AppendFormat(" where PagerAutoRowNumber between {0} and {1}", number * size - size + 1, number * size);
            }

            return sql1.ToString();
        }

        /// <summary>
        /// 得到分页sql
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public string GetPaerSql(string table, string fileds, string where, string order, int size, int number, out long count, MySqlParameter[] param = null)
        {
            string where1 = string.Empty;
            if (where.IsNullOrEmpty())
            {
                where1 = "";
            }
            else
            {
                where1 = where.Trim();
                if (where1.StartsWith("and", StringComparison.CurrentCultureIgnoreCase))
                {
                    where1 = where1.Substring(3);
                }
            }
            string where2 = where1.IsNullOrEmpty() ? "" : "where " + where1;
            //  string sql = string.Format("select {0},ROW_NUMBER() OVER(ORDER BY {1}) as PagerAutoRowNumber from {2} {3}", fileds, order, table, where2);
            
            string sql = string.Format("select {0} from {2} {3} order by {1}  limit {4},{5} ", fileds, order, table, where2, number * size - size, number * size);
            string count1 = GetFieldValue(string.Format("select count(*) from {0} {1}", table, where2), param);
            long i;
            count = count1.IsLong(out i) ? i : 0;

            StringBuilder sql1 = new StringBuilder();
            //sql1.AppendFormat("select {0} from (", fileds.IsNullOrEmpty() ? "*" : fileds);
            sql1.Append(sql);
            //sql1.AppendFormat(") as PagerTempTable");
            //if (count > size)
            //{
            //    sql1.AppendFormat(" where PagerAutoRowNumber between {0} and {1}", number * size - size + 1, number * size);
            //}

            return sql1.ToString();
            
        }

    }
}
