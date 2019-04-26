using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 解决端口占用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string cmd(string strInput)
        {
            // 创建进程
            Process p = new Process();
            //设置要启动的应用程序
            p.StartInfo.FileName = "cmd.exe";
            //是否使用操作系统shell启动
            p.StartInfo.UseShellExecute = false;
            // 接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardInput = true;
            //输出信息
            p.StartInfo.RedirectStandardOutput = true;
            // 输出错误
            p.StartInfo.RedirectStandardError = true;
            //不显示程序窗口
            p.StartInfo.CreateNoWindow = true;
            //启动程序
            p.Start();
            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(strInput + "&exit");
            p.StandardInput.AutoFlush = true;
            //获取输出信息
            string strOuput = p.StandardOutput.ReadToEnd();
            //等待程序执行完退出进程
            p.WaitForExit();
            p.Close();
            return strOuput;
        }

        private void check_Click(object sender, EventArgs e)
        {
            try
            {
                // 获取端口
                string port = this.port.Text;
                // 判断是否输入
                if (port == "")
                {
                    MessageBox.Show("请输入端口", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    string strInput = "netstat -aon|findstr " + port;
                    string strOuput = cmd(strInput);
                    // 判断是否有返回值
                    if (strOuput == "")
                    {
                        MessageBox.Show("该端口未被占用");
                        return;
                    }
                    else
                    {
                        int i = strOuput.IndexOf('&');
                        strOuput = strOuput.Substring(i);
                        // 查找数字
                        MatchCollection matches = Regex.Matches(strOuput, "[0-9]+");
                        // 定义list存放遍历结果
                        List<string> list = new List<string>();
                        // 遍历
                        foreach (Match item in matches)
                        {
                            //item.Value表示本次提取到的字符串
                            list.Add(item.Value);
                        }
                        // list转换成数组
                        string[] arrs = list.ToArray();
                        // 判断是否有返回值
                        if (arrs == null)
                        {
                            MessageBox.Show("该端口未被占用");
                            return;
                        }
                        else
                        {
                            // 获取第一个pid
                            string pid = arrs[10];
                            // 查询第一个pid是什么软件的进程
                            strInput = "tasklist|findstr " + pid;
                            strOuput = cmd(strInput);
                            Regex reg = new Regex(@"\w+\.[e][x][e]");
                            Match match = reg.Match(strOuput);
                            string exe = "";
                            if (match.Success)
                            {
                                exe = match.Value;
                            }
                            else
                            {
                                exe = "没查找到进程名";
                            }
                            //MessageBox.Show("占用此端口的进程为:  "+ exe + "\r\n\r\n是否关闭该进程释放端口?", "提示", MessageBoxButtons.OKCancel);
                            DialogResult dr = MessageBox.Show("占用此端口的进程为:  " + exe + "\r\n\r\n是否关闭该进程释放端口?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (dr == DialogResult.OK)
                            {
                                //点确定:  关闭该进程
                                strInput = "taskkill /f /t /im " + exe;
                                strOuput = cmd(strInput);
                                reg = new Regex(@"[S][U][C][C][E][S][S]");
                                match = reg.Match(strOuput);
                                if (match.Success)
                                {
                                    MessageBox.Show("成功关闭" + exe + "进程", "提示");
                                }
                                else
                                {
                                    MessageBox.Show("未关闭" + exe + "进程\r\n\r\n可能的原因如下:\r\n1：进程已经被关闭。\r\n2：进程已经未找到。\r\n3：没有权限，尝试管理员运行。", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                //点取消的代码 
                                return;
                            }
                        }

                    }

                }
            }
            catch
            {
                MessageBox.Show("请输入正确的端口", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

            
            
        }

        private void fankui_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 调用默认浏览器发起qq对话
            Process.Start("http://wpa.qq.com/msgrd?v=3&uin=451508532&site=qq&menu=yes");
        }
    }
}
