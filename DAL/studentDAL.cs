/**  版本信息模板在安装目录下，可自行修改。
* student.cs
*
* 功 能： N/A
* 类 名： student
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/2/28 23:06:26   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Model;
namespace DAL
{
	/// <summary>
	/// 数据访问类:student
	/// </summary>
	public  class studentDAL
	{
		public studentDAL()
		{}
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public student GetModel(string name, string pwd)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 stuID,stuLoginName,stuLoginPWD,stuState,stuRealName,stuNo,stuSex,gradeID,classID from student ");

            strSql.Append(" where stuLoginName='" + name + "' and stuLoginPWD='" + pwd + "'");

            student model = new  student();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public student DataRowToModel(DataRow row)
        {
           student model = new student();
            if (row != null)
            {
                if (row["stuID"] != null && row["stuID"].ToString() != "")
                {
                    model.stuID = int.Parse(row["stuID"].ToString());
                }
                if (row["stuLoginName"] != null)
                {
                    model.stuLoginName = row["stuLoginName"].ToString();
                }
                if (row["stuLoginPWD"] != null)
                {
                    model.stuLoginPWD = row["stuLoginPWD"].ToString();
                }
                if (row["stuState"] != null && row["stuState"].ToString() != "")
                {
                    if ((row["stuState"].ToString() == "1") || (row["stuState"].ToString().ToLower() == "true"))
                    {
                        model.stuState = true;
                    }
                    else
                    {
                        model.stuState = false;
                    }
                }
                if (row["stuRealName"] != null)
                {
                    model.stuRealName = row["stuRealName"].ToString();
                }
                if (row["stuNo"] != null)
                {
                    model.stuNo = row["stuNo"].ToString();
                }
                if (row["stuSex"] != null && row["stuSex"].ToString() != "")
                {
                    if ((row["stuSex"].ToString() == "1") || (row["stuSex"].ToString().ToLower() == "true"))
                    {
                        model.stuSex = true;
                    }
                    else
                    {
                        model.stuSex = false;
                    }
                }
                if (row["gradeID"] != null && row["gradeID"].ToString() != "")
                {
                    model.gradeID = int.Parse(row["gradeID"].ToString());
                }
                if (row["classID"] != null && row["classID"].ToString() != "")
                {
                    model.classID = int.Parse(row["classID"].ToString());
                }
            }
            return model;
        }
	
	}
}

