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
    public class LianXiXinXiBusRule
    {
        
        public LianXiXinXiBusRule()
        {
        }
        
        #region 公有全局方法insert/update/delete
        // 添加由实体指定的一条记录 AddLianXiXinXi
        public bool Add(LianXiXinXiBusEntity obj)
        {
            return InsertEntity(obj);
        }
        
        // 修改由实体指定的一条记录 ModifyLianXiXinXi
        public bool Modify(LianXiXinXiBusEntity obj)
        {
            return UpdateEntity(obj);
        }
        
        // 物理删除由主键userID指定的一条记录 DeleteLianXiXinXi
        public bool Delete(int userID)
        {
            LianXiXinXiDelete exec = new LianXiXinXiDelete();
            try
            {
                exec.UserID = userID;
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
        // 公用静态方法，插入一条记录 InsertLianXiXinXi
        public static bool InsertEntity(LianXiXinXiBusEntity obj)
        {
            LianXiXinXiInsert exec = new LianXiXinXiInsert();
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
        
        // 公用静态方法，修改一条记录 UpdateLianXiXinXi
        public static bool UpdateEntity(LianXiXinXiBusEntity obj)
        {
            if (obj == null || obj.IsEmpty)
            {
                return false;
            }
            LianXiXinXiUpdate exec = new LianXiXinXiUpdate();
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
        
        // 公用静态方法，删除一条记录 DeleteLianXiXinXi
        public static bool DeleteEntity(LianXiXinXiBusEntity obj)
        {
            if (obj == null || obj.IsEmpty)
            {
                return false;
            }
            LianXiXinXiDelete exec = new LianXiXinXiDelete();
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