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
    
    
    public class PinZhongDelete : BaseExecute
    {
        
        private SqlParameter paraCoalVarietyID;
        
        public int CoalVarietyID
        {
            get
            {
return (System.Int32)this.paraCoalVarietyID.Value;
            }
            set
            {
this.paraCoalVarietyID.Value = value;
            }
        }
        
        public PinZhongDelete()
        {
base.InitCommand("PinZhongDelete");
ConfigParameter();
        }
        
        #region 存储过程参数赋值
        public void ConfigParameter()
        {
//--------------------------------------------------------
this.paraCoalVarietyID = new SqlParameter();
this.paraCoalVarietyID.ParameterName = "@CoalVarietyID";
this.paraCoalVarietyID.SqlDbType = SqlDbType.Int;
this.paraCoalVarietyID.Size = 4;
this.paraCoalVarietyID.Direction = ParameterDirection.Input;
this.paraCoalVarietyID.Value=DBNull.Value;
base.m_cmd.Parameters.Add(this.paraCoalVarietyID);
        }
        #endregion
    }
}
