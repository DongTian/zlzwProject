using System;
namespace zlzw.Model
{
    /// <summary>
    /// NewsTypeListModal:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class NewsTypeListModal
    {
        public NewsTypeListModal()
        { }
        #region Model
        private int _newstypeid;
        private string _newstypename;
        private int? _isenable;
        private DateTime? _publishdate4;
        private string _other01;
        private string _other02;
        /// <summary>
        /// 
        /// </summary>
        public int NewsTypeID
        {
            set { _newstypeid = value; }
            get { return _newstypeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NewsTypeName
        {
            set { _newstypename = value; }
            get { return _newstypename; }
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
        public DateTime? PublishDate4
        {
            set { _publishdate4 = value; }
            get { return _publishdate4; }
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