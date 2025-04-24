using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildBlocks.CQRS
{
    public interface IQueryHandler<in TQeury, TResponse>
        :IRequestHandler<TQeury, TResponse>
        where TQeury : IQuery<TResponse>
        where TResponse : notnull
    {
    }
}
