using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace RoadFlow.Data.MYSQL
{
    public class UsersRelation : RoadFlow.Data.Interface.IUsersRelation
    {
        private DBHelper dbHelper = new DBHelper();
        /// <summary>
        /// 构造函数
        /// </summary>
        public UsersRelation()
        {
        }
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.UsersRelation实体类</param>
        /// <returns>操作所影响的行数</returns>
        public int Add(RoadFlow.Data.Model.UsersRelation model)
        {
            string sql = @"INSERT INTO UsersRelation
				(UserID,OrganizeID,IsMain,Sort) 
				VALUES(@UserID,@OrganizeID,@IsMain,@Sort)";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@UserID", MySqlDbType.VarChar, -1){ Value = model.UserID },
				new MySqlParameter("@OrganizeID", MySqlDbType.VarChar, -1){ Value = model.OrganizeID },
				new MySqlParameter("@IsMain", MySqlDbType.Int32, -1){ Value = model.IsMain },
				new MySqlParameter("@Sort", MySqlDbType.Int32, -1){ Value = model.Sort }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.UsersRelation实体类</param>
        public int Update(RoadFlow.Data.Model.UsersRelation model)
        {
            string sql = @"UPDATE UsersRelation SET 
				IsMain=@IsMain,Sort=@Sort
				WHERE UserID=@UserID and OrganizeID=@OrganizeID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@IsMain", MySqlDbType.Int32, -1){ Value = model.IsMain },
				new MySqlParameter("@Sort", MySqlDbType.Int32, -1){ Value = model.Sort },
				new MySqlParameter("@UserID", MySqlDbType.VarChar, -1){ Value = model.UserID },
				new MySqlParameter("@OrganizeID", MySqlDbType.VarChar, -1){ Value = model.OrganizeID }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        public int Delete(Guid userid, Guid organizeid)
        {
            string sql = "DELETE FROM UsersRelation WHERE UserID=@UserID AND OrganizeID=@OrganizeID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@UserID", MySqlDbType.VarChar){ Value = userid },
				new MySqlParameter("@OrganizeID", MySqlDbType.VarChar){ Value = organizeid }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 将DataRedar转换为List
        /// </summary>
        private List<RoadFlow.Data.Model.UsersRelation> DataReaderToList(MySqlDataReader dataReader)
        {
            List<RoadFlow.Data.Model.UsersRelation> List = new List<RoadFlow.Data.Model.UsersRelation>();
            RoadFlow.Data.Model.UsersRelation model = null;
            while (dataReader.Read())
            {
                model = new RoadFlow.Data.Model.UsersRelation();
                model.UserID = dataReader.GetGuid(0);
                model.OrganizeID = dataReader.GetGuid(1);
                model.IsMain = dataReader.GetInt32(2);
                model.Sort = dataReader.GetInt32(3);
                List.Add(model);
            }
            return List;
        }
        /// <summary>
        /// 查询所有记录
        /// </summary>
        public List<RoadFlow.Data.Model.UsersRelation> GetAll()
        {
            string sql = "SELECT * FROM UsersRelation";
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql);
            List<RoadFlow.Data.Model.UsersRelation> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }
        /// <summary>
        /// 查询记录数
        /// </summary>
        public long GetCount()
        {
            string sql = "SELECT COUNT(*) FROM UsersRelation";
            long count;
            return long.TryParse(dbHelper.GetFieldValue(sql), out count) ? count : 0;
        }
        /// <summary>
        /// 根据主键查询一条记录
        /// </summary>
        public RoadFlow.Data.Model.UsersRelation Get(Guid userid, Guid organizeid)
        {
            string sql = "SELECT * FROM UsersRelation WHERE UserID=@UserID AND OrganizeID=@OrganizeID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@UserID", MySqlDbType.VarChar){ Value = userid },
				new MySqlParameter("@OrganizeID", MySqlDbType.VarChar){ Value = organizeid }
			};
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql, parameters);
            List<RoadFlow.Data.Model.UsersRelation> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List.Count > 0 ? List[0] : null;
        }

        /// <summary>
        /// 查询一个岗位下所有记录
        /// </summary>
        public List<RoadFlow.Data.Model.UsersRelation> GetAllByOrganizeID(Guid organizeID)
        {
            string sql = "SELECT * FROM UsersRelation WHERE OrganizeID=@OrganizeID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@OrganizeID", MySqlDbType.VarChar){ Value = organizeID }
			};
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql, parameters);
            List<RoadFlow.Data.Model.UsersRelation> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }

        /// <summary>
        /// 查询一个用户所有记录
        /// </summary>
        public List<RoadFlow.Data.Model.UsersRelation> GetAllByUserID(Guid userID)
        {
            string sql = "SELECT * FROM UsersRelation WHERE UserID=@UserID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@UserID", MySqlDbType.VarChar){ Value = userID }
			};
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql, parameters);
            List<RoadFlow.Data.Model.UsersRelation> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }

        /// <summary>
        /// 查询一个用户主要岗位
        /// </summary>
        public RoadFlow.Data.Model.UsersRelation GetMainByUserID(Guid userID)
        {
            string sql = "SELECT * FROM UsersRelation WHERE UserID=@UserID AND IsMain=1";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@UserID", MySqlDbType.VarChar){ Value = userID }
			};
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql, parameters);
            List<RoadFlow.Data.Model.UsersRelation> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List.Count > 0 ? List[0] : null;
        }


        /// <summary>
        /// 删除一个用户记录
        /// </summary>
        public int DeleteByUserID(Guid userID)
        {
            string sql = "DELETE FROM UsersRelation WHERE UserID=@UserID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@UserID", MySqlDbType.VarChar){ Value = userID }
			};
            return dbHelper.Execute(sql, parameters);
        }

        /// <summary>
        /// 删除一个用户的兼职记录
        /// </summary>
        public int DeleteNotIsMainByUserID(Guid userID)
        {
            string sql = "DELETE FROM UsersRelation WHERE IsMain=0 AND UserID=@UserID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@UserID", MySqlDbType.VarChar){ Value = userID }
			};
            return dbHelper.Execute(sql, parameters);
        }

        /// <summary>
        /// 删除一个机构下所有记录
        /// </summary>
        public int DeleteByOrganizeID(Guid organizeID)
        {
            string sql = "DELETE FROM UsersRelation WHERE OrganizeID=@OrganizeID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@OrganizeID", MySqlDbType.VarChar){ Value = organizeID }
			};
            return dbHelper.Execute(sql, parameters);
        }

        /// <summary>
        /// 得到最大排序值
        /// </summary>
        /// <returns></returns>
        public int GetMaxSort(Guid organizeID)
        {
            string sql = "SELECT IFNULL(MAX(Sort),0)+1 FROM UsersRelation WHERE OrganizeID=@OrganizeID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@OrganizeID", MySqlDbType.VarChar){ Value = organizeID }
			};
            DBHelper dbHelper = new DBHelper();
            string sort = dbHelper.GetFieldValue(sql, parameters);
            return sort.ToInt();
        }
    }
}