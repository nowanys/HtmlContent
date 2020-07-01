using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    /**
     * 票据背面信息
     */
    class BillBack
    {
        /**
         * 背书类型	String(30)	Y	E 背书
         * F 买断式贴现
         * Q 保证
         * O 质押背书
         * P 解质押背书
         * H 回购式贴现赎回
         *  I 买断式转贴现
         * K 回购式转贴现赎回
         * X 央行卖票
         */
        private string endorseType;

        /**
         * 背书人名称	String(100)	Y
         */
        private string field1;

        /**
         * 被背书人名称	String(100)	Y
         */
        private string field2;

        /**
         * 不得转让标志、
         * （保证人地址——仅用于保证）、
         * （出质日期——仅用于质押）	String(50)	Y
         */
        private string field3;

        /**
         * 背书时间、
         * （解质押日期——仅用于质押）	String(30)	Y
         */
        private string field4;

        public string EndorseType { get => endorseType; set => endorseType = value; }
        public string Field1 { get => field1; set => field1 = value; }
        public string Field2 { get => field2; set => field2 = value; }
        public string Field3 { get => field3; set => field3 = value; }
        public string Field4 { get => field4; set => field4 = value; }
    }
}
