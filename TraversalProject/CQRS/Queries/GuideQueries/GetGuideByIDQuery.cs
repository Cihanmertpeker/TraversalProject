using MediatR;
using TraversalProject.CQRS.Results.GuideResults;

namespace TraversalProject.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery:IRequest<GetGuideByIDQueryResult>
    {
        public int Id { get; set; }

        public GetGuideByIDQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
