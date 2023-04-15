using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErcApp.Domain.Core
{
    public class Invoice : BaseEntity
    {
        public decimal XBCAmount { get; set; }
        public decimal GBCTHAmount { get; set; }
        public decimal GBCTEAmount { get; set; }
        public decimal EEAmount { get; set; }

        private decimal sum;
        public decimal Sum
        {
            get
            {
                sum = XBCAmount + GBCTHAmount + GBCTEAmount + EEAmount;
                return sum;
            }
            set
            {
                sum = value;
            }
        }
    }
}
