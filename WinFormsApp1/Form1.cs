using System.Diagnostics;
using System.Collections.Generic;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;

namespace WinFormsApp1
{


    public partial class Form1 : Form
    {

        public void Cywd()
        {
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
        }
        public void Cnwd()
        {
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
        }
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Process h = new Process();
        private void button1_Click(object sender, EventArgs e)
        {
            h.StartInfo.FileName = "cmd";
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
            h.StandardInput.WriteLine("shutdown -s -t 0");
            h.StandardInput.WriteLine("exit");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sb = numericUpDown1.Value.ToString();
            int sss = int.Parse(sb) * 60;
            sb = sss.ToString();
            h.StartInfo.FileName = "cmd";
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
            h.StandardInput.WriteLine("shutdown -s -t" + " " + sb);
            h.StandardInput.WriteLine("exit");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sb = " ";
            h.StartInfo.FileName = "cmd";
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
            h.StandardInput.WriteLine("ipconfig&exit");
            h.StandardInput.AutoFlush = true;
            sb = h.StandardOutput.ReadToEnd();
            richTextBox1.Text = sb;




        }

        private void button4_Click(object sender, EventArgs e)
        {
            h.StartInfo.FileName = "cmd";
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
            h.StandardInput.WriteLine("logoff&exit");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            h.StartInfo.FileName = "regedit";
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            h.StartInfo.FileName = "cmd";
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
            h.StandardInput.WriteLine("services.msc&exit");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            h.StartInfo.FileName = "cmd";
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
            h.StandardInput.WriteLine("start cmd & exit");
        }



        private void button9_Click(object sender, EventArgs e)
        {
            h.StartInfo.FileName = "cmd";
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
            h.StandardInput.WriteLine("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SecurityHealthService\" /v Start /d 3 /t REG_DWORD /f & exit");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            h.StartInfo.FileName = "UserAccountControlSettings.exe";
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            h.StartInfo.FileName = "cmd";
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
            h.StandardInput.WriteLine("shutdown /r /t 0  & exit");
        }

        private void button12_Click(object sender, EventArgs e)
        {

            h.StartInfo.FileName = "cmd";
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
            h.StandardInput.WriteLine("control.exe system & exit");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            h.StartInfo.FileName = "winver";
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
        }
        public string str;
        public string a;


        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("��ַ����Ϊ�գ�����");
            }
            else if(textBox2.Text == " ")
            {
                MessageBox.Show("��ַ����Ϊ�գ�����");
            }
            else
            {
                new ToastContentBuilder()
            .AddArgument("action", "viewConversation")
            .AddArgument("huang", 9813)
            .AddText("�������ڽ���")
            .AddText("���Եȣ�������ܿ��������ùرգ����ѵ�ʱ����ܻ��Ԥ���Գ��������ǽ��ᾡ����ɡ�")
            .Show(toast =>
            {
                toast.ExpirationTime = DateTime.Now.AddSeconds(2);
            });
                str = textBox2.Text;
                h.StartInfo.FileName = "cmd";
                Cnwd();
                h.StandardInput.WriteLine("ping " + str + "&exit");
                h.StandardInput.Close();
                a = h.StandardOutput.ReadToEnd();
                new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("huang", 9813)
                .AddText("�����Ѿ����")
                .AddText("������ȥ�����鿴�����")
                .Show();
                richTextBox1.Text = a;
            }
            



        }

        private void button15_Click(object sender, EventArgs e)
        {
            h.StartInfo.FileName = "cmd";
            Cnwd();
            h.StandardInput.WriteLine("shutdown -a &exit");
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            h.StartInfo.FileName = "cmd";
            Cnwd();
            h.StandardInput.WriteLine("slui 4 &exit");
        }
    }
}
