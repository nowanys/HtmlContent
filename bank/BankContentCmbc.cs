using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 民生银行实现方式
 */
namespace WindowsFormsApp1.bank
{
    class BankContentCmbc : GetBankContent
    {
        BillInfo GetBankContent.getBillInfo(string htmlBody)
        {
            BillInfo billInfo = new BillInfo();
            if (htmlBody.Contains("票据号码："))
            {
                billInfo.BillNo = htmlBody.Substring(htmlBody.IndexOf("票据号码：")+5,34);
                billInfo.SueDt = htmlBody.Substring(htmlBody.IndexOf("出票日期：") + 5, 10);
                billInfo.DueDt = htmlBody.Substring(htmlBody.IndexOf("汇票到期日：")+6, 10);

                //int billMoney = htmlBody.IndexOf("<td width=\"43 % \" class=\"rightLine v - binding\" rowspan=\"2\">");
                //int billMoneyEnd = htmlBody.IndexOf("</td>", billMoney + 60, 20);
                //billInfo.BillMoney = htmlBody.Substring(billMoney + 60, billMoneyEnd-billMoney-60);

                //int acceptor = htmlBody.IndexOf("<td width=\"73 % \" class=\"bottomLine v - binding\">&nbsp;");
                //int acceptorEnd = htmlBody.IndexOf("</td>", acceptor + 55, 20);
                //billInfo.Acceptor = htmlBody.Substring(acceptor + 55, acceptorEnd - acceptor - 55);

                //int remitter = htmlBody.IndexOf("<td width=\"237\" class=\"v - binding\">");
                //int remitterEnd = htmlBody.IndexOf("</td>", remitter + 34, 40);
                //billInfo.Remitter = htmlBody.Substring(remitter + 34, remitterEnd - remitter - 34);
            }
            else 
            {
                return null;
            }







            return billInfo;
        }

        List<BillSimple> GetBankContent.listBillSimple(string htmlBody)
        {




            return null;
        }
    }
}
