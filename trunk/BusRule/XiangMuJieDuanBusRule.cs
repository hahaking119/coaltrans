﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行库版本:2.0.50727.1433
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusRule
{
    using System;
    using System.Data;
    using System.Xml;
    using System.Reflection;
    using System.Data.SqlClient;
    using DataLogic;
    using BusEntity;
    using BusFacade;
    
    
    // [Transaction(TransactionOption.Required)]
    public class XiangMuJieDuanBusRule
    {
        
        public XiangMuJieDuanBusRule()
        {
        }
        
        #region 公有全局方法insert/update/delete
        // 添加由实体指定的一条记录 AddXiangMuJieDuan
        public bool Add(XiangMuJieDuanBusEntity obj)
        {
            return InsertEntity(obj);
        }
        
        // 修改由实体指定的一条记录 ModifyXiangMuJieDuan
        public bool Modify(XiangMuJieDuanBusEntity obj)
        {
            return UpdateEntity(obj);
        }
        
        // 物理删除由主键ID指定的一条记录 DeleteXiangMuJieDuan
        public bool Delete(int ID)
        {
            XiangMuJieDuanDelete exec = new XiangMuJieDuanDelete();
            try
            {
                exec.ID = ID;
                exec.ExecNoQuery();
                return true;
            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }
            finally
            {
                exec = null;
            }
        }
        #endregion
        
        #region 公有静态全局方法insert/update/delete
        // 公用静态方法，插入一条记录 InsertXiangMuJieDuan
        public static bool InsertEntity(XiangMuJieDuanBusEntity obj)
        {
            XiangMuJieDuanInsert exec = new XiangMuJieDuanInsert();
            try
            {
                exec.ReceiveParameter(obj);
                exec.ExecNoQuery();
                return true;
            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }
            finally
            {
                obj = null;
            }
        }
        
        // 公用静态方法，修改一条记录 UpdateXiangMuJieDuan
        public static bool UpdateEntity(XiangMuJieDuanBusEntity obj)
        {
            if (obj == null || obj.IsEmpty)
            {
                return false;
            }
            XiangMuJieDuanUpdate exec = new XiangMuJieDuanUpdate();
            try
            {
                exec.ReceiveParameter(obj);
                exec.ExecNoQuery();
                return true;
            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }
            finally
            {
                obj = null;
            }
        }
        
        // 公用静态方法，删除一条记录 DeleteXiangMuJieDuan
        public static bool DeleteEntity(XiangMuJieDuanBusEntity obj)
        {
            if (obj == null || obj.IsEmpty)
            {
                return false;
            }
            XiangMuJieDuanDelete exec = new XiangMuJieDuanDelete();
            try
            {
                exec.ReceiveParameter(obj);
                exec.ExecNoQuery();
                return true;
            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }
            finally
            {
                obj = null;
            }
        }
        #endregion
    }
}
