using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErcApp.Domain.Core
{
    public class Indication : BaseEntity
    {
        public int PeopleCount { get; set; }
        public decimal ColdWater { get; set; }
        public decimal HotWater { get; set; }
        public decimal Electricity { get; set; }
        public decimal ElectricityDay { get; set; }
        public decimal ElectricityNaght { get; set; }
    }
}
