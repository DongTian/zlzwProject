using System;
namespace zlzw.Model
{
    /// <summary>
    /// VentureStarListModal:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class VentureStarListModal
    {
        public VentureStarListModal()
        { }
        #region Model
        private int _venturestarid;
        private Guid _venturestarguid;
        private string _venturestarsource;
        private string _dictionarykey;
        private string _venturestarname;
        private string _venturestarcontent;
        private string _venturestarimage;
        private int? _ishot;
        private int? _isenable;
        private DateTime? _publishdate;
        private string _other01;
        private string _other02;
        /// <summary>
        /// 
        /// </summary>
        public int VentureStarID
        {
            set { _venturestarid = value; }
            get { return _venturestarid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid VentureStarGUID
        {
            set { _venturestarguid = value; }
            get { return _venturestarguid; }
        }
        /// <summary>
        /// 备用
        /// </summary>
        public string VentureStarSource
        {
            set { _venturestarsource = value; }
            get { return _venturestarsource; }
        }
        /// <summary>
        /// 所在店面
        /// </summary>
        public string DictionaryKey
        {
            set { _dictionarykey = value; }
            get { return _dictionarykey; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VentureStarName
        {
            set { _venturestarname = value; }
            get { return _venturestarname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VentureStarContent
        {
            set { _venturestarcontent = value; }
            get { return _venturestarcontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VentureStarImage
        {
            set { _venturestarimage = value; }
            get { return _venturestarimage; }
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