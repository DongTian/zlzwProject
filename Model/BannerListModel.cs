using System;
namespace zlzw.Model
{
    /// <summary>
    /// BannerListModel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class BannerListModel
    {
        public BannerListModel()
        { }
        #region Model
        private int _bannerid;
        private Guid _bannerguid;
        private int? _bannertype;
        private string _bannertitle;
        private string _bannercontent;
        private string _bannerimage;
        private string _bannerlinks;
        private int? _isenable;
        private int? _ishot;
        private DateTime? _publishdate;
        private string _other01;
        private string _other02;
        /// <summary>
        /// 
        /// </summary>
        public int BannerID
        {
            set { _bannerid = value; }
            get { return _bannerid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid BannerGUID
        {
            set { _bannerguid = value; }
            get { return _bannerguid; }
        }
        /// <summary>
        /// 0:为首页Banner 1:为首页广告栏横幅
        /// </summary>
        public int? BannerType
        {
            set { _bannertype = value; }
            get { return _bannertype; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string BannerTitle
        {
            set { _bannertitle = value; }
            get { return _bannertitle; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string BannerContent
        {
            set { _bannercontent = value; }
            get { return _bannercontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BannerImage
        {
            set { _bannerimage = value; }
            get { return _bannerimage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BannerLinks
        {
            set { _bannerlinks = value; }
            get { return _bannerlinks; }
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