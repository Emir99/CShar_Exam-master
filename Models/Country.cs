using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Can't be Blank!")]
        [MaxLength(50, ErrorMessage = "Can't be longer than 50!")]
        public string Name { get; set; }

        [Display(Name = "Info Hotline")]
        [Phone(ErrorMessage = "It must be a phone number")]
        public string info_hotline { get; set; }

        [Required(ErrorMessage = "Can't be Blank!")]
        [Display(Name = "World Category")]
        public Category1 world_category { get; set; }

        [RangeUntilCurrentYear(1900, ErrorMessage = "Please enter a valid year")]
        public int year_formed { get; set; }

        public ICollection<City> Cities { get; set; }

        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
        public class RangeUntilCurrentYearAttribute : RangeAttribute
        {
            public RangeUntilCurrentYearAttribute(int minimum) : base(minimum, DateTime.Now.Year) { }
        }
    }
}
