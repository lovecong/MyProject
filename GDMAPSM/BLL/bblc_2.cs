using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using GDMAPSM.Model;
namespace GDMAPSM.BLL
{
	/// <summary>
	/// bblc_2
	/// </summary>
	public partial class bblc_2
	{
		private readonly GDMAPSM.DAL.bblc_2 dal=new GDMAPSM.DAL.bblc_2();
		public bblc_2()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(GDMAPSM.Model.bblc_2 model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(GDMAPSM.Model.bblc_2 model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
        /// <summary>
        /// 根据电脑编号，删除数据
        /// </summary>
        public bool DeleteByPCBH(string BH)
        {

            return dal.DeleteByPCBH(BH);
        }
        /// <summary>
        /// 根据硬盘编号，删除数据
        /// </summary>
        public bool DeleteByYPSN(string SH)
        {

            return dal.DeleteByYPSN(SH);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GDMAPSM.Model.bblc_2 GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public GDMAPSM.Model.bblc_2 GetModelByCache(int ID)
		{
			
			string CacheKey = "bblc_2Model-" + ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (GDMAPSM.Model.bblc_2)objModel;
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
		public List<GDMAPSM.Model.bblc_2> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<GDMAPSM.Model.bblc_2> DataTableToList(DataTable dt)
		{
			List<GDMAPSM.Model.bblc_2> modelList = new List<GDMAPSM.Model.bblc_2>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				GDMAPSM.Model.bblc_2 model;
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
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListBySQL(string SQL)
        {
            return dal.GetListBySQL(SQL);
        }
        #endregion  ExtensionMethod
    }
}

