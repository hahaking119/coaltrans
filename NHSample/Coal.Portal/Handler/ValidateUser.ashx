﻿<%@ WebHandler Language="C#" Class="ValidateUser" %>

using System;
using System.Web;

public class ValidateUser : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) 
    {

        string validKey = context.Request.QueryString[0];
        string keys = Coal.Util.CryptoHelper.Decrypt(validKey, "coalchina");

        string[] nameAndPassword = keys.Split(',');

        if (nameAndPassword.Length == 2)
        {
            string loginName = nameAndPassword[0];
            string password = nameAndPassword[1];

            if (Coal.BLL.UserManager.ValidLogin(loginName, password))
            {
                //根据loginname 和 password 获取用户， 把用户状态置为valid = 1
                //写cookie，并转向到频道首页
                context.Response.ContentType = "text/plain";
                context.Response.Redirect("../reg_end.aspx");
            }
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}