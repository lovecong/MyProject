using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace RoadFlow.Data.MYSQL
{
    public class UsersRole : RoadFlow.Data.Interface.IUsersRole
    {
        private DBHelper dbHelper = new DBHelper();
        /// <summary>
        /// 构造函数
        /// </summary>
        public UsersRole()
        {
        }
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.UsersRole实体类</param>
        /// <returns>操作所影响的行数</returns>
        public int Add(RoadFlow.Data.Model.UsersRole model)
        {
            string sql = @"INSERT INTO UsersRole
				(MemberID,RoleID,IsDefault) 
				VALUES(@MemberID,@RoleID,@IsDefault)";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@MemberID", MySqlDbType.VarChar, -1){ Value = model.MemberID },
				new MySqlParameter("@RoleID", MySqlDbType.VarChar, -1){ Value = model.RoleID },
				new MySqlParameter("@IsDefault", MySqlDbType.Bit, -1){ Value = model.IsDefault }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.UsersRole实体类</param>
        public int Update(RoadFlow.Data.Model.UsersRole model)
        {
            string sql = @"UPDATE UsersRole SET 
				IsDefault=@IsDefault
				WHERE MemberID=@MemberID and RoleID=@RoleID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@IsDefault", MySqlDbType.Bit, -1){ Value = model.IsDefault },
				new MySqlParameter("@MemberID", MySqlDbType.VarChar, -1){ Value = model.MemberID },
				new MySqlParameter("@RoleID", MySqlDbType.VarChar, -1){ Value = model.RoleID }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        public int Delete(Guid memberid, Guid roleid)
        {
            string sql = "DELETE FROM UsersRole WHERE MemberID=@MemberID AND RoleID=@RoleID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@MemberID", MySqlDbType.VarChar){ Value = memberid },
				new MySqlParameter("@RoleID", MySqlDbType.VarChar){ Value = roleid }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 将DataRedar转换为List
        /// </summary>
        private List<RoadFlow.Data.Model.UsersRole> DataReaderToList(MySqlDataReader dataReader)
        {
            List<RoadFlow.Data.Model.UsersRole> List = new List<RoadFlow.Data.Model.UsersRole>();
            RoadFlow.Data.Model.UsersRole model = null;
            while (dataReader.Read())
            {
                model = new RoadFlow.Data.Model.UsersRole();
                model.MemberID = dataReader.GetGuid(0);
                model.RoleID = dataReader.GetGuid(1);
                model.IsDefault = dataReader.GetBoolean(2);
                List.Add(model);
            }
            return List;
        }
        /// <summary>
        /// 查询所有记录
        /// </summary>
        public List<RoadFlow.Data.Model.UsersRole> GetAll()
        {
            string sql = "SELECT * FROM UsersRole";
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql);
            List<RoadFlow.Data.Model.UsersRole> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }
        /// <summary>
        /// 查询记录数
        /// </summary>
        public long GetCount()
        {
            string sql = "SELECT COUNT(*) FROM UsersRole";
            long count;
            return long.TryParse(dbHelper.GetFieldValue(sql), out count) ? count : 0;
        }
        /// <summary>
        /// 根据主键查询一条记录
        /// </summary>
        public RoadFlow.Data.Model.UsersRole Get(Guid memberid, Guid roleid)
        {
            string sql = "SELECT * FROM UsersRole WHERE MemberID=@MemberID AND RoleID=@RoleID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@MemberID", MySqlDbType.VarChar){ Value = memberid },
				new MySqlParameter("@RoleID", MySqlDbType.VarChar){ Value = roleid }
			};
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql, parameters);
            List<RoadFlow.Data.Model.UsersRole> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List.Count > 0 ? List[0] : null;
        }

        /// <summary>
        /// 删除一个机构所有记录
        /// </summary>
        public int DeleteByUserID(Guid userID)
        {
            string sql = "DELETE FROM UsersRole WHERE MemberID=@MemberID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@MemberID", MySqlDbType.VarChar){ Value = userID }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 删除一个角色所有记录
        /// </summary>
        public int DeleteByRoleID(Guid roleid)
        {
            string sql = "DELETE FROM UsersRole WHERE RoleID=@RoleID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@RoleID", MySqlDbType.VarChar){ Value = roleid }
			};
            return dbHelper.Execute(sql, parameters);
        }
        /// <summary>
        /// 根据一组机构ID查询记录
        /// </summary>
        public List<RoadFlow.Data.Model.UsersRole> GetByUserIDArray(Guid[] userIDArray)
        {
            string sql = "SELECT * FROM UsersRole WHERE MemberID IN(" + RoadFlow.Utility.Tools.GetSqlInString(userIDArray) + ")";
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql);
            List<RoadFlow.Data.Model.UsersRole> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }

        /// <summary>
        /// 根据人员ID查询记录
        /// </summary>
        public List<RoadFlow.Data.Model.UsersRole> GetByUserID(Guid userID)
        {
            string sql = "SELECT * FROM UsersRole WHERE MemberID=@MemberID";
            MySqlParameter[] parameters = new MySqlParameter[]{
				new MySqlParameter("@MemberID", MySqlDbType.VarChar){ Value = userID }
			};
            MySqlDataReader dataReader = dbHelper.GetDataReader(sql, parameters);

            List<RoadFlow.Data.Model.UsersRole> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }
    }
}