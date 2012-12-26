using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MudFish
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, uint hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hwnd, uint wMsg, int wParam, int lParam);
        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow", SetLastError = true)]
        private static extern void SetForegroundWindow(IntPtr hwnd);
        [DllImport("user32.dll", EntryPoint = "GetForegroundWindow", SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();


        public Config MudFishConfig=new Config();
        public Form1()
        {
            InitializeComponent();


            RefreshConfig();


        }

        private void btn_loopjump_Click(object sender, EventArgs e)
        {
            if (btn_loopjump.Text == "开始")
            {
                btn_loopjump.Text = "停止";
                timer_jump.Enabled = true;
            }
            else {
                btn_loopjump.Text = "开始";
                timer_jump.Enabled = false;
            
            }

        }

        //刷新配置
        private void RefreshConfig() {
            MudFishConfig.IntervalTime = Convert.ToInt32(nudIntervalTime.Value);
            MudFishConfig.WndSwitchTime = Convert.ToInt32(nudWndSwitchTime.Value);
        }

        private void timer_jump_Tick(object sender, EventArgs e)
        {
            RefreshConfig();
            timer_jump.Interval = MudFishConfig.IntervalTime*1000;

            IntPtr hwndTargetWOW = FindWindow(null, "魔兽世界"); //查找魔兽窗口句柄
            IntPtr hwndSource = GetForegroundWindow();//查找当前窗口句柄，方便返回。

            if (hwndTargetWOW != IntPtr.Zero)
            {

                SetForegroundWindow(hwndTargetWOW);    //将魔兽窗口设为当前活动窗口

                System.Threading.Thread.Sleep(MudFishConfig.WndSwitchTime);
                //给哥跳一下
                SendKeys.SendWait(" ");
                System.Threading.Thread.Sleep(MudFishConfig.WndSwitchTime);
            }
            else {
                return;
            }

            //返回之前的窗口
            if (hwndSource != IntPtr.Zero)
            {
                SetForegroundWindow(hwndSource);
            }
        }
    }
}
