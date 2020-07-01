using mshtml;
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



                        IHTMLFramesCollection2 frames = htmlDoc.frames;
                        int len = frames.length;
                        int i = 0;
                        IHTMLWindow2 mainFrame = null;
                        IHTMLWindow2 windowFrame = null;

                        for (;i< len;i++) {
                            IHTMLWindow2 frame2 = frames.item(i) as IHTMLWindow2;
                            //if ("mainFrame".Equals(frame2.name)) {
                            //    htmlContent= frame2.document.body.innerHTML.ToString();
                            //}

                            if (frame2.name!=null && frame2.name.Contains("window"))
                            {
                                htmlContent = frame2.document.body.innerHTML.ToString();
                                windowFrame = frame2;
                                //HTMLIFrame fe = (HTMLIFrame)frames.item(i).document;
                                //fe.contentWindow.execScript("doShut()", "javascript");
                                //触发点击事件
                                //mshtml.IHTMLWindow2 win = (mshtml.IHTMLWindow2)htmlDoc.parentWindow;
                                //frame2.execScript(";", "javascript");//使用JS
                            }

                            if (frame2.name != null && frame2.name.Contains("mainFrame"))
                            {
                                htmlContent = frame2.document.body.innerHTML.ToString();
                                mainFrame = frame2;
                            }
                        }
                        mainFrame.execScript("showRHBillDetailForAuth('3785441458','1','15000096057223')");
                        //windowFrame.execScript("doShut()");
                        //string aa = htmlDoc != null ? htmlDoc.body.outerHTML.ToString() : "***Failed***";
                        //htmlContent = aa;

                        //string aa = htmlDoc.body.innerHTML.ToString();
                        //htmlContent = aa;

                        //触发点击事件
                        //mshtml.IHTMLWindow2 win = (mshtml.IHTMLWindow2)htmlDoc.parentWindow;
                        //win.execScript("doSubmit()", "javascript");//使用JS
                    }
                }
            }
            this.groupBox2.Text = urls;
            this.richTextBox1.Text = htmlContent;
            this.textBox1.Text = num.ToString();

            //Form2 form2 = new Form2();
            //form2.Show();
            ////this.Close();
            //this.Hide();



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
