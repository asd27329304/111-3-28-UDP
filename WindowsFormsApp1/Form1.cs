using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UdpClient U;
        Thread Th;

        //監聽副程序
        private void Listen()
        {
            //設定監聽用的通訊埠
            int Port = int.Parse(tbGetPort.Text);

            //監聽UDP監聽器實體
            U = new UdpClient(Port);

            //建立本機端點資訊
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port);

            while (true)
            {
                byte[] B = U.Receive(ref EP); //接收到的訊息放到陣列
                tbText.Text = Encoding.Unicode.GetString(B);    //翻譯陣列為字串
            }
;
        }

        
        private string MyIP()
        {
            string hostname = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostEntry(hostname).AddressList;

            foreach (IPAddress it in ip)
            {
                if (it.AddressFamily == AddressFamily.InterNetwork && it.ToString() != "192.168.56.1")
                {
                    return it.ToString();
                }
            }
            return "";
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false; //忽略跨執行續錯誤
            Th = new Thread(Listen); //建立監聽執行緒，目標副程序->Listen
            Th.Start(); //啟動監聽執行緒
            buttonGet.Enabled = false; //使button失效(不能重複開啟開啟監聽)
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string IP = tbIP.Text;  //設定發送目標IP
            int Port = int.Parse(tbPort.Text);  //設定發送目標Port
            byte[] B = Encoding.Unicode.GetBytes(tbEnter.Text); //字串翻譯成位元
            UdpClient S = new UdpClient();  //建立UDP Client
            S.Send(B, B.Length, IP, Port);  //發送資料到指定位置
            S.Close();  //關閉UDP Client
            tbEnter.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "我的IP:" + MyIP();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Th != null)
                {
                    Th.Abort(); //關閉執行緒
                    U.Close();  //關閉監聽
                }

            }

            catch
            {

            }
        }

        

        
    }
}
