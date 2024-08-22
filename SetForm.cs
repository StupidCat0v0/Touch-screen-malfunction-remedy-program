using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 补丁
{
    public partial class SetForm : Form
    {
        public SetForm()
        {
            InitializeComponent();

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//跨线程访问

            抖动范围text.Visible = false;
            抖动范围.Visible = false;
            Promptlabel.Visible = false;
            输入.Checked = true;
            左键.Checked = true;
            Promptlabel.Visible = true;


            CheckForIllegalCrossThreadCalls = false;
            Thread topthread = new Thread(MAIN);
            //创建Thread对象
            //启动线程
            topthread.Start();
        }

        Point locations = new Point(0, 0);
        Size formSize = new Size(415, 415);
        List<Color> ColorsList = new List<Color>();
        List<PointF> PointList = new List<PointF>();
        List<int> SizeList = new List<int>();

        ShowForm form2 = new ShowForm(); //生成一个Form2对象，实例化即可使用

        private void SetForm_Shown(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            ReadLastBarrier();//读取上一任车主
            form2.FormBorderStyle = FormBorderStyle.None;
            send();//复制粘贴
        }


        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                抖动范围text.Visible = false;
                抖动范围.Visible = false;
                左键.Visible = true;
                中键.Visible = true;
                右键.Visible = true;
            }
        }

        private void close(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();//Dead dead dead All dead
            this.Dispose();
            this.Close();
        }

        private void MAIN()
        {
            while (true)
            {
                form2.TopMost = true;


                while (GetAsyncKeyState(mouse.VK_F6) == 0) ;//重复执行直到按下

                while (GetAsyncKeyState(mouse.VK_F6) != 0) ;//重复执行直到松开
                if (左键.Checked == true)
                    key = 1;
                else if (右键.Checked == true)
                    key = 2;
                else if (中键.Checked == true)
                    key = 3;

                if (输入.Checked == true)
                {
                    listtime.Items.Clear();
                    time_ = int.Parse(时UpDown.Text) * 3600000 + int.Parse(分UpDown.Text)
                        * 60000 + int.Parse(秒UpDown.Text) * 1000 + int.Parse(毫UpDown.Text);

                    if (time_ == 0)
                    {
                        毫UpDown.Text = "1";
                        time_ = 1;
                    }
                    listtime.Items.Add(time_ + "ms");
                    Clickrun();
                }
                else if (录制.Checked == true)
                {
                    listtime.Items.Clear();
                    Record();
                Continuou:
                    this.Promptlabel.Text = "F6开始/暂停";
                    while (GetAsyncKeyState(mouse.VK_F6) == 0) ;//重复执行直到按下
                    while (GetAsyncKeyState(mouse.VK_F6) != 0) ;//重复执行直到松开
                    Clickrun();
                    this.Promptlabel.Text = "F6继续\r\nF7结束";
                    while (true)
                    {
                        if (GetAsyncKeyState(mouse.VK_F6) != 0)//如果按下
                        {
                            goto Continuou;
                        }
                        else if (GetAsyncKeyState(mouse.VK_F7) != 0)//如果按下
                        {
                            listtime.Items.Clear();
                            break;
                        }
                    }

                }

                Thread.Sleep(100);
            }
        }

        #region 屏障

        //保存数据到文件中
        private void saveBarrier()
        {
            locations = form2.Location;
            if (form2.statef != 2)
            {
                locations.X -= form2.Location.X - form2.PointToScreen(new Point(0, 0)).X;
                locations.Y -= form2.Location.Y - form2.PointToScreen(new Point(0, 0)).Y;
            }//弥补误差

            string str1 = locations.X + "\n" + locations.Y + "\n"
                + form2.Width + "\n" + form2.Height;
            for (int i = 0; i < ColorsList.Count; i++)
            {
                str1 += "\n" + System.Drawing.ColorTranslator.ToHtml(ColorsList[i]);
            }
            str1 += "\npoint";
            for (int i = 0; i < PointList.Count; i++)
            {
                str1 += "\n" + PointList[i].X + "\n" + PointList[i].Y;
            }
            str1 += "\nsize";
            for (int i = 0; i < SizeList.Count; i++)
            {
                str1 += "\n" + SizeList[i];
            }
            File.WriteAllText(@"./data.txt", str1);//第一种
        }

        //读取数据
        private void ReadLastBarrier()
        {
            StreamReader sr;
            try
            {
                sr = File.OpenText(@"./data.txt");
            }
            catch
            {//没文件你看你么呢
                locations = new Point(20, 20);
                ColorsList.Add(Color.Red);//#FF44FB
                PointList.Add(new Point(55, 55));
                SizeList.Add(20);
                return;
            }
            locations = new Point(int.Parse(sr.ReadLine()), int.Parse(sr.ReadLine()));
            formSize.Width = int.Parse(sr.ReadLine());
            formSize.Height = int.Parse(sr.ReadLine());
            while (true)
            {
                string x = sr.ReadLine();
                if (x == "point")
                    break;
                ColorsList.Add(System.Drawing.ColorTranslator.FromHtml(x));
            }
            while (true)
            {
                string x = sr.ReadLine();
                if (x == "size")
                    break;
                string y = sr.ReadLine();
                PointList.Add(new Point(int.Parse(x), int.Parse(y)));
            }
            while (true)
            {
                string x = sr.ReadLine();
                if (x == null)
                    break;
                SizeList.Add(int.Parse(x));
            }

            sr.Close();
        }

        private void receive(int s)
        {
            int sas = form2.statef;

            form2.Close();
            locations = form2.Location;
            formSize = form2.Size;
            ColorsList = form2.ColorsListf;
            PointList = form2.PointListf;
            SizeList = form2.SizeListf;

            form2 = new ShowForm();

            //小亮，给他整个活！
            if (sas == 2 && s != 2)
            {
                locations.X += form2.Location.X - form2.PointToScreen(new Point(0, 0)).X;
                locations.Y += form2.Location.Y - form2.PointToScreen(new Point(0, 0)).Y;
            }
            else if (sas != 2 && s == 2)
            {
                locations.X -= form2.Location.X - form2.PointToScreen(new Point(0, 0)).X;
                locations.Y -= form2.Location.Y - form2.PointToScreen(new Point(0, 0)).Y;
            }//弥补不知道哪来的误差
        }
        private void send()
        {
            numericUpDown1.Value = locations.X;
            numericUpDown2.Value = locations.Y;
            numericUpDown3.Value = formSize.Height;
            numericUpDown4.Value = formSize.Width;//校准步进控件

            form2.Location = locations;
            form2.Size = formSize;
            form2.valuef = trackBarsize.Value;
            form2.ColorsListf = ColorsList;
            form2.PointListf = PointList;
            form2.SizeListf = SizeList;


            form2.Show();  //将Form2窗体显示
        }

        private void Show_Click(object sender, EventArgs e)
        {
            receive(1);//接管备份

            form2.FormBorderStyle = FormBorderStyle.Sizable;
            form2.TransparencyKey = Color.White;
            send();//复制粘贴新窗口

            form2.statef = 1;
        }

        private void Hide_Click(object sender, EventArgs e)
        {

            receive(2);//接管备份

            form2.FormBorderStyle = FormBorderStyle.None;
            form2.TransparencyKey = Color.White;
            send();//复制粘贴新窗口

            form2.statef = 2;
        }

        private void draw_Click(object sender, EventArgs e)
        {
            receive(3);//接管备份

            form2.FormBorderStyle = FormBorderStyle.Sizable;
            form2.TransparencyKey = Color.Black;
            send();//复制粘贴新窗口

            form2.statef = 3;
        }

        private void Erase_Click(object sender, EventArgs e)
        {
            receive(4);//接管备份

            form2.FormBorderStyle = FormBorderStyle.Sizable;
            form2.TransparencyKey = Color.Black;
            send();//复制粘贴新窗口

            form2.statef = 4;
        }

        private void trackBarsize_ValueChanged(object sender, EventArgs e)
        {
            form2.valuef = trackBarsize.Value;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            receive(3);//接管备份

            ColorsList = new List<Color>();
            PointList = new List<PointF>();
            SizeList = new List<int>();

            form2.FormBorderStyle = FormBorderStyle.Sizable;
            form2.TransparencyKey = Color.Black;
            send();//复制粘贴新窗口

            form2.statef = 3;
        }

        private void numericUpDownlocation_ValueChanged(object sender, EventArgs e)
        {
            form2.Location = new Point((int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }

        private void numericUpDownsize_ValueChanged(object sender, EventArgs e)
        {
            form2.Size = new Size((int)numericUpDown3.Value, (int)numericUpDown4.Value);
        }


        private void 控制面板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = true;
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;//正常显示
        }

        private void minimize(object sender, FormClosingEventArgs e)
        {
            saveBarrier();//保存一下先

            e.Cancel = true; //取消close操作
            this.ShowInTaskbar = false;//任务栏隐藏
            WindowState = FormWindowState.Minimized;//死了嘛，如死
        }

        private void 移到00ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.Location = new Point(0, 0);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            控制面板ToolStripMenuItem_Click(sender, e);
        }


        #endregion

        #region 连点器

        struct mouse
        {
            public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
            public const int MOUSEEVENTF_LEFTUP = 0x0004;
            public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
            public const int MOUSEEVENTF_RIGHTUP = 0x0010;
            public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
            public const int MOUSEEVENTF_MIDDLEUP = 0x0040;
            public const int MOUSEEVENTF_WHEEL = 0x800;
            public const int KEYEVENTF_KEYUP = 0x0002;
            public const int VK_F6 = 0x75;
            public const int VK_F7 = 0x76;
        }

        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event(
            byte bVk,
            byte bScan,
            int dwFlags,  //这里是整数类型  0 为按下，2为释放
            int dwExtraInfo  //这里是整数类型 一般情况下设成为 0
        );

        [DllImport("user32.dll")]
        public static extern bool FlashWindowEx(ref FLASHWINFO pwfi);

        [DllImport("user32.dll")]
        public static extern int MessageBeep(uint uType);
        uint beepI = 0x00000010;

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("kernel32")]
        static extern uint GetTickCount();

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern int SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int vKey);

        public static class SystemSleep
        {
            [DllImport("kernel32")]
            private static extern ExecutionState SetThreadExecutionState(ExecutionState esFlags);
            [Flags]
            private enum ExecutionState : uint
            {
                SystemRequired = 0x01,

                DisplayRequired = 0x02,

                [Obsolete("This value is not supported.")]
                UserPresent = 0x04,
                AwaymodeRequired = 0x40,
                Continuous = 0x80000000,
            }

            public static void PreventForCurrentThread(bool keepDisplayOn = true)
            {
                SetThreadExecutionState(keepDisplayOn
                    ? ExecutionState.Continuous | ExecutionState.SystemRequired | ExecutionState.DisplayRequired
                    : ExecutionState.Continuous | ExecutionState.SystemRequired);
            }
            public static void RestoreForCurrentThread()
            {
                SetThreadExecutionState(ExecutionState.Continuous);
            }
            public static void ResetIdle(bool keepDisplayOn = true)
            {
                SetThreadExecutionState(keepDisplayOn
                    ? ExecutionState.SystemRequired | ExecutionState.DisplayRequired
                    : ExecutionState.SystemRequired);
            }
        }


        public struct FLASHWINFO
        {
            public UInt32 cbSize;
            public IntPtr hwnd;
            public UInt32 dwFlags;
            public UInt32 uCount;
            public UInt32 dwTimeout;
        }
        public enum falshType : uint
        {
            FLASHW_STOP = 0,    //停止闪烁
            FALSHW_CAPTION = 1,  //只闪烁标题
            FLASHW_TRAY = 2,   //只闪烁任务栏
            FLASHW_ALL = 3,     //标题和任务栏同时闪烁
            FLASHW_PARAM1 = 4,
            FLASHW_PARAM2 = 12,
            FLASHW_TIMER = FLASHW_TRAY | FLASHW_PARAM1,   //无条件闪烁任务栏直到发送停止标志或者窗口被激活，如果未激活，停止时高亮
            FLASHW_TIMERNOFG = FLASHW_TRAY | FLASHW_PARAM2  //未激活时闪烁任务栏直到发送停止标志或者窗体被激活，停止后高亮
        }
        public static bool flashTaskBar(IntPtr hWnd, falshType type)
        {
            FLASHWINFO fInfo = new FLASHWINFO();
            fInfo.cbSize = Convert.ToUInt32(Marshal.SizeOf(fInfo));
            fInfo.hwnd = hWnd;//要闪烁的窗口的句柄，该窗口可以是打开的或最小化的
            fInfo.dwFlags = (uint)type;//闪烁的类型
            fInfo.uCount = UInt32.MaxValue;//闪烁窗口的次数
            fInfo.dwTimeout = 0; //窗口闪烁的频度，毫秒为单位；若该值为0，则为默认图标的闪烁频度
            return FlashWindowEx(ref fInfo);
        }


        private void 左键_CheckedChanged(object sender, EventArgs e)
        {
            if (左键.Checked == true)
            {
                中键.Checked = false;
                右键.Checked = false;
            }
        }
        private void 中键_CheckedChanged(object sender, EventArgs e)
        {
            if (中键.Checked == true)
            {
                左键.Checked = false;
                右键.Checked = false;
            }
        }
        private void 右键_CheckedChanged(object sender, EventArgs e)
        {
            if (右键.Checked == true)
            {
                中键.Checked = false;
                左键.Checked = false;
            }
        }
        private void 录制_CheckedChanged(object sender, EventArgs e)
        {
            if (录制.Checked == true)
            {
                this.Promptlabel.Text = "F6开始录制\r\n左键点击6次";
                listtime.Items.Clear();
                Promptlabel.Visible = true;
                输入.Checked = false;
                时UpDown.Visible = false;
                分UpDown.Visible = false;
                秒UpDown.Visible = false;
                毫UpDown.Visible = false;
                时.Visible = false;
                分.Visible = false;
                秒.Visible = false;
                毫.Visible = false;
            }
        }
        private void 输入_CheckedChanged(object sender, EventArgs e)
        {
            if (输入.Checked == true)
            {
                this.Promptlabel.Text = "F6开始/暂停";
                listtime.Items.Clear();
                录制.Checked = false;
                Promptlabel.Visible = true;
                时UpDown.Visible = true;
                分UpDown.Visible = true;
                秒UpDown.Visible = true;
                毫UpDown.Visible = true;
                时.Visible = true;
                分.Visible = true;
                秒.Visible = true;
                毫.Visible = true;
            }
        }
        private void 常亮_CheckedChanged(object sender, EventArgs e)
        {
            if (常亮.Checked == true)
                SystemSleep.PreventForCurrentThread();
            else
                SystemSleep.RestoreForCurrentThread();
        }


        int key = 1;
        int time_ = 1;

        private void Record()
        {
            while (GetAsyncKeyState(key) != 0) ;//重复执行直到松开
            while (GetAsyncKeyState(key) == 0)//重复执行直到按下
                if (GetAsyncKeyState(mouse.VK_F7) != 0)
                    goto exitlearn;
            while (GetAsyncKeyState(key) != 0) ;//重复执行直到松开
            int[] time2 = new int[5];
            for (int i = 0; i < 4; i++)
            {
                uint s1 = GetTickCount();

                while (GetAsyncKeyState(key) == 0)
                    if (GetAsyncKeyState(mouse.VK_F7) != 0)
                        goto exitlearn;//Process.GetCurrentProcess().Kill();
                while (GetAsyncKeyState(key) != 0) ;

                uint s2 = GetTickCount() - s1;

                listtime.Items.Add("t" + (i + 1).ToString() + ":" + s2.ToString() + "ms");
                int.TryParse(s2 + "", out time2[i]);
            }
            time_ = (time2[0] + time2[1] + time2[2] + time2[3] + time2[4]) / 5;
            listtime.Items.Add("均：" + time_ + "ms");

        exitlearn:
            while (GetAsyncKeyState(mouse.VK_F6) != 0) ;//重复执行直到松开
            flashTaskBar(this.Handle, falshType.FLASHW_TIMERNOFG);
            MessageBeep(beepI);
        }

        private void Clickrun()
        {
            while (GetAsyncKeyState(mouse.VK_F6) != 0) ;//重复执行直到松开
            while (GetAsyncKeyState(mouse.VK_F6) == 0)//重复执行直到按下
            {
                switch (key)
                {
                    case 1:
                        mouse_event(mouse.MOUSEEVENTF_LEFTDOWN | mouse.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);//左键点击
                        break;
                    case 2:
                        mouse_event(mouse.MOUSEEVENTF_RIGHTDOWN | mouse.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);//右键点击
                        break;
                    case 3:
                        mouse_event(mouse.MOUSEEVENTF_MIDDLEDOWN | mouse.MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);//中键点击
                        break;
                }
                uint t1 = GetTickCount();
                uint t2 = t1;
                while (int.Parse((t2 - t1).ToString()) < time_)
                {
                    t2 = GetTickCount();

                    if (GetAsyncKeyState(mouse.VK_F6) != 0)//如果按下
                        goto exitrun;
                }
            }
        exitrun:;
            while (GetAsyncKeyState(mouse.VK_F6) != 0) ;//重复执行直到松开

            flashTaskBar(this.Handle, falshType.FLASHW_TIMERNOFG);//任务栏提示
            MessageBeep(beepI);
        }

        /*
        0x01					鼠标左键
        0x02				 	鼠标右键
        0x03				 	控制中断处理
        0x04				 	中间鼠标按钮 (三键鼠标)
        0x05				 	X1 鼠标按钮
        0x06				 	X2 鼠标按钮
        0x30				 	0 键
        0x31				 	1 键
        0x32				 	2 键
        0x33				 	3 键
        0x34				 	4 键
        0x35				 	5 键
        0x36				 	6 键
        0x37				 	7 键
        0x38				 	8 键
        0x39				 	9 键
        0x41				 	A 键
        0x42				 	B 键
        0x43				 	C 键
        0x44				 	D 键
        0x45				 	E 键
        0x46				 	F 键
        0x47				 	G 键
        0x48				 	H 键
        0x49				 	I 键
        0x4A				 	J 键
        0x4B				 	K 键
        0x4C				 	L 键
        0x4D				 	M 键
        0x4E				 	N 键
        0x4F				 	O 键
        0x50				 	P 键
        0x51				 	Q 键
        0x52				 	R 键
        0x53				 	S 键
        0x54				 	T 键
        0x55				 	U 键
        0x56				 	V 键
        0x57				 	W 键
        0x58				 	X 键
        0x59				 	Y 键
        0x5A				 	Z 键
        0x70				 	F1 键
        0x71				 	F2 键
        0x72				 	F3 键
        0x73				 	F4 键
        0x74				 	F5 键
        0x75				 	F6 键
        0x76				 	F7 键
        0x77				 	F8 键
        0x78				 	F9 键
        0x79				 	F10 键
        0x7A				 	F11 键
        0x7B				 	F12 键
        0x7C				 	F13 键
        0x7D				 	F14 键
        0x7E				 	F15 键
        0x7F				 	F16 键
        0x80				 	F17 键
        0x81				 	F18 键
        0x82				 	F19 键
        0x83				 	F20 键
        0x84				 	F21 键
        0x85				 	F22 键
        0x86				 	F23 键
        0x87				 	F24 键
        0x09				 	Tab 键
        0x20				 	空格键
        0x1B				 	ESC 键
        0x0C				 	CLEAR 键
        0x0D				 	Enter 键
        0x10				 	SHIFT 键
        0x11				 	Ctrl 键
        0x12				 	Alt 键
        0x13				 	PAUSE 键
        0x14				 	CAPS LOCK 键
        0x21				 	PAGE UP 键
        0x22				 	PAGE DOWN 键
        0x23				 	END 键
        0x24				 	HOME 键
        0x29				 	SELECT 键
        0x2A				 	PRINT 键
        0x2B				 	EXECUTE 键
        0x08				 	BACKSPACE 密钥
        0xA0				 	左 SHIFT 键
        0xA1				 	右 SHIFT 键
        0xA2				 	左 Ctrl 键
        0xA3				 	右 Ctrl 键
        0xA4				 	左 Alt 键
        0xA5				 	右 ALT 键
        0x5B				 	左Windows键 (自然键盘)
        0x5C				 	右Windows键 (自然键盘)
        0x25				 	向左键
        0x26				 	向上键
        0x27				 	向右键
        0x28				 	向下键
        0x6A				 	乘键
        0x6B				 	添加密钥
        0x6C				 	分隔符键
        0x6D				 	减去键
        0x6E				 	十进制键
        0x6F				 	除键
        0xBB				 	对于任何国家/地区，“+”键
        0xBC				 	对于任何国家/地区，“，键
        0xBD				 	对于任何国家/地区，“-”键
        0xBE				 	对于任何国家/地区，“.”键
        0x60				 	数字键盘 0 键
        0x61				 	数字键盘 1 键
        0x62				 	数字键盘 2 键
        0x63				 	数字键盘 3 键
        0x64				 	数字键盘 4 键
        0x65				 	数字键盘 5 键
        0x66				 	数字键盘 6 键
        0x67				 	数字键盘 7 键
        0x68				 	数字键盘 8 键
        0x69				 	数字键盘 9 键
        0x15				 	IME Kana 模式
        0x15				 	IME 朝鲜文库埃尔模式
        0x15				 	IME Hanguel 模式
        0x16				 	IME On
        0x17				 	IME Junja 模式
        0x18				 	IME 最终模式
        0x19				 	IME Hanja 模式
        0x19				 	IME Kanji 模式
        0x1A				 	IME 关闭
        0x1C				 	IME 转换
        0x1D				 	IME 不转换
        0x1E				 	IME 接受
        0x1F				 	IME 模式更改请求
        0x5D				 	应用程序键 (自然键盘)
        0x2C				 	打印屏幕键
        0x2D				 	INS 密钥
        0x2E				 	DEL 键
        0x2F				 	帮助密钥
        0x5F				 	计算机休眠键
        0x90				 	NUM LOCK 密钥
        0x91				 	SCROLL LOCK 键
        0xA6				 	浏览器后退键
        0xA7				 	浏览器前进键
        0xA8				 	浏览器刷新键
        0xA9				 	浏览器停止键
        0xAA				 	浏览器搜索键
        0xAB				 	浏览器收藏键
        0xAC				 	浏览器“开始”和“主页”键
        0xAD				 	静音键
        0xAE				 	音量减小键
        0xAF				 	音量增加键
        0xB0				 	下一曲目键
        0xB1				 	上一曲目键
        0xB2				 	停止媒体键
        0xB3				 	播放/暂停媒体键
        0xB4				 	启动邮件键
        0xB5				 	选择媒体键
        0xB6				 	启动应用程序 1 键
        0xB7				 	启动应用程序 2 键
        0xBA				 	美国标准键盘，“;：”键
        0xBF				 	美国标准键盘，“/？” key
        0xC0				 	美国标准键盘，“~”键
        0xDB				 	美国标准键盘，“[{”键
        0xDC				 	美国标准键盘，“\|”键
        0xDD				 	=美国标准键盘，“]}”键
        0xDE				 	美国标准键盘，“单引号/双引号”键
        0xE1				 	OEM 特定
        0xE2				 	美国标准键盘<>键，或102 键键盘\\|键
        0xE5					IME PROCESS 密钥
        0xE6					OEM 特定
        0xE7					用于将 Unicode 字符当作键击传递
        0xF6					Attn 键
        0xF7					CrSel 键
        0xF8					ExSel 密钥
        0xF9					擦除 EOF 密钥
        0xFA					播放键
        0xFB					缩放键
        0xFD					PA1 键
        0xFE					清除键
         */
        #endregion
    }
}
