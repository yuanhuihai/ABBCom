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
using ABB.Robotics.Controllers.MotionDomain;
using ABB.Robotics.Controllers.RapidDomain;
using RobotStudio.Services.RobApi.RobApi1;

namespace ABBCom
{
    public partial class Form1 : Form
    {
     
        NetworkScanner scanner = null;

        static Controller controller;



        static  int taskint ;
        static int moduleint;
        static int routineint ;



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
            
                 
                        }
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

       

       
    }
}
