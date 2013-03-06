using System;
namespace zlzw.Model
{
    /// <summary>
    /// CareersListModal:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CareersListModal
    {
        public CareersListModal()
        { }
        #region Model
        private int _careersid;
        private Guid _careersguid;
        private string _dictionarykey;
        private string _departmentname;
        private string _careerstitle;
        private int? _careerscount;
        private string _workadd;
        private string _educational;
        private string _salary;
        private string _workexperience;
        private string _responsibilities;
        private string _qualifications;
        private string _email;
        private string _telephone;
        private string _contactman;
        private int? _isenable;
        private int? _ishot;
        private DateTime? _publishdate;
        private string _other01;
        private string _other02;
        private string _other03;
        /// <summary>
        /// 
        /// </summary>
        public int CareersID
        {
            set { _careersid = value; }
            get { return _careersid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid CareersGUID
        {
            set { _careersguid = value; }
            get { return _careersguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DictionaryKey
        {
            set { _dictionarykey = value; }
            get { return _dictionarykey; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DepartmentName
        {
            set { _departmentname = value; }
            get { return _departmentname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CareersTitle
        {
            set { _careerstitle = value; }
            get { return _careerstitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CareersCount
        {
            set { _careerscount = value; }
            get { return _careerscount; }
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
        public string Educational
        {
            set { _educational = value; }
            get { return _educational; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Salary
        {
            set { _salary = value; }
            get { return _salary; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WorkExperience
        {
            set { _workexperience = value; }
            get { return _workexperience; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Responsibilities
        {
            set { _responsibilities = value; }
            get { return _responsibilities; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Qualifications
        {
            set { _qualifications = value; }
            get { return _qualifications; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EMail
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Telephone
        {
            set { _telephone = value; }
            get { return _telephone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ContactMan
        {
            set { _contactman = value; }
            get { return _contactman; }
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