using MediatR;
using Nav.Application.Mappers;
using Nav.Application.Queries;
using Nav.Application.Responses;
using Nav.Core.Entities.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Nav.Application.Handlers
{
    public  class GetStoresListByUserLocationHandler : IRequestHandler<GetStoresListByUserLocationQuery, IEnumerable<StoreResponse>>
    {
        private readonly IStoreRepository _storeRepository;

        public GetStoresListByUserLocationHandler(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        public async Task<IEnumerable<StoreResponse>> Handle(GetStoresListByUserLocationQuery request, CancellationToken cancellationToken)
        {
         var storesList=    await _storeRepository.GetStoresByUserLocation(request.location);
            return StoreMapper.Mapper.Map<IEnumerable<StoreResponse>>(storesList);
        }
    }
}
