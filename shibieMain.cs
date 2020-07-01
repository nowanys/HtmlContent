using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class shibieMain : Form
    {
        public shibieMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //识别单张票据
            InternetExpHandle internetExpHandle = new InternetExpHandle();
            BillHtml billHtml = internetExpHandle.getBillInfoHtml();
            if (billHtml.GetBankContent == null)
            {
                this.textBox1.Text = "未获取到票据信息";
                return;
            }


            BillInfo billInfo = billHtml.GetBankContent.getBillInfo(billHtml.HtmlBody);
            if (billInfo != null)
            {
                this.textBox1.Text = billInfo.BillNo;
                this.textBox3.Text = billInfo.DueDt;
                this.textBox4.Text = billInfo.BillMoney;
                this.textBox5.Text = billInfo.Acceptor;
                this.textBox6.Text = billInfo.Remitter;
                this.textBox7.Text = billInfo.SueDt;
            }
            else 
            {
                this.textBox1.Text = "未获取到票据信息";
            }


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //识别批量票据
            InternetExpHandle internetExpHandle = new InternetExpHandle();
            BillHtml billHtml = internetExpHandle.getBillListHtml();
            //List<BillSimple> billSimples = billHtml.GetBankContent.listBillSimple(billHtml.HtmlBody);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
