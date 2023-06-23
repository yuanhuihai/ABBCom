using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ABB.Robotics.Controllers;
using ABB.Robotics.Controllers.Discovery;
using ABB.Robotics.Controllers.EventLogDomain;
using ABB.Robotics.Controllers.IOSystemDomain;
using ABB.Robotics.Controllers.MotionDomain;
using ABB.Robotics.Controllers.RapidDomain;
using RobotStudio.Services.RobApi.RobApi1;

namespace ABBCom
{
    public partial class Form1 : Form
    {

        NetworkScanner scanner = null;

        static Controller controller;
        static ABB.Robotics.Controllers.RapidDomain.Task _task = null;




        static int taskint;
        static int moduleint;
        static int routineint;

        RapidData rd;





        public string localFilePath; //rapidcode代码内容保存地址

        public Form1()
        {
            InitializeComponent();

         



        }


        //搜素可连接的机器人 20230520

        private void scanRobot_Click(object sender, EventArgs e)
        {

            if (scanner == null)
            {
                scanner = new NetworkScanner();
            }
            scanner.Scan();
            ControllerInfoCollection controls = scanner.Controllers;
            this.listView1.Items.Clear();
            foreach (ControllerInfo info in controls)
            {
                ListViewItem item = new ListViewItem(info.SystemName);
                item.SubItems.Add(info.IPAddress.ToString());//显示IP地址
                item.SubItems.Add(info.Version.ToString());//显示robotware版本
                item.SubItems.Add(info.IsVirtual.ToString());// 显示是否为虚拟控制
                item.SubItems.Add(info.ControllerName.ToString());//显示控制器名称
                item.Tag = info;
                this.listView1.Items.Add(item);
            }
        }


        //列表双击连接机器人 20230520
        private void conRobot(object sender, EventArgs e)
        {


            if (this.listView1.Items.Count > 0)
            {
                ListViewItem item = this.listView1.SelectedItems[0];
                if (item != null)
                {
                    ControllerInfo info = (ControllerInfo)item.Tag;
                    if (info.Availability == Availability.Available)
                    {
                        if (controller != null)
                        {
                            controller.Logoff();
                            controller.Dispose();
                            controller = null;

                        }
                        controller = ControllerFactory.CreateFrom(info);
                        controller.Logon(UserInfo.DefaultUser);
                        MessageBox.Show("已经登录控制器" + info.SystemName);

                        _task = controller.Rapid.GetTasks()[0];

                    }

                    timer2.Start();
                }

            
             
            }



        }


        // 获取坐标 20230520
        private void getPos_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //每1s钟获取一次坐标 20230520
        private void timer1_Tick(object sender, EventArgs e)
        {
            //关节坐标
            if (radioButton1.Checked)
            {
                ABB.Robotics.Controllers.RapidDomain.JointTarget RJ = controller.MotionSystem.ActiveMechanicalUnit.GetPosition();
                label2.Text = "J1:";
                label3.Text = "J2:";
                label4.Text = "J3:";
                label5.Text = "J4:";
                label6.Text = "J5:";
                label7.Text = "J6:";
                PX1.Text = RJ.RobAx.Rax_1.ToString(format: "0.00");
                PY1.Text = RJ.RobAx.Rax_2.ToString(format: "0.00");
                PZ1.Text = RJ.RobAx.Rax_3.ToString(format: "0.00");
                RX1.Text = RJ.RobAx.Rax_4.ToString(format: "0.00");
                RY1.Text = RJ.RobAx.Rax_5.ToString(format: "0.00");
                RZ1.Text = RJ.RobAx.Rax_6.ToString(format: "0.00");
            }

            //基坐标
            if (radioButton2.Checked)
            {
                double tx;
                double ty;
                double tz;
                ABB.Robotics.Controllers.RapidDomain.RobTarget robTarget = controller.MotionSystem.ActiveMechanicalUnit.GetPosition(CoordinateSystemType.World);
                label2.Text = "PX:";
                label3.Text = "PY:";
                label4.Text = "PZ:";
                label5.Text = "RX:";
                label6.Text = "RY:";
                label7.Text = "RZ;";
                PX1.Text = robTarget.Trans.X.ToString(format: "0.00");
                PY1.Text = robTarget.Trans.Y.ToString(format: "0.00");
                PZ1.Text = robTarget.Trans.Z.ToString(format: "0.00");
                robTarget.Rot.ToEulerAngles(out tx, out ty, out tz);
                RX1.Text = tx.ToString(format: "0.00");
                RY1.Text = ty.ToString(format: "0.00");
                RZ1.Text = tz.ToString(format: "0.00");


            }
        }


        //每5s钟获取一次机器人状态 20230623
        private void timer2_Tick(object sender, EventArgs e)
        {
            updateStatus();
        }


        //每5s钟获取机器人方法20230623

            public void updateStatus()
        {
            ControllerState con_states = new ControllerState();
            con_states = controller.State;
            ControllerOperatingMode op_mode = new ControllerOperatingMode();
            op_mode = controller.OperatingMode;
            string T1 = "";
            string T2 = "";
            if (con_states.Equals(ControllerState.EmergencyStop)) T1 = "急停";
            else if (con_states.Equals(ControllerState.EmergencyStopReset)) T1 = "急停复位";
            else if (con_states.Equals(ControllerState.GuardStop)) T1 = "安全停止";
            else if (con_states.Equals(ControllerState.Init)) T1 = "初始化";
            else if (con_states.Equals(ControllerState.MotorsOff)) T1 = "电机关闭";
            else if (con_states.Equals(ControllerState.MotorsOn)) T1 = "电机启动";
            else if (con_states.Equals(ControllerState.SystemFailure)) T1 = "系统失效";
            else if (con_states.Equals(ControllerState.Unknown)) T1 = "未知";
            else T1 = "严重错误";
            if (op_mode.Equals(ControllerOperatingMode.Auto)) T2 = "自动";
            else if (op_mode.Equals(ControllerOperatingMode.AutoChange)) T2 = "自动改";
            else if (op_mode.Equals(ControllerOperatingMode.Init)) T2 = "初始化";
            else if (op_mode.Equals(ControllerOperatingMode.ManualFullSpeed)) T2 = "手动全速";
            else if (op_mode.Equals(ControllerOperatingMode.ManualFullSpeedChange)) T2 = "手动全速改";
            else if (op_mode.Equals(ControllerOperatingMode.ManualReducedSpeed)) T2 = "手动减速";
            else if (op_mode.Equals(ControllerOperatingMode.NotApplicable)) T2 = "不适用";
            else T2 = "严重错误";

            opMode.Text = "操作模式：" + T2;
            controlStatus.Text = "控制状态：" + T1;
            opMode.ForeColor = Color.Blue;
            controlStatus.ForeColor = Color.Blue;

        }

        //获取机器人当前状态 20230520

        private void getStatus_Click(object sender, EventArgs e)
        {
            ControllerState con_states = new ControllerState();
            con_states = controller.State;
            ControllerOperatingMode op_mode = new ControllerOperatingMode();
            op_mode = controller.OperatingMode;
            string T1 = "";
            string T2 = "";
            if (con_states.Equals(ControllerState.EmergencyStop)) T1 = "急停";
            else if (con_states.Equals(ControllerState.EmergencyStopReset)) T1 = "急停复位";
            else if (con_states.Equals(ControllerState.GuardStop)) T1 = "安全停止";
            else if (con_states.Equals(ControllerState.Init)) T1 = "初始化";
            else if (con_states.Equals(ControllerState.MotorsOff)) T1 = "电机关闭";
            else if (con_states.Equals(ControllerState.MotorsOn)) T1 = "电机启动";
            else if (con_states.Equals(ControllerState.SystemFailure)) T1 = "系统失效";
            else if (con_states.Equals(ControllerState.Unknown)) T1 = "未知";
            else T1 = "严重错误";
            if (op_mode.Equals(ControllerOperatingMode.Auto)) T2 = "自动";
            else if (op_mode.Equals(ControllerOperatingMode.AutoChange)) T2 = "自动改";
            else if (op_mode.Equals(ControllerOperatingMode.Init)) T2 = "初始化";
            else if (op_mode.Equals(ControllerOperatingMode.ManualFullSpeed)) T2 = "手动全速";
            else if (op_mode.Equals(ControllerOperatingMode.ManualFullSpeedChange)) T2 = "手动全速改";
            else if (op_mode.Equals(ControllerOperatingMode.ManualReducedSpeed)) T2 = "手动减速";
            else if (op_mode.Equals(ControllerOperatingMode.NotApplicable)) T2 = "不适用";
            else T2 = "严重错误";


            statusOne.Text = T1;
            statusTwo.Text = T2;




        }


        //电机开启 20230520

        private void motorOn_Click(object sender, EventArgs e)
        {


            try
            {
                if (controller.OperatingMode == ControllerOperatingMode.Auto)//判断控制箱操作模式是否为自动模式
                {
                    controller.State = ControllerState.MotorsOn;//开启电机

                    MessageBox.Show("电机开启成功!");
                }
                else
                {
                    MessageBox.Show("请切换自动模式！");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("发生意外!:" + ex.Message);
            }


        }


        //电机关闭 20230520
        private void motorOff_Click(object sender, EventArgs e)
        {
            try
            {
                if (controller.OperatingMode == ControllerOperatingMode.Auto)
                {
                    controller.State = ControllerState.MotorsOff;
                    MessageBox.Show("机器人电机关闭成功");
                }
                else
                {
                    MessageBox.Show("请切换自动模式！");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("发生意外" + ex.Message);
            }
        }


      

        // 获取任务列表 20230609

        private void getTask_Click(object sender, EventArgs e)
        {

            listTask.Items.Clear();

            for (int i = 0; i < (int)controller.Rapid.GetTasks().Count(); i++)
            {
                listTask.Items.Add(controller.Rapid.GetTasks()[i].Name);
            }

        }

        //获取模块列表20230609
        private void listTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            int taskint = listTask.SelectedIndex;
            Module[] modules = controller.Rapid.GetTasks()[taskint].GetModules();
            listModule.Items.Clear();
            for (int i = 0; i < (int)modules.Count(); i++)
            {

                listModule.Items.Add(modules[i].Name);
            };


        }

        //获取子程序列表20230609
        private void listModule_SelectedIndexChanged(object sender, EventArgs e)
        {

            listRoutine.Items.Clear();
            int taskint = listTask.SelectedIndex;
            int moduleint = listModule.SelectedIndex;


            Routine[] routines1 = controller.Rapid.GetTasks()[taskint].GetModules()[moduleint].GetRoutines();
            for (int i = 0; i < (int)routines1.Count(); i++)
            {
                listRoutine.Items.Add(routines1[i].Name);
            }


        }

        //获取程序中点位信息 20230609

        private void listRoutine_SelectedIndexChanged(object sender, EventArgs e)
        {
            RapidSymbolSearchProperties date = RapidSymbolSearchProperties.CreateDefault();
            date.Types = SymbolTypes.Data;
            date.SearchMethod = SymbolSearchMethod.Block;
            date.Recursive = true;
            date.InUse = false;
            date.LocalSymbols = false;
            RapidSymbol[] symbols = controller.Rapid.GetTasks()[taskint].SearchRapidSymbol(date, "robtarget", string.Empty);
            listPoint.Items.Clear();
            foreach (RapidSymbol symbol in symbols)
            {
                try
                {
                    RapidData rD = controller.Rapid.GetTasks()[taskint].GetRapidData(symbol);
                    listPoint.Items.Add(rD.Name);

                }
                catch (Exception)
                {
                    return;
                }
            }
            if (listPoint.Items == null)
            {
                listPoint.Items.Add("没有坐标变量");

            }
        }

        //获取程序中点坐标具体信息20230609
        private void listPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            RapidSymbolSearchProperties date = RapidSymbolSearchProperties.CreateDefault();
            date.Types = SymbolTypes.Data;
            date.SearchMethod = SymbolSearchMethod.Block;
            date.Recursive = true;
            date.InUse = false;
            date.LocalSymbols = false;
            RapidSymbol[] symbols = controller.Rapid.GetTasks()[taskint].SearchRapidSymbol(date, "robtarget", string.Empty);

            foreach (RapidSymbol symbol in symbols)
            {
                try
                {
                    RapidData rD = controller.Rapid.GetTasks()[taskint].GetRapidData(symbol);
                    if (rD.Name == listPoint.SelectedItem.ToString())
                    {

                        if (rD.Value != null)
                        {

                            pointInfo.Text = rD.Value.ToString();

                            RobTarget pp = (RobTarget)rD.Value;

                            showX.Text = pp.Trans.X.ToString(format: "0.00");
                            showY.Text = pp.Trans.Y.ToString(format: "0.00");
                            showZ.Text = pp.Trans.Z.ToString(format: "0.00");
                            showQone.Text = pp.Rot.Q1.ToString(format: "0.00");
                            showQtwo.Text = pp.Rot.Q2.ToString(format: "0.00");
                            showQthree.Text = pp.Rot.Q3.ToString(format: "0.00");
                            showQfour.Text = pp.Rot.Q4.ToString(format: "0.00");

                        }
                        else
                        {
                        }

                    }
                    else
                    {
                        continue;
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }

        }

        //写入Target 20230610
        private void writeRobTarget_Click(object sender, EventArgs e)
        {

            try
            {
                using (Mastership.Request(controller.Rapid))
                {
                    RapidData rd = controller.Rapid.GetRapidData(taskInfo.Text.ToString(), moduleInfo.Text.ToString(), variRobTarget.Text.ToString());
                    RobTarget number = (RobTarget)rd.Value;
                    number.Trans.X = Convert.ToSingle(showX.Text);
                    number.Trans.Y = Convert.ToSingle(showY.Text);
                    number.Trans.Z = Convert.ToSingle(showZ.Text);
                    number.Rot.Q1 = Convert.ToSingle(showQone.Text);
                    number.Rot.Q2 = Convert.ToSingle(showQtwo.Text);
                    number.Rot.Q3 = Convert.ToSingle(showQthree.Text);
                    number.Rot.Q4 = Convert.ToSingle(showQfour.Text);
                    rd.Value = number;


                }
            }


            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }
        //读取num数值 20230610
        private void getNum_Click(object sender, EventArgs e)
        {
            RapidData nnum = controller.Rapid.GetRapidData(taskInfo.Text.ToString(), moduleInfo.Text.ToString(), variNum.Text.ToString());
            numReadValue.Text = nnum.Value.ToString();
        }
        //写入num数值 20230610
        private void writeNum_Click(object sender, EventArgs e)
        {
            try
            {
                using (Mastership.Request(controller.Rapid))
                {
                    RapidData rd = controller.Rapid.GetRapidData(taskInfo.Text.ToString(), moduleInfo.Text.ToString(), variNum.Text.ToString());
                    Num number = (Num)rd.Value;
                    number.FillFromString2(this.numWriteValue.Text);
                    rd.Value = number;

                }
            }


            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }




        #region
        //日志标签
        #endregion
        //20230609获取日志
        private void getLog_Click(object sender, EventArgs e)
        {
            EventLog log = controller.EventLog;
            EventLogCategory cat;
            cat = log.GetCategory(0);
            //0表示读取所有日志，具体见CategoryType

            {
                foreach (EventLogMessage emsg in cat.Messages)
                {


                    listLog.Items.Add(emsg.Timestamp + " " + emsg.Title + " " + "\r\n");   //讲每一条日志的时间戳和日志标题写入并显示
                }
            }
        }


        #region
        //运行程序标签
        #endregion

        // 20230611选择程序运行
        private void startPro_Click(object sender, EventArgs e)
        {

            if (controller.OperatingMode == ControllerOperatingMode.Auto)
            {

                using (Mastership.Request(controller.Rapid))
                {

                    _task.SetProgramPointer(moduleName.Text, proName.Text);
                    controller.Rapid.Start();

                    runStatus.Text = DateTime.Now.ToString() + "程序已经运行。";

                    startPro.Enabled = false;

                }

                Mastership.Request(controller.Rapid).Release();
            }
            else
            {

                runStatus.Text = DateTime.Now.ToString() + "机器人没有处于自动模式!";
            }



        }
        //20230613结束程序运行
        private void stopPro_Click(object sender, EventArgs e)
        {
            using (Mastership.Request(controller.Rapid))
            {

                controller.Rapid.Stop(StopMode.Immediate);
                startPro.Enabled = true;
            }
        }


        //20230611 获取任务列表
        private void getTaskOne_Click(object sender, EventArgs e)
        {
            listTaskOne.Items.Clear();

            for (int i = 0; i < (int)controller.Rapid.GetTasks().Count(); i++)
            {
                listTaskOne.Items.Add(controller.Rapid.GetTasks()[i].Name);
            }
        }

        //20230611获取选中任务的模块
        private void listTaskOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = listTaskOne.SelectedIndex;
            Module[] modules = controller.Rapid.GetTasks()[a].GetModules();
            listModuleOne.Items.Clear();
            for (int i = 0; i < (int)modules.Count(); i++)
            {

                listModuleOne.Items.Add(modules[i].Name);
            };
        }

        //20230611 显示选择的模块
        private void listModuleOne_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedModule.Text = listModuleOne.SelectedItem.ToString();
        }

        //20230611 读取模块内容
        private void readModule_Click(object sender, EventArgs e)
        {
            rapidCodeValue.Clear();

            ABB.Robotics.Controllers.RapidDomain.Module m1 = _task.GetModule(selectedModule.Text);
            //根据currModuleName获取该模块
            string remotePath = controller.FileSystem.RemoteDirectory + "/pctmp";
            //获取模块到本地，需要先把模块存储到机器人控制器，并利用module.SaveToFile函数存储到本地并显示
            //设置机器人控制器下存储的路径，此处设置为Home/pctmp
            try
            {

                using (Mastership m = Mastership.Request(controller))
                {
                    if (controller.FileSystem.DirectoryExists("pctmp") == false)
                    {
                        //如果HOME/pctmp文件夹不存在，则创建该路径
                        controller.FileSystem.CreateDirectory("pctmp");
                    }
                    m1.SaveToFile(remotePath);
                    //将对应模块文件存储到该路径
                    controller.FileSystem.GetFile("pctmp/" + selectedModule.Text + ".mod", selectedModule.Text + ".mod", true);
                    //将Home/pctmp下的存储的模块存储到PC本地，默认路径为bin/Debug下
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            string rootpath = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            //获取C#项目路径
            localFilePath = rootpath + "\\Debug\\" + selectedModule.Text + ".mod";
            //存储本地module文件的路径，后续修改rapid时，先将修改后的文件存储到该路径，并从该路径传输到机器人控制器并加载到RAPID
            string text = System.IO.File.ReadAllText(localFilePath);
            //读取存储到本地的模块文件
            rapidCodeValue.Text = text;
            //将模块文件内容显示到textBox4中
        }

        //20230611 模块中写入内容
        private void writeModule_Click(object sender, EventArgs e)
        {
            string strTest;
            strTest = rapidCodeValue.Text;
            System.IO.File.WriteAllText(localFilePath, strTest);
            //将最新的textBox4中修改的RAPID代码存储到localFilePath路径下的模块文件
            try
            {
                using (Mastership.Request(controller.Rapid))
                {
                    controller.FileSystem.PutFile(localFilePath, "/pctmp/" + selectedModule.Text + ".mod", true);
                    //将localFilePath路径下的本地模块传输到机器人控制器的Home/pctmp文件夹下
                    bool flag1 = _task.LoadModuleFromFile(controller.FileSystem.RemoteDirectory + "/pctmp/" + selectedModule.Text + ".mod", RapidLoadMode.Replace);
                    //将Home/pctmp文件夹下的该模块加载到RAPID，如果有重复模块则替换
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            rapidCodeValue.Clear();
            MessageBox.Show("修改成功");

            //提示修改成功
        }


        //20230614 调试测试
        private void button1_Click(object sender, EventArgs e)
        {
          
        

        }

        //20230614 获取IO信号列表
        private void getIOsignal_Click(object sender, EventArgs e)
        {
            var ios = controller.IOSystem.GetSignals(IOFilterTypes.All);

            foreach (Signal io in ios)
            {
              
                ListViewItem item = new ListViewItem(io.Name);
                item.SubItems.Add(io.Type.ToString());
                item.SubItems.Add(io.Value.ToString());
                this.listViewIO.Items.Add(item);
             
            }

        }
        //20230614 获取IO单元
        private void getIOunit_Click(object sender, EventArgs e)
        {
            var Units = controller.IOSystem.GetUnits();
            foreach (Unit unit in Units)
            {    //显示扫描到的IO板
             
                listBoxIOunit.Items.Add("IOBoard:" + unit.Name);
            }
        }

        //20230622 获取机器人选项信息
        private void robotOption_Click(object sender, EventArgs e)
        {
            RobotWareOptionCollection options = controller.RobotWare.Options;

            richOption.Text += "系统名:" + controller.RobotWare.Name.ToString() + "\r\n";
            richOption.Text += "RW版本:" + controller.RobotWare.Version.ToString() + "\r\n";
            foreach(RobotWareOption option in options)
            {
                richOption.Text += "option:" + option.ToString() + "\r\n";
            }
        }

        //20230622 机器人运行时间
        private void runTime_Click(object sender, EventArgs e)
        {
            MechanicalUnitServiceInfo unitServcieInfo = controller.MotionSystem.ActiveMechanicalUnit.ServiceInfo;
            richRunTime.Text += "生产总时间:" + unitServcieInfo.ElapsedProductionTime.TotalHours.ToString() + "小时\r\n";
            richRunTime.Text += "自上次服务后的生产总时间:" + unitServcieInfo.ElapsedProductionTimeSinceLastService.TotalHours.ToString() + "小时\r\n";
            richRunTime.Text += "上次开机时间:" + unitServcieInfo.LastStart.ToString() + "小时\r\n";
            richRunTime.Text += "自上次检修后的校准时间:" + unitServcieInfo.ElapsedProductionTimeSinceLastService.TotalHours.ToString() + "小时\r\n";
        }

       
    }
}
    
       
