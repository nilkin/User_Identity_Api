using Application.Abouts;
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
        private readonly IMediator _mediator;

        public AboutsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<About>>>GetAbouts()
        {
            return await _mediator.Send(new List.Query());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<About>> GetAbout(Guid Id)
        {
            return Ok();
        }
    }
}
