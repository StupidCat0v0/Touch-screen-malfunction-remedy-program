using 补丁.Properties;

namespace 补丁
{
    partial class SetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Requi
        /// method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetForm));
            this.Show = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Erase = new System.Windows.Forms.Button();
            this.trackBarsize = new System.Windows.Forms.TrackBar();
            this.Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.控制面板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移到00ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移到00ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.左键 = new System.Windows.Forms.CheckBox();
            this.右键 = new System.Windows.Forms.CheckBox();
            this.中键 = new System.Windows.Forms.CheckBox();
            this.Promptlabel = new System.Windows.Forms.Label();
            this.listtime = new System.Windows.Forms.ListBox();
            this.毫UpDown = new System.Windows.Forms.NumericUpDown();
            this.毫 = new System.Windows.Forms.Label();
            this.秒UpDown = new System.Windows.Forms.NumericUpDown();
            this.分UpDown = new System.Windows.Forms.NumericUpDown();
            this.秒 = new System.Windows.Forms.Label();
            this.分 = new System.Windows.Forms.Label();
            this.时 = new System.Windows.Forms.Label();
            this.时UpDown = new System.Windows.Forms.NumericUpDown();
            this.输入 = new System.Windows.Forms.CheckBox();
            this.抖动范围text = new System.Windows.Forms.Label();
            this.抖动范围 = new System.Windows.Forms.NumericUpDown();
            this.录制 = new System.Windows.Forms.CheckBox();
            this.常亮 = new System.Windows.Forms.CheckBox();
            this.置顶 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.毫UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.秒UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.分UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.时UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.抖动范围)).BeginInit();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(1, 217);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(263, 54);
            this.Show.TabIndex = 0;
            this.Show.Text = "显示";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Hide
            // 
            this.Hide.Location = new System.Drawing.Point(345, 217);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(237, 54);
            this.Hide.TabIndex = 1;
            this.Hide.Text = "隐藏";
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "绘制";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.draw_Click);
            // 
            // Erase
            // 
            this.Erase.Location = new System.Drawing.Point(213, 68);
            this.Erase.Name = "Erase";
            this.Erase.Size = new System.Drawing.Size(170, 55);
            this.Erase.TabIndex = 3;
            this.Erase.Text = "擦除";
            this.Erase.UseVisualStyleBackColor = true;
            this.Erase.Click += new System.EventHandler(this.Erase_Click);
            // 
            // trackBarsize
            // 
            this.trackBarsize.Location = new System.Drawing.Point(1, 6);
            this.trackBarsize.Maximum = 250;
            this.trackBarsize.Minimum = 5;
            this.trackBarsize.Name = "trackBarsize";
            this.trackBarsize.Size = new System.Drawing.Size(578, 56);
            this.trackBarsize.TabIndex = 4;
            this.trackBarsize.Value = 15;
            this.trackBarsize.ValueChanged += new System.EventHandler(this.trackBarsize_ValueChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(409, 68);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(170, 55);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "清屏";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "窗口坐标-";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(6, 161);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(131, 30);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDownlocation_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "窗口尺寸-";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("宋体", 12F);
            this.numericUpDown3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(311, 161);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(131, 30);
            this.numericUpDown3.TabIndex = 12;
            this.numericUpDown3.Value = new decimal(new int[] {
            415,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDownsize_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("宋体", 12F);
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(143, 161);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(131, 30);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDownlocation_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("宋体", 12F);
            this.numericUpDown4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown4.Location = new System.Drawing.Point(448, 161);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(131, 30);
            this.numericUpDown4.TabIndex = 14;
            this.numericUpDown4.Value = new decimal(new int[] {
            415,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDownsize_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(64, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "x          y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(357, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Height    Width";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "补丁";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.控制面板ToolStripMenuItem,
            this.显示ToolStripMenuItem,
            this.隐藏ToolStripMenuItem,
            this.移到00ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 124);
            // 
            // 控制面板ToolStripMenuItem
            // 
            this.控制面板ToolStripMenuItem.Name = "控制面板ToolStripMenuItem";
            this.控制面板ToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.控制面板ToolStripMenuItem.Text = "控制面板";
            this.控制面板ToolStripMenuItem.Click += new System.EventHandler(this.控制面板ToolStripMenuItem_Click);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.Show_Click);
            // 
            // 隐藏ToolStripMenuItem
            // 
            this.隐藏ToolStripMenuItem.Name = "隐藏ToolStripMenuItem";
            this.隐藏ToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.隐藏ToolStripMenuItem.Text = "隐藏";
            this.隐藏ToolStripMenuItem.Click += new System.EventHandler(this.Hide_Click);
            // 
            // 移到00ToolStripMenuItem
            // 
            this.移到00ToolStripMenuItem.Name = "移到00ToolStripMenuItem";
            this.移到00ToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.移到00ToolStripMenuItem.Text = "移到(0,0)";
            this.移到00ToolStripMenuItem.Click += new System.EventHandler(this.移到00ToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.close);
            // 
            // 移到00ToolStripMenuItem1
            // 
            this.移到00ToolStripMenuItem1.Name = "移到00ToolStripMenuItem1";
            this.移到00ToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "程序关闭时将自动保存设置";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 363);
            this.tabControl1.TabIndex = 18;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.trackBarsize);
            this.tabPage1.Controls.Add(this.Show);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Hide);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Erase);
            this.tabPage1.Controls.Add(this.numericUpDown4);
            this.tabPage1.Controls.Add(this.Clear);
            this.tabPage1.Controls.Add(this.numericUpDown2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDown3);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(585, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "屏障";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.左键);
            this.tabPage2.Controls.Add(this.右键);
            this.tabPage2.Controls.Add(this.中键);
            this.tabPage2.Controls.Add(this.Promptlabel);
            this.tabPage2.Controls.Add(this.listtime);
            this.tabPage2.Controls.Add(this.毫UpDown);
            this.tabPage2.Controls.Add(this.毫);
            this.tabPage2.Controls.Add(this.秒UpDown);
            this.tabPage2.Controls.Add(this.分UpDown);
            this.tabPage2.Controls.Add(this.秒);
            this.tabPage2.Controls.Add(this.分);
            this.tabPage2.Controls.Add(this.时);
            this.tabPage2.Controls.Add(this.时UpDown);
            this.tabPage2.Controls.Add(this.输入);
            this.tabPage2.Controls.Add(this.抖动范围text);
            this.tabPage2.Controls.Add(this.抖动范围);
            this.tabPage2.Controls.Add(this.录制);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(585, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "连点器";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 23);
            this.button2.TabIndex = 104;
            this.button2.Text = "终止";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // 左键
            // 
            this.左键.AutoSize = true;
            this.左键.Location = new System.Drawing.Point(9, 5);
            this.左键.Name = "左键";
            this.左键.Size = new System.Drawing.Size(59, 19);
            this.左键.TabIndex = 101;
            this.左键.Text = "左键";
            this.左键.UseVisualStyleBackColor = true;
            this.左键.CheckedChanged += new System.EventHandler(this.左键_CheckedChanged);
            // 
            // 右键
            // 
            this.右键.AutoSize = true;
            this.右键.Location = new System.Drawing.Point(139, 5);
            this.右键.Name = "右键";
            this.右键.Size = new System.Drawing.Size(59, 19);
            this.右键.TabIndex = 103;
            this.右键.Text = "右键";
            this.右键.UseVisualStyleBackColor = true;
            this.右键.CheckedChanged += new System.EventHandler(this.右键_CheckedChanged);
            // 
            // 中键
            // 
            this.中键.AutoSize = true;
            this.中键.Location = new System.Drawing.Point(74, 5);
            this.中键.Name = "中键";
            this.中键.Size = new System.Drawing.Size(59, 19);
            this.中键.TabIndex = 102;
            this.中键.Text = "中键";
            this.中键.UseVisualStyleBackColor = true;
            this.中键.CheckedChanged += new System.EventHandler(this.中键_CheckedChanged);
            // 
            // Promptlabel
            // 
            this.Promptlabel.AutoSize = true;
            this.Promptlabel.Location = new System.Drawing.Point(293, 174);
            this.Promptlabel.Name = "Promptlabel";
            this.Promptlabel.Size = new System.Drawing.Size(143, 15);
            this.Promptlabel.TabIndex = 99;
            this.Promptlabel.Text = "                 ";
            // 
            // listtime
            // 
            this.listtime.FormattingEnabled = true;
            this.listtime.ItemHeight = 15;
            this.listtime.Location = new System.Drawing.Point(6, 174);
            this.listtime.Name = "listtime";
            this.listtime.Size = new System.Drawing.Size(281, 154);
            this.listtime.TabIndex = 98;
            // 
            // 毫UpDown
            // 
            this.毫UpDown.Location = new System.Drawing.Point(448, 124);
            this.毫UpDown.Maximum = new decimal(new int[] {
            1910001000,
            0,
            0,
            0});
            this.毫UpDown.Name = "毫UpDown";
            this.毫UpDown.Size = new System.Drawing.Size(93, 25);
            this.毫UpDown.TabIndex = 97;
            this.毫UpDown.ThousandsSeparator = true;
            this.毫UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // 毫
            // 
            this.毫.AutoSize = true;
            this.毫.Location = new System.Drawing.Point(405, 129);
            this.毫.Name = "毫";
            this.毫.Size = new System.Drawing.Size(37, 15);
            this.毫.TabIndex = 96;
            this.毫.Text = "毫秒";
            // 
            // 秒UpDown
            // 
            this.秒UpDown.Location = new System.Drawing.Point(300, 124);
            this.秒UpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.秒UpDown.Name = "秒UpDown";
            this.秒UpDown.Size = new System.Drawing.Size(99, 25);
            this.秒UpDown.TabIndex = 95;
            // 
            // 分UpDown
            // 
            this.分UpDown.Location = new System.Drawing.Point(167, 124);
            this.分UpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.分UpDown.Name = "分UpDown";
            this.分UpDown.Size = new System.Drawing.Size(99, 25);
            this.分UpDown.TabIndex = 94;
            // 
            // 秒
            // 
            this.秒.AutoSize = true;
            this.秒.Location = new System.Drawing.Point(272, 128);
            this.秒.Name = "秒";
            this.秒.Size = new System.Drawing.Size(22, 15);
            this.秒.TabIndex = 93;
            this.秒.Text = "秒";
            // 
            // 分
            // 
            this.分.AutoSize = true;
            this.分.Location = new System.Drawing.Point(139, 129);
            this.分.Name = "分";
            this.分.Size = new System.Drawing.Size(22, 15);
            this.分.TabIndex = 92;
            this.分.Text = "分";
            // 
            // 时
            // 
            this.时.AutoSize = true;
            this.时.Location = new System.Drawing.Point(6, 129);
            this.时.Name = "时";
            this.时.Size = new System.Drawing.Size(22, 15);
            this.时.TabIndex = 91;
            this.时.Text = "时";
            // 
            // 时UpDown
            // 
            this.时UpDown.Location = new System.Drawing.Point(34, 124);
            this.时UpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.时UpDown.Name = "时UpDown";
            this.时UpDown.Size = new System.Drawing.Size(99, 25);
            this.时UpDown.TabIndex = 90;
            // 
            // 输入
            // 
            this.输入.AutoSize = true;
            this.输入.Location = new System.Drawing.Point(9, 60);
            this.输入.Name = "输入";
            this.输入.Size = new System.Drawing.Size(89, 19);
            this.输入.TabIndex = 89;
            this.输入.Text = "输入时长";
            this.输入.UseVisualStyleBackColor = true;
            this.输入.CheckedChanged += new System.EventHandler(this.输入_CheckedChanged);
            // 
            // 抖动范围text
            // 
            this.抖动范围text.AutoSize = true;
            this.抖动范围text.Location = new System.Drawing.Point(3, 32);
            this.抖动范围text.Name = "抖动范围text";
            this.抖动范围text.Size = new System.Drawing.Size(67, 15);
            this.抖动范围text.TabIndex = 87;
            this.抖动范围text.Text = "抖动范围";
            // 
            // 抖动范围
            // 
            this.抖动范围.Location = new System.Drawing.Point(87, 30);
            this.抖动范围.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.抖动范围.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.抖动范围.Name = "抖动范围";
            this.抖动范围.Size = new System.Drawing.Size(150, 25);
            this.抖动范围.TabIndex = 86;
            this.抖动范围.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // 录制
            // 
            this.录制.AutoSize = true;
            this.录制.Location = new System.Drawing.Point(109, 60);
            this.录制.Name = "录制";
            this.录制.Size = new System.Drawing.Size(89, 19);
            this.录制.TabIndex = 88;
            this.录制.Text = "录制时长";
            this.录制.UseVisualStyleBackColor = true;
            this.录制.CheckedChanged += new System.EventHandler(this.录制_CheckedChanged);
            // 
            // 常亮
            // 
            this.常亮.AutoSize = true;
            this.常亮.Location = new System.Drawing.Point(517, 9);
            this.常亮.Name = "常亮";
            this.常亮.Size = new System.Drawing.Size(89, 19);
            this.常亮.TabIndex = 84;
            this.常亮.Text = "屏幕常亮";
            this.常亮.UseVisualStyleBackColor = true;
            this.常亮.CheckedChanged += new System.EventHandler(this.常亮_CheckedChanged);
            // 
            // 置顶
            // 
            this.置顶.AutoSize = true;
            this.置顶.Location = new System.Drawing.Point(411, 9);
            this.置顶.Name = "置顶";
            this.置顶.Size = new System.Drawing.Size(89, 19);
            this.置顶.TabIndex = 85;
            this.置顶.Text = "窗口置顶";
            this.置顶.UseVisualStyleBackColor = true;
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 387);
            this.Controls.Add(this.置顶);
            this.Controls.Add(this.常亮);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SetForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.minimize);
            this.Shown += new System.EventHandler(this.SetForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.毫UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.秒UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.分UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.时UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.抖动范围)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Erase;
        private System.Windows.Forms.TrackBar trackBarsize;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 控制面板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移到00ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移到00ToolStripMenuItem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox 右键;
        private System.Windows.Forms.CheckBox 中键;
        private System.Windows.Forms.Label Promptlabel;
        private System.Windows.Forms.ListBox listtime;
        private System.Windows.Forms.NumericUpDown 毫UpDown;
        private System.Windows.Forms.Label 毫;
        private System.Windows.Forms.NumericUpDown 秒UpDown;
        private System.Windows.Forms.NumericUpDown 分UpDown;
        private System.Windows.Forms.Label 秒;
        private System.Windows.Forms.Label 分;
        private System.Windows.Forms.Label 时;
        private System.Windows.Forms.NumericUpDown 时UpDown;
        private System.Windows.Forms.CheckBox 输入;
        private System.Windows.Forms.CheckBox 左键;
        private System.Windows.Forms.CheckBox 录制;
        private System.Windows.Forms.Label 抖动范围text;
        private System.Windows.Forms.NumericUpDown 抖动范围;
        private System.Windows.Forms.CheckBox 常亮;
        private System.Windows.Forms.CheckBox 置顶;
        private System.Windows.Forms.Button button2;
    }
}