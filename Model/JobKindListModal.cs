using System;
namespace zlzw.Model
{
    /// <summary>
    /// JobKindListModel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class JobKindListModel
    {
        public JobKindListModel()
        { }
        #region Model
        private int _jobkindid;
        private Guid _jobcategoryguid;
        private Guid _jobkindguid;
        private string _jobkindname;
        private int? _jobcount;
        private int? _ishot;
        private int? _isenable;
        private int? _isshowdefaultpage;
        private DateTime? _publishdate;
        private string _other01;
        private string _other02;
        private int? _other03;
        /// <summary>
        /// 
        /// </summary>
        public int JobKindID
        {
            set { _jobkindid = value; }
            get { return _jobkindid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid JobCategoryGUID
        {
            set { _jobcategoryguid = value; }
            get { return _jobcategoryguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid JobKindGUID
        {
            set { _jobkindguid = value; }
            get { return _jobkindguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JobKindName
        {
            set { _jobkindname = value; }
            get { return _jobkindname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? JobCount
        {
            set { _jobcount = value; }
            get { return _jobcount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsHot
        {
            set { _ishot = value; }
            get { return _ishot; }
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
        /// 是否显示在首页
        /// </summary>
        public int? IsShowDefaultPage
        {
            set { _isshowdefaultpage = value; }
            get { return _isshowdefaultpage; }
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
        /// <summary>
        /// 
        /// </summary>
        public int? Other03
        {
            set { _other03 = value; }
            get { return _other03; }
        }
        #endregion Model

    }
}