using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }

        [HttpPost("addcar")]
        public IActionResult AddCar(Car car)
        {
            var result = _carService.Add(car);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }
        [HttpPut("updatecar")]
        public IActionResult UpdateCar(Car car)
        {
            var result = _carService.Update(car);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }

        [HttpPost("deletecar")]
        public IActionResult DeleteCar(Car car)
        {
            var result = _carService.Delete(car);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }

        [HttpGet("getcardetail")]
        public IActionResult getCarDetail()
        {
            var result = _carService.GetCarDetails();
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }

        [HttpGet("getcardetailsbycar")]
        public IActionResult GetCarDetails(int carId)
        {
            var result = _carService.GetCarDetailsByCar(carId);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }

        [HttpGet("getcardetailsbybrand")]
        public IActionResult GetCarDetailsByBrandId(int brandId)
        {
            var result = _carService.GetCarDetailsByBrand(brandId);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }

        [HttpGet("getcarbyid")]
        public IActionResult GetCarById(int carId)
        {
            var result = _carService.GetById(carId);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }
    }
}
