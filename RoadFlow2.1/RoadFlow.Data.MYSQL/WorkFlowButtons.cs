using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace RoadFlow.Data.MYSQL
{
    public class WorkFlowButtons : RoadFlow.Data.Interface.IWorkFlowButtons
    {
        private DBHelper dbHelper = new DBHelper();
        /// <summary>
        /// 构造函数
        /// </summary>
        public WorkFlowButtons()
        {
        }
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.WorkFlowButtons实体类</param>
        /// <returns>操作所影响的行数</returns>
        public int Add(RoadFlow.Data.Model.WorkFlowButtons model)
        {
            string sql = @"INSERT INTO WorkFlowButtons
				(ID,Title,Ico,Script,Note,Sort) 
				VALUES(@ID,@Title,@Ico,@Script,@Note,@Sort)";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar, -1){ Value = model.ID },
				new MySqlParameter("@Title", MySqlDbType.String, 1000){ Value = model.Title },
				model.Ico == null ? new MySqlParameter("@Ico", MySqlDbType.String, 500) { Value = DBNull.Value } : new MySqlParameter("@Ico", MySqlDbType.String, 500) { Value = model.Ico },
				model.Script == null ? new MySqlParameter("@Script", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@Script", MySqlDbType.String, -1) { Value = model.Script },
				model.Note == null ? new MySqlParameter("@Note", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@Note", MySqlDbType.String, -1) { Value = model.Note },
				new MySqlParameter("@Sort", MySqlDbType.Int32, -1){ Value = model.Sort }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.WorkFlowButtons实体类</param>
        public int Update(RoadFlow.Data.Model.WorkFlowButtons model)
        {
            string sql = @"UPDATE WorkFlowButtons SET 
				Title=@Title,Ico=@Ico,Script=@Script,Note=@Note,Sort=@Sort
				WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@Title", MySqlDbType.String, 1000){ Value = model.Title },
				model.Ico == null ? new MySqlParameter("@Ico", MySqlDbType.String, 500) { Value = DBNull.Value } : new MySqlParameter("@Ico", MySqlDbType.String, 500) { Value = model.Ico },
				model.Script == null ? new MySqlParameter("@Script", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@Script", MySqlDbType.String, -1) { Value = model.Script },
				model.Note == null ? new MySqlParameter("@Note", MySqlDbType.String, -1) { Value = DBNull.Value } : new MySqlParameter("@Note", MySqlDbType.String, -1) { Value = model.Note },
				new MySqlParameter("@Sort", MySqlDbType.Int32, -1){ Value = model.Sort },
				new MySqlParameter("@ID", MySqlDbType.VarChar, -1){ Value = model.ID }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        public int Delete(Guid id)
        {
            string sql = "DELETE FROM WorkFlowButtons WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar){ Value = id }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 将DataRedar转换为List
        /// </summary>
        private List<RoadFlow.Data.Model.WorkFlowButtons> DataReaderToList(MySqlDataReader dataReader)
        {
            List<RoadFlow.Data.Model.WorkFlowButtons> List = new List<RoadFlow.Data.Model.WorkFlowButtons>();
            RoadFlow.Data.Model.WorkFlowButtons model = null;
            while (dataReader.Read())
            {
                model = new RoadFlow.Data.Model.WorkFlowButtons();
                model.ID = dataReader.GetGuid(0);
                model.Title = dataReader.GetString(1);
                if (!dataReader.IsDBNull(2))
                    model.Ico = dataReader.GetString(2);
                if (!dataReader.IsDBNull(3))
                    model.Script = dataReader.GetString(3);
                if (!dataReader.IsDBNull(4))
                    model.Note = dataReader.GetString(4);
                model.Sort = dataReader.GetInt32(5);
                List.Add(model);
            }
            return List;
        }
        /// <summary>
        /// 查询所有记录
        /// </summary>
        public List<RoadFlow.Data.Model.WorkFlowButtons> GetAll()
        {
            string sql = "SELECT * FROM WorkFlowButtons";
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql);
            List<RoadFlow.Data.Model.WorkFlowButtons> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }
        /// <summary>
        /// 查询记录数
        /// </summary>
        public long GetCount()
        {
            string sql = "SELECT COUNT(*) FROM WorkFlowButtons";
            long count;
            return long.TryParse(dbHelper.GetFieldValue(sql), out count) ? count : 0;
        }
        /// <summary>
        /// 根据主键查询一条记录
        /// </summary>
        public RoadFlow.Data.Model.WorkFlowButtons Get(Guid id)
        {
            string sql = "SELECT * FROM WorkFlowButtons WHERE ID=@ID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@ID", MySqlDbType.VarChar){ Value = id }
			};
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql, parameters);
            List<RoadFlow.Data.Model.WorkFlowButtons> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List.Count > 0 ? List[0] : null;
        }

        /// <summary>
        /// 查询最大排序
        /// </summary>
        public int GetMaxSort()
        {
            string sql = "SELECT GetMaxSort(MAX(Sort),0)+1 FROM WorkFlowButtons";
            string max = dbHelper.GetFieldValue(sql);
            return max.IsInt() ? max.ToInt() : 1;
        }
    }
}