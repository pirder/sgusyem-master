﻿/* ***********************************************
 * author :  罗敏贵
 * email  :  minguiluo@163.com 
 * function: 
 * history:  created by 罗敏贵 2010-3-21 17:18:30 
 * ***********************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace MyProject
{
    /// <summary>
    /// 数据库常量配置
    /// </summary>
    [DebuggerStepThrough]
    public class SysConst
    {
        /// <summary>
        ///  源数据库 连接字符串
        /// </summary>
        public static string SourceDbConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=patent.accdb;Persist Security Info=False";
        ///  目标数据库连接字符串
        /// </summary>
        public static string GoalDbConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=patent.accdb;Persist Security Info=False";


        /// <summary>
        /// --读取库中的所有表名
        /// </summary>
        public const string table = "select name from sysobjects where xtype='u'";
        /// <summary>
        /// --读取指定表的所有列名
        /// </summary>
        public const string columns = "select name from syscolumns where id=(select max(id) from sysobjects where xtype='u' and name='{0}')";
        /// <summary>
        /// --读取库中的所有视图名
        /// </summary>
        public const string view = "select name from sysobjects where xtype='v'";
        public SysConst()
        { 
        
        }
    }
}
