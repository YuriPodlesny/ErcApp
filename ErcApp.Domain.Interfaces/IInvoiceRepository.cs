using ErcApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErcApp.Domain.Interfaces
{
    public interface IInvoiceRepository : IBaseRepository<Invoice>
    {
        public decimal GetInvoiceColdWater(int peopleCount, decimal coldWater);
        decimal GetInvoiceElectricity(int peopleCount, decimal electricity, decimal electricityDay, decimal electricityNaght);
        decimal GetInvoiceHotWater(int peopleCount, decimal hotWater);
        decimal GetInvoiceHeatWater(int peopleCount, decimal hotWater);
    }
}
