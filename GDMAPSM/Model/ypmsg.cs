using System;
namespace GDMAPSM.Model
{
	/// <summary>
	/// ypmsg:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ypmsg
	{
		public ypmsg()
		{}
		#region Model
		private string _sn;
		private string _lx;
		private string _zt;
		private string _bdjsj;
		private string _syqk;
		private DateTime? _gmsj;
		private DateTime? _bbsj;
		private string _bz;
		private string _bajsj;
		/// <summary>
		/// 
		/// </summary>
		public string SN
		{
			set{ _sn=value;}
			get{return _sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LX
		{
			set{ _lx=value;}
			get{return _lx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZT
		{
			set{ _zt=value;}
			get{return _zt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BDJSJ
		{
			set{ _bdjsj=value;}
			get{return _bdjsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SYQK
		{
			set{ _syqk=value;}
			get{return _syqk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? GMSJ
		{
			set{ _gmsj=value;}
			get{return _gmsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BBSJ
		{
			set{ _bbsj=value;}
			get{return _bbsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ
		{
			set{ _bz=value;}
			get{return _bz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BAJSJ
		{
			set{ _bajsj=value;}
			get{return _bajsj;}
		}
		#endregion Model

	}
}

