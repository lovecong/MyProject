using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GDMAPSM.DAL
{
	/// <summary>
	/// 数据访问类:bblc_1
	/// </summary>
	public partial class bblc_1
	{
		public bblc_1()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string GUID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from bblc_1");
			strSql.Append(" where GUID=@GUID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@GUID", MySqlDbType.VarChar,50)			};
			parameters[0].Value = GUID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(GDMAPSM.Model.bblc_1 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into bblc_1(");
			strSql.Append("GUID,ZT,JBR,Stime,Etime,BZ,FJ,BBSJ)");
			strSql.Append(" values (");
			strSql.Append("@GUID,@ZT,@JBR,@Stime,@Etime,@BZ,@FJ,@BBSJ)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@GUID", MySqlDbType.VarChar,50),
					new MySqlParameter("@ZT", MySqlDbType.VarChar,10),
					new MySqlParameter("@JBR", MySqlDbType.VarChar,255),
					new MySqlParameter("@Stime", MySqlDbType.Date),
					new MySqlParameter("@Etime", MySqlDbType.Date),
					new MySqlParameter("@BZ", MySqlDbType.Text),
					new MySqlParameter("@FJ", MySqlDbType.VarChar,255),
					new MySqlParameter("@BBSJ", MySqlDbType.Date)};
			parameters[0].Value = model.GUID;
			parameters[1].Value = model.ZT;
			parameters[2].Value = model.JBR;
			parameters[3].Value = model.Stime;
			parameters[4].Value = model.Etime;
			parameters[5].Value = model.BZ;
			parameters[6].Value = model.FJ;
			parameters[7].Value = model.BBSJ;

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
		public bool Update(GDMAPSM.Model.bblc_1 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update bblc_1 set ");
			strSql.Append("ZT=@ZT,");
			strSql.Append("JBR=@JBR,");
			strSql.Append("Stime=@Stime,");
			strSql.Append("Etime=@Etime,");
			strSql.Append("BZ=@BZ,");
			strSql.Append("FJ=@FJ,");
			strSql.Append("BBSJ=@BBSJ");
			strSql.Append(" where GUID=@GUID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ZT", MySqlDbType.VarChar,10),
					new MySqlParameter("@JBR", MySqlDbType.VarChar,255),
					new MySqlParameter("@Stime", MySqlDbType.Date),
					new MySqlParameter("@Etime", MySqlDbType.Date),
					new MySqlParameter("@BZ", MySqlDbType.Text),
					new MySqlParameter("@FJ", MySqlDbType.VarChar,255),
					new MySqlParameter("@BBSJ", MySqlDbType.Date),
					new MySqlParameter("@GUID", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.ZT;
			parameters[1].Value = model.JBR;
			parameters[2].Value = model.Stime;
			parameters[3].Value = model.Etime;
			parameters[4].Value = model.BZ;
			parameters[5].Value = model.FJ;
			parameters[6].Value = model.BBSJ;
			parameters[7].Value = model.GUID;

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
		public bool Delete(string GUID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from bblc_1 ");
			strSql.Append(" where GUID=@GUID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@GUID", MySqlDbType.VarChar,50)			};
			parameters[0].Value = GUID;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string GUIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from bblc_1 ");
			strSql.Append(" where GUID in ("+GUIDlist + ")  ");
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
		public GDMAPSM.Model.bblc_1 GetModel(string GUID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select GUID,ZT,JBR,Stime,Etime,BZ,FJ,BBSJ from bblc_1 ");
			strSql.Append(" where GUID=@GUID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@GUID", MySqlDbType.VarChar,50)			};
			parameters[0].Value = GUID;

			GDMAPSM.Model.bblc_1 model=new GDMAPSM.Model.bblc_1();
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
		public GDMAPSM.Model.bblc_1 DataRowToModel(DataRow row)
		{
			GDMAPSM.Model.bblc_1 model=new GDMAPSM.Model.bblc_1();
			if (row != null)
			{
				if(row["GUID"]!=null)
				{
					model.GUID=row["GUID"].ToString();
				}
				if(row["ZT"]!=null)
				{
					model.ZT=row["ZT"].ToString();
				}
				if(row["JBR"]!=null)
				{
					model.JBR=row["JBR"].ToString();
				}
				if(row["Stime"]!=null && row["Stime"].ToString()!="")
				{
					model.Stime=DateTime.Parse(row["Stime"].ToString());
				}
				if(row["Etime"]!=null && row["Etime"].ToString()!="")
				{
					model.Etime=DateTime.Parse(row["Etime"].ToString());
				}
				if(row["BZ"]!=null)
				{
					model.BZ=row["BZ"].ToString();
				}
				if(row["FJ"]!=null)
				{
					model.FJ=row["FJ"].ToString();
				}
				if(row["BBSJ"]!=null && row["BBSJ"].ToString()!="")
				{
					model.BBSJ=DateTime.Parse(row["BBSJ"].ToString());
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
			strSql.Append("select GUID,ZT,JBR,Stime,Etime,BZ,FJ,BBSJ ");
			strSql.Append(" FROM bblc_1 ");
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
			strSql.Append("select count(1) FROM bblc_1 ");
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
				strSql.Append("order by T.GUID desc");
			}
			strSql.Append(")AS Row, T.*  from bblc_1 T ");
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
			parameters[0].Value = "bblc_1";
			parameters[1].Value = "GUID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

