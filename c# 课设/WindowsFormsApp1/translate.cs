using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{


    public partial class translate : Form
    {
        String question;        //一个是记录下之前按的问题
        String answer;          //一个是记录下之前的答案
        int firsttime=0;        //记录是不是刚登陆进来
        int word = 0;           //是不是单词，是的话1，不是0，翻译不出来 2
        public int times = 1;       //用户登陆次数
        public int trans_usingid;  //记录正在使用的账户号

        //用来决定是否保存的函数
        public void save()
        {
            //如果刚进来，没东西保存,不跳是否保存的问题
            if (firsttime != 0)
            {

                answer = @answer_txtbox.Text;
                answer = answer.Replace("'", "''");
                //MessageBox.Show(answer);
                //英文和中文顺序
                if ( Regex.Matches(question, "[a-zA-Z]").Count == 0)
                {
                    String temp;
                    temp = answer;
                    answer = question;
                    question = temp;
                }

                //先建立连接
                SqlConnection conn = new SqlConnection("server="+MyGlobal.ip+";database=register_translate;UID=sa;PWD=zyh@197068;Integrated Security=False");
                conn.Open();
                //添加一个是否保存
                //判断是不是有结果和询问是否保存
                if (this.word != 2 && MessageBox.Show("是否要对上次结果进行保存", "信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //保存到数据库
                    if (this.word == 1)
                    {
                        //第一次，和第n次
                        SqlCommand cmd = new SqlCommand("select times from TRANSLATE_WORD where word='" + this.question+"' and userid ='"+this.trans_usingid+"'", conn);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        int searchtimes = 0;        //搜索过的次数
                        if (sdr.Read())
                        {                            
                            searchtimes = sdr.GetInt32(0) + 1;
                            sdr.Close();
                            string myinsert = "update TRANSLATE_WORD set times=" + searchtimes + " where word = '" + this.question+"'";
                            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
                            mycom.ExecuteNonQuery();                                         //执行插入语句 
                        }
                        else
                        {
                            sdr.Close();
                            //插入语句
                            string myinsert = "insert into TRANSLATE_WORD (userid,word,answer,times) values (" + this.trans_usingid+",'"+this.question+"','"+this.answer+ "',1)";
                            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
                            mycom.ExecuteNonQuery();
                        }                                        //执行插入语句 

                    }
                    else if (this.word == 0)
                    {
                        //保存句子
                        //第一次，和第n次
                        SqlCommand cmd = new SqlCommand("select times from TRANSLATE_SENTENCE where sentence='" + this.question + "' and userid ='" + this.trans_usingid + "'", conn);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        int searchtimes = 0;        //搜索过的次数
                        if (sdr.Read())
                        {
                            //改变次数
                            searchtimes = sdr.GetInt32(0) + 1;
                            sdr.Close();
                            string myinsert = "update TRANSLATE_SENTENCE set times=" + searchtimes + " where sentence = '" + this.question + "'";
                            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
                            mycom.ExecuteNonQuery();                                         //执行插入语句 

                            //改变翻译内容
                            myinsert = "update TRANSLATE_SENTENCE set answer='" + this.answer + "' where sentence = '" + this.question + "'";
                            mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
                            mycom.ExecuteNonQuery();                                         //执行插入语句 
                        }
                        else
                        {
                            sdr.Close();
                            //插入语句
                            string myinsert = "insert into TRANSLATE_SENTENCE (userid,sentence,answer,times) values (" + this.trans_usingid + ",'" + this.question + "','" + this.answer + "',1)";
                            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
                            mycom.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    //不保存啥都不做
                    MessageBox.Show("不保存");
                }
            }
        }


        //相当于request
        private static string GetUrlHtml(string url)
        {

            string strHtml = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();//从Internet资源返回数据流

            if (response.CharacterSet.ToLower() == "gbk")
            {
                using (Stream respStream = response.GetResponseStream())//读取数据流
                {
                    using (StreamReader str = new StreamReader(respStream, Encoding.GetEncoding("gb2312")))//读取数据
                    {
                        strHtml = str.ReadToEnd();
                    }
                }
            }
            else
            {
                using (Stream respStream = response.GetResponseStream())//读取数据流
                {
                    using (StreamReader str = new StreamReader(respStream, Encoding.UTF8))//读取数据
                    {
                        strHtml = str.ReadToEnd();
                    }
                }
            }
            return strHtml;
        }


        //正则匹配合成的函数
        public String Patternfun(String answer)
        {
            //因为单词的翻译和句子翻译的源码不一样
            //要进行两次的判断

            //单词
            //先对源码进行两次筛选
            //第一次正则匹配
            //"word_mean":"苹果; 苹果树","sen
            String pattern = "\\\"word_mean\\\":\\\"(.*?)\\\",";
            String ans = null;
            foreach (Match match in Regex.Matches(answer, pattern))
                if (ans == null) ans = (match.Value);


            if (ans != null)
            {
                /*
                //第二次正则匹配
                pattern = @"<span>(.*?)；</span>";
                foreach (Match match in Regex.Matches(ans, pattern))
                    ans = match.Value;
                */
                //整理输出的语句
                ans = ans.Replace("\"word_mean\":\"", "");
                ans = ans.Replace("\"", "");
                this.word = 1;
                return ans;
            }

            //如果查询的是句子，这里就会报错，需要换一种正则匹配来匹配句子
            if (ans == null)
            {
                //句子
                //先对源码进行两次筛选
                //第一次正则匹配
                //'{"translate_result":"(.*?)"'
                pattern = "{\\\"translate_result\\\":\\\"(.*?)\\\"";
                ans = null;
                foreach (Match match in Regex.Matches(answer, pattern))
                    ans = match.Value;
                if (ans != null)
                {
                    /*
                    //第二次正则匹配
                    pattern = @">(.*?)</div>";
                    foreach (Match match in Regex.Matches(ans, pattern))
                        ans = match.Value;
                    */
                    //整理输出的语句
                    ans = ans.Replace("{\"translate_result\":\"", "");
                    ans = ans.Replace("\"", "");
                    this.word = 0;
                    return ans;
                }
            }

            //句子也没有匹配到，则说明输入的东西有误，需要用户重新输入
            //此时返回特殊值
            return ans;
        }


            public translate(ref int usingid)
        {
            this.trans_usingid = usingid;
            //先建立连接
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=register_translate;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();

            //获取登陆次数  
            SqlCommand cmd = new SqlCommand("SELECT times FROM TRANSLATE_USERTIMES where userid=" + this.trans_usingid , conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                //获取登陆的次数
                times = sdr.GetInt32(0);
                sdr.Close();
            }
            conn.Close();
            InitializeComponent();
            this.sayhello.Text = "欢迎您第"+times+"次使用本翻译软件，祝您使用愉快";
        }


        //按下返回按钮
        private void back_but_Click(object sender, EventArgs e)
        {
            //看看是否保存
            this.save();
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            this.Close();
        }

        //按下退出按钮
        private void exit_but_Click(object sender, EventArgs e)
        {
            //添加一个是否保存
            save();
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
            this.Close();
        }



        //按下翻译按钮
        private void translate_but_Click(object sender, EventArgs e)
        {
            //确认usingid
            //MessageBox.Show(Convert.ToString(this.trans_usingid));
            
            //除了第一次外，添加一个是否保存
            if (this.firsttime == 0)
                this.firsttime++;        
            else     
                save();
            
            this.question = question_text.Text;
            String URL = "http://www.iciba.com/" + question;

            //URL_get就是爬到的源码
            String URL_get = GetUrlHtml(URL);
            //Console.WriteLine(URL_get);

            //正则匹配获取结果
            this.answer = Patternfun(URL_get);
            if (answer != null)
                answer_txtbox.Text = answer;
            else
            {
                this.word = 2;
                MessageBox.Show("当中有特殊符号或非法字符！！请重新进行选择！");
                answer_txtbox.Text = ("当中有特殊符号或非法字符！！请重新进行选择！");
            }
            question = question_text.Text;

        }

        private void question_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
