using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace RoadFlow.Data.MYSQL
{
    public class WorkFlowDelegation : RoadFlow.Data.Interface.IWorkFlowDelegation
    {
        private DBHelper dbHelper = new DBHelper();
        /// <summary>
        /// 构造函数
        /// </summary>
        public WorkFlowDelegation()
        {
        }
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.WorkFlowDelegation实体类</param>
        /// <returns>操作所影响的行数</returns>
        public int Add(RoadFlow.Data.Model.WorkFlowDelegation model)
        {
            string sql = @"INSERT INTO WorkFlowDelegation
				(ID,UserID,StartTime,EndTime,FlowID,ToUserID,WriteTime,Note) 
				VALUES(@ID,@UserID,@StartTime,@EndTime,@FlowID,@ToUserID,@WriteTime,@Note)";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar, -1){ Value = model.ID },
				new MySqlParameter("@UserID", MySqlDbType.VarChar, -1){ Value = model.UserID },
				new MySqlParameter("@StartTime", MySqlDbType.DateTime, 8){ Value = model.StartTime },
				new MySqlParameter("@EndTime", MySqlDbType.DateTime, 8){ Value = model.EndTime },
				model.FlowID == null ? new MySqlParameter("@FlowID", MySqlDbType.VarChar, -1) { Value = DBNull.Value } : new MySqlParameter("@FlowID", MySqlDbType.VarChar, -1) { Value = model.FlowID },
				new MySqlParameter("@ToUserID", MySqlDbType.VarChar, -1){ Value = model.ToUserID },
				new MySqlParameter("@WriteTime", MySqlDbType.DateTime, 8){ Value = model.WriteTime },
				model.Note == null ? new MySqlParameter("@Note", MySqlDbType.String, 8000) { Value = DBNull.Value } : new MySqlParameter("@Note", MySqlDbType.String, 8000) { Value = model.Note }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.WorkFlowDelegation实体类</param>
        public int Update(RoadFlow.Data.Model.WorkFlowDelegation model)
        {
            string sql = @"UPDATE WorkFlowDelegation SET 
				UserID=@UserID,StartTime=@StartTime,EndTime=@EndTime,FlowID=@FlowID,ToUserID=@ToUserID,WriteTime=@WriteTime,Note=@Note
				WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@UserID", MySqlDbType.VarChar, -1){ Value = model.UserID },
				new MySqlParameter("@StartTime", MySqlDbType.DateTime, 8){ Value = model.StartTime },
				new MySqlParameter("@EndTime", MySqlDbType.DateTime, 8){ Value = model.EndTime },
				model.FlowID == null ? new MySqlParameter("@FlowID", MySqlDbType.VarChar, -1) { Value = DBNull.Value } : new MySqlParameter("@FlowID", MySqlDbType.VarChar, -1) { Value = model.FlowID },
				new MySqlParameter("@ToUserID", MySqlDbType.VarChar, -1){ Value = model.ToUserID },
				new MySqlParameter("@WriteTime", MySqlDbType.DateTime, 8){ Value = model.WriteTime },
				model.Note == null ? new MySqlParameter("@Note", MySqlDbType.String, 8000) { Value = DBNull.Value } : new MySqlParameter("@Note", MySqlDbType.String, 8000) { Value = model.Note },
				new MySqlParameter("@ID", MySqlDbType.VarChar, -1){ Value = model.ID }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        public int Delete(Guid id)
        {
            string sql = "DELETE FROM WorkFlowDelegation WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar){ Value = id }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 将DataRedar转换为List
        /// </summary>
        private List<RoadFlow.Data.Model.WorkFlowDelegation> DataReaderToList(MySqlDataReader dataReader)
        {
            List<RoadFlow.Data.Model.WorkFlowDelegation> List = new List<RoadFlow.Data.Model.WorkFlowDelegation>();
            RoadFlow.Data.Model.WorkFlowDelegation model = null;
            while (dataReader.Read())
            {
                model = new RoadFlow.Data.Model.WorkFlowDelegation();
                model.ID = dataReader.GetGuid(0);
                model.UserID = dataReader.GetGuid(1);
                model.StartTime = dataReader.GetDateTime(2);
                model.EndTime = dataReader.GetDateTime(3);
                if (!dataReader.IsDBNull(4))
                    model.FlowID = dataReader.GetGuid(4);
                model.ToUserID = dataReader.GetGuid(5);
                model.WriteTime = dataReader.GetDateTime(6);
                if (!dataReader.IsDBNull(7))
                    model.Note = dataReader.GetString(7);
                List.Add(model);
            }
            return List;
        }
        /// <summary>
        /// 查询所有记录
        /// </summary>
        public List<RoadFlow.Data.Model.WorkFlowDelegation> GetAll()
        {
            string sql = "SELECT * FROM WorkFlowDelegation";
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql);
            List<RoadFlow.Data.Model.WorkFlowDelegation> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }
        /// <summary>
        /// 查询记录数
        /// </summary>
        public long GetCount()
        {
            string sql = "SELECT COUNT(*) FROM WorkFlowDelegation";
            long count;
            return long.TryParse(dbHelper.GetFieldValue(sql), out count) ? count : 0;
        }
        /// <summary>
        /// 根据主键查询一条记录
        /// </summary>
        public RoadFlow.Data.Model.WorkFlowDelegation Get(Guid id)
        {
            string sql = "SELECT * FROM WorkFlowDelegation WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar){ Value = id }
			};
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql, parameters);
            List<RoadFlow.Data.Model.WorkFlowDelegation> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List.Count > 0 ? List[0] : null;
        }

        /// <summary>
        /// 查询一个用户所有记录
        /// </summary>
        public List<RoadFlow.Data.Model.WorkFlowDelegation> GetByUserID(Guid userID)
        {
            string sql = "SELECT * FROM WorkFlowDelegation WHERE UserID=@UserID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@UserID", MySqlDbType.VarChar){ Value = userID }
			};
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql, parameters);
            List<RoadFlow.Data.Model.WorkFlowDelegation> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }

        /// <summary>
        /// 得到一页数据
        /// </summary>
        /// <param name="pager"></param>
        /// <param name="query"></param>
        /// <param name="userID"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public List<RoadFlow.Data.Model.WorkFlowDelegation> GetPagerData(out string pager, string query = "", string userID="", string startTime = "", string endTime = "")
        {
            StringBuilder WHERE = new StringBuilder();
            List<MySqlParameter> parList = new List<MySqlParameter>();

            if (userID.IsGuid())
            {
                WHERE.Append("AND UserID=@UserID ");
                parList.Add(new MySqlParameter("@UserID", MySqlDbType.VarChar) { Value = userID.ToGuid() });
            }
            if (startTime.IsDateTime())
            {
                WHERE.Append("AND StartTime>=@StartTime ");
                parList.Add(new MySqlParameter("@StartTime", MySqlDbType.DateTime) { Value = startTime.ToDateTime().ToString("yyyy-MM-dd").ToDateTime() });
            }
            if (endTime.IsDateTime())
            {
                WHERE.Append("AND EndTime<=@EndTime ");
                parList.Add(new MySqlParameter("@EndTime", MySqlDbType.DateTime) { Value = endTime.ToDateTime().AddDays(1).ToString("yyyy-MM-dd").ToDateTime() });
            }
            long count;
            int pageSize=RoadFlow.Utility.Tools.GetPageSize();
            int pageNumber=RoadFlow.Utility.Tools.GetPageNumber();
            string sql = dbHelper.GetPaerSql("WorkFlowDelegation", "*", WHERE.ToString(), "WriteTime Desc", pageSize, pageNumber, out count, parList.ToArray());

            pager = RoadFlow.Utility.Tools.GetPagerHtml(count, pageSize, pageNumber, query);
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql, parList.ToArray());
            List<RoadFlow.Data.Model.WorkFlowDelegation> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }

        /// <summary>
        /// 得到未过期的委托
        /// </summary>
        public List<RoadFlow.Data.Model.WorkFlowDelegation> GetNoExpiredList()
        {
            string sql = "SELECT * FROM WorkFlowDelegation WHERE EndTime>=@EndTime";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@EndTime", MySqlDbType.DateTime){ Value = RoadFlow.Utility.DateTimeNew.Now }
			};
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql, parameters);
            List<RoadFlow.Data.Model.WorkFlowDelegation> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }
    }
}