﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行库版本:2.0.50727.1433
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataEntity
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Data.SqlTypes;
    using System.Xml;
    using System.Reflection;
    
    
    public class UsersDataEntity : BaseEntity
    {
        
        public UsersDataEntity()
        {
        }
        
        private int m_UserID;
        
        public int UserID
        {
            get
            {
return this.m_UserID;
            }
            set
            {
this.m_UserID = value;
            }
        }
        
        private string m_UserName;
        
        public string UserName
        {
            get
            {
return this.m_UserName;
            }
            set
            {
this.m_UserName = value;
            }
        }
        
        private string m_UserPwd;
        
        public string UserPwd
        {
            get
            {
return this.m_UserPwd;
            }
            set
            {
this.m_UserPwd = value;
            }
        }
        
        private string m_UserMail;
        
        public string UserMail
        {
            get
            {
return this.m_UserMail;
            }
            set
            {
this.m_UserMail = value;
            }
        }
        
        private string m_UserQ;
        
        public string UserQ
        {
            get
            {
return this.m_UserQ;
            }
            set
            {
this.m_UserQ = value;
            }
        }
        
        private string m_UserA;
        
        public string UserA
        {
            get
            {
return this.m_UserA;
            }
            set
            {
this.m_UserA = value;
            }
        }
        
        private bool m_IsFormal;
        
        public bool IsFormal
        {
            get
            {
return this.m_IsFormal;
            }
            set
            {
this.m_IsFormal = value;
            }
        }
        
        private System.DateTime m_CreatDate;
        
        public System.DateTime CreatDate
        {
            get
            {
return this.m_CreatDate;
            }
            set
            {
this.m_CreatDate = value;
            }
        }
    }
}
