using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace USBHIDControl
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            test1();
           // GetUSBDevices();
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/

        }


        static void GetUSBDevices()
        {

            ManagementObjectCollection collection;

            using (var searcher = new ManagementObjectSearcher(@"Select * From LogicalDisk"))
            {
                collection = searcher.Get();
                Console.WriteLine(searcher.Get().GetEnumerator());
            }

            foreach (var device in collection)
            {


                string deviceId = (string)device.GetPropertyValue("DeviceID");
                string pid = (string)device.GetPropertyValue("PNPDeviceID");
                string description = (string)device.GetPropertyValue("Description");

                Console.WriteLine("deviceID = {0} ,pid= {1}, description = {2} ,{3} "
                    , deviceId, pid);

                if (deviceId.Length > 21 && deviceId.Substring(0, 21) == "USB\\VID_FFFF&PID_5678")
                {
                    string deviceType = (string)device.GetPropertyValue("DeviceType");
                    Console.WriteLine("deviceID = {0} ,pid= {1}, description = {2} , deviceType={3}"
                        , deviceId, pid, description, deviceType);
                }


                /*devices.Add(((string)device.GetPropertyValue("DeviceID"),
                    (string)device.GetPropertyValue("PNPDeviceID"),
                    (string)device.GetPropertyValue("Description")));*/
            }

            collection.Dispose();
        }


        private static void test1()
        {
            SelectQuery sq = new SelectQuery("select * from win32_logicaldisk");
            System.Management.ManagementObjectSearcher mos = new ManagementObjectSearcher(sq);
           
            foreach (System.Management.ManagementObject disk in mos.Get())
            {
                Console.WriteLine(disk["Name"].ToString());
                //Name表示设备的名称
                //各属性的标识见联机的MSDN里，Win32 and COM Development下的WMI。
                //如http://msdn.microsoft.com/en-us/library/aa394173(VS.85).aspx
                try
                {
                    string strType = disk["DriveType"].ToString();
                    switch (strType) //类型 
                    {
                        case "0":
                            //item.SubItems.Add("未知设备");
                            break;
                        case "1":
                            //item.SubItems.Add("未分区");
                            break;
                        case "2":
                            //item.SubItems.Add("可移动磁盘");
                            break;
                        case "3":
                            //item.SubItems.Add("硬盘");
                            break;
                        case "4":
                            //item.SubItems.Add("网络驱动器");
                            break;
                        case "5":
                            //item.SubItems.Add("光驱");
                            break;
                        case "6":
                            //item.SubItems.Add("内存磁盘");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("设备未准备好");
                }
                try
                {
                    Console.WriteLine(GetSizeUseUnit(disk["Size"].ToString()));
                    //未用GetSizeUseUnit函数处理的Size属性以字节为单位 
                }
                catch
                {
                }
                try //可移动设备如光驱在未插入光盘时处于不可用状态，需要捕捉异常。 
                {
                    Console.WriteLine(GetSizeUseUnit(disk["FreeSpace"].ToString()));
                }
                catch
                {
                }
                try
                {
                    Console.WriteLine(disk["VolumeSerialNumber"].ToString());
                }
                catch
                {
                }
            }
        }

        public static string GetSizeUseUnit(string size)
        {
            double dSpace = Convert.ToDouble(size);
            string sSpace = dSpace.ToString("N");
            string[] tmp;
            string rtnSize = "0";
            tmp = sSpace.Split(',');
            switch (tmp.GetUpperBound(0))
            {
                case 0:
                    rtnSize = tmp[0] + " 字节";
                    break;
                case 1:
                    rtnSize = tmp[0] + "." + tmp[1].Substring(0, 2) + " K";
                    break;
                case 2:
                    rtnSize = tmp[0] + "." + tmp[1].Substring(0, 2) + " M";
                    break;
                case 3:
                    rtnSize = tmp[0] + "." + tmp[1].Substring(0, 2) + " G";
                    break;
                case 4:
                    rtnSize = tmp[0] + "." + tmp[1].Substring(0, 2) + " T";
                    break;
            }
            return rtnSize;
        }
    }

  

}

  


