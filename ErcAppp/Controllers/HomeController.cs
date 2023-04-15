using ErcApp.Domain.Core;
using ErcApp.Domain.Interfaces;
using ErcApp.Models;
using ErcApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ErcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInvoiceRepository _invoice;
        private readonly IIndicationRepository _indication;

        public HomeController(IInvoiceRepository invoice, IIndicationRepository indication)
        {
            _invoice = invoice;
            _indication = indication;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateIndication(IndexViewModel model)
        {
            var old = _indication.GetAll().OrderByDescending(x => x.Id).FirstOrDefault();
            var indication = new Indication
            {
                ColdWater = model.ColdWater,
                Electricity = model.Electricity,
                ElectricityDay = model.ElectricityDay,
                ElectricityNaght = model.ElectricityNaght,
                HotWater = model.HotWater,
                PeopleCount = model.PeopleCount,
            };
            var resultIndication = await _indication.Create(indication);

            if (old != null)
            {
                await CreatInvoice(model, old.ColdWater, old.Electricity, old.ElectricityDay, old.ElectricityNaght, old.HotWater);
            }
            else await CreatInvoice(model, 0, 0, 0, 0, 0);

            if (resultIndication == true)
            {
                return RedirectToAction(nameof(Indication));
            }
            return View(model);
        }

        private async Task<bool> CreatInvoice(IndexViewModel model, decimal oldColWater, decimal oldElectricity, decimal oldElectricityDay, decimal oldElectricityNaght, decimal oldHotWater)
        {
            var invoice = new Invoice
            {
                XBCAmount = _invoice.GetInvoiceColdWater(model.PeopleCount, model.ColdWater - oldColWater),
                EEAmount = _invoice.GetInvoiceElectricity(
                        model.PeopleCount,
                        model.Electricity - oldElectricity,
                        model.ElectricityDay - oldElectricityDay,
                        model.ElectricityNaght - oldElectricityNaght),
                GBCTHAmount = _invoice.GetInvoiceHotWater(model.PeopleCount, model.HotWater - oldHotWater),
                GBCTEAmount = _invoice.GetInvoiceHeatWater(model.PeopleCount, model.HotWater - oldHotWater)
            };
            return await _invoice.Create(invoice);
        }


        public IActionResult Invoice()
        {
            var result = _invoice.GetAll();
            return View(result);
        }

        public IActionResult Indication()
        {
            var result = _indication.GetAll();
            return View(result);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}