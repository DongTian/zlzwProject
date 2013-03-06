using System;
namespace zlzw.Model
{
    /// <summary>
    /// LinkListModal:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class LinkListModal
    {
        public LinkListModal()
        { }
        #region Model
        private int _linkid;
        private Guid _linkguid;
        private string _linktitle;
        private string _linktarget;
        private string _linkimage;
        private DateTime? _publishdate;
        private int? _linktype;
        private string _linkdesc;
        private int? _isenable;
        private string _other01;
        private string _other02;
        private int? _other03;
        /// <summary>
        /// 
        /// </summary>
        public int LinkID
        {
            set { _linkid = value; }
            get { return _linkid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid LinkGUID
        {
            set { _linkguid = value; }
            get { return _linkguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LinkTitle
        {
            set { _linktitle = value; }
            get { return _linktitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LinkTarget
        {
            set { _linktarget = value; }
            get { return _linktarget; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LinkImage
        {
            set { _linkimage = value; }
            get { return _linkimage; }
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
        /// 0为图片类型 1为文字类型
        /// </summary>
        public int? LinkType
        {
            set { _linktype = value; }
            get { return _linktype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LinkDesc
        {
            set { _linkdesc = value; }
            get { return _linkdesc; }
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
        public int? Other03
        {
            set { _other03 = value; }
            get { return _other03; }
        }
        #endregion Model

    }
}