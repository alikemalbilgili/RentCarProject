﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _colorService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]

        public IActionResult Add(Color color)
        {
            var result = _colorService.Add(color);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpDelete("delete")]

        public IActionResult Delete(Color color)
        {
            var result = _colorService.Delete(color);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Color color)
        {
            var result = _colorService.Update(color);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}