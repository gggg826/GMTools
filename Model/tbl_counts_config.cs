using System;
using System.Collections.Generic;
using System.Text;

namespace FengNiao.GMTools.Database.Model
{
    public partial class tbl_counts_config
    {
        public tbl_counts_config(){}

        private int _record_id;

        public int record_id
        {
            get { return _record_id; }
            set { _record_id = value; }
        }

        private int _item_id;

        public int item_id
        {
            get { return _item_id; }
            set { _item_id = value; }
        }

        private int _count;

        public int count
        {
            get { return _count; }
            set { _count = value; }
        }

        private string _dec;

        public string dec
        {
            get { return _dec; }
            set { _dec = value; }
        }

        private int _kindofrewards;

        public int kindofrewards
        {
            get { return _kindofrewards; }
            set { _kindofrewards = value; }
        }

        private int _reward1;

        public int reward1
        {
            get { return _reward1; }
            set { _reward1 = value; }
        }

        private int _count1;

        public int count1
        {
            get { return _count1; }
            set { _count1 = value; }
        }

        private int _reward2;

        public int reward2
        {
            get { return _reward2; }
            set { _reward2 = value; }
        }

        private int _count2;

        public int count2
        {
            get { return _count2; }
            set { _count2 = value; }
        }

        private int _reward3;

        public int reward3
        {
            get { return _reward3; }
            set { _reward3 = value; }
        }

        private int _count3;

        public int count3
        {
            get { return _count3; }
            set { _count3 = value; }
        }

        private int _reward4;

        public int reward4
        {
            get { return _reward4; }
            set { _reward4 = value; }
        }

        private int _count4;

        public int count4
        {
            get { return _count4; }
            set { _count4 = value; }
        }

        private int _serverID;

        public int serverID
        {
            get { return _serverID; }
            set { _serverID = value; }
        }
    }
}
