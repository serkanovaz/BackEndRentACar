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
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }

        [HttpPost("addcustomer")]
        public IActionResult AddCustomer(Customer customer)
        {
            var result = _customerService.Add(customer);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }
        [HttpPut("updatecustomer")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            var result = _customerService.Update(customer);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }

        [HttpPost("deletecustomer")]
        public IActionResult DeleteCustomer(Customer customer)
        {
            var result = _customerService.Delete(customer);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }

        [HttpGet("getcustomerdetailbyid")]
        public IActionResult GetCustomerDetailById(int customerId)
        {
            var result = _customerService.getCustomerDetailById(customerId);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }

        [HttpGet("getcustomerbyemail")]
        public IActionResult GetCustomerByEmail(string email)
        {
            var result = _customerService.getCustomerByEmail(email);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result);
        }
    }
}