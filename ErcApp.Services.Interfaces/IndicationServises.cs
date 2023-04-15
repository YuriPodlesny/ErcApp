using ErcApp.Domain.Core;
using ErcApp.Domain.Interfaces;
using ErcApp.Infrastructure.Data;
using ErcApp.Infrastructure.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErcApp.Services
{
    public class IndicationServises : BaseServices<Indication>, IIndicationRepository
    {
        public IndicationServises(ErcAppDbContext context) : base(context)
        {
        }
    }
}
