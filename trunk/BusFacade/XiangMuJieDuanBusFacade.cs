﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行库版本:2.0.50727.1433
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusFacade
{
    using System;
    using System.Data;
    using System.Xml;
    using System.Reflection;
    using System.Data.SqlClient;
    using DataLogic;
    using BusEntity;
    
    
    public class XiangMuJieDuanBusFacade
    {
        
        public XiangMuJieDuanBusFacade()
        {
        }
        
        // 根据主键ID返回指定的XiangMuJieDuan实体
        public static XiangMuJieDuanBusEntity GetEntity(int ID)
        {
            XiangMuJieDuanByPK exec = new XiangMuJieDuanByPK();
            exec.ID = ID;
            XiangMuJieDuanBusEntity obj = new XiangMuJieDuanBusEntity();
            obj.MetaDataTable = exec.ExecDataTable();
            return obj;
        }
        
        // 返回所有XiangMuJieDuan
        public static DataTable GetList()
        {
            XiangMuJieDuanByAll exec = new XiangMuJieDuanByAll();
            return exec.ExecDataTable();
        }
    }
}
