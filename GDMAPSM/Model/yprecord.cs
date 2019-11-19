using System;
namespace GDMAPSM.Model
{
	/// <summary>
	/// yprecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class yprecord
	{
		public yprecord()
		{}
		#region Model
		private int _id;
		private string _sn;
		private string _lx;
		private string _bh;
		private DateTime? _time;
		private string _bz;
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
		public string BH
		{
			set{ _bh=value;}
			get{return _bh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TIME
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ
		{
			set{ _bz=value;}
			get{return _bz;}
		}
		#endregion Model

	}
}

