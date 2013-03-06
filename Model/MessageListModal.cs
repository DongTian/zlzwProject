using System;
namespace zlzw.Model
{
    /// <summary>
    /// MessageListModal:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class MessageListModal
    {
        public MessageListModal()
        { }
        #region Model
        private int _messageid;
        private Guid _messageguid;
        private string _publishusername;
        private string _publishcontent;
        private DateTime? _publishdate;
        private Guid _replyuserguid;
        private string _replycontent;
        private DateTime? _replydate;
        private int? _isreply;
        private int? _isenable;
        private string _other01;
        private string _other02;
        private string _other03;
        private int? _other04;
        /// <summary>
        /// 
        /// </summary>
        public int MessageID
        {
            set { _messageid = value; }
            get { return _messageid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid MessageGUID
        {
            set { _messageguid = value; }
            get { return _messageguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PublishUserName
        {
            set { _publishusername = value; }
            get { return _publishusername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PublishContent
        {
            set { _publishcontent = value; }
            get { return _publishcontent; }
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
        public Guid ReplyUserGUID
        {
            set { _replyuserguid = value; }
            get { return _replyuserguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ReplyContent
        {
            set { _replycontent = value; }
            get { return _replycontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ReplyDate
        {
            set { _replydate = value; }
            get { return _replydate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsReply
        {
            set { _isreply = value; }
            get { return _isreply; }
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
        public string Other03
        {
            set { _other03 = value; }
            get { return _other03; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Other04
        {
            set { _other04 = value; }
            get { return _other04; }
        }
        #endregion Model

    }
}