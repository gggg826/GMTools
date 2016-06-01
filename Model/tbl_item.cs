using System;
namespace FengNiao.GMTools.Database.Model
{
	/// <summary>
	/// tbl_item:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tbl_item
	{
		public tbl_item()
		{}
		#region Model
		private int _item_record_id;
		private int _item_id;
		private string _name;
		private string _describe;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int item_record_id
		{
			set{ _item_record_id=value;}
			get{return _item_record_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int item_id
		{
			set{ _item_id=value;}
			get{return _item_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string describe
		{
			set{ _describe=value;}
			get{return _describe;}
		}

        public int count
        {
            set;
            get;
        }
		#endregion Model

	}
}

