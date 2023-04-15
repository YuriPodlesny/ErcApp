using System.ComponentModel.DataAnnotations;

namespace ErcApp.ViewModels
{
    public class IndexViewModel
    {
        [Required]
        public int PeopleCount { get; set; }

        [Display(Name = "Холодная вода")]
        public decimal ColdWater { get; set; }

        [Display(Name = "Горячая вода")]
        public decimal HotWater { get; set; }

        [Display(Name = "Электричество")]
        public decimal Electricity { get; set; }

        [Display(Name = "Электричество день")]
        public decimal ElectricityDay { get; set; }

        [Display(Name = "Электричество ночь")]
        public decimal ElectricityNaght { get; set; }
    }
}
