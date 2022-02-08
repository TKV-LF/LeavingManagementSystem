using Entity.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class Repository<T>
    {
        public readonly RequestContext _context;
        protected readonly ILogger<T> _logger;
        public Repository(RequestContext context, ILogger<T> logger)
        {
            _context = context;
            _logger = logger;
        }

        protected int Code500
        {
            get
            {
                return StatusCodes.Status500InternalServerError;
            }
        }
        protected int Code200
        {
            get
            {
                return StatusCodes.Status200OK;
            }
        }
        protected int Code404
        {
            get
            {
                return StatusCodes.Status404NotFound;
            }
        }
    }
}
