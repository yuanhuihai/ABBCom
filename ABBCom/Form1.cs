using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ABB.Robotics.Controllers;
using ABB.Robotics.Controllers.Configuration;

namespace ABBCom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //搜素可连接的机器人
        private void button1_Click(object sender, EventArgs e)
        {
          
          
                if (Scanner == null)
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
                    item.SubItems.Add(info.IsVirtual.ToString()); 显示是否为虚拟控制
                    item.SubItems.Add(info.ControllerName.ToString());//显示控制器名称
                    item.Tag = info;
                    this.listView1.Items.Add(item);
                }
            
        }
    }
}
