using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreTutAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreTutAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        List<MedicineModel> medicines = new List<MedicineModel>();

        public ValuesController()
        {
            this.medicines.Add(new MedicineModel("1", "Test Medicine 1", "Test Manufacturer 1", 100.00, new DateTime(2017, 10, 12)));
            this.medicines.Add(new MedicineModel("2", "Test Medicine 2", "Test Manufacturer 2", 200.00, new DateTime(2017, 10, 14)));
            this.medicines.Add(new MedicineModel("3", "Test Medicine 3", "Test Manufacturer 3", 300.00, new DateTime(2017, 10, 15)));
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<MedicineModel>> Get()
        {
            return medicines;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<MedicineModel> Get(int id)
        {
            MedicineModel medicine = this.medicines.SingleOrDefault(x => x.Id == id.ToString());

            return medicine;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<List<MedicineModel>> Post([FromBody] MedicineModel value)
        {
            this.medicines.Add(new MedicineModel(value.Id, value.Name, value.Manufacturer, value.Pricing, value.Expiry));

            return medicines;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<MedicineModel> Put(int id, [FromBody] MedicineModel value)
        {
            MedicineModel medicine = this.medicines.SingleOrDefault(x => x.Id == id.ToString());

            medicine.Id = value.Id;
            medicine.Name = value.Name;
            medicine.Manufacturer = value.Manufacturer;
            medicine.Pricing = value.Pricing;
            medicine.Expiry = value.Expiry;

            this.medicines.Add(new MedicineModel(medicine.Id, medicine.Name, medicine.Manufacturer, medicine.Pricing, medicine.Expiry));

            return value;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<List<MedicineModel>> Delete(int id)
        {
            MedicineModel medicine = this.medicines.SingleOrDefault(x => x.Id == id.ToString());
            this.medicines.Remove(medicine);

            return this.medicines;
        }
    }
}
