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
using ABB.Robotics.Controllers.MotionDomain;
using RobotStudio.Services.RobApi.RobApi1;

namespace ABBCom
{
    public partial class Form1 : Form
    {
        NetworkScanner Scanner = null;
        NetworkScanner scanner = null;

        static Controller controller;


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
                        currentstatus();
                 
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





        static public double[] GetPosition(CoordinateSystemType type)//返回坐标值
        {
            double[] Pos = new double[7];
            string PosStr = controller.MotionSystem.MechanicalUnits[0].GetPosition(type).ToString();
            string[] Poses = PosStr.Split(new char[] { ' ', '{', '}', '[', ']', ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < 7; i++) Pos[i] = Convert.ToDouble(Poses[i]);
            return Pos;
        }

       
    }
}
