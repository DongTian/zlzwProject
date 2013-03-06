using System;
namespace zlzw.Model
{
    /// <summary>
    /// AdminListModel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class AdminListModel
    {
        public AdminListModel()
        { }
        #region Model
        private int _adminid;
        private Guid _adminguid;
        private string _adminname;
        private string _adminpassword;
        private int? _isenable;
        private DateTime? _publishdate;
        private string _other01;
        private string _other02;
        /// <summary>
        /// 
        /// </summary>
        public int AdminID
        {
            set { _adminid = value; }
            get { return _adminid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid AdminGUID
        {
            set { _adminguid = value; }
            get { return _adminguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AdminName
        {
            set { _adminname = value; }
            get { return _adminname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AdminPassword
        {
            set { _adminpassword = value; }
            get { return _adminpassword; }
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
        #endregion Model

    }
}