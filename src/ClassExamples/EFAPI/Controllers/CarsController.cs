using EFAPI.BindingModel;
using EFAPI.Data;
using EFAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ApplicationDbContext DbContext;
        public CarsController(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetAllCars()
        {
            var cars = DbContext.Cars.ToList();
            return cars;
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetCarByID(int id)
        {
            var carToFind = DbContext.Cars.FirstOrDefault(c => c.ID == id);
            if (carToFind != null)
                return carToFind;
            else
                return NotFound("Sorry, we could not find a car");
        }

        [HttpPost("add")]
        public ActionResult<Car> AddCar([FromBody] AddCarBindingModel addCarBinding)
        {
            var carAdded = DbContext.Cars.Add(new Car
            {
                Make = addCarBinding.Make,
                Model = addCarBinding.Model,
                Year = addCarBinding.Year,
                DateAdded = DateTime.Now
            }).Entity;
            DbContext.SaveChanges();
            return carAdded;
        }

        [HttpPut("update/{id}")]
        public ActionResult<Car> UpdateCar(int id, [FromBody] UpdateCarBindingModel updateCarBinding)
        {
            var carToUpdate = DbContext.Cars.FirstOrDefault(c => c.ID == id);
            if (carToUpdate != null)
            {
                carToUpdate.Make = updateCarBinding.Make;
                carToUpdate.Model = updateCarBinding.Model;
                carToUpdate.Year = updateCarBinding.Year;
                DbContext.SaveChanges();
                return carToUpdate;
            }
            else
            {
                return NotFound("Sorry, we could not find a car");
            }
        }
        [HttpDelete("delete/{id}")]
        public ActionResult<Car> DeleteCar(int id)
        {
            var carToDelete = DbContext.Cars.FirstOrDefault(c => c.ID == id);
            if (carToDelete != null)
            {
                DbContext.Cars.Remove(carToDelete);
                DbContext.SaveChanges();
                return Ok($"{carToDelete.Make} {carToDelete.Model} with ID - {carToDelete.ID} has been deleted.");
            }
            else
                return NotFound("Sorry, we could not find a car");
        }

    }
}