using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        //Loosely coupled
        //naming convention 
        //Ioc  Container -- Inversion of control
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;                       // Gelenin referansı _productService'e atanmış oldu.
        }

        [HttpGet("getall")]
       /* [Authorize(Roles = "car.list")]  */             // Nasıl girebilir = Product.List yetkisi
        public IActionResult GetAll()
        {
            //Dependency chain -- 

            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);      //Ok 200
            }
            return BadRequest(result);
        }

        [HttpGet("getallcardetails")]

        public IActionResult GetCarDetails()
        {
            //Dependency chain -- 

            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result);      //Ok 200
            }
            return BadRequest(result);
        }




        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbybrand")]
        public IActionResult GetByBrand(int brandId)
        {
            var result = _carService.GetAllByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcardetailsbybrand")]
        public IActionResult GetCarDetailsByBrandId(int brandId)
        {
            var result = _carService.GetCarDetailsByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("getcardetailsbycolor")]
        public IActionResult GetCarDetailsByColorId(int colorId)
        {
            var result = _carService.GetCarDetailsByColorId(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcardetailsbycarıd")] 
        public IActionResult GetCarDetailsByCarId(int carId)
        {
            var result = _carService.GetCarDetailsByCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]       // add - update - delete
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
