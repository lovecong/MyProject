using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace RoadFlow.Data.Factory
{
    public class Factory
    {
        /*
        private static string dataType = RoadFlow.Utility.Config.DataBaseType;
        private static string cacheKey = RoadFlow.Utility.Keys.CacheKeys.ClassInstance_.ToString();
        public static object CreateInstance(string className)
        {
            string cacheKey1 = cacheKey + className;
            string typeName = "RoadFlow.Data." + dataType + "." + className;
            object obj = RoadFlow.Cache.IO.Opation.Get(cacheKey1);
            if (obj == null)
            {
                Type type = Assembly.Load("RoadFlow.Data." + dataType).GetType(typeName, true);
                obj = Activator.CreateInstance(type);
             
                RoadFlow.Cache.IO.Opation.Set(cacheKey1, obj);
        
                return obj;
            }
            else
            {
                return obj;
            }
        }
        */

        
        //#region MSSQL
        //public static Data.Interface.IAppLibrary GetAppLibrary()
        //{
        //    return new Data.MSSQL.AppLibrary();
        //}

        //public static Data.Interface.IDBConnection GetDBConnection()
        //{
        //    return new Data.MSSQL.DBConnection();
        //}

        //public static Data.Interface.IDictionary GetDictionary()
        //{
        //    return new Data.MSSQL.Dictionary();
        //}

        //public static Data.Interface.ILog GetLog()
        //{
        //    return new Data.MSSQL.Log();
        //}

        //public static Data.Interface.IOrganize GetOrganize()
        //{
        //    return new Data.MSSQL.Organize();
        //}

        //public static Data.Interface.IRole GetRole()
        //{
        //    return new Data.MSSQL.Role();
        //}

        //public static Data.Interface.IRoleApp GetRoleApp()
        //{
        //    return new Data.MSSQL.RoleApp();
        //}

        //public static Data.Interface.IUsers GetUsers()
        //{
        //    return new Data.MSSQL.Users();
        //}

        //public static Data.Interface.IUsersApp GetUsersApp()
        //{
        //    return new Data.MSSQL.UsersApp();
        //}

        //public static Data.Interface.IUsersInfo GetUsersInfo()
        //{
        //    return new Data.MSSQL.UsersInfo();
        //}

        //public static Data.Interface.IUsersRelation GetUsersRelation()
        //{
        //    return new Data.MSSQL.UsersRelation();
        //}

        //public static Data.Interface.IUsersRole GetUsersRole()
        //{
        //    return new Data.MSSQL.UsersRole();
        //}

        //public static Data.Interface.IWorkFlow GetWorkFlow()
        //{
        //    return new Data.MSSQL.WorkFlow();
        //}

        //public static Data.Interface.IWorkFlowArchives GetWorkFlowArchives()
        //{
        //    return new Data.MSSQL.WorkFlowArchives();
        //}

        //public static Data.Interface.IWorkFlowButtons GetWorkFlowButtons()
        //{
        //    return new Data.MSSQL.WorkFlowButtons();
        //}

        //public static Data.Interface.IWorkFlowComment GetWorkFlowComment()
        //{
        //    return new Data.MSSQL.WorkFlowComment();
        //}

        //public static Data.Interface.IWorkFlowData GetWorkFlowData()
        //{
        //    return new Data.MSSQL.WorkFlowData();
        //}

        //public static Data.Interface.IWorkFlowDelegation GetWorkFlowDelegation()
        //{
        //    return new Data.MSSQL.WorkFlowDelegation();
        //}

        //public static Data.Interface.IWorkFlowForm GetWorkFlowForm()
        //{
        //    return new Data.MSSQL.WorkFlowForm();
        //}

        //public static Data.Interface.IWorkFlowTask GetWorkFlowTask()
        //{
        //    return new Data.MSSQL.WorkFlowTask();
        //}

        //public static Data.Interface.IWorkGroup GetWorkGroup()
        //{
        //    return new Data.MSSQL.WorkGroup();
        //}

        //#endregion

        #region MYSQL
        public static Data.Interface.IAppLibrary GetAppLibrary()
        {
            return new Data.MYSQL.AppLibrary();
        }

        public static Data.Interface.IDBConnection GetDBConnection()
        {
            return new Data.MYSQL.DBConnection();
        }

        public static Data.Interface.IDictionary GetDictionary()
        {
            return new Data.MYSQL.Dictionary();
        }

        public static Data.Interface.ILog GetLog()
        {
            return new Data.MYSQL.Log();
        }

        public static Data.Interface.IOrganize GetOrganize()
        {
            return new Data.MYSQL.Organize();
        }

        public static Data.Interface.IRole GetRole()
        {
            return new Data.MYSQL.Role();
        }

        public static Data.Interface.IRoleApp GetRoleApp()
        {
            return new Data.MYSQL.RoleApp();
        }

        public static Data.Interface.IUsers GetUsers()
        {
            return new Data.MYSQL.Users();
        }

        public static Data.Interface.IUsersApp GetUsersApp()
        {
            return new Data.MYSQL.UsersApp();
        }

        public static Data.Interface.IUsersInfo GetUsersInfo()
        {
            return new Data.MYSQL.UsersInfo();
        }

        public static Data.Interface.IUsersRelation GetUsersRelation()
        {
            return new Data.MYSQL.UsersRelation();
        }

        public static Data.Interface.IUsersRole GetUsersRole()
        {
            return new Data.MYSQL.UsersRole();
        }

        public static Data.Interface.IWorkFlow GetWorkFlow()
        {
            return new Data.MYSQL.WorkFlow();
        }

        public static Data.Interface.IWorkFlowArchives GetWorkFlowArchives()
        {
            return new Data.MYSQL.WorkFlowArchives();
        }

        public static Data.Interface.IWorkFlowButtons GetWorkFlowButtons()
        {
            return new Data.MYSQL.WorkFlowButtons();
        }

        public static Data.Interface.IWorkFlowComment GetWorkFlowComment()
        {
            return new Data.MYSQL.WorkFlowComment();
        }

        public static Data.Interface.IWorkFlowData GetWorkFlowData()
        {
            return new Data.MYSQL.WorkFlowData();
        }

        public static Data.Interface.IWorkFlowDelegation GetWorkFlowDelegation()
        {
            return new Data.MYSQL.WorkFlowDelegation();
        }

        public static Data.Interface.IWorkFlowForm GetWorkFlowForm()
        {
            return new Data.MYSQL.WorkFlowForm();
        }

        public static Data.Interface.IWorkFlowTask GetWorkFlowTask()
        {
            return new Data.MYSQL.WorkFlowTask();
        }

        public static Data.Interface.IWorkGroup GetWorkGroup()
        {
            return new Data.MYSQL.WorkGroup();
        }

        #endregion
        #region ORACLE
        /*
        public static Data.Interface.IAppLibrary GetAppLibrary()
        {
            return new Data.ORACLE.AppLibrary();
        }

        public static Data.Interface.IDBConnection GetDBConnection()
        {
            return new Data.ORACLE.DBConnection();
        }

        public static Data.Interface.IDictionary GetDictionary()
        {
            return new Data.ORACLE.Dictionary();
        }

        public static Data.Interface.ILog GetLog()
        {
            return new Data.ORACLE.Log();
        }

        public static Data.Interface.IOrganize GetOrganize()
        {
            return new Data.ORACLE.Organize();
        }

        public static Data.Interface.IRole GetRole()
        {
            return new Data.ORACLE.Role();
        }

        public static Data.Interface.IRoleApp GetRoleApp()
        {
            return new Data.ORACLE.RoleApp();
        }

        public static Data.Interface.IUsers GetUsers()
        {
            return new Data.ORACLE.Users();
        }

        public static Data.Interface.IUsersApp GetUsersApp()
        {
            return new Data.ORACLE.UsersApp();
        }

        public static Data.Interface.IUsersInfo GetUsersInfo()
        {
            return new Data.ORACLE.UsersInfo();
        }

        public static Data.Interface.IUsersRelation GetUsersRelation()
        {
            return new Data.ORACLE.UsersRelation();
        }

        public static Data.Interface.IUsersRole GetUsersRole()
        {
            return new Data.ORACLE.UsersRole();
        }

        public static Data.Interface.IWorkFlow GetWorkFlow()
        {
            return new Data.ORACLE.WorkFlow();
        }

        public static Data.Interface.IWorkFlowArchives GetWorkFlowArchives()
        {
            return new Data.ORACLE.WorkFlowArchives();
        }

        public static Data.Interface.IWorkFlowButtons GetWorkFlowButtons()
        {
            return new Data.ORACLE.WorkFlowButtons();
        }

        public static Data.Interface.IWorkFlowComment GetWorkFlowComment()
        {
            return new Data.ORACLE.WorkFlowComment();
        }

        public static Data.Interface.IWorkFlowData GetWorkFlowData()
        {
            return new Data.ORACLE.WorkFlowData();
        }

        public static Data.Interface.IWorkFlowDelegation GetWorkFlowDelegation()
        {
            return new Data.ORACLE.WorkFlowDelegation();
        }

        public static Data.Interface.IWorkFlowForm GetWorkFlowForm()
        {
            return new Data.ORACLE.WorkFlowForm();
        }

        public static Data.Interface.IWorkFlowTask GetWorkFlowTask()
        {
            return new Data.ORACLE.WorkFlowTask();
        }

        public static Data.Interface.IWorkGroup GetWorkGroup()
        {
            return new Data.ORACLE.WorkGroup();
        }
        */
        #endregion
    }
}
