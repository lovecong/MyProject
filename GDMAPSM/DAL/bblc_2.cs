using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GDMAPSM.DAL
{
	/// <summary>
	/// 数据访问类:bblc_2
	/// </summary>
	public partial class bblc_2
	{
		public bblc_2()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("ID", "bblc_2"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from bblc_2");
			strSql.Append(" where ID=@ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32)
			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(GDMAPSM.Model.bblc_2 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into bblc_2(");
			strSql.Append("GUID,LX,PCBH,YPSN,BZ,BLSJ)");
			strSql.Append(" values (");
			strSql.Append("@GUID,@LX,@PCBH,@YPSN,@BZ,@BLSJ)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@GUID", MySqlDbType.VarChar,50),
					new MySqlParameter("@LX", MySqlDbType.VarChar,10),
					new MySqlParameter("@PCBH", MySqlDbType.VarChar,10),
					new MySqlParameter("@YPSN", MySqlDbType.VarChar,255),
					new MySqlParameter("@BZ", MySqlDbType.Text),
					new MySqlParameter("@BLSJ", MySqlDbType.Date)};
			parameters[0].Value = model.GUID;
			parameters[1].Value = model.LX;
			parameters[2].Value = model.PCBH;
			parameters[3].Value = model.YPSN;
			parameters[4].Value = model.BZ;
			parameters[5].Value = model.BLSJ;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(GDMAPSM.Model.bblc_2 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update bblc_2 set ");
			strSql.Append("GUID=@GUID,");
			strSql.Append("LX=@LX,");
			strSql.Append("PCBH=@PCBH,");
			strSql.Append("YPSN=@YPSN,");
			strSql.Append("BZ=@BZ,");
			strSql.Append("BLSJ=@BLSJ");
			strSql.Append(" where ID=@ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@GUID", MySqlDbType.VarChar,50),
					new MySqlParameter("@LX", MySqlDbType.VarChar,10),
					new MySqlParameter("@PCBH", MySqlDbType.VarChar,10),
					new MySqlParameter("@YPSN", MySqlDbType.VarChar,255),
					new MySqlParameter("@BZ", MySqlDbType.Text),
					new MySqlParameter("@BLSJ", MySqlDbType.Date),
					new MySqlParameter("@ID", MySqlDbType.Int32,11)};
			parameters[0].Value = model.GUID;
			parameters[1].Value = model.LX;
			parameters[2].Value = model.PCBH;
			parameters[3].Value = model.YPSN;
			parameters[4].Value = model.BZ;
			parameters[5].Value = model.BLSJ;
			parameters[6].Value = model.ID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from bblc_2 ");
			strSql.Append(" where ID=@ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32)
			};
			parameters[0].Value = ID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
        /// <summary>
        /// 根据电脑编号，删除数据
        /// </summary>
        public bool DeleteByPCBH(string BH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from bblc_2 ");
            strSql.Append(" where PCBH=@BH");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@BH", MySqlDbType.String)
            };
            parameters[0].Value = BH;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 根据电脑编号，删除数据
        /// </summary>
        public bool DeleteByYPSN(string YPSN)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from bblc_2 ");
            strSql.Append(" where YPSN=@YPSN");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@YPSN", MySqlDbType.String)
            };
            parameters[0].Value = YPSN;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from bblc_2 ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GDMAPSM.Model.bblc_2 GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select GUID,LX,PCBH,YPSN,BZ,ID,BLSJ from bblc_2 ");
			strSql.Append(" where ID=@ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32)
			};
			parameters[0].Value = ID;

			GDMAPSM.Model.bblc_2 model=new GDMAPSM.Model.bblc_2();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GDMAPSM.Model.bblc_2 DataRowToModel(DataRow row)
		{
			GDMAPSM.Model.bblc_2 model=new GDMAPSM.Model.bblc_2();
			if (row != null)
			{
				if(row["GUID"]!=null)
				{
					model.GUID=row["GUID"].ToString();
				}
				if(row["LX"]!=null)
				{
					model.LX=row["LX"].ToString();
				}
				if(row["PCBH"]!=null)
				{
					model.PCBH=row["PCBH"].ToString();
				}
				if(row["YPSN"]!=null)
				{
					model.YPSN=row["YPSN"].ToString();
				}
				if(row["BZ"]!=null)
				{
					model.BZ=row["BZ"].ToString();
				}
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["BLSJ"]!=null && row["BLSJ"].ToString()!="")
				{
					model.BLSJ=DateTime.Parse(row["BLSJ"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select GUID,LX,PCBH,YPSN,BZ,ID,BLSJ ");
			strSql.Append(" FROM bblc_2 ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM bblc_2 ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from bblc_2 T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "bblc_2";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        public DataSet GetListBySQL(string sql)
        {
            StringBuilder strSql = new StringBuilder();
            if (sql.Trim() == "")
            {
                return null;
            }
            strSql.Append(sql);
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

