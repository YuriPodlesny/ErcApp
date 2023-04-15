using ErcApp.Domain.Core;
using ErcApp.Domain.Interfaces;
using ErcApp.Infrastructure.Business;
using ErcApp.Infrastructure.Data;
using ErcApp.Infrastructure.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErcApp.Services
{
    public class InvoiceServices : BaseServices<Invoice>, IInvoiceRepository
    {
        private readonly Rate _rate;
        private readonly ErcAppDbContext context;
        public InvoiceServices(ErcAppDbContext context) : base(context)
        {
            this.context = context;
            _rate = new Rate();
        }

        public decimal GetInvoiceColdWater(int peopleCount, decimal coldWater)
        {
            if (coldWater > 0)
            {
                return Сalculate.GeneralCalc(coldWater, _rate.XBCT);
            }
            else return Сalculate.GeneralCalc(_rate.XBCH, _rate.XBCT * peopleCount);
        }

        public decimal GetInvoiceElectricity(int peopleCount, decimal electricity, decimal electricityDay, decimal electricityNaght)
        {
            if (electricity > 0)
            {
                return Сalculate.GeneralCalc(electricity, _rate.EET);
            }
            else if (electricityDay > 0 && electricityNaght > 0)
            {
                return Сalculate.CalcDayAndNaght(electricityDay, electricityNaght, _rate.EEDay, _rate.EENight);
            }
            else return Сalculate.GeneralCalc(_rate.EEH, _rate.EET * peopleCount);
        }

        public decimal GetInvoiceHotWater(int peopleCount, decimal hotWater)
        {
            if (hotWater > 0)
            {
                return Сalculate.GeneralCalc(hotWater, _rate.GVST);
            }
            else return Сalculate.GeneralCalc(_rate.GVST, _rate.GVSH * peopleCount);
        }

        public decimal GetInvoiceHeatWater(int peopleCount, decimal hotWater)
        {
            if (hotWater > 0)
            {
                return Сalculate.GeneralCalc(hotWater, _rate.GVSET * _rate.GVSEH);
            }
            else return Сalculate.GeneralCalc(_rate.GVSET, _rate.GVSH * _rate.GVSEH * peopleCount);
        }
    }
}
