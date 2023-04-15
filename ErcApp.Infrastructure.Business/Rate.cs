using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErcApp.Infrastructure.Business
{
    public class Rate
    {
        private decimal xBCT = 35.78m;
        private decimal xBCH = 4.85m;
        private decimal eET = 4.28m;
        private decimal eEH = 164m;
        private decimal eEDay = 4.9m;
        private decimal eENight = 2.31m;
        private decimal gVST = 35.78m;
        private decimal gVSH = 4.01m;
        private decimal gVSET = 998.69m;
        private decimal gVSEH = 0.05349m;

        public decimal XBCT { get => xBCT; set => xBCT = value; }
        public decimal XBCH { get => xBCH; set => xBCH = value; }
        public decimal EET { get => eET; set => eET = value; }
        public decimal EEH { get => eEH; set => eEH = value; }
        public decimal EEDay { get => eEDay; set => eEDay = value; }
        public decimal EENight { get => eENight; set => eENight = value; }
        public decimal GVST { get => gVST; set => gVST = value; }
        public decimal GVSH { get => gVSH; set => gVSH = value; }
        public decimal GVSET { get => gVSET; set => gVSET = value; }
        public decimal GVSEH { get => gVSEH; set => gVSEH = value; }
    }
}
