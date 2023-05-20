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
            this.listView1 = new System.Windows.Forms.ListView();
            this.SystemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsVirtual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ControllerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scanRobot = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PX1 = new System.Windows.Forms.TextBox();
            this.PY1 = new System.Windows.Forms.TextBox();
            this.PZ1 = new System.Windows.Forms.TextBox();
            this.RX1 = new System.Windows.Forms.TextBox();
            this.RY1 = new System.Windows.Forms.TextBox();
            this.RZ1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.getPos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.getStatus = new System.Windows.Forms.Button();
            this.statusOne = new System.Windows.Forms.TextBox();
            this.statusTwo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SystemName,
            this.IPAddress,
            this.Version,
            this.IsVirtual,
            this.ControllerName});
            this.listView1.Location = new System.Drawing.Point(18, 20);
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
            this.scanRobot.Location = new System.Drawing.Point(18, 123);
            this.scanRobot.Name = "scanRobot";
            this.scanRobot.Size = new System.Drawing.Size(75, 23);
            this.scanRobot.TabIndex = 1;
            this.scanRobot.Text = "扫描机器人";
            this.scanRobot.UseVisualStyleBackColor = true;
            this.scanRobot.Click += new System.EventHandler(this.scanRobot_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // PX1
            // 
            this.PX1.Location = new System.Drawing.Point(96, 68);
            this.PX1.Name = "PX1";
            this.PX1.Size = new System.Drawing.Size(35, 21);
            this.PX1.TabIndex = 9;
            // 
            // PY1
            // 
            this.PY1.Location = new System.Drawing.Point(96, 95);
            this.PY1.Name = "PY1";
            this.PY1.Size = new System.Drawing.Size(35, 21);
            this.PY1.TabIndex = 10;
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
            // RY1
            // 
            this.RY1.Location = new System.Drawing.Point(210, 95);
            this.RY1.Name = "RY1";
            this.RY1.Size = new System.Drawing.Size(35, 21);
            this.RY1.TabIndex = 13;
            // 
            // RZ1
            // 
            this.RZ1.Location = new System.Drawing.Point(210, 122);
            this.RZ1.Name = "RZ1";
            this.RZ1.Size = new System.Drawing.Size(35, 21);
            this.RZ1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "机器人当前状态";
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
            this.groupBox1.Location = new System.Drawing.Point(25, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 162);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "坐标位置";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(76, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 23;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.scanRobot);
            this.groupBox2.Location = new System.Drawing.Point(25, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(886, 153);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "扫描机器人（双击连接）";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusTwo);
            this.groupBox3.Controls.Add(this.statusOne);
            this.groupBox3.Controls.Add(this.getStatus);
            this.groupBox3.Location = new System.Drawing.Point(25, 365);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 532);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button scanRobot;
        private System.Windows.Forms.ColumnHeader SystemName;
        private System.Windows.Forms.ColumnHeader IPAddress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PX1;
        private System.Windows.Forms.TextBox PY1;
        private System.Windows.Forms.TextBox PZ1;
        private System.Windows.Forms.TextBox RX1;
        private System.Windows.Forms.TextBox RY1;
        private System.Windows.Forms.TextBox RZ1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Version;
        private System.Windows.Forms.ColumnHeader IsVirtual;
        private System.Windows.Forms.ColumnHeader ControllerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button getPos;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox statusTwo;
        private System.Windows.Forms.TextBox statusOne;
        private System.Windows.Forms.Button getStatus;
    }
}

