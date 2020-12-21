﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using keshe;
using frmWin.fun;

namespace frmWin.chargeType
{
    class Class2
    {
		/// <summary>
		/// 专门用来添加数据的方法
		/// sql语句可以连接数据库进行操作数据
		/// </summary>
		/// <param name="d">
		/// dormType是实体类
		/// 用来保存用户提交的参数
		/// 方便此方法多次使用且数据不会被覆盖
		/// </param>
		public void insert(Class1 d)
		{
			SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
			conn.Open();

			string mysql = string.Format(@"insert into chargeType(typeid,typeName,unitPrice,memo) 
											values('{0}','{1}','{2}','{3}','{4}')",
													d.typeid, d.typeName, d.unitPrice, d.memo);
			SqlCommand sql = new SqlCommand(mysql, conn);
			SqlDataReader reader = sql.ExecuteReader();

		}
		public void update(Class1 d)
		{
			SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
			conn.Open();
			string mysql = string.Format(@"update chargeType set 
										typeid = '{0}',typeName = '{1}',unitPrice = '{2}', where memo = {3}",
										d.typeid, d.typeName, d.unitPrice, d.memo);
			SqlCommand sql = new SqlCommand(mysql, conn);
			SqlDataReader reader = sql.ExecuteReader();
			reader.Close();
			conn.Close();
		}


		public DataTable findTypeName(string name)
		{
			SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
			conn.Open();
			string mysql = string.Format("select typeid from chargeType where chargeid = '{0}'", name);
			SqlCommand sql = new SqlCommand(mysql, conn);
			SqlDataReader reader = sql.ExecuteReader();
			DataTable dt = new DataTable();
			while (reader.Read())//决定行数
			{
				dt.Columns.Add(reader[1].ToString());//是第二列吧？？？
			}
			reader.Close();
			conn.Close();
			return dt;
		}

		public void delete(Class1 d)
		{
			SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
			conn.Open();
			string mysql = string.Format("delete from chargeType where typeid = {0}", d.typeid);
			SqlCommand sql = new SqlCommand(mysql, conn);
			SqlDataReader reader;
			try
			{
				reader = sql.ExecuteReader();
				reader.Close();
				conn.Close();
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show("该项正在被使用，无法删除！", "温馨提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
			}
		}

		/// <summary>
		/// 按类型名称进行模糊查询
		/// 可以查询到用户所需要的数据
		/// </summary>
		/// </param>
		/// <param name="page">
		/// PageHelper用来帮助分页
		/// 使用此类中的方法来填写limit的查询要求
		/// </param>
		/// limit一般是用于select语句中用以从结果集中拿出特定的一部分数据。
		/// 用处：我目前用到的地方是数据库查询分页，比如前台要展示数据库中数据，需要后台实现分页，传入数据要有“页码page”跟“每页数据条数nums”。
		/// 对应SQL大概是这样子：select* from mytbl order by id limit(page-1)*nums,nums
		/// <returns>按条件返回分页后的查询内容，方便之后的使用</returns>
		public DataTable findAll(Class1 d, PageHelper page)
		{
			SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
			conn.Open();
			string mysql = string.Format("select * from chargeType where typeName like '%{0}%' order by typerid asc limit {1},{2}", d.typeName, page.getBegin(), page.pageSize);
			SqlCommand sql = new SqlCommand(mysql, conn);
			SqlDataReader reader = sql.ExecuteReader();
			DataTable dt = new DataTable();
			while (reader.Read())//决定行数
			{
				dt.Columns.Add(reader.ToString());
			}
			reader.Close();
			conn.Close();
			return dt;
		}
		public int count(Class1 d)
		{
			SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
			conn.Open();
			string mysql = string.Format("select * from chargeType where chargeType like '%{0}%'", d.typeName);
			SqlCommand sql = new SqlCommand(mysql, conn);
			SqlDataReader reader = sql.ExecuteReader();
			DataTable dt = new DataTable();
			while (reader.Read())//决定行数
			{
				dt.Columns.Add(reader.ToString());
			}
			reader.Close();
			conn.Close();
			return dt.Rows.Count;
		}


		/// <summary>
		/// 此方法用来查询dormType表中的所有数据
		/// 为之后的下拉框中的数据做准备
		/// </summary>
		/// <returns>返回查询到的所有数据，方便之后成为下拉框的值 </returns>
		public DataTable queryAll()
		{
			SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
			conn.Open();
			string mysql = string.Format("select * from chargeType");
			SqlCommand sql = new SqlCommand(mysql, conn);
			SqlDataReader reader = sql.ExecuteReader();
			DataTable dt = new DataTable();
			while (reader.Read())//决定行数
			{
				dt.Columns.Add(reader.ToString());
			}
			reader.Close();
			conn.Close();
			return dt;
		}
	}
}