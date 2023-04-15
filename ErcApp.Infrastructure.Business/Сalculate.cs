using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErcApp.Infrastructure.Business
{
    public static class Сalculate
    {

        // P = V * T
        public static decimal GeneralCalc(decimal indication, decimal rate)
        {
            return indication * rate;
        }

        public static decimal CalcDayAndNaght(decimal day, decimal naght, decimal rateDay, decimal rateNaght) 
        {
            return day * rateDay + naght * rateNaght;
        }

        //V = Mтек – Mпред
        public static decimal MeterReadingsCalc(decimal current, decimal previous)
        {
            return current - previous;
        }

        //V = n * N
        public static decimal StandardVolumeCalc(decimal people, decimal rate)
        {
            return people * rate;
        }

        //Vгвс тэ = Vгвс тн * Nгвс тэ
        public static decimal GVSCalc(decimal volume, decimal rate) 
        {
            return volume * rate;
        }
    }
}
