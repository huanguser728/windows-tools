﻿namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            button14 = new Button();
            button15 = new Button();
            menuStrip1 = new MenuStrip();
            ping历史ToolStripMenuItem = new ToolStripMenuItem();
            查询ToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 39);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "定时关机（分）";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(115, 39);
            numericUpDown1.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(108, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(6, 70);
            button1.Name = "button1";
            button1.Size = new Size(103, 37);
            button1.TabIndex = 3;
            button1.Text = "立刻关机";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(115, 70);
            button2.Name = "button2";
            button2.Size = new Size(108, 37);
            button2.TabIndex = 4;
            button2.Text = "定时关机";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(234, 31);
            button3.Name = "button3";
            button3.Size = new Size(101, 38);
            button3.TabIndex = 5;
            button3.Text = "ip设置";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(341, 31);
            button4.Name = "button4";
            button4.Size = new Size(101, 38);
            button4.TabIndex = 6;
            button4.Text = "注销";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(448, 31);
            button5.Name = "button5";
            button5.Size = new Size(101, 38);
            button5.TabIndex = 7;
            button5.Text = "打开注册表";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(555, 31);
            button6.Name = "button6";
            button6.Size = new Size(98, 38);
            button6.TabIndex = 8;
            button6.Text = "打开服务";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(659, 31);
            button7.Name = "button7";
            button7.Size = new Size(98, 38);
            button7.TabIndex = 9;
            button7.Text = "打开cmd";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 72);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 10;
            label3.Text = "运行命令";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 27);
            textBox1.TabIndex = 11;
            // 
            // button8
            // 
            button8.Location = new Point(555, 86);
            button8.Name = "button8";
            button8.Size = new Size(98, 38);
            button8.TabIndex = 12;
            button8.Text = "运行！";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(659, 86);
            button9.Name = "button9";
            button9.Size = new Size(98, 38);
            button9.TabIndex = 13;
            button9.Text = "关闭wdf";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(6, 151);
            button10.Name = "button10";
            button10.Size = new Size(103, 33);
            button10.TabIndex = 14;
            button10.Text = "更改uac";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(115, 151);
            button11.Name = "button11";
            button11.Size = new Size(108, 33);
            button11.TabIndex = 15;
            button11.Text = "Internet选项";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(234, 151);
            button12.Name = "button12";
            button12.Size = new Size(103, 33);
            button12.TabIndex = 16;
            button12.Text = "系统属性";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(341, 151);
            button13.Name = "button13";
            button13.Size = new Size(103, 33);
            button13.TabIndex = 17;
            button13.Text = "系统版本";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 128);
            label4.Name = "label4";
            label4.Size = new Size(268, 20);
            label4.TabIndex = 18;
            label4.Text = "ping测试（下方填网址，不要http！）";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(450, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 27);
            textBox2.TabIndex = 19;
            // 
            // button14
            // 
            button14.Location = new Point(659, 151);
            button14.Name = "button14";
            button14.Size = new Size(98, 38);
            button14.TabIndex = 20;
            button14.Text = "开始！";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(6, 113);
            button15.Name = "button15";
            button15.Size = new Size(217, 32);
            button15.TabIndex = 21;
            button15.Text = "取消定时关机";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ping历史ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(776, 28);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // ping历史ToolStripMenuItem
            // 
            ping历史ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 查询ToolStripMenuItem });
            ping历史ToolStripMenuItem.Name = "ping历史ToolStripMenuItem";
            ping历史ToolStripMenuItem.Size = new Size(86, 24);
            ping历史ToolStripMenuItem.Text = "ping历史";
            // 
            // 查询ToolStripMenuItem
            // 
            查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            查询ToolStripMenuItem.Size = new Size(224, 26);
            查询ToolStripMenuItem.Text = "查询";
            查询ToolStripMenuItem.Click += 查询ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 199);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "windows小工具";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label3;
        private TextBox textBox1;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Label label4;
        private TextBox textBox2;
        private Button button14;
        private Button button15;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ping历史ToolStripMenuItem;
        private ToolStripMenuItem 查询ToolStripMenuItem;
    }
}