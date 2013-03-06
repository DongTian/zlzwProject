using System;
namespace zlzw.Model
{
    /// <summary>
    /// CareersTypeListModel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CareersTypeListModel
    {
        public CareersTypeListModel()
        { }
        #region Model
        private int _careerstypeid;
        private string _careerstypename;
        private int? _isenable;
        private DateTime? _publishdate;
        private string _other01;
        private string _other02;
        /// <summary>
        /// 诚聘英才类型ID
        /// </summary>
        public int CareersTypeID
        {
            set { _careerstypeid = value; }
            get { return _careerstypeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CareersTypeName
        {
            set { _careerstypename = value; }
            get { return _careerstypename; }
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