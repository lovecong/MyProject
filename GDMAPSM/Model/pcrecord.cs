using System;
namespace GDMAPSM.Model
{
	/// <summary>
	/// pcrecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class pcrecord
	{
		public pcrecord()
		{}
		#region Model
		private int _id;
		private string _lx;
		private string _bh;
		private DateTime? _time;
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
		#endregion Model

	}
}

