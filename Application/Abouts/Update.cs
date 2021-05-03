using AutoMapper;
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
    public class Update
    {
        public class Command : IRequest
        {
            public About About { get; set; }
            public class Handler : IRequestHandler<Command>
            {
                private readonly DataContext _context;
                private readonly IMapper _mapper;

                public Handler(DataContext context,IMapper mapper)
                {
                    _context = context;
                    _mapper = mapper;
                }

                public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
                {
                    var about = await _context.Abouts.FindAsync(request.About.Id);
                    _mapper.Map(request.About,about);
                    await _context.SaveChangesAsync();
                    return Unit.Value;
                }
            }
        }
    }
}
