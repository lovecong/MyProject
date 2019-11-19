using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GDMAPSM.DAL
{
	/// <summary>
	/// 数据访问类:ypmsg
	/// </summary>
	public partial class ypmsg
	{
		public ypmsg()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SN)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ypmsg");
			strSql.Append(" where SN=@SN ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SN", MySqlDbType.VarChar,255)			};
			parameters[0].Value = SN;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(GDMAPSM.Model.ypmsg model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ypmsg(");
			strSql.Append("SN,LX,ZT,BDJSJ,SYQK,GMSJ,BBSJ,BZ,BAJSJ)");
			strSql.Append(" values (");
			strSql.Append("@SN,@LX,@ZT,@BDJSJ,@SYQK,@GMSJ,@BBSJ,@BZ,@BAJSJ)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SN", MySqlDbType.VarChar,255),
					new MySqlParameter("@LX", MySqlDbType.VarChar,2),
					new MySqlParameter("@ZT", MySqlDbType.VarChar,2),
					new MySqlParameter("@BDJSJ", MySqlDbType.VarChar,255),
					new MySqlParameter("@SYQK", MySqlDbType.VarChar,2),
					new MySqlParameter("@GMSJ", MySqlDbType.Date),
					new MySqlParameter("@BBSJ", MySqlDbType.Date),
					new MySqlParameter("@BZ", MySqlDbType.Text),
					new MySqlParameter("@BAJSJ", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.SN;
			parameters[1].Value = model.LX;
			parameters[2].Value = model.ZT;
			parameters[3].Value = model.BDJSJ;
			parameters[4].Value = model.SYQK;
			parameters[5].Value = model.GMSJ;
			parameters[6].Value = model.BBSJ;
			parameters[7].Value = model.BZ;
			parameters[8].Value = model.BAJSJ;

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
		public bool Update(GDMAPSM.Model.ypmsg model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ypmsg set ");
			strSql.Append("LX=@LX,");
			strSql.Append("ZT=@ZT,");
			strSql.Append("BDJSJ=@BDJSJ,");
			strSql.Append("SYQK=@SYQK,");
			strSql.Append("GMSJ=@GMSJ,");
			strSql.Append("BBSJ=@BBSJ,");
			strSql.Append("BZ=@BZ,");
			strSql.Append("BAJSJ=@BAJSJ");
			strSql.Append(" where SN=@SN ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@LX", MySqlDbType.VarChar,2),
					new MySqlParameter("@ZT", MySqlDbType.VarChar,2),
					new MySqlParameter("@BDJSJ", MySqlDbType.VarChar,255),
					new MySqlParameter("@SYQK", MySqlDbType.VarChar,2),
					new MySqlParameter("@GMSJ", MySqlDbType.Date),
					new MySqlParameter("@BBSJ", MySqlDbType.Date),
					new MySqlParameter("@BZ", MySqlDbType.Text),
					new MySqlParameter("@BAJSJ", MySqlDbType.VarChar,255),
					new MySqlParameter("@SN", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.LX;
			parameters[1].Value = model.ZT;
			parameters[2].Value = model.BDJSJ;
			parameters[3].Value = model.SYQK;
			parameters[4].Value = model.GMSJ;
			parameters[5].Value = model.BBSJ;
			parameters[6].Value = model.BZ;
			parameters[7].Value = model.BAJSJ;
			parameters[8].Value = model.SN;

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
        public bool UpdateSN(string sn,string newSN)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ypmsg set ");
            strSql.Append("SN=@newSN");
            strSql.Append(" where SN=@SN ");
            MySqlParameter[] parameters = {
                 new MySqlParameter("@newSN", MySqlDbType.VarChar,255),
            new MySqlParameter("@SN", MySqlDbType.VarChar,255)};

            parameters[0].Value = newSN;
            parameters[1].Value = sn;
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string SN)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ypmsg ");
			strSql.Append(" where SN=@SN ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SN", MySqlDbType.VarChar,255)			};
			parameters[0].Value = SN;

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
        /// 删除与计算机绑定的多条个硬盘
        /// </summary>
        public bool DeleteBYBH(string BH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ypmsg ");
            strSql.Append(" where BAJSJ=@BH ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@BH", MySqlDbType.VarChar,255)          };
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string SNlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ypmsg ");
			strSql.Append(" where SN in ("+SNlist + ")  ");
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
		public GDMAPSM.Model.ypmsg GetModel(string SN)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SN,LX,ZT,BDJSJ,SYQK,GMSJ,BBSJ,BZ,BAJSJ from ypmsg ");
			strSql.Append(" where SN=@SN ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SN", MySqlDbType.VarChar,255)			};
			parameters[0].Value = SN;

			GDMAPSM.Model.ypmsg model=new GDMAPSM.Model.ypmsg();
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
		public GDMAPSM.Model.ypmsg DataRowToModel(DataRow row)
		{
			GDMAPSM.Model.ypmsg model=new GDMAPSM.Model.ypmsg();
			if (row != null)
			{
				if(row["SN"]!=null)
				{
					model.SN=row["SN"].ToString();
				}
				if(row["LX"]!=null)
				{
					model.LX=row["LX"].ToString();
				}
				if(row["ZT"]!=null)
				{
					model.ZT=row["ZT"].ToString();
				}
				if(row["BDJSJ"]!=null)
				{
					model.BDJSJ=row["BDJSJ"].ToString();
				}
				if(row["SYQK"]!=null)
				{
					model.SYQK=row["SYQK"].ToString();
				}
				if(row["GMSJ"]!=null && row["GMSJ"].ToString()!="")
				{
					model.GMSJ=DateTime.Parse(row["GMSJ"].ToString());
				}
				if(row["BBSJ"]!=null && row["BBSJ"].ToString()!="")
				{
					model.BBSJ=DateTime.Parse(row["BBSJ"].ToString());
				}
				if(row["BZ"]!=null)
				{
					model.BZ=row["BZ"].ToString();
				}
				if(row["BAJSJ"]!=null)
				{
					model.BAJSJ=row["BAJSJ"].ToString();
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
			strSql.Append("select SN,LX,ZT,BDJSJ,SYQK,GMSJ,BBSJ,BZ,BAJSJ ");
			strSql.Append(" FROM ypmsg ");
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
			strSql.Append("select count(1) FROM ypmsg ");
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
				strSql.Append("order by T.SN desc");
			}
			strSql.Append(")AS Row, T.*  from ypmsg T ");
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
			parameters[0].Value = "ypmsg";
			parameters[1].Value = "SN";
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

