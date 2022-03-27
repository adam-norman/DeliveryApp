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
    public class GetItemsListByStoreIdHandler : IRequestHandler<GetItemsListByStoreIdQuery, StoreDTOResponse>
    {
        private readonly IStoreRepository _storeRepository;

        public GetItemsListByStoreIdHandler(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        public async Task<StoreDTOResponse> Handle(GetItemsListByStoreIdQuery request, CancellationToken cancellationToken)
        {
            var storesList = await _storeRepository.GetItemsListByStoreId(request.storeId);
            return StoreMapper.Mapper.Map<StoreDTOResponse>(storesList);
        }
    }
}
