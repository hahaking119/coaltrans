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
    
    
    public class PinDaoSheZhiBusFacade
    {
        
        public PinDaoSheZhiBusFacade()
        {
        }
        
        // 根据主键ID返回指定的PinDaoSheZhi实体
        public static PinDaoSheZhiBusEntity GetEntity(int ID)
        {
            PinDaoSheZhiByPK exec = new PinDaoSheZhiByPK();
            exec.ID = ID;
            PinDaoSheZhiBusEntity obj = new PinDaoSheZhiBusEntity();
            obj.MetaDataTable = exec.ExecDataTable();
            return obj;
        }
        
        // 返回所有PinDaoSheZhi
        public static DataTable GetList()
        {
            PinDaoSheZhiByAll exec = new PinDaoSheZhiByAll();
            return exec.ExecDataTable();
        }
    }
}
