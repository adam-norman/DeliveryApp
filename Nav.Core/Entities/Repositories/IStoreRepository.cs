using Nav.Core.Entities.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nav.Core.Entities.Repositories
{
   public interface IStoreRepository: IRepository<Store>
    {
        Task<IEnumerable<Store>> GetStoresByUserLocation(Location  location);
    }
}
