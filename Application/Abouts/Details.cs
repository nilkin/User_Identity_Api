using Domain.Entities;
using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Abouts
{
    public class Details
    {
        public class Query : IRequest<About>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, About>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<About> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Abouts.FindAsync(request.Id);
            }
        }
    }
}
