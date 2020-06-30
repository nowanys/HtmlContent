using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SHDocVw.ShellWindows shellWindows = new SHDocVw.ShellWindowsClass();
            int a = shellWindows.Count;
            string urls = "";
            string htmlContent = "";
            string textBox2 = this.textBox2.Text;
            if (a==0) {
                this.groupBox2.Text = "请确认已打开浏览器窗口";
            }
            int num = 0;
            foreach (SHDocVw.InternetExplorer ie in shellWindows)
            {
                //filename = Path.GetFileNameWithoutExtension(ie.FullName).ToLower();
                string url = ie.LocationURL;
                if (url.Contains("http")) {
                    num++;
                    urls = urls + url + "\n";
                    if (num == int.Parse(textBox2)) {
                        mshtml.IHTMLDocument2 htmlDoc = (mshtml.IHTMLDocument2)ie.Document;
                        string aa = htmlDoc != null ? htmlDoc.body.outerHTML.ToString() : "***Failed***";
                        htmlContent = aa;
                    }
                }
            }
            this.groupBox2.Text = urls;
            this.richTextBox1.Text = htmlContent;
            this.textBox1.Text = num.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
