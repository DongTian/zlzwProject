using System;
namespace zlzw.Model
{
    /// <summary>
    /// StoreImageListModal:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class StoreImageListModal
    {
        public StoreImageListModal()
        { }
        #region Model
        private int _storeimageid;
        private Guid _storeimageguid;
        private string _dictionarykey;
        private string _storeimagetitle;
        private string _storeimagedesc;
        private string _storeimagepath;
        private int? _isenable;
        private int? _ishot;
        private DateTime? _publishdate;
        private string _other01;
        private string _other02;
        private string _other03;
        /// <summary>
        /// 
        /// </summary>
        public int StoreImageID
        {
            set { _storeimageid = value; }
            get { return _storeimageid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid StoreImageGUID
        {
            set { _storeimageguid = value; }
            get { return _storeimageguid; }
        }
        /// <summary>
        /// 所属门店
        /// </summary>
        public string DictionaryKey
        {
            set { _dictionarykey = value; }
            get { return _dictionarykey; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StoreImageTitle
        {
            set { _storeimagetitle = value; }
            get { return _storeimagetitle; }
        }
        /// <summary>
        /// 店面图片介绍
        /// </summary>
        public string StoreImageDesc
        {
            set { _storeimagedesc = value; }
            get { return _storeimagedesc; }
        }
        /// <summary>
        /// 店面图片路径
        /// </summary>
        public string StoreImagePath
        {
            set { _storeimagepath = value; }
            get { return _storeimagepath; }
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