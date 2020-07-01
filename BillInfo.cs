using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{

    /**
     * 票据列表对象
     */
    class BillInfo
    {
        /**
         * 票号
         */
        private string billNo;

        /**
         * 票据类型
         */
        private string billType;

        /**
         * 出票日
         */
        private string sueDt;

        /**
         * 到期日
         */
        private string dueDt;

        /**
         * 票面金额
         */
        private string billMoney;

        /**
         * 出票人
         */
        private string remitter;

        /**
         * 承兑人
         */
        private string acceptor;

        /**
         * 背面列表
         */
        private List<BillBack> billBacks;

        public string BillNo { get => billNo; set => billNo = value; }
        public string BillType { get => billType; set => billType = value; }
        public string SueDt { get => sueDt; set => sueDt = value; }
        public string DueDt { get => dueDt; set => dueDt = value; }
        public string BillMoney { get => billMoney; set => billMoney = value; }
        public string Remitter { get => remitter; set => remitter = value; }
        public string Acceptor { get => acceptor; set => acceptor = value; }

    }
}
