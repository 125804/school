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
using System.Collections.Generic;
using DAL;
using Model;
namespace BLL
{
	/// <summary>
	/// student
	/// </summary>
	public  class studentBLL
	{
		private readonly studentDAL dal=new studentDAL();
		public studentBLL()
		{}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public student GetModel(string name,string pwd)
		{
			
			return dal.GetModel(name,pwd);
		}

		
		
	}
}

