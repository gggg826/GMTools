using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengNiao.GMTools.Database.Model
{
    [Serializable]
    public class tbl_baidupush
    {
        public tbl_baidupush()
        { }

        #region     Model
        private int _record_id;
        private string _apiKey;
        private string _secretKey;
        private string _tile;
        private string _context;
        private DateTime? _startime;
        private DateTime? _stoptime;
        private DateTime? _pushtime;

        public int record_id
        {
            get
            {
                return _record_id;
            }

            set
            {
                _record_id = value;
            }
        }

        public string apiKey
        {
            get
            {
                return _apiKey;
            }

            set
            {
                _apiKey = value;
            }
        }

        public string secretKey
        {
            get
            {
                return _secretKey;
            }

            set
            {
                _secretKey = value;
            }
        }

        public string tile
        {
            get
            {
                return _tile;
            }

            set
            {
                _tile = value;
            }
        }

        public string context
        {
            get
            {
                return _context;
            }

            set
            {
                _context = value;
            }
        }

        public DateTime? startime
        {
            get
            {
                return _startime;
            }

            set
            {
                _startime = value;
            }
        }

        public DateTime? stoptime
        {
            get
            {
                return _stoptime;
            }

            set
            {
                _stoptime = value;
            }
        }

        public DateTime? pushtime
        {
            get
            {
                return _pushtime;
            }

            set
            {
                _pushtime = value;
            }
        }
        #endregion
    }
}
