﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行库版本:2.0.50727.1433
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLogic
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Data.SqlTypes;
    using System.Xml;
    using System.Reflection;
    
    
    public class UsersByUserName : BaseExecute
    {
        
        private SqlParameter paraUsername;
        
        public string Username
        {
            get
            {
return (System.String)this.paraUsername.Value;
            }
            set
            {
this.paraUsername.Value = value;
            }
        }
        
        public UsersByUserName()
        {
base.InitCommand("UsersByUserName");
ConfigParameter();
        }
        
        #region 存储过程参数赋值
        public void ConfigParameter()
        {
//--------------------------------------------------------
this.paraUsername = new SqlParameter();
this.paraUsername.ParameterName = "@Username";
this.paraUsername.SqlDbType = SqlDbType.NVarChar;
this.paraUsername.Size = 20;
this.paraUsername.Direction = ParameterDirection.Input;
this.paraUsername.Value=DBNull.Value;
base.m_cmd.Parameters.Add(this.paraUsername);
        }
        #endregion
    }
}
