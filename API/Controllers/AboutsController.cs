using Domain.Entities;
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
        private readonly DataContext _context;

        public AboutsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<About>>>GetAbouts()
        {
            return await _context.Abouts.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<About>> GetAbout(Guid Id)
        {
            return await _context.Abouts.FindAsync(Id);
        }
    }
}
