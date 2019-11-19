using System;
namespace GDMAPSM.Model
{
	/// <summary>
	/// count:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class count
	{
		public count()
		{}
		#region Model
		private int _id;
		private int _count;
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
		public int COUNT
		{
			set{ _count=value;}
			get{return _count;}
		}
		#endregion Model

	}
}

