using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApp1.bank;

/**
 * ie浏览器操作
 * 
 * 
 */
namespace WindowsFormsApp1
{
    class InternetExpHandle
    {
        /**
         * 批量识别
         */
        public BillHtml getBillListHtml() {

            BillHtml billHtml = new BillHtml();
            SHDocVw.ShellWindows shellWindows = new SHDocVw.ShellWindowsClass();
            foreach (SHDocVw.InternetExplorer ie in shellWindows)
            {
                string url = ie.LocationURL;
                if (url.Contains("https://ent.cmbc.com.cn:8443/eweb/static/main_new.html"))  //民生银行
                {
                    billHtml.GetBankContent = new BankContentCmbc();
                }

                if (billHtml.GetBankContent != null)
                {
                    mshtml.IHTMLDocument2 htmlDoc = (mshtml.IHTMLDocument2)ie.Document;
                    string aa = htmlDoc != null ? htmlDoc.body.outerHTML.ToString() : "***Failed***";
                    billHtml.HtmlBody = aa;
                    break;
                }
            }
            
            return billHtml;
        }

        /**
         * 单张票据识别
         */
        public BillHtml getBillInfoHtml() {
            BillHtml billHtml = new BillHtml();
            SHDocVw.ShellWindows shellWindows = new SHDocVw.ShellWindowsClass();
            foreach (SHDocVw.InternetExplorer ie in shellWindows)
            {
                string url = ie.LocationURL;
                if (url.Contains("https://ent.cmbc.com.cn:8443/eweb/static/commonPage/DraftDetail.html"))  //民生银行
                {
                    billHtml.GetBankContent = new BankContentCmbc();
                    
                }

                if (billHtml.GetBankContent != null)
                {
                    mshtml.IHTMLDocument2 htmlDoc = (mshtml.IHTMLDocument2)ie.Document;
                    string aa = htmlDoc != null ? htmlDoc.body.outerHTML.ToString() : "***Failed***";
                    billHtml.HtmlBody = aa;
                    break;
                }
            }

            return billHtml;
        }
    }
}
