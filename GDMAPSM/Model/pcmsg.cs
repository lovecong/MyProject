using System;
namespace GDMAPSM.Model
{
	/// <summary>
	/// pcmsg:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class pcmsg
	{
		public pcmsg()
		{}
		#region Model
		private string _bh;
		private string _syzt;
		private string _bazt;
		private string _babh;
		private string _basj;
		private string _sybm;
		private string _bmzzr;
		private string _syr;
		private string _jsjlx;
		private string _pplx;
		private string _wz;
		private string _bz;
		private string _sn;
		private DateTime? _djsj;
        private DateTime? _qysj;
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
		public string SYZT
		{
			set{ _syzt=value;}
			get{return _syzt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BAZT
		{
			set{ _bazt=value;}
			get{return _bazt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BABH
		{
			set{ _babh=value;}
			get{return _babh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BASJ
		{
			set{ _basj=value;}
			get{return _basj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SYBM
		{
			set{ _sybm=value;}
			get{return _sybm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BMZZR
		{
			set{ _bmzzr=value;}
			get{return _bmzzr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SYR
		{
			set{ _syr=value;}
			get{return _syr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSJLX
		{
			set{ _jsjlx=value;}
			get{return _jsjlx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PPLX
		{
			set{ _pplx=value;}
			get{return _pplx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WZ
		{
			set{ _wz=value;}
			get{return _wz;}
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
		public string SN
		{
			set{ _sn=value;}
			get{return _sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DJSJ
		{
			set{ _djsj=value;}
			get{return _djsj;}
		}
        /// <summary>
        /// 
        /// </summary>
        public DateTime? QYSJ
        {
            set { _qysj = value; }
            get { return _qysj; }
        }
        #endregion Model 

    }
}

