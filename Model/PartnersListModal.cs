using System;
namespace zlzw.Model
{
    /// <summary>
    /// PartnersListModel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PartnersListModel
    {
        public PartnersListModel()
        { }
        #region Model
        private int _partnerid;
        private Guid _partnerguid;
        private string _partnername;
        private string _partnertitle;
        private string _partnerintroduction;
        private string _partnerlogo;
        private string _partnerbanner;
        private int? _partnerkind;
        private string _partnercategory;
        private int? _ishot;
        private int? _isenable;
        private DateTime? _publishdate;
        private string _jobcontactname;
        private string _jobcontactadd;
        private string _jobcontactphone;
        private string _other01;
        private string _other02;
        private string _other03;
        /// <summary>
        /// 
        /// </summary>
        public int PartnerID
        {
            set { _partnerid = value; }
            get { return _partnerid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid PartnerGUID
        {
            set { _partnerguid = value; }
            get { return _partnerguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PartnerName
        {
            set { _partnername = value; }
            get { return _partnername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PartnerTitle
        {
            set { _partnertitle = value; }
            get { return _partnertitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PartnerIntroduction
        {
            set { _partnerintroduction = value; }
            get { return _partnerintroduction; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PartnerLogo
        {
            set { _partnerlogo = value; }
            get { return _partnerlogo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PartnerBanner
        {
            set { _partnerbanner = value; }
            get { return _partnerbanner; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PartnerKind
        {
            set { _partnerkind = value; }
            get { return _partnerkind; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PartnerCategory
        {
            set { _partnercategory = value; }
            get { return _partnercategory; }
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
        public string JobContactName
        {
            set { _jobcontactname = value; }
            get { return _jobcontactname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JobContactAdd
        {
            set { _jobcontactadd = value; }
            get { return _jobcontactadd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JobContactPhone
        {
            set { _jobcontactphone = value; }
            get { return _jobcontactphone; }
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
        public string Other03
        {
            set { _other03 = value; }
            get { return _other03; }
        }
        #endregion Model

    }
}