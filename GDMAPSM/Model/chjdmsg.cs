using System;
namespace GDMAPSM.Model
{
	/// <summary>
	/// chjdmsg:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class chjdmsg
	{
		public chjdmsg()
		{}
		#region Model
		private string _kzh;
		private string _ip;
		private string _mac;
		private string _bm;
		private string _gqh;
		private string _jhj;
		/// <summary>
		/// 
		/// </summary>
		public string KZH
		{
			set{ _kzh=value;}
			get{return _kzh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IP
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MAC
		{
			set{ _mac=value;}
			get{return _mac;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BM
		{
			set{ _bm=value;}
			get{return _bm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GQH
		{
			set{ _gqh=value;}
			get{return _gqh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JHJ
		{
			set{ _jhj=value;}
			get{return _jhj;}
		}
		#endregion Model

	}
}

