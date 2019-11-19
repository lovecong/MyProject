using System;
namespace GDMAPSM.Model
{
	/// <summary>
	/// bblc_2:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class bblc_2
	{
		public bblc_2()
		{}
		#region Model
		private string _guid;
		private string _lx;
		private string _pcbh;
		private string _ypsn;
		private string _bz;
		private int _id;
		private DateTime? _blsj;
		/// <summary>
		/// 
		/// </summary>
		public string GUID
		{
			set{ _guid=value;}
			get{return _guid;}
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
		public string PCBH
		{
			set{ _pcbh=value;}
			get{return _pcbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YPSN
		{
			set{ _ypsn=value;}
			get{return _ypsn;}
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
		/// auto_increment
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BLSJ
		{
			set{ _blsj=value;}
			get{return _blsj;}
		}
		#endregion Model

	}
}

