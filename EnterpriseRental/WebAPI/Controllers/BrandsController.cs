﻿using System;
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
    public class BrandsController : ControllerBase
    {
        private IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("getallbrand")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }

        [HttpPost("addbrand")]
        public IActionResult AddBrand(Brand brand)
        {
            var result = _brandService.Add(brand);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }
        [HttpPut("updatebrand")]
        public IActionResult UpdateBrand(Brand brand)
        {
            var result = _brandService.Update(brand);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }

        [HttpPost("deletebrand")]
        public IActionResult DeleteBrand(Brand brand)
        {
            var result = _brandService.Delete(brand);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }

        [HttpGet("getbrandbyid")]
        public IActionResult GetBrandById(int brandId)
        {
            var result = _brandService.GetById(brandId);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }
    }
}
