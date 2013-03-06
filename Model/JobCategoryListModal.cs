using System;
namespace zlzw.Model
{
    /// <summary>
    /// JobCategoryListModal:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class JobCategoryListModal
    {
        public JobCategoryListModal()
        { }
        #region Model
        private int _jobcategoryid;
        private Guid _jobcategoryguid;
        private string _jobcategoryname;
        private int? _jobcount;
        private DateTime? _publishdate;
        private int? _ishot;
        private int? _isenable;
        private string _other01;
        private string _other02;
        /// <summary>
        /// 
        /// </summary>
        public int JobCategoryID
        {
            set { _jobcategoryid = value; }
            get { return _jobcategoryid; }
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
        public string JobCategoryName
        {
            set { _jobcategoryname = value; }
            get { return _jobcategoryname; }
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
        public DateTime? PublishDate
        {
            set { _publishdate = value; }
            get { return _publishdate; }
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