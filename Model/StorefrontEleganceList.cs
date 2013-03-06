using System;
namespace zlzw.Model
{
    /// <summary>
    /// StorefrontEleganceListModal:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class StorefrontEleganceListModal
    {
        public StorefrontEleganceListModal()
        { }
        #region Model
        private int _storefronteleganceid;
        private Guid _storefronteleganceguid;
        private string _dictionarykey;
        private string _storefrontelegancetitle;
        private string _storefrontelegancedescription;
        private string _storefronteleganceheadimage;
        private string _storefronteleganceimages;
        private string _pushjobs;
        private int? _isenable;
        private DateTime? _publishdate;
        private string _other01;
        private string _other02;
        private string _other03;
        private string _other04;
        /// <summary>
        /// 
        /// </summary>
        public int StorefrontEleganceID
        {
            set { _storefronteleganceid = value; }
            get { return _storefronteleganceid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid StorefrontEleganceGUID
        {
            set { _storefronteleganceguid = value; }
            get { return _storefronteleganceguid; }
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
        public string StorefrontEleganceTitle
        {
            set { _storefrontelegancetitle = value; }
            get { return _storefrontelegancetitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StorefrontEleganceDescription
        {
            set { _storefrontelegancedescription = value; }
            get { return _storefrontelegancedescription; }
        }
        /// <summary>
        /// 店面介绍图片 只允许上传一张
        /// </summary>
        public string StorefrontEleganceHeadImage
        {
            set { _storefronteleganceheadimage = value; }
            get { return _storefronteleganceheadimage; }
        }
        /// <summary>
        /// 店面图片 允许上传多张
        /// </summary>
        public string StorefrontEleganceImages
        {
            set { _storefronteleganceimages = value; }
            get { return _storefronteleganceimages; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PushJobs
        {
            set { _pushjobs = value; }
            get { return _pushjobs; }
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
        public string Other03
        {
            set { _other03 = value; }
            get { return _other03; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Other04
        {
            set { _other04 = value; }
            get { return _other04; }
        }
        #endregion Model

    }
}