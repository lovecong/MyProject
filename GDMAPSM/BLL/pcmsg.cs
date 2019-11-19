using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using GDMAPSM.Model;
namespace GDMAPSM.BLL
{
	/// <summary>
	/// pcmsg
	/// </summary>
	public partial class pcmsg
	{
		private readonly GDMAPSM.DAL.pcmsg dal=new GDMAPSM.DAL.pcmsg();
		public pcmsg()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string BH)
		{
			return dal.Exists(BH);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(GDMAPSM.Model.pcmsg model)
		{

            int count = int.Parse(model.BH.Substring(2,model.BH.Length-2))+1;
            if (dal.Add(model))
            {
                BLL.count c_bll = new count();
                Model.count c = c_bll.GetModel(1);
                c.COUNT = count;

                return c_bll.Update(c);
            }
            return false;
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(GDMAPSM.Model.pcmsg model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string BH)
		{
			
			return dal.Delete(BH);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string BHlist )
		{
			return dal.DeleteList(BHlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GDMAPSM.Model.pcmsg GetModel(string BH)
		{
			
			return dal.GetModel(BH);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public GDMAPSM.Model.pcmsg GetModelByCache(string BH)
		{
			
			string CacheKey = "pcmsgModel-" + BH;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(BH);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (GDMAPSM.Model.pcmsg)objModel;
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
		public List<GDMAPSM.Model.pcmsg> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<GDMAPSM.Model.pcmsg> DataTableToList(DataTable dt)
		{
			List<GDMAPSM.Model.pcmsg> modelList = new List<GDMAPSM.Model.pcmsg>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				GDMAPSM.Model.pcmsg model;
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
        public DataSet GetListBySQL(string strSQL)
        {
            return dal.GetListBySQL(strSQL);
        }
        #endregion  ExtensionMethod
    }
}

