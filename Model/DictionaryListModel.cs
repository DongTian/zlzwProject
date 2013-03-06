using System;
namespace zlzw.Model
{
    /// <summary>
    /// DictionaryListModel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class DictionaryListModel
    {
        public DictionaryListModel()
        { }
        #region Model
        private int _dictionarylistid;
        private string _dictionarykey;
        private string _dictionaryvalue;
        private string _dictionarycategory;
        private string _dictionarydesc;
        private int? _ordernumber;
        private int? _isinner;
        private int? _isenable;
        private DateTime? _publishdate;
        /// <summary>
        /// 
        /// </summary>
        public int DictionaryListID
        {
            set { _dictionarylistid = value; }
            get { return _dictionarylistid; }
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
        public string DictionaryValue
        {
            set { _dictionaryvalue = value; }
            get { return _dictionaryvalue; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DictionaryCategory
        {
            set { _dictionarycategory = value; }
            get { return _dictionarycategory; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DictionaryDesc
        {
            set { _dictionarydesc = value; }
            get { return _dictionarydesc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? OrderNumber
        {
            set { _ordernumber = value; }
            get { return _ordernumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsInner
        {
            set { _isinner = value; }
            get { return _isinner; }
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
        #endregion Model

    }
}