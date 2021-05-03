﻿using Domain.Entities;
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

                public Handler(DataContext context)
                {
                    _context = context;
                }

                public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
                {
                    await _context.SaveChangesAsync();
                    return Unit.Value;
                }
            }
        }
    }
}
