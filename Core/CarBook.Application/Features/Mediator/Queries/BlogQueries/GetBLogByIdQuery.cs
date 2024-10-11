using CarBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBLogByIdQuery:IRequest<GetBlogByIdQueryResult,>
    {
        public int Id { get; set; }

        public GetBLogByIdQuery(int id)
        {
            Id = id;
        }
    }
}
