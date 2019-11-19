using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using GDMAPSM.Model;
namespace GDMAPSM.BLL
{
	/// <summary>
	/// ypmsg
	/// </summary>
	public partial class ypmsg
	{
		private readonly GDMAPSM.DAL.ypmsg dal=new GDMAPSM.DAL.ypmsg();
		public ypmsg()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SN)
		{
			return dal.Exists(SN);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(GDMAPSM.Model.ypmsg model)
		{

			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(GDMAPSM.Model.ypmsg model)
		{

            return dal.Update(model);
		}
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool UpdateSN(string SN,string newSN)
        {

            return dal.UpdateSN(SN,newSN);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string SN)
		{
			
			return dal.Delete(SN);
		}
        /// <summary>
        /// 删除与备案计算机的所有硬盘
        /// </summary>
        public bool DeleteByBH(string BH)
        {

            return dal.DeleteBYBH(BH);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string SNlist )
		{
			return dal.DeleteList(SNlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GDMAPSM.Model.ypmsg GetModel(string SN)
		{
			
			return dal.GetModel(SN);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public GDMAPSM.Model.ypmsg GetModelByCache(string SN)
		{
			
			string CacheKey = "ypmsgModel-" + SN;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(SN);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (GDMAPSM.Model.ypmsg)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<GDMAPSM.Model.ypmsg> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<GDMAPSM.Model.ypmsg> DataTableToList(DataTable dt)
		{
			List<GDMAPSM.Model.ypmsg> modelList = new List<GDMAPSM.Model.ypmsg>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				GDMAPSM.Model.ypmsg model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

