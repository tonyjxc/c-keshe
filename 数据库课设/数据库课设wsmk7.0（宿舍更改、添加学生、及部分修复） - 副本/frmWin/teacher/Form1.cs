﻿using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using keshe;

using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmWin.teacher
{
    public partial class Form1 : Form
    {
        public Form1(string teachId)
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int teachId = Convert.ToInt32(txtteachId.Text);
            string teachName = txtteachName.Text;
            int teachUserName = Convert.ToInt32(txtteachUserName.Text);
            int teachPass = Convert.ToInt32(txtteachPass.Text);

            string sex = "";
            if (rdoMan.Checked) sex = "男";
            else sex = "女";

            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select teachId from teacher", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                teachId = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            teachId++;
            //insert into dormtype(typeId,typeName,personcount,price,sex,memo) values (5,'三人间(男)',3,600,'男','nothing' )
            //insert into dormtype(typeId,typeName,personcount,price,sex,memo) values ("+dormtype_id+",'"typename+"',"+personcount+","+price",'"+sex+"','"+memo+"' )";
            string myinsert = @"insert into teacher(teachId,teachUserName,teachPass,sex,teachName) values (" + teachId + "," + teachUserName + "," + teachPass + ",'" + sex + "','" + teachName + "' )";
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            mycom.ExecuteNonQuery();
            MessageBox.Show(teachName + "寝室楼已经添加成功");
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dormTypeInsertFrm2_Load(object sender, EventArgs e)
        {

        }


    }
}
