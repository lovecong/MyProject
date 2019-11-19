using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace RoadFlow.Data.MYSQL
{
    public class WorkFlow : RoadFlow.Data.Interface.IWorkFlow
    {
        private DBHelper dbHelper = new DBHelper();
        /// <summary>
        /// 构造函数
        /// </summary>
        public WorkFlow()
        {
        }
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.WorkFlow实体类</param>
        /// <returns>操作所影响的行数</returns>
        public int Add(RoadFlow.Data.Model.WorkFlow model)
        {
            string sql = @"INSERT INTO WorkFlow
				(ID,Name,Type,Manager,InstanceManager,CreateDate,CreateUserID,DesignJSON,InstallDate,InstallUserID,RunJSON,Status) 
				VALUES(@ID,@Name,@Type,@Manager,@InstanceManager,@CreateDate,@CreateUserID,@DesignJSON,@InstallDate,@InstallUserID,@RunJSON,@Status)";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar, -1){ Value = model.ID },
				new MySqlParameter("@Name", MySqlDbType.String, 1000){ Value = model.Name },
				new MySqlParameter("@Type", MySqlDbType.VarChar, -1){ Value = model.Type },
				new MySqlParameter("@Manager", MySqlDbType.String, 5000){ Value = model.Manager },
				new MySqlParameter("@InstanceManager", MySqlDbType.String, 5000){ Value = model.InstanceManager },
				new MySqlParameter("@CreateDate", MySqlDbType.DateTime, 8){ Value = model.CreateDate },
				new MySqlParameter("@CreateUserID", MySqlDbType.VarChar, -1){ Value = model.CreateUserID },
				model.DesignJSON == null ? new MySqlParameter("@DesignJSON", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@DesignJSON", MySqlDbType.String, -1) { Value = model.DesignJSON },
				model.InstallDate == null ? new MySqlParameter("@InstallDate", MySqlDbType.DateTime, 8) { Value = DBNull.Value } : new MySqlParameter("@InstallDate", MySqlDbType.DateTime, 8) { Value = model.InstallDate },
				model.InstallUserID == null ? new MySqlParameter("@InstallUserID", MySqlDbType.VarChar, -1) { Value = DBNull.Value } : new MySqlParameter("@InstallUserID", MySqlDbType.VarChar, -1) { Value = model.InstallUserID },
				model.RunJSON == null ? new MySqlParameter("@RunJSON", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@RunJSON", MySqlDbType.String, -1) { Value = model.RunJSON },
				new MySqlParameter("@Status", MySqlDbType.Int32, -1){ Value = model.Status }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.WorkFlow实体类</param>
        public int Update(RoadFlow.Data.Model.WorkFlow model)
        {
            string sql = @"UPDATE WorkFlow SET 
				Name=@Name,Type=@Type,Manager=@Manager,InstanceManager=@InstanceManager,CreateDate=@CreateDate,CreateUserID=@CreateUserID,DesignJSON=@DesignJSON,InstallDate=@InstallDate,InstallUserID=@InstallUserID,RunJSON=@RunJSON,Status=@Status
				WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@Name", MySqlDbType.String, 1000){ Value = model.Name },
				new MySqlParameter("@Type", MySqlDbType.VarChar, -1){ Value = model.Type },
				new MySqlParameter("@Manager", MySqlDbType.String, 5000){ Value = model.Manager },
				new MySqlParameter("@InstanceManager", MySqlDbType.String, 5000){ Value = model.InstanceManager },
				new MySqlParameter("@CreateDate", MySqlDbType.DateTime, 8){ Value = model.CreateDate },
				new MySqlParameter("@CreateUserID", MySqlDbType.VarChar, -1){ Value = model.CreateUserID },
				model.DesignJSON == null ? new MySqlParameter("@DesignJSON", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@DesignJSON", MySqlDbType.String, -1) { Value = model.DesignJSON },
				model.InstallDate == null ? new MySqlParameter("@InstallDate", MySqlDbType.DateTime, 8) { Value = DBNull.Value } : new MySqlParameter("@InstallDate", MySqlDbType.DateTime, 8) { Value = model.InstallDate },
				model.InstallUserID == null ? new MySqlParameter("@InstallUserID", MySqlDbType.VarChar, -1) { Value = DBNull.Value } : new MySqlParameter("@InstallUserID", MySqlDbType.VarChar, -1) { Value = model.InstallUserID },
				model.RunJSON == null ? new MySqlParameter("@RunJSON", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@RunJSON", MySqlDbType.String, -1) { Value = model.RunJSON },
				new MySqlParameter("@Status", MySqlDbType.Int32, -1){ Value = model.Status },
				new MySqlParameter("@ID", MySqlDbType.VarChar, -1){ Value = model.ID }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        public int Delete(Guid id)
        {
            string sql = "DELETE FROM WorkFlow WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar){ Value = id }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 将DataRedar转换为List
        /// </summary>
        private List<RoadFlow.Data.Model.WorkFlow> DataReaderToList(MySqlDataReader dataReader)
        {
            List<RoadFlow.Data.Model.WorkFlow> List = new List<RoadFlow.Data.Model.WorkFlow>();
            RoadFlow.Data.Model.WorkFlow model = null;
            while (dataReader.Read())
            {
                model = new RoadFlow.Data.Model.WorkFlow();
                model.ID = dataReader.GetGuid(0);
                model.Name = dataReader.GetString(1);
                model.Type = dataReader.GetGuid(2);
                model.Manager = dataReader.GetString(3);
                model.InstanceManager = dataReader.GetString(4);
                model.CreateDate = dataReader.GetDateTime(5);
                model.CreateUserID = dataReader.GetGuid(6);
                if (!dataReader.IsDBNull(7))
                    model.DesignJSON = dataReader.GetString(7);
                if (!dataReader.IsDBNull(8))
                    model.InstallDate = dataReader.GetDateTime(8);
                if (!dataReader.IsDBNull(9))
                    model.InstallUserID = dataReader.GetGuid(9);
                if (!dataReader.IsDBNull(10))
                    model.RunJSON = dataReader.GetString(10);
                model.Status = dataReader.GetInt32(11);
                List.Add(model);
            }
            return List;
        }
        /// <summary>
        /// 查询所有记录
        /// </summary>
        public List<RoadFlow.Data.Model.WorkFlow> GetAll()
        {
            string sql = "SELECT * FROM WorkFlow";
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql);
            List<RoadFlow.Data.Model.WorkFlow> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }
        /// <summary>
        /// 查询记录数
        /// </summary>
        public long GetCount()
        {
            string sql = "SELECT COUNT(*) FROM WorkFlow";
            long count;
            return long.TryParse(dbHelper.GetFieldValue(sql), out count) ? count : 0;
        }
        /// <summary>
        /// 根据主键查询一条记录
        /// </summary>
        public RoadFlow.Data.Model.WorkFlow Get(Guid id)
        {
            string sql = "SELECT * FROM WorkFlow WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar){ Value = id }
			};
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql, parameters);
            List<RoadFlow.Data.Model.WorkFlow> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List.Count > 0 ? List[0] : null;
        }


        /// <summary>
        /// 查询所有类型
        /// </summary>
        public List<string> GetAllTypes()
        {
            string sql = "SELECT Type FROM WorkFlow GROUP BY Type";
            List<string> list = new List<string>();
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql);
            while (dataReader.Read())
            {
                list.Add(dataReader.GetString(0));
            }
            dataReader.Close();
            return list;
        }

        /// <summary>
        /// 查询所有ID和名称
        /// </summary>
        public Dictionary<Guid, string> GetAllIDAndName()
        {
            string sql = "SELECT ID,Name FROM WorkFlow WHERE Status<4 ORDER BY Name";
            Dictionary<Guid, string> dict = new Dictionary<Guid, string>();
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql);
            while (dataReader.Read())
            {
                dict.Add(dataReader.GetGuid(0), dataReader.GetString(1));
            }
            dataReader.Close();
            return dict;
        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        public List<RoadFlow.Data.Model.WorkFlow> GetByTypes(string typeString)
        {
            string sql = "SELECT * FROM WorkFlow where Type IN(" + RoadFlow.Utility.Tools.GetSqlInString(typeString) + ")";
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql);
            List<RoadFlow.Data.Model.WorkFlow> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }
    }
}