using MediatR;
using Nav.Application.Responses;
using System.Collections.Generic;

namespace Nav.Application.Queries
{
    public class GetItemsListByStoreIdQuery : IRequest<StoreDTOResponse>
    {
        public int storeId;
        public GetItemsListByStoreIdQuery(int storeId)
        {
            this.storeId = storeId;
        }
    }
}
