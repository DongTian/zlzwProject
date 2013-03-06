using System;
namespace zlzw.Model
{
    /// <summary>
    /// DefaultPostListModal:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class DefaultPostListModal
    {
        public DefaultPostListModal()
        { }
        #region Model
        private int _enterpriseid;
        private int? _dictionarylistid;
        private Guid _enterpriseguid;
        private string _enterprisename;
        private string _workadd;
        private string _recruitmentnumber;
        private string _postinfo;
        private string _postdemand;
        private string _treatmentinfo;
        private string _otherinfo;
        private int? _isenable;
        private int? _ishot;
        private DateTime? _publishdate;
        private string _other01;
        private string _other02;
        /// <summary>
        /// 
        /// </summary>
        public int EnterpriseID
        {
            set { _enterpriseid = value; }
            get { return _enterpriseid; }
        }
        /// <summary>
        /// 职位所属地区
        /// </summary>
        public int? DictionaryListID
        {
            set { _dictionarylistid = value; }
            get { return _dictionarylistid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid EnterpriseGUID
        {
            set { _enterpriseguid = value; }
            get { return _enterpriseguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EnterpriseName
        {
            set { _enterprisename = value; }
            get { return _enterprisename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WorkAdd
        {
            set { _workadd = value; }
            get { return _workadd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RecruitmentNumber
        {
            set { _recruitmentnumber = value; }
            get { return _recruitmentnumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PostInfo
        {
            set { _postinfo = value; }
            get { return _postinfo; }
        }
        /// <summary>
        /// 岗位要求
        /// </summary>
        public string PostDemand
        {
            set { _postdemand = value; }
            get { return _postdemand; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TreatmentInfo
        {
            set { _treatmentinfo = value; }
            get { return _treatmentinfo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OtherInfo
        {
            set { _otherinfo = value; }
            get { return _otherinfo; }
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
        public int? IsHot
        {
            set { _ishot = value; }
            get { return _ishot; }
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
        #endregion Model

    }
}