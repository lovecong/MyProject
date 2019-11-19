using System;
namespace GDMAPSM.Model
{
	/// <summary>
	/// bblc_1:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class bblc_1
	{
		public bblc_1()
		{}
		#region Model
		private string _guid;
		private string _zt;
		private string _jbr;
		private DateTime? _stime;
		private DateTime? _etime;
		private string _bz;
		private string _fj;
		private DateTime? _bbsj;
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
		public string ZT
		{
			set{ _zt=value;}
			get{return _zt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JBR
		{
			set{ _jbr=value;}
			get{return _jbr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Stime
		{
			set{ _stime=value;}
			get{return _stime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Etime
		{
			set{ _etime=value;}
			get{return _etime;}
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
		public string FJ
		{
			set{ _fj=value;}
			get{return _fj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BBSJ
		{
			set{ _bbsj=value;}
			get{return _bbsj;}
		}
		#endregion Model

	}
}

