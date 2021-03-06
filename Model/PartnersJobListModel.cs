﻿using System;
namespace zlzw.Model
{
    /// <summary>
    /// PartnersJobListModel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PartnersJobListModel
    {
        public PartnersJobListModel()
        { }
        #region Model
        private int _partnersjobid;
        private Guid _partnerguid;
        private string _workadd;
        private string _recruitmentnumber;
        private string _postinfo;
        private string _postdemand;
        private string _treatmentinfo;
        private string _otherinfo;
        private int? _isenable;
        private int? _ishot;
        private DateTime? _publishdate;
        private string _other01;
        private string _other02;
        /// <summary>
        /// 合作伙伴职位管理
        /// </summary>
        public int PartnersJobID
        {
            set { _partnersjobid = value; }
            get { return _partnersjobid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid PartnerGUID
        {
            set { _partnerguid = value; }
            get { return _partnerguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WorkAdd
        {
            set { _workadd = value; }
            get { return _workadd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RecruitmentNumber
        {
            set { _recruitmentnumber = value; }
            get { return _recruitmentnumber; }
        }
        /// <summary>
        /// 招聘职位信息
        /// </summary>
        public string PostInfo
        {
            set { _postinfo = value; }
            get { return _postinfo; }
        }
        /// <summary>
        /// 岗位要求
        /// </summary>
        public string PostDemand
        {
            set { _postdemand = value; }
            get { return _postdemand; }
        }
        /// <summary>
        /// 待遇相关
        /// </summary>
        public string TreatmentInfo
        {
            set { _treatmentinfo = value; }
            get { return _treatmentinfo; }
        }
        /// <summary>
        /// 备注其他
        /// </summary>
        public string OtherInfo
        {
            set { _otherinfo = value; }
            get { return _otherinfo; }
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