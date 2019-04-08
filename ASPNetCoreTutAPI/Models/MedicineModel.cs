using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreTutAPI.Models
{
    public class MedicineModel
    {
        public MedicineModel(string id, string name, string manufacturer, double pricing, DateTime expiry)
        {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Pricing = pricing;
            Expiry = expiry;
        }

        [Required]
        public String Id { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "Name of medicine must be 10 to 150 characters long")]
        public String Name { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "Name of medicine must be 10 to 150 characters long")]
        public String Manufacturer { get; set; }

        [Required]
        public Double Pricing { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Expiry { get; set; }

    }
}
