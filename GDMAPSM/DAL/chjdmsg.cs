using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GDMAPSM.DAL
{
	/// <summary>
	/// 数据访问类:chjdmsg
	/// </summary>
	public partial class chjdmsg
	{
		public chjdmsg()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(GDMAPSM.Model.chjdmsg model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into chjdmsg(");
			strSql.Append("KZH,IP,MAC,BM,GQH,JHJ)");
			strSql.Append(" values (");
			strSql.Append("@KZH,@IP,@MAC,@BM,@GQH,@JHJ)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@KZH", MySqlDbType.VarChar,50),
					new MySqlParameter("@IP", MySqlDbType.VarChar,50),
					new MySqlParameter("@MAC", MySqlDbType.VarChar,50),
					new MySqlParameter("@BM", MySqlDbType.VarChar,50),
					new MySqlParameter("@GQH", MySqlDbType.VarChar,50),
					new MySqlParameter("@JHJ", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.KZH;
			parameters[1].Value = model.IP;
			parameters[2].Value = model.MAC;
			parameters[3].Value = model.BM;
			parameters[4].Value = model.GQH;
			parameters[5].Value = model.JHJ;

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
		public bool Update(GDMAPSM.Model.chjdmsg model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update chjdmsg set ");
			strSql.Append("KZH=@KZH,");
			strSql.Append("IP=@IP,");
			strSql.Append("MAC=@MAC,");
			strSql.Append("BM=@BM,");
			strSql.Append("GQH=@GQH,");
			strSql.Append("JHJ=@JHJ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@KZH", MySqlDbType.VarChar,50),
					new MySqlParameter("@IP", MySqlDbType.VarChar,50),
					new MySqlParameter("@MAC", MySqlDbType.VarChar,50),
					new MySqlParameter("@BM", MySqlDbType.VarChar,50),
					new MySqlParameter("@GQH", MySqlDbType.VarChar,50),
					new MySqlParameter("@JHJ", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.KZH;
			parameters[1].Value = model.IP;
			parameters[2].Value = model.MAC;
			parameters[3].Value = model.BM;
			parameters[4].Value = model.GQH;
			parameters[5].Value = model.JHJ;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from chjdmsg ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public GDMAPSM.Model.chjdmsg GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select KZH,IP,MAC,BM,GQH,JHJ from chjdmsg ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
			};

			GDMAPSM.Model.chjdmsg model=new GDMAPSM.Model.chjdmsg();
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
		public GDMAPSM.Model.chjdmsg DataRowToModel(DataRow row)
		{
			GDMAPSM.Model.chjdmsg model=new GDMAPSM.Model.chjdmsg();
			if (row != null)
			{
				if(row["KZH"]!=null)
				{
					model.KZH=row["KZH"].ToString();
				}
				if(row["IP"]!=null)
				{
					model.IP=row["IP"].ToString();
				}
				if(row["MAC"]!=null)
				{
					model.MAC=row["MAC"].ToString();
				}
				if(row["BM"]!=null)
				{
					model.BM=row["BM"].ToString();
				}
				if(row["GQH"]!=null)
				{
					model.GQH=row["GQH"].ToString();
				}
				if(row["JHJ"]!=null)
				{
					model.JHJ=row["JHJ"].ToString();
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
			strSql.Append("select KZH,IP,MAC,BM,GQH,JHJ ");
			strSql.Append(" FROM chjdmsg ");
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
			strSql.Append("select count(1) FROM chjdmsg ");
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
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from chjdmsg T ");
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
			parameters[0].Value = "chjdmsg";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// sql获取值
        /// </summary>
        public string GetString(string strSql,string fieldName)
        {


            GDMAPSM.Model.chjdmsg model = new GDMAPSM.Model.chjdmsg();
            DataSet ds = DbHelperMySQL.Query(strSql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[0][fieldName].ToString();
            }
            else
            {
                return null;
            }
        }
        #endregion  ExtensionMethod
    }
}

