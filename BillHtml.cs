using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 * 票据类型及html
 */
namespace WindowsFormsApp1
{
    class BillHtml
    {

        /**
         * 对应银行类型
         */
        private GetBankContent getBankContent;

        /**
         * html内容
         */
        private string htmlBody;

        public string HtmlBody { get => htmlBody; set => htmlBody = value; }
        internal GetBankContent GetBankContent { get => getBankContent; set => getBankContent = value; }
    }
}
