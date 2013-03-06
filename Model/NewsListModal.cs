using System;
namespace zlzw.Model
{
    /// <summary>
    /// NewsListModel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class NewsListModel
    {
        public NewsListModel()
        { }
        #region Model
        private int _newsid;
        private Guid _newsguid;
        private string _dictionarykey;
        private string _newstitle;
        private string _newstag;
        private string _newssummary;
        private string _newscontent;
        private string _newssource;
        private string _newssourcelink;
        private Guid _publishuserguid;
        private DateTime? _publishdate;
        private int? _isenable;
        private int? _ishot;
        private int? _viewcount;
        private string _other01;
        private string _other02;
        private string _other03;
        /// <summary>
        /// 
        /// </summary>
        public int NewsID
        {
            set { _newsid = value; }
            get { return _newsid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid NewsGUID
        {
            set { _newsguid = value; }
            get { return _newsguid; }
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
        public string NewsTitle
        {
            set { _newstitle = value; }
            get { return _newstitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NewsTag
        {
            set { _newstag = value; }
            get { return _newstag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NewsSummary
        {
            set { _newssummary = value; }
            get { return _newssummary; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NewsContent
        {
            set { _newscontent = value; }
            get { return _newscontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NewsSource
        {
            set { _newssource = value; }
            get { return _newssource; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NewsSourceLink
        {
            set { _newssourcelink = value; }
            get { return _newssourcelink; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid PublishUserGUID
        {
            set { _publishuserguid = value; }
            get { return _publishuserguid; }
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
        public int? IsHot
        {
            set { _ishot = value; }
            get { return _ishot; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ViewCount
        {
            set { _viewcount = value; }
            get { return _viewcount; }
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