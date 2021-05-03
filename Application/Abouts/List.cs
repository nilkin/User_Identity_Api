using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Abouts
{
    public class List
    {
        public class Query : IRequest<List<About>> { }
        public class Handler : IRequestHandler<Query, List<About>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<About>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Abouts.ToListAsync();
            }
        }
    }
}
