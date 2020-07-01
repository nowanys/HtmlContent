using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    interface GetBankContent
    {

        /**
         * 获取票据列表信息
         */
        List<BillSimple> listBillSimple(String htmlBody);


        /**
         * 获取票据正反面信息
         */
        BillInfo getBillInfo(String htmlBody);

    }
}
