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
    
    
    public class QiYeXinXiBusFacade
    {
        
        public QiYeXinXiBusFacade()
        {
        }
        
        // 根据主键userID返回指定的QiYeXinXi实体
        public static QiYeXinXiBusEntity GetEntity(int userID)
        {
            QiYeXinXiByPK exec = new QiYeXinXiByPK();
            exec.UserID = userID;
            QiYeXinXiBusEntity obj = new QiYeXinXiBusEntity();
            obj.MetaDataTable = exec.ExecDataTable();
            return obj;
        }
        
        // 返回所有QiYeXinXi
        public static DataTable GetList()
        {
            QiYeXinXiByAll exec = new QiYeXinXiByAll();
            return exec.ExecDataTable();
        }
    }
}
