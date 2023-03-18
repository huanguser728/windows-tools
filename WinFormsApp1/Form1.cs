using System;
using System.IO;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;

using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.ComponentModel;

namespace WinFormsApp1
{


    public partial class Form1 : Form
    {

        public void Cywd()
        {
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
        }
        public void Cnwd()
        {
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
        }
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

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
            MessageBox.Show(sb);




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

        private void button8_Click(object sender, EventArgs e)
        {
            string into = "cmd";
            string ss = " ";
            h.StartInfo.FileName = "cmd";
            h.StartInfo.RedirectStandardOutput = true;
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardInput = true;
            h.StartInfo.CreateNoWindow = true;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
            into = textBox1.Text;
            h.StandardInput.WriteLine(into + "&exit");
            ss = h.StandardOutput.ReadToEnd();
            MessageBox.Show(ss);
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
            h.StandardInput.WriteLine("inetcpl.cpl & exit");
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
        private void InitializeBackGroundWorker()
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            string str = textBox2.Text;
            h.StartInfo.FileName = "cmd";
            Cnwd();
            h.StandardInput.WriteLine("ping " + str + "&exit");
            string a = h.StandardOutput.ReadToEnd();
            MessageBox.Show(a);
            backgroundWorker1.CancelAsync();


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true){
                label5.Text = "«Î…‘∫Û.";
                label5.Text = "«Î…‘∫Û..";
                label5.Text = "«Î…‘∫Û...";
                label5.Text = "«Î…‘∫Û....";
            }
        }


    }
}