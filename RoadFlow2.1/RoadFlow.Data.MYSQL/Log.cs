using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace RoadFlow.Data.MYSQL
{
    public class Log : RoadFlow.Data.Interface.ILog
    {
        private DBHelper dbHelper = new DBHelper();
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Log()
        {

        }
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.Log实体类</param>
        /// <returns>操作所影响的行数</returns>
        public int Add(RoadFlow.Data.Model.Log model)
        {
            string sql = @"INSERT INTO Log
				(ID,Title,Type,WriteTime,UserID,UserName,IPAddress,URL,Contents,Others,OldXml,NewXml) 
				VALUES(@ID,@Title,@Type,@WriteTime,@UserID,@UserName,@IPAddress,@URL,@Contents,@Others,@OldXml,@NewXml)";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar, -1){ Value = model.ID },
				new MySqlParameter("@Title", MySqlDbType.String, -1){ Value = model.Title },
				new MySqlParameter("@Type", MySqlDbType.String, 100){ Value = model.Type },
				new MySqlParameter("@WriteTime", MySqlDbType.DateTime, 8){ Value = model.WriteTime },
				model.UserID == null ? new MySqlParameter("@UserID", MySqlDbType.VarChar, -1) { Value = DBNull.Value } : new MySqlParameter("@UserID", MySqlDbType.VarChar, -1) { Value = model.UserID },
				model.UserName == null ? new MySqlParameter("@UserName", MySqlDbType.String, 100) { Value = DBNull.Value } : new MySqlParameter("@UserName", MySqlDbType.String, 100) { Value = model.UserName },
				model.IPAddress == null ? new MySqlParameter("@IPAddress", MySqlDbType.String, 50) { Value = DBNull.Value } : new MySqlParameter("@IPAddress", MySqlDbType.String, 50) { Value = model.IPAddress },
				model.URL == null ? new MySqlParameter("@URL", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@URL", MySqlDbType.String, -1) { Value = model.URL },
				model.Contents == null ? new MySqlParameter("@Contents", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@Contents", MySqlDbType.String, -1) { Value = model.Contents },
				model.Others == null ? new MySqlParameter("@Others", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@Others", MySqlDbType.String, -1) { Value = model.Others },
				model.OldXml == null ? new MySqlParameter("@OldXml", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@OldXml", MySqlDbType.String, -1) { Value = model.OldXml },
				model.NewXml == null ? new MySqlParameter("@NewXml", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@NewXml", MySqlDbType.String, -1) { Value = model.NewXml }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.Log实体类</param>
        public int Update(RoadFlow.Data.Model.Log model)
        {
            string sql = @"UPDATE Log SET 
				Title=@Title,Type=@Type,WriteTime=@WriteTime,UserID=@UserID,UserName=@UserName,IPAddress=@IPAddress,URL=@URL,Contents=@Contents,Others=@Others,OldXml=@OldXml,NewXml=@NewXml
				WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@Title", MySqlDbType.String, -1){ Value = model.Title },
				new MySqlParameter("@Type", MySqlDbType.String, 100){ Value = model.Type },
				new MySqlParameter("@WriteTime", MySqlDbType.DateTime, 8){ Value = model.WriteTime },
				model.UserID == null ? new MySqlParameter("@UserID", MySqlDbType.VarChar, -1) { Value = DBNull.Value } : new MySqlParameter("@UserID", MySqlDbType.VarChar, -1) { Value = model.UserID },
				model.UserName == null ? new MySqlParameter("@UserName", MySqlDbType.String, 100) { Value = DBNull.Value } : new MySqlParameter("@UserName", MySqlDbType.String, 100) { Value = model.UserName },
				model.IPAddress == null ? new MySqlParameter("@IPAddress", MySqlDbType.String, 50) { Value = DBNull.Value } : new MySqlParameter("@IPAddress", MySqlDbType.String, 50) { Value = model.IPAddress },
				model.URL == null ? new MySqlParameter("@URL", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@URL", MySqlDbType.String, -1) { Value = model.URL },
				model.Contents == null ? new MySqlParameter("@Contents", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@Contents", MySqlDbType.String, -1) { Value = model.Contents },
				model.Others == null ? new MySqlParameter("@Others", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@Others", MySqlDbType.String, -1) { Value = model.Others },
				model.OldXml == null ? new MySqlParameter("@OldXml", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@OldXml", MySqlDbType.String, -1) { Value = model.OldXml },
				model.NewXml == null ? new MySqlParameter("@NewXml", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@NewXml", MySqlDbType.String, -1) { Value = model.NewXml },
				new MySqlParameter("@ID", MySqlDbType.VarChar, -1){ Value = model.ID }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        public int Delete(Guid id)
        {
            string sql = "DELETE FROM Log WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar){ Value = id }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 将DataRedar转换为List
        /// </summary>
        private List<RoadFlow.Data.Model.Log> DataReaderToList(MySqlDataReader dataReader)
        {
            List<RoadFlow.Data.Model.Log> List = new List<RoadFlow.Data.Model.Log>();
            RoadFlow.Data.Model.Log model = null;
            while (dataReader.Read())
            {
                model = new RoadFlow.Data.Model.Log();
                model.ID = dataReader.GetGuid(0);
                model.Title = dataReader.GetString(1);
                model.Type = dataReader.GetString(2);
                model.WriteTime = dataReader.GetDateTime(3);
                if (!dataReader.IsDBNull(4))
                    model.UserID = dataReader.GetGuid(4);
                if (!dataReader.IsDBNull(5))
                    model.UserName = dataReader.GetString(5);
                if (!dataReader.IsDBNull(6))
                    model.IPAddress = dataReader.GetString(6);
                if (!dataReader.IsDBNull(7))
                    model.URL = dataReader.GetString(7);
                if (!dataReader.IsDBNull(8))
                    model.Contents = dataReader.GetString(8);
                if (!dataReader.IsDBNull(9))
                    model.Others = dataReader.GetString(9);
                if (!dataReader.IsDBNull(10))
                    model.OldXml = dataReader.GetString(10);
                if (!dataReader.IsDBNull(11))
                    model.NewXml = dataReader.GetString(11);
                List.Add(model);
            }
            return List;
        }
        /// <summary>
        /// 查询所有记录
        /// </summary>
        public List<RoadFlow.Data.Model.Log> GetAll()
        {
            string sql = "SELECT * FROM Log";
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql);
            List<RoadFlow.Data.Model.Log> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }
        /// <summary>
        /// 查询记录数
        /// </summary>
        public long GetCount()
        {
            string sql = "SELECT COUNT(*) FROM Log";
            long count;
            return long.TryParse(dbHelper.GetFieldValue(sql), out count) ? count : 0;
        }
        /// <summary>
        /// 根据主键查询一条记录
        /// </summary>
        public RoadFlow.Data.Model.Log Get(Guid id)
        {
            string sql = "SELECT * FROM Log WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar){ Value = id }
			};
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql, parameters);
            List<RoadFlow.Data.Model.Log> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List.Count > 0 ? List[0] : null;
        }

        /// <summary>
        /// 得到一页日志数据
        /// </summary>
        /// <param name="pager"></param>
        /// <param name="query"></param>
        /// <param name="order"></param>
        /// <param name="size"></param>
        /// <param name="number"></param>
        /// <param name="title"></param>
        /// <param name="type"></param>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public DataTable GetPagerData(out string pager, string query = "", int size = 15, int number = 1, string title = "", string type = "", string date1 = "", string date2 = "", string userID = "")
        {
            StringBuilder where = new StringBuilder();
            List<MySqlParameter> parList = new List<MySqlParameter>();
            if (!title.IsNullOrEmpty())
            {
                where.Append("AND CHARINDEX(@Title,Title)>0 ");
                parList.Add(new MySqlParameter("@Title", MySqlDbType.String) { Value = title });
            }
            if (!type.IsNullOrEmpty())
            {
                where.Append("AND Type=@Type ");
                parList.Add(new MySqlParameter("@Type", MySqlDbType.String) { Value = type });
            }
            if (date1.IsDateTime())
            {
                where.Append("AND WriteTime>=@Date1 ");
                parList.Add(new MySqlParameter("@Date1", MySqlDbType.DateTime) { Value = date1.ToDateTime().ToString("yyyy-MM-dd 00:00:00") });
            }
            if (date2.IsDateTime())
            {
                where.Append("AND WriteTime<=@Date2 ");
                parList.Add(new MySqlParameter("@Date2", MySqlDbType.DateTime) { Value = date2.ToDateTime().AddDays(1).ToString("yyyy-MM-dd 00:00:00") });
            }
            if (userID.IsGuid())
            {
                where.Append("AND UserID=@UserID ");
                parList.Add(new MySqlParameter("@UserID", MySqlDbType.VarChar) { Value = userID.ToGuid() });
            }
            long count;
            string sql = dbHelper.GetPaerSql("Log", "ID,Title,Type,WriteTime,UserName,IPAddress", where.ToString(), "WriteTime DESC", size, number, out count, parList.ToArray());
            pager = RoadFlow.Utility.Tools.GetPagerHtml(count, size, number, query);
            return dbHelper.GetDataTable(sql.ToString(), parList.ToArray());
        }
    }
}