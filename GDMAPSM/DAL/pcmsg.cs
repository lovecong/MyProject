using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GDMAPSM.DAL
{
	/// <summary>
	/// 数据访问类:pcmsg
	/// </summary>
	public partial class pcmsg
	{
		public pcmsg()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string BH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from pcmsg");
			strSql.Append(" where BH=@BH ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@BH", MySqlDbType.VarChar,50)			};
			parameters[0].Value = BH;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(GDMAPSM.Model.pcmsg model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into pcmsg(");
			strSql.Append("BH,SYZT,BAZT,BABH,BASJ,SYBM,BMZZR,SYR,JSJLX,PPLX,WZ,BZ,SN,DJSJ,QYSJ)");
			strSql.Append(" values (");
			strSql.Append("@BH,@SYZT,@BAZT,@BABH,@BASJ,@SYBM,@BMZZR,@SYR,@JSJLX,@PPLX,@WZ,@BZ,@SN,@DJSJ,@QYSJ)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@BH", MySqlDbType.VarChar,50),
					new MySqlParameter("@SYZT", MySqlDbType.VarChar,50),
					new MySqlParameter("@BAZT", MySqlDbType.VarChar,50),
					new MySqlParameter("@BABH", MySqlDbType.VarChar,50),
					new MySqlParameter("@BASJ", MySqlDbType.VarChar,50),
					new MySqlParameter("@SYBM", MySqlDbType.VarChar,50),
					new MySqlParameter("@BMZZR", MySqlDbType.VarChar,50),
					new MySqlParameter("@SYR", MySqlDbType.VarChar,50),
					new MySqlParameter("@JSJLX", MySqlDbType.VarChar,50),
					new MySqlParameter("@PPLX", MySqlDbType.VarChar,50),
					new MySqlParameter("@WZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@BZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@SN", MySqlDbType.VarChar,255),
					new MySqlParameter("@DJSJ", MySqlDbType.Date),
                    new MySqlParameter("@QYSJ", MySqlDbType.Date)};
			parameters[0].Value = model.BH;
			parameters[1].Value = model.SYZT;
			parameters[2].Value = model.BAZT;
			parameters[3].Value = model.BABH;
			parameters[4].Value = model.BASJ;
			parameters[5].Value = model.SYBM;
			parameters[6].Value = model.BMZZR;
			parameters[7].Value = model.SYR;
			parameters[8].Value = model.JSJLX;
			parameters[9].Value = model.PPLX;
			parameters[10].Value = model.WZ;
			parameters[11].Value = model.BZ;
			parameters[12].Value = model.SN;
			parameters[13].Value = model.DJSJ;
            parameters[14].Value = model.QYSJ;

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
		public bool Update(GDMAPSM.Model.pcmsg model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update pcmsg set ");
			strSql.Append("SYZT=@SYZT,");
			strSql.Append("BAZT=@BAZT,");
			strSql.Append("BABH=@BABH,");
			strSql.Append("BASJ=@BASJ,");
			strSql.Append("SYBM=@SYBM,");
			strSql.Append("BMZZR=@BMZZR,");
			strSql.Append("SYR=@SYR,");
			strSql.Append("JSJLX=@JSJLX,");
			strSql.Append("PPLX=@PPLX,");
			strSql.Append("WZ=@WZ,");
			strSql.Append("BZ=@BZ,");
			strSql.Append("SN=@SN,");
			strSql.Append("DJSJ=@DJSJ,");
            strSql.Append("QYSJ=@QYSJ");
            strSql.Append(" where BH=@BH ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SYZT", MySqlDbType.VarChar,50),
					new MySqlParameter("@BAZT", MySqlDbType.VarChar,50),
					new MySqlParameter("@BABH", MySqlDbType.VarChar,50),
					new MySqlParameter("@BASJ", MySqlDbType.VarChar,50),
					new MySqlParameter("@SYBM", MySqlDbType.VarChar,50),
					new MySqlParameter("@BMZZR", MySqlDbType.VarChar,50),
					new MySqlParameter("@SYR", MySqlDbType.VarChar,50),
					new MySqlParameter("@JSJLX", MySqlDbType.VarChar,50),
					new MySqlParameter("@PPLX", MySqlDbType.VarChar,50),
					new MySqlParameter("@WZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@BZ", MySqlDbType.VarChar,50),
					new MySqlParameter("@SN", MySqlDbType.VarChar,255),
					new MySqlParameter("@DJSJ", MySqlDbType.Date),
                    new MySqlParameter("@QYSJ", MySqlDbType.Date),
                    new MySqlParameter("@BH", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.SYZT;
			parameters[1].Value = model.BAZT;
			parameters[2].Value = model.BABH;
			parameters[3].Value = model.BASJ;
			parameters[4].Value = model.SYBM;
			parameters[5].Value = model.BMZZR;
			parameters[6].Value = model.SYR;
			parameters[7].Value = model.JSJLX;
			parameters[8].Value = model.PPLX;
			parameters[9].Value = model.WZ;
			parameters[10].Value = model.BZ;
			parameters[11].Value = model.SN;
			parameters[12].Value = model.DJSJ;
            parameters[13].Value = model.QYSJ;
            parameters[14].Value = model.BH;

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
		public bool Delete(string BH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from pcmsg ");
			strSql.Append(" where BH=@BH ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@BH", MySqlDbType.VarChar,50)			};
			parameters[0].Value = BH;

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
		public bool DeleteList(string BHlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from pcmsg ");
			strSql.Append(" where BH in ("+BHlist + ")  ");
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
		public GDMAPSM.Model.pcmsg GetModel(string BH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select BH,SYZT,BAZT,BABH,BASJ,SYBM,BMZZR,SYR,JSJLX,PPLX,WZ,BZ,SN,DJSJ,QYSJ from pcmsg ");
			strSql.Append(" where BH=@BH ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@BH", MySqlDbType.VarChar,50)			};
			parameters[0].Value = BH;

			GDMAPSM.Model.pcmsg model=new GDMAPSM.Model.pcmsg();
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
		public GDMAPSM.Model.pcmsg DataRowToModel(DataRow row)
		{
			GDMAPSM.Model.pcmsg model=new GDMAPSM.Model.pcmsg();
			if (row != null)
			{
				if(row["BH"]!=null)
				{
					model.BH=row["BH"].ToString();
				}
				if(row["SYZT"]!=null)
				{
					model.SYZT=row["SYZT"].ToString();
				}
				if(row["BAZT"]!=null)
				{
					model.BAZT=row["BAZT"].ToString();
				}
				if(row["BABH"]!=null)
				{
					model.BABH=row["BABH"].ToString();
				}
				if(row["BASJ"]!=null)
				{
					model.BASJ=row["BASJ"].ToString();
				}
				if(row["SYBM"]!=null)
				{
					model.SYBM=row["SYBM"].ToString();
				}
				if(row["BMZZR"]!=null)
				{
					model.BMZZR=row["BMZZR"].ToString();
				}
				if(row["SYR"]!=null)
				{
					model.SYR=row["SYR"].ToString();
				}
				if(row["JSJLX"]!=null)
				{
					model.JSJLX=row["JSJLX"].ToString();
				}
				if(row["PPLX"]!=null)
				{
					model.PPLX=row["PPLX"].ToString();
				}
				if(row["WZ"]!=null)
				{
					model.WZ=row["WZ"].ToString();
				}
				if(row["BZ"]!=null)
				{
					model.BZ=row["BZ"].ToString();
				}
				if(row["SN"]!=null)
				{
					model.SN=row["SN"].ToString();
				}
				if(row["DJSJ"]!=null && row["DJSJ"].ToString()!="")
				{
					model.DJSJ=DateTime.Parse(row["DJSJ"].ToString());
				}
                if (row["QYSJ"] != null && row["QYSJ"].ToString() != "")
                {
                    model.QYSJ = DateTime.Parse(row["QYSJ"].ToString());
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
			strSql.Append("select BH,SYZT,BAZT,BABH,BASJ,SYBM,BMZZR,SYR,JSJLX,PPLX,WZ,BZ,SN,DJSJ,QYSJ ");
			strSql.Append(" FROM pcmsg ");
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
			strSql.Append("select count(1) FROM pcmsg ");
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
				strSql.Append("order by T.BH desc");
			}
			strSql.Append(")AS Row, T.*  from pcmsg T ");
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
			parameters[0].Value = "pcmsg";
			parameters[1].Value = "BH";
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetListBySQL(string strSQL)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(strSQL);
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

