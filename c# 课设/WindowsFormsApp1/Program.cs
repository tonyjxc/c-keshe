using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// 尝试visual studio更改
namespace WindowsFormsApp1
{
    public class MyGlobal
    {
        public static string ip = "tonyjxc.xyz,6220";
    }
    static class Program
    {
        
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //决定窗体的位置
            Point local = (Point)new Size(100,200);

            int usingid=-1;      //存储正在使用的用户的userid

            //主要功能的窗体
            //注册、登陆、翻译、背诵

            Login login = new Login();
            /*
            register register1 = new register();
            translate translate1 = new translate();
            */

            //一直做，直到按退出
            while (true)
            {
                //打开
                login = new Login();
                login.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
                login.Location = local;
                login.ShowDialog();

                //注册
                if (login.DialogResult == DialogResult.OK)
                {
                    //记录位置
                    local = login.Location;
                    //保证登陆的位置与前一项的位置一模一样
                    register register1 = new register();
                    register1.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
                    register1.Location = local;
                    register1.ShowDialog();



                    //注册后
                    //重新回到登陆界面,或选择了退出程序
                    if (register1.DialogResult == DialogResult.OK)
                    {
                        local = register1.Location;
                        continue;
                    }
                    else if (register1.DialogResult == DialogResult.Yes)
                        continue;
                    else if (register1.DialogResult == DialogResult.Cancel)
                        return;
                }

                //登陆后
                else if (login.DialogResult == DialogResult.Yes)
                {
                    usingid = login.login_usingid;
                    //MessageBox.Show(Convert.ToString( usingid));
                    //记录位置
                    local = login.Location;

                    translate_or_memory transormem = new translate_or_memory(ref usingid, 1);
                    transormem.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
                    transormem.Location = local;
                    //MessageBox.Show(Convert.ToString(usingid));
                    transormem.ShowDialog();


                    local = transormem.Location;
                    Boolean choosetemp = false;
                    //如果不是选择界面退出，则一直循环
                    while (true)
                    {
                        //除了第一次外，参数都是0
                        if (choosetemp)
                        {
                            transormem = new translate_or_memory(ref usingid, 0);
                            transormem.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
                            transormem.Location = local;
                            //MessageBox.Show(Convert.ToString(usingid));
                            transormem.ShowDialog();
                        }
                        choosetemp = true;
                        //背诵
                        if (transormem.DialogResult == DialogResult.OK)
                        {
                            while (true)
                            {                                
                                memory mem = new memory(ref usingid);      //新建背诵
                                mem.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
                                mem.Location = local;
                                //MessageBox.Show(Convert.ToString(usingid));
                                mem.ShowDialog();

                                //句子
                                if (mem.DialogResult == DialogResult.Yes)
                                {
                                    local = mem.Location;
                                    mem_sen memsen = new mem_sen(usingid);
                                    memsen.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
                                    memsen.Location = local;
                                    //MessageBox.Show(Convert.ToString(usingid));
                                    memsen.ShowDialog();
                                    if (memsen.DialogResult == DialogResult.Abort)
                                    {
                                        local = memsen.Location;
                                        continue;
                                    }
                                    else if (memsen.DialogResult == DialogResult.Cancel)
                                        return;
                                }
                                //单词
                                else if (mem.DialogResult == DialogResult.Abort)
                                {
                                    local = mem.Location;
                                    mem_word memword = new mem_word(usingid);
                                    memword.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
                                    memword.Location = local;
                                    //MessageBox.Show(Convert.ToString(usingid));
                                    memword.ShowDialog();

                                    if (memword.DialogResult == DialogResult.Abort)
                                    {
                                        local = memword.Location;
                                        continue;
                                    }
                                    else if (memword.DialogResult == DialogResult.Cancel)
                                        return;
                                }

                                //返回
                                if (mem.DialogResult == DialogResult.OK)
                                {
                                    local = mem.Location;
                                    break;          //回到选择功能的循环
                                }
                                //退出
                                else if (mem.DialogResult == DialogResult.Cancel)
                                    return;
                            }
                            continue;
                        }
                        //翻译
                        else if (transormem.DialogResult == DialogResult.Yes)
                        {
                            local = transormem.Location;
                            //保证登陆的位置与前一项的位置一模一样
                            translate translate1 = new translate(ref usingid);
                            translate1.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
                            translate1.Location = local;
                            //MessageBox.Show(Convert.ToString(usingid));
                            translate1.ShowDialog();

                            //返回
                            if (translate1.DialogResult == DialogResult.OK)
                            {
                                local = translate1.Location;
                                continue;
                            }
                            //退出
                            else if (translate1.DialogResult == DialogResult.Cancel)
                            {
                                return;
                            }
                        }
                        else if (transormem.DialogResult == DialogResult.Abort)
                        {
                            local = transormem.Location;
                            break;
                        }
                        //退出
                        else if (transormem.DialogResult == DialogResult.Cancel)
                            return;
                    }
                }
                //退出
                else if (login.DialogResult == DialogResult.Cancel)
                    return;

            }


        }
    }
}
