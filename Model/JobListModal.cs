using System;
namespace zlzw.Model
{
    /// <summary>
    /// JobListModel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class JobListModel
    {
        public JobListModel()
        { }
        #region Model
        private int _jobid;
        private int? _jobtypeid;
        private string _jobname;
        private int? _ishot;
        private int? _isenable;
        private DateTime? _publishdate;
        private string _other01;
        private string _other02;
        private int? _other03;
        /// <summary>
        /// 
        /// </summary>
        public int JobID
        {
            set { _jobid = value; }
            get { return _jobid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? JobTypeID
        {
            set { _jobtypeid = value; }
            get { return _jobtypeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JobName
        {
            set { _jobname = value; }
            get { return _jobname; }
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