using MediatR;
using Nav.Application.Responses;
using Nav.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nav.Application.Queries
{
    public class GetStoresListByUserLocationQuery:IRequest<IEnumerable<StoreResponse>>
    {
        public Location location;
        public GetStoresListByUserLocationQuery(Location location)
        {
            this.location = location;
        }
    }
}
