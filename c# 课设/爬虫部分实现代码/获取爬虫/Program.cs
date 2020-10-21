using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
namespace 获取爬虫
{using System.Text.RegularExpressions;
    class Program
    {

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
        public static String Patternfun(String answer)
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
                if(ans==null)   ans=(match.Value);

            
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
                    ans=match.Value;
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
                }         
            }

            //句子也没有匹配到，则说明输入的东西有误，需要用户重新输入
            //此时返回特殊值
            return ans;

        }
        static void Main(string[] args)
        {
            String question = "今天天气不错，不如一起出去打篮球吧";
            String URL =  "http://www.iciba.com/" + question;

            //answer就是爬到的源码
            String URL_get = GetUrlHtml(URL);
            //Console.WriteLine(URL_get);
            
            //正则匹配获取结果
            String answer = Patternfun(URL_get);
            if (answer != null)
                Console.WriteLine(answer);
            else
                Console.WriteLine("未找到匹配的。。。");
        }
    }
}
