namespace ABBCom
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.getLog = new System.Windows.Forms.Button();
            this.listLog = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.showX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pointInfo = new System.Windows.Forms.TextBox();
            this.listPoint = new System.Windows.Forms.ListBox();
            this.listRoutine = new System.Windows.Forms.ListBox();
            this.getTask = new System.Windows.Forms.Button();
            this.listModule = new System.Windows.Forms.ListBox();
            this.listTask = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.scanRobot = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SystemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsVirtual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ControllerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getPos = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PX1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RZ1 = new System.Windows.Forms.TextBox();
            this.PY1 = new System.Windows.Forms.TextBox();
            this.RY1 = new System.Windows.Forms.TextBox();
            this.PZ1 = new System.Windows.Forms.TextBox();
            this.RX1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusTwo = new System.Windows.Forms.TextBox();
            this.statusOne = new System.Windows.Forms.TextBox();
            this.getStatus = new System.Windows.Forms.Button();
            this.motorOn = new System.Windows.Forms.Button();
            this.motorOff = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.showY = new System.Windows.Forms.TextBox();
            this.showZ = new System.Windows.Forms.TextBox();
            this.showQone = new System.Windows.Forms.TextBox();
            this.showQtwo = new System.Windows.Forms.TextBox();
            this.showQthree = new System.Windows.Forms.TextBox();
            this.showQfour = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.getNum = new System.Windows.Forms.Button();
            this.numReadValue = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBo4 = new System.Windows.Forms.GroupBox();
            this.taskInfo = new System.Windows.Forms.TextBox();
            this.moduleInfo = new System.Windows.Forms.TextBox();
            this.variNum = new System.Windows.Forms.TextBox();
            this.writeNum = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.numWriteValue = new System.Windows.Forms.TextBox();
            this.writeRobTarget = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.variRobTarget = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBo4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.getLog);
            this.tabPage3.Controls.Add(this.listLog);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(921, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "日志";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // getLog
            // 
            this.getLog.Location = new System.Drawing.Point(452, 6);
            this.getLog.Name = "getLog";
            this.getLog.Size = new System.Drawing.Size(75, 23);
            this.getLog.TabIndex = 1;
            this.getLog.Text = "获取";
            this.getLog.UseVisualStyleBackColor = true;
            this.getLog.Click += new System.EventHandler(this.getLog_Click);
            // 
            // listLog
            // 
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 12;
            this.listLog.Location = new System.Drawing.Point(6, 6);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(440, 448);
            this.listLog.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.groupBo4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listPoint);
            this.tabPage2.Controls.Add(this.listRoutine);
            this.tabPage2.Controls.Add(this.getTask);
            this.tabPage2.Controls.Add(this.listModule);
            this.tabPage2.Controls.Add(this.listTask);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(921, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据读写";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // showX
            // 
            this.showX.Location = new System.Drawing.Point(208, 23);
            this.showX.Name = "showX";
            this.showX.Size = new System.Drawing.Size(79, 21);
            this.showX.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 46;
            this.label11.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 45;
            this.label10.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 12);
            this.label1.TabIndex = 44;
            this.label1.Text = "1-获取任务列表，鼠标选择任务，对对应的模块信息显示";
            // 
            // pointInfo
            // 
            this.pointInfo.Location = new System.Drawing.Point(6, 20);
            this.pointInfo.Multiline = true;
            this.pointInfo.Name = "pointInfo";
            this.pointInfo.Size = new System.Drawing.Size(156, 128);
            this.pointInfo.TabIndex = 41;
            // 
            // listPoint
            // 
            this.listPoint.FormattingEnabled = true;
            this.listPoint.ItemHeight = 12;
            this.listPoint.Location = new System.Drawing.Point(646, 114);
            this.listPoint.Name = "listPoint";
            this.listPoint.Size = new System.Drawing.Size(202, 136);
            this.listPoint.TabIndex = 40;
            this.listPoint.SelectedIndexChanged += new System.EventHandler(this.listPoint_SelectedIndexChanged);
            // 
            // listRoutine
            // 
            this.listRoutine.FormattingEnabled = true;
            this.listRoutine.ItemHeight = 12;
            this.listRoutine.Location = new System.Drawing.Point(429, 114);
            this.listRoutine.Name = "listRoutine";
            this.listRoutine.Size = new System.Drawing.Size(202, 136);
            this.listRoutine.TabIndex = 39;
            this.listRoutine.SelectedIndexChanged += new System.EventHandler(this.listRoutine_SelectedIndexChanged);
            // 
            // getTask
            // 
            this.getTask.Location = new System.Drawing.Point(13, 24);
            this.getTask.Name = "getTask";
            this.getTask.Size = new System.Drawing.Size(86, 23);
            this.getTask.TabIndex = 28;
            this.getTask.Text = "获取任务列表";
            this.getTask.UseVisualStyleBackColor = true;
            this.getTask.Click += new System.EventHandler(this.getTask_Click);
            // 
            // listModule
            // 
            this.listModule.FormattingEnabled = true;
            this.listModule.ItemHeight = 12;
            this.listModule.Location = new System.Drawing.Point(221, 114);
            this.listModule.Name = "listModule";
            this.listModule.Size = new System.Drawing.Size(202, 136);
            this.listModule.TabIndex = 38;
            this.listModule.SelectedIndexChanged += new System.EventHandler(this.listModule_SelectedIndexChanged);
            // 
            // listTask
            // 
            this.listTask.FormattingEnabled = true;
            this.listTask.ItemHeight = 12;
            this.listTask.Location = new System.Drawing.Point(13, 114);
            this.listTask.Name = "listTask";
            this.listTask.Size = new System.Drawing.Size(202, 136);
            this.listTask.TabIndex = 37;
            this.listTask.SelectedIndexChanged += new System.EventHandler(this.listTask_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.scanRobot);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.motorOn);
            this.tabPage1.Controls.Add(this.motorOff);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(921, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "连接机器人";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "双击连接";
            // 
            // scanRobot
            // 
            this.scanRobot.Location = new System.Drawing.Point(13, 138);
            this.scanRobot.Name = "scanRobot";
            this.scanRobot.Size = new System.Drawing.Size(75, 23);
            this.scanRobot.TabIndex = 1;
            this.scanRobot.Text = "扫描机器人";
            this.scanRobot.UseVisualStyleBackColor = true;
            this.scanRobot.Click += new System.EventHandler(this.scanRobot_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SystemName,
            this.IPAddress,
            this.Version,
            this.IsVirtual,
            this.ControllerName});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(862, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.conRobot);
            // 
            // SystemName
            // 
            this.SystemName.Text = "系统名称";
            this.SystemName.Width = 120;
            // 
            // IPAddress
            // 
            this.IPAddress.Text = "IP地址";
            this.IPAddress.Width = 120;
            // 
            // Version
            // 
            this.Version.Text = "版本";
            this.Version.Width = 120;
            // 
            // IsVirtual
            // 
            this.IsVirtual.Text = "是否虚拟机";
            this.IsVirtual.Width = 80;
            // 
            // ControllerName
            // 
            this.ControllerName.Text = "控制器名称";
            this.ControllerName.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getPos);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.PX1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.RZ1);
            this.groupBox1.Controls.Add(this.PY1);
            this.groupBox1.Controls.Add(this.RY1);
            this.groupBox1.Controls.Add(this.PZ1);
            this.groupBox1.Controls.Add(this.RX1);
            this.groupBox1.Location = new System.Drawing.Point(13, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 162);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "坐标位置";
            // 
            // getPos
            // 
            this.getPos.Location = new System.Drawing.Point(6, 29);
            this.getPos.Name = "getPos";
            this.getPos.Size = new System.Drawing.Size(56, 23);
            this.getPos.TabIndex = 25;
            this.getPos.Text = "获取";
            this.getPos.UseVisualStyleBackColor = true;
            this.getPos.Click += new System.EventHandler(this.getPos_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(179, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 16);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.Text = "笛卡尔坐标";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(76, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "关节坐标";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // PX1
            // 
            this.PX1.Location = new System.Drawing.Point(96, 68);
            this.PX1.Name = "PX1";
            this.PX1.Size = new System.Drawing.Size(35, 21);
            this.PX1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // RZ1
            // 
            this.RZ1.Location = new System.Drawing.Point(210, 122);
            this.RZ1.Name = "RZ1";
            this.RZ1.Size = new System.Drawing.Size(35, 21);
            this.RZ1.TabIndex = 14;
            // 
            // PY1
            // 
            this.PY1.Location = new System.Drawing.Point(96, 95);
            this.PY1.Name = "PY1";
            this.PY1.Size = new System.Drawing.Size(35, 21);
            this.PY1.TabIndex = 10;
            // 
            // RY1
            // 
            this.RY1.Location = new System.Drawing.Point(210, 95);
            this.RY1.Name = "RY1";
            this.RY1.Size = new System.Drawing.Size(35, 21);
            this.RY1.TabIndex = 13;
            // 
            // PZ1
            // 
            this.PZ1.Location = new System.Drawing.Point(96, 122);
            this.PZ1.Name = "PZ1";
            this.PZ1.Size = new System.Drawing.Size(35, 21);
            this.PZ1.TabIndex = 11;
            // 
            // RX1
            // 
            this.RX1.Location = new System.Drawing.Point(210, 68);
            this.RX1.Name = "RX1";
            this.RX1.Size = new System.Drawing.Size(35, 21);
            this.RX1.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusTwo);
            this.groupBox3.Controls.Add(this.statusOne);
            this.groupBox3.Controls.Add(this.getStatus);
            this.groupBox3.Location = new System.Drawing.Point(360, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 68);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "机器人状态";
            // 
            // statusTwo
            // 
            this.statusTwo.Location = new System.Drawing.Point(179, 31);
            this.statusTwo.Name = "statusTwo";
            this.statusTwo.Size = new System.Drawing.Size(83, 21);
            this.statusTwo.TabIndex = 27;
            // 
            // statusOne
            // 
            this.statusOne.Location = new System.Drawing.Point(96, 31);
            this.statusOne.Name = "statusOne";
            this.statusOne.Size = new System.Drawing.Size(77, 21);
            this.statusOne.TabIndex = 26;
            // 
            // getStatus
            // 
            this.getStatus.Location = new System.Drawing.Point(6, 31);
            this.getStatus.Name = "getStatus";
            this.getStatus.Size = new System.Drawing.Size(56, 23);
            this.getStatus.TabIndex = 25;
            this.getStatus.Text = "获取";
            this.getStatus.UseVisualStyleBackColor = true;
            this.getStatus.Click += new System.EventHandler(this.getStatus_Click);
            // 
            // motorOn
            // 
            this.motorOn.Location = new System.Drawing.Point(360, 230);
            this.motorOn.Name = "motorOn";
            this.motorOn.Size = new System.Drawing.Size(75, 23);
            this.motorOn.TabIndex = 25;
            this.motorOn.Text = "电机开启";
            this.motorOn.UseVisualStyleBackColor = true;
            this.motorOn.Click += new System.EventHandler(this.motorOn_Click);
            // 
            // motorOff
            // 
            this.motorOff.Location = new System.Drawing.Point(441, 230);
            this.motorOff.Name = "motorOff";
            this.motorOff.Size = new System.Drawing.Size(75, 23);
            this.motorOff.TabIndex = 26;
            this.motorOff.Text = "电机关闭";
            this.motorOff.UseVisualStyleBackColor = true;
            this.motorOff.Click += new System.EventHandler(this.motorOff_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 526);
            this.tabControl1.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(187, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(275, 12);
            this.label12.TabIndex = 48;
            this.label12.Text = "2-依次选择，最后显示相应程序中的robTarget类型";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(185, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 49;
            this.label13.Text = "Z";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(185, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 52;
            this.label14.Text = "Q3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(185, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 51;
            this.label15.Text = "Q2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(185, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 50;
            this.label16.Text = "Q1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(185, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 53;
            this.label17.Text = "Q4";
            // 
            // showY
            // 
            this.showY.Location = new System.Drawing.Point(208, 50);
            this.showY.Name = "showY";
            this.showY.Size = new System.Drawing.Size(79, 21);
            this.showY.TabIndex = 54;
            // 
            // showZ
            // 
            this.showZ.Location = new System.Drawing.Point(208, 77);
            this.showZ.Name = "showZ";
            this.showZ.Size = new System.Drawing.Size(79, 21);
            this.showZ.TabIndex = 55;
            // 
            // showQone
            // 
            this.showQone.Location = new System.Drawing.Point(208, 104);
            this.showQone.Name = "showQone";
            this.showQone.Size = new System.Drawing.Size(79, 21);
            this.showQone.TabIndex = 56;
            // 
            // showQtwo
            // 
            this.showQtwo.Location = new System.Drawing.Point(208, 133);
            this.showQtwo.Name = "showQtwo";
            this.showQtwo.Size = new System.Drawing.Size(79, 21);
            this.showQtwo.TabIndex = 57;
            // 
            // showQthree
            // 
            this.showQthree.Location = new System.Drawing.Point(208, 161);
            this.showQthree.Name = "showQthree";
            this.showQthree.Size = new System.Drawing.Size(79, 21);
            this.showQthree.TabIndex = 58;
            // 
            // showQfour
            // 
            this.showQfour.Location = new System.Drawing.Point(208, 187);
            this.showQfour.Name = "showQfour";
            this.showQfour.Size = new System.Drawing.Size(79, 21);
            this.showQfour.TabIndex = 59;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(187, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(263, 12);
            this.label18.TabIndex = 60;
            this.label18.Text = "3-选择列表中robTarget，对应的显示出坐标信息";
            // 
            // getNum
            // 
            this.getNum.Location = new System.Drawing.Point(6, 125);
            this.getNum.Name = "getNum";
            this.getNum.Size = new System.Drawing.Size(75, 23);
            this.getNum.TabIndex = 61;
            this.getNum.Text = "获取Num";
            this.getNum.UseVisualStyleBackColor = true;
            this.getNum.Click += new System.EventHandler(this.getNum_Click);
            // 
            // numReadValue
            // 
            this.numReadValue.Location = new System.Drawing.Point(91, 127);
            this.numReadValue.Name = "numReadValue";
            this.numReadValue.Size = new System.Drawing.Size(53, 21);
            this.numReadValue.TabIndex = 62;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pointInfo);
            this.groupBox2.Controls.Add(this.showX);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.showQfour);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.showQthree);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.showQtwo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.showQone);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.showZ);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.showY);
            this.groupBox2.Location = new System.Drawing.Point(13, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 220);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "robTarget信息";
            // 
            // groupBo4
            // 
            this.groupBo4.Controls.Add(this.writeRobTarget);
            this.groupBo4.Controls.Add(this.label25);
            this.groupBo4.Controls.Add(this.variRobTarget);
            this.groupBo4.Controls.Add(this.numWriteValue);
            this.groupBo4.Controls.Add(this.label20);
            this.groupBo4.Controls.Add(this.label19);
            this.groupBo4.Controls.Add(this.label9);
            this.groupBo4.Controls.Add(this.writeNum);
            this.groupBo4.Controls.Add(this.variNum);
            this.groupBo4.Controls.Add(this.moduleInfo);
            this.groupBo4.Controls.Add(this.taskInfo);
            this.groupBo4.Controls.Add(this.numReadValue);
            this.groupBo4.Controls.Add(this.getNum);
            this.groupBo4.Location = new System.Drawing.Point(338, 267);
            this.groupBo4.Name = "groupBo4";
            this.groupBo4.Size = new System.Drawing.Size(283, 208);
            this.groupBo4.TabIndex = 64;
            this.groupBo4.TabStop = false;
            this.groupBo4.Text = "Num和robTarget读写";
            // 
            // taskInfo
            // 
            this.taskInfo.Location = new System.Drawing.Point(68, 31);
            this.taskInfo.Name = "taskInfo";
            this.taskInfo.Size = new System.Drawing.Size(76, 21);
            this.taskInfo.TabIndex = 63;
            // 
            // moduleInfo
            // 
            this.moduleInfo.Location = new System.Drawing.Point(68, 58);
            this.moduleInfo.Name = "moduleInfo";
            this.moduleInfo.Size = new System.Drawing.Size(76, 21);
            this.moduleInfo.TabIndex = 64;
            // 
            // variNum
            // 
            this.variNum.Location = new System.Drawing.Point(68, 85);
            this.variNum.Name = "variNum";
            this.variNum.Size = new System.Drawing.Size(76, 21);
            this.variNum.TabIndex = 65;
            // 
            // writeNum
            // 
            this.writeNum.Location = new System.Drawing.Point(6, 161);
            this.writeNum.Name = "writeNum";
            this.writeNum.Size = new System.Drawing.Size(75, 23);
            this.writeNum.TabIndex = 66;
            this.writeNum.Text = "写入Num";
            this.writeNum.UseVisualStyleBackColor = true;
            this.writeNum.Click += new System.EventHandler(this.writeNum_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 65;
            this.label9.Text = "任务名";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 67;
            this.label19.Text = "模块名";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 12);
            this.label20.TabIndex = 68;
            this.label20.Text = "num变量名";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 99);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 12);
            this.label21.TabIndex = 69;
            this.label21.Text = "任务列表";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(219, 99);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 70;
            this.label22.Text = "模块列表";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(427, 99);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 71;
            this.label23.Text = "程序列表";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(644, 99);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 12);
            this.label24.TabIndex = 72;
            this.label24.Text = "robTarget列表";
            // 
            // numWriteValue
            // 
            this.numWriteValue.Location = new System.Drawing.Point(91, 163);
            this.numWriteValue.Name = "numWriteValue";
            this.numWriteValue.Size = new System.Drawing.Size(53, 21);
            this.numWriteValue.TabIndex = 69;
            // 
            // writeRobTarget
            // 
            this.writeRobTarget.Location = new System.Drawing.Point(180, 112);
            this.writeRobTarget.Name = "writeRobTarget";
            this.writeRobTarget.Size = new System.Drawing.Size(93, 23);
            this.writeRobTarget.TabIndex = 70;
            this.writeRobTarget.Text = "写入robTarget";
            this.writeRobTarget.UseVisualStyleBackColor = true;
            this.writeRobTarget.Click += new System.EventHandler(this.writeRobTarget_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(178, 70);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(95, 12);
            this.label25.TabIndex = 71;
            this.label25.Text = "robTarget变量名";
            // 
            // variRobTarget
            // 
            this.variRobTarget.Location = new System.Drawing.Point(180, 85);
            this.variRobTarget.Name = "variRobTarget";
            this.variRobTarget.Size = new System.Drawing.Size(93, 21);
            this.variRobTarget.TabIndex = 70;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(633, 317);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(281, 12);
            this.label26.TabIndex = 73;
            this.label26.Text = "2-写入都是在自动模式下，手动模式需要示教器确认";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(633, 287);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(221, 12);
            this.label27.TabIndex = 74;
            this.label27.Text = "1-在左侧robTarget中的XYZ部分写入数据";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(634, 349);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(257, 12);
            this.label28.TabIndex = 75;
            this.label28.Text = "3-数据类型是变量才允许写入，不能为constant";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 550);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "C#和ABB机器人通讯";
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBo4.ResumeLayout(false);
            this.groupBo4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button getLog;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox pointInfo;
        private System.Windows.Forms.ListBox listPoint;
        private System.Windows.Forms.ListBox listRoutine;
        private System.Windows.Forms.Button getTask;
        private System.Windows.Forms.ListBox listModule;
        private System.Windows.Forms.ListBox listTask;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button scanRobot;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader SystemName;
        private System.Windows.Forms.ColumnHeader IPAddress;
        private System.Windows.Forms.ColumnHeader Version;
        private System.Windows.Forms.ColumnHeader IsVirtual;
        private System.Windows.Forms.ColumnHeader ControllerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button getPos;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox PX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RZ1;
        private System.Windows.Forms.TextBox PY1;
        private System.Windows.Forms.TextBox RY1;
        private System.Windows.Forms.TextBox PZ1;
        private System.Windows.Forms.TextBox RX1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox statusTwo;
        private System.Windows.Forms.TextBox statusOne;
        private System.Windows.Forms.Button getStatus;
        private System.Windows.Forms.Button motorOn;
        private System.Windows.Forms.Button motorOff;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox showX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox showQfour;
        private System.Windows.Forms.TextBox showQthree;
        private System.Windows.Forms.TextBox showQtwo;
        private System.Windows.Forms.TextBox showQone;
        private System.Windows.Forms.TextBox showZ;
        private System.Windows.Forms.TextBox showY;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox numReadValue;
        private System.Windows.Forms.Button getNum;
        private System.Windows.Forms.GroupBox groupBo4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button writeNum;
        private System.Windows.Forms.TextBox variNum;
        private System.Windows.Forms.TextBox moduleInfo;
        private System.Windows.Forms.TextBox taskInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox numWriteValue;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button writeRobTarget;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox variRobTarget;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
    }
}

