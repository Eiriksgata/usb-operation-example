using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace USBHIDControl
{
    public partial class Form1 : Form
    {
        USBHID usbHID = null;
        public Form1()
        {
            InitializeComponent();
            usbHID = new USBHID();

            foreach (string device in usbHID.GetDeviceList())
                list_UsbHID.Items.Add(device);
            usbHID.DataReceived += usbHID_DataReceived;
            usbHID.DeviceRemoved += usbHID_DeviceRemoved;
        }

        void usbHID_DeviceRemoved(object sender, EventArgs e)
        {
            report myRP = (report)e;
            if (InvokeRequired)
            {
                Invoke(new EventHandler(usbHID_DeviceRemoved), new object[] { sender, e });
            }
            else
            {
                tb_information.Text = "设备连接";
            }
        }

        void usbHID_DataReceived(object sender, EventArgs e)
        {
            report myRP = (report)e;
            if (InvokeRequired)
            {
                Invoke(new EventHandler(usbHID_DataReceived), new object[] { sender, e });
            }
            else
            {
                if(usbHID.hidDevice!= null)
                {
                    tb_information.Text = "\r Received:";
                    tb_information.Text += USBHID.ByteToHexString(myRP.reportBuff);
                }
               
            }
        }

        /// <summary>
        /// open USB HID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (list_UsbHID.SelectedItem == null) {
                tb_information.Text += "\r\n vendorID和productID不能为空";
                return;
            }

            if (usbHID.OpenUSBHid(list_UsbHID.SelectedItem.ToString()))
            {
                Console.WriteLine(list_UsbHID.SelectedItem.ToString());
                tb_information.Text += "\r\n open success";
            }
            else
                tb_information.Text += "\r\n open fail";
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            tb_information.Text +="\r\n w: "+ usbHID.WriteUSBHID(tb_send.Text);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_information.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usbHID.CloseDevice();
            tb_information.Text += "\r\n close device";
        }
    }
}
