﻿using Application.Abouts;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class AboutsController :BaseApiController
    {


        [HttpGet]
        public async Task<ActionResult<List<About>>>GetAbouts()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<About>> GetAbout(Guid Id)
        {
            return Ok();
        }
    }
}
