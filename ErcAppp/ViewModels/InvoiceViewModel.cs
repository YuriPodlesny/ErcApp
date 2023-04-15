using System.ComponentModel.DataAnnotations;

namespace ErcApp.ViewModels
{
    public class InvoiceViewModel
    {
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal XBCAmount { get; set; }
        public decimal GBCTHAmount { get; set; }
        public decimal GBCTEAmount { get; set; }
        public decimal EEAmount { get; set; }
        public decimal Sum { get; set; }
    }
}
