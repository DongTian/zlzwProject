using System;
namespace zlzw.Model
{
    /// <summary>
    /// StoreStatisticsListModal:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class StoreStatisticsListModal
    {
        public StoreStatisticsListModal()
        { }
        #region Model
        private int _storestatisticsid;
        private Guid _storestatisticsguid;
        private DateTime? _storestatisticsdate;
        private string _storedictionarykey;
        private string _dictionarykey;
        private string _indexvalue;
        private string _indexdesc;
        private int? _storestatisticsorder;
        private int? _isenable;
        private DateTime? _publishdate;
        private string _other01;
        private string _other02;
        private string _other03;
        private string _other04;
        /// <summary>
        /// 
        /// </summary>
        public int StoreStatisticsID
        {
            set { _storestatisticsid = value; }
            get { return _storestatisticsid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid StoreStatisticsGUID
        {
            set { _storestatisticsguid = value; }
            get { return _storestatisticsguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? StoreStatisticsDate
        {
            set { _storestatisticsdate = value; }
            get { return _storestatisticsdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StoreDictionaryKey
        {
            set { _storedictionarykey = value; }
            get { return _storedictionarykey; }
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
        public string IndexValue
        {
            set { _indexvalue = value; }
            get { return _indexvalue; }
        }
        /// <summary>
        /// 店面介绍图片 只允许上传一张
        /// </summary>
        public string IndexDesc
        {
            set { _indexdesc = value; }
            get { return _indexdesc; }
        }
        /// <summary>
        /// 店面图片 允许上传多张
        /// </summary>
        public int? StoreStatisticsOrder
        {
            set { _storestatisticsorder = value; }
            get { return _storestatisticsorder; }
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