using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace RoadFlow.Data.MYSQL
{
    public class WorkFlowForm : RoadFlow.Data.Interface.IWorkFlowForm
    {
        private DBHelper dbHelper = new DBHelper();
        /// <summary>
        /// 构造函数
        /// </summary>
        public WorkFlowForm()
        {
        }
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.WorkFlowForm实体类</param>
        /// <returns>操作所影响的行数</returns>
        public int Add(RoadFlow.Data.Model.WorkFlowForm model)
        {
            string sql = @"INSERT INTO WorkFlowForm
				(ID,Name,Type,CreateUserID,CreateUserName,CreateTime,LastModifyTime,Html,SubTableJson,EventsJson,Attribute,Status) 
				VALUES(@ID,@Name,@Type,@CreateUserID,@CreateUserName,@CreateTime,@LastModifyTime,@Html,@SubTableJson,@EventsJson,@Attribute,@Status)";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar, -1){ Value = model.ID },
				new MySqlParameter("@Name", MySqlDbType.String, 1000){ Value = model.Name },
				new MySqlParameter("@Type", MySqlDbType.VarChar, -1){ Value = model.Type },
				new MySqlParameter("@CreateUserID", MySqlDbType.VarChar, -1){ Value = model.CreateUserID },
				new MySqlParameter("@CreateUserName", MySqlDbType.String, 100){ Value = model.CreateUserName },
				new MySqlParameter("@CreateTime", MySqlDbType.DateTime, 8){ Value = model.CreateTime },
				new MySqlParameter("@LastModifyTime", MySqlDbType.DateTime, 8){ Value = model.LastModifyTime },
				model.Html == null ? new MySqlParameter("@Html", MySqlDbType.Text, -1) { Value = DBNull.Value } : new MySqlParameter("@Html", MySqlDbType.Text, -1) { Value = model.Html },
				model.SubTableJson == null ? new MySqlParameter("@SubTableJson", MySqlDbType.Text, -1) { Value = DBNull.Value } : new MySqlParameter("@SubTableJson", MySqlDbType.Text, -1) { Value = model.SubTableJson },
				model.EventsJson == null ? new MySqlParameter("@EventsJson", MySqlDbType.Text, -1) { Value = DBNull.Value } : new MySqlParameter("@EventsJson", MySqlDbType.Text, -1) { Value = model.EventsJson },
				model.Attribute == null ? new MySqlParameter("@Attribute", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@Attribute", MySqlDbType.String, -1) { Value = model.Attribute },
				new MySqlParameter("@Status", MySqlDbType.Int32, -1){ Value = model.Status }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.WorkFlowForm实体类</param>
        public int Update(RoadFlow.Data.Model.WorkFlowForm model)
        {
            string sql = @"UPDATE WorkFlowForm SET 
				Name=@Name,Type=@Type,CreateUserID=@CreateUserID,CreateUserName=@CreateUserName,CreateTime=@CreateTime,LastModifyTime=@LastModifyTime,Html=@Html,SubTableJson=@SubTableJson,EventsJson=@EventsJson,Attribute=@Attribute,Status=@Status
				WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@Name", MySqlDbType.String, 1000){ Value = model.Name },
				new MySqlParameter("@Type", MySqlDbType.VarChar, -1){ Value = model.Type },
				new MySqlParameter("@CreateUserID", MySqlDbType.VarChar, -1){ Value = model.CreateUserID },
				new MySqlParameter("@CreateUserName", MySqlDbType.String, 100){ Value = model.CreateUserName },
				new MySqlParameter("@CreateTime", MySqlDbType.DateTime, 8){ Value = model.CreateTime },
				new MySqlParameter("@LastModifyTime", MySqlDbType.DateTime, 8){ Value = model.LastModifyTime },
				model.Html == null ? new MySqlParameter("@Html", MySqlDbType.Text, -1) { Value = DBNull.Value } : new MySqlParameter("@Html", MySqlDbType.Text, -1) { Value = model.Html },
				model.SubTableJson == null ? new MySqlParameter("@SubTableJson", MySqlDbType.Text, -1) { Value = DBNull.Value } : new MySqlParameter("@SubTableJson", MySqlDbType.Text, -1) { Value = model.SubTableJson },
				model.EventsJson == null ? new MySqlParameter("@EventsJson", MySqlDbType.Text, -1) { Value = DBNull.Value } : new MySqlParameter("@EventsJson", MySqlDbType.Text, -1) { Value = model.EventsJson },
				model.Attribute == null ? new MySqlParameter("@Attribute", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@Attribute", MySqlDbType.String, -1) { Value = model.Attribute },
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
            string sql = "DELETE FROM WorkFlowForm WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar){ Value = id }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 将DataRedar转换为List
        /// </summary>
        private List<RoadFlow.Data.Model.WorkFlowForm> DataReaderToList(MySqlDataReader dataReader)
        {
            List<RoadFlow.Data.Model.WorkFlowForm> List = new List<RoadFlow.Data.Model.WorkFlowForm>();
            RoadFlow.Data.Model.WorkFlowForm model = null;
            while (dataReader.Read())
            {
                model = new RoadFlow.Data.Model.WorkFlowForm();
                model.ID = dataReader.GetGuid(0);
                model.Name = dataReader.GetString(1);
                model.Type = dataReader.GetGuid(2);
                model.CreateUserID = dataReader.GetGuid(3);
                model.CreateUserName = dataReader.GetString(4);
                model.CreateTime = dataReader.GetDateTime(5);
                model.LastModifyTime = dataReader.GetDateTime(6);
                if (!dataReader.IsDBNull(7))
                    model.Html = dataReader.GetString(7);
                if (!dataReader.IsDBNull(8))
                    model.SubTableJson = dataReader.GetString(8);
                if (!dataReader.IsDBNull(9))
                    model.EventsJson = dataReader.GetString(9);
                if (!dataReader.IsDBNull(10))
                    model.Attribute = dataReader.GetString(10);
                model.Status = dataReader.GetInt32(11);
                List.Add(model);
            }
            return List;
        }
        /// <summary>
        /// 查询所有记录
        /// </summary>
        public List<RoadFlow.Data.Model.WorkFlowForm> GetAll()
        {
            string sql = "SELECT * FROM WorkFlowForm";
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql);
            List<RoadFlow.Data.Model.WorkFlowForm> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }
        /// <summary>
        /// 查询记录数
        /// </summary>
        public long GetCount()
        {
            string sql = "SELECT COUNT(*) FROM WorkFlowForm";
            long count;
            return long.TryParse(dbHelper.GetFieldValue(sql), out count) ? count : 0;
        }
        /// <summary>
        /// 根据主键查询一条记录
        /// </summary>
        public RoadFlow.Data.Model.WorkFlowForm Get(Guid id)
        {
            string sql = "SELECT * FROM WorkFlowForm WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar){ Value = id }
			};
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql, parameters);
            List<RoadFlow.Data.Model.WorkFlowForm> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List.Count > 0 ? List[0] : null;
        }



        /// <summary>
        /// 查询一个分类所有记录
        /// </summary>
        public List<RoadFlow.Data.Model.WorkFlowForm> GetAllByType(string types)
        {
            string sql = "SELECT * FROM WorkFlowForm where Type IN(" + RoadFlow.Utility.Tools.GetSqlInString(types) + ")";
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql);
            List<RoadFlow.Data.Model.WorkFlowForm> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }
    }
}