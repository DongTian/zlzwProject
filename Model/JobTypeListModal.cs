using System;
namespace zlzw.Model
{
    /// <summary>
    /// JobTypeListModel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class JobTypeListModel
    {
        public JobTypeListModel()
        { }
        #region Model
        private int _jobtypeid;
        private string _jobtypename;
        private DateTime? _publishdate;
        private int? _isenable;
        private string _other01;
        private string _other02;
        /// <summary>
        /// 
        /// </summary>
        public int JobTypeID
        {
            set { _jobtypeid = value; }
            get { return _jobtypeid; }
        }
        /// <summary>
        /// 岗位信息名称
        /// </summary>
        public string JobTypeName
        {
            set { _jobtypename = value; }
            get { return _jobtypename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PublishDate
        {
            set { _publishdate = value; }
            get { return _publishdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsEnable
        {
            set { _isenable = value; }
            get { return _isenable; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Other01
        {
            set { _other01 = value; }
            get { return _other01; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Other02
        {
            set { _other02 = value; }
            get { return _other02; }
        }
        #endregion Model

    }
}