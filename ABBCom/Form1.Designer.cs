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
            this.listLog = new System.Windows.Forms.ListBox();
            this.getLog = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listTask = new System.Windows.Forms.ListBox();
            this.listModule = new System.Windows.Forms.ListBox();
            this.getTask = new System.Windows.Forms.Button();
            this.listRoutine = new System.Windows.Forms.ListBox();
            this.listPoint = new System.Windows.Forms.ListBox();
            this.pointInfo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.motorOff = new System.Windows.Forms.Button();
            this.motorOn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.getStatus = new System.Windows.Forms.Button();
            this.statusOne = new System.Windows.Forms.TextBox();
            this.statusTwo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RX1 = new System.Windows.Forms.TextBox();
            this.PZ1 = new System.Windows.Forms.TextBox();
            this.RY1 = new System.Windows.Forms.TextBox();
            this.PY1 = new System.Windows.Forms.TextBox();
            this.RZ1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PX1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.getPos = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SystemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsVirtual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ControllerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scanRobot = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            // listLog
            // 
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 12;
            this.listLog.Location = new System.Drawing.Point(6, 6);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(440, 448);
            this.listLog.TabIndex = 0;
            // 
            // getLog
            // 
            this.getLog.Location = new System.Drawing.Point(507, 34);
            this.getLog.Name = "getLog";
            this.getLog.Size = new System.Drawing.Size(75, 23);
            this.getLog.TabIndex = 1;
            this.getLog.Text = "获取";
            this.getLog.UseVisualStyleBackColor = true;
            this.getLog.Click += new System.EventHandler(this.getLog_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.pointInfo);
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
            this.tabPage2.Text = "坐标点信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listTask
            // 
            this.listTask.FormattingEnabled = true;
            this.listTask.ItemHeight = 12;
            this.listTask.Location = new System.Drawing.Point(13, 48);
            this.listTask.Name = "listTask";
            this.listTask.Size = new System.Drawing.Size(202, 208);
            this.listTask.TabIndex = 37;
            this.listTask.SelectedIndexChanged += new System.EventHandler(this.listTask_SelectedIndexChanged);
            // 
            // listModule
            // 
            this.listModule.FormattingEnabled = true;
            this.listModule.ItemHeight = 12;
            this.listModule.Location = new System.Drawing.Point(221, 48);
            this.listModule.Name = "listModule";
            this.listModule.Size = new System.Drawing.Size(202, 208);
            this.listModule.TabIndex = 38;
            this.listModule.SelectedIndexChanged += new System.EventHandler(this.listModule_SelectedIndexChanged);
            // 
            // getTask
            // 
            this.getTask.Location = new System.Drawing.Point(13, 9);
            this.getTask.Name = "getTask";
            this.getTask.Size = new System.Drawing.Size(75, 23);
            this.getTask.TabIndex = 28;
            this.getTask.Text = "获取任务";
            this.getTask.UseVisualStyleBackColor = true;
            this.getTask.Click += new System.EventHandler(this.getTask_Click);
            // 
            // listRoutine
            // 
            this.listRoutine.FormattingEnabled = true;
            this.listRoutine.ItemHeight = 12;
            this.listRoutine.Location = new System.Drawing.Point(429, 48);
            this.listRoutine.Name = "listRoutine";
            this.listRoutine.Size = new System.Drawing.Size(202, 208);
            this.listRoutine.TabIndex = 39;
            this.listRoutine.SelectedIndexChanged += new System.EventHandler(this.listRoutine_SelectedIndexChanged);
            // 
            // listPoint
            // 
            this.listPoint.FormattingEnabled = true;
            this.listPoint.ItemHeight = 12;
            this.listPoint.Location = new System.Drawing.Point(646, 48);
            this.listPoint.Name = "listPoint";
            this.listPoint.Size = new System.Drawing.Size(202, 208);
            this.listPoint.TabIndex = 40;
            this.listPoint.SelectedIndexChanged += new System.EventHandler(this.listPoint_SelectedIndexChanged);
            // 
            // pointInfo
            // 
            this.pointInfo.Location = new System.Drawing.Point(82, 287);
            this.pointInfo.Name = "pointInfo";
            this.pointInfo.Size = new System.Drawing.Size(766, 21);
            this.pointInfo.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 43;
            this.label9.Text = "坐标信息";
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
            // statusOne
            // 
            this.statusOne.Location = new System.Drawing.Point(96, 31);
            this.statusOne.Name = "statusOne";
            this.statusOne.Size = new System.Drawing.Size(77, 21);
            this.statusOne.TabIndex = 26;
            // 
            // statusTwo
            // 
            this.statusTwo.Location = new System.Drawing.Point(179, 31);
            this.statusTwo.Name = "statusTwo";
            this.statusTwo.Size = new System.Drawing.Size(83, 21);
            this.statusTwo.TabIndex = 27;
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
            // RX1
            // 
            this.RX1.Location = new System.Drawing.Point(210, 68);
            this.RX1.Name = "RX1";
            this.RX1.Size = new System.Drawing.Size(35, 21);
            this.RX1.TabIndex = 12;
            // 
            // PZ1
            // 
            this.PZ1.Location = new System.Drawing.Point(96, 122);
            this.PZ1.Name = "PZ1";
            this.PZ1.Size = new System.Drawing.Size(35, 21);
            this.PZ1.TabIndex = 11;
            // 
            // RY1
            // 
            this.RY1.Location = new System.Drawing.Point(210, 95);
            this.RY1.Name = "RY1";
            this.RY1.Size = new System.Drawing.Size(35, 21);
            this.RY1.TabIndex = 13;
            // 
            // PY1
            // 
            this.PY1.Location = new System.Drawing.Point(96, 95);
            this.PY1.Name = "PY1";
            this.PY1.Size = new System.Drawing.Size(35, 21);
            this.PY1.TabIndex = 10;
            // 
            // RZ1
            // 
            this.RZ1.Location = new System.Drawing.Point(210, 122);
            this.RZ1.Name = "RZ1";
            this.RZ1.Size = new System.Drawing.Size(35, 21);
            this.RZ1.TabIndex = 14;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // PX1
            // 
            this.PX1.Location = new System.Drawing.Point(96, 68);
            this.PX1.Name = "PX1";
            this.PX1.Size = new System.Drawing.Size(35, 21);
            this.PX1.TabIndex = 9;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "双击连接";
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button getLog;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
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
    }
}

