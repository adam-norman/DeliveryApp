using Microsoft.EntityFrameworkCore;
using Nav.Core.Entities;
using Nav.Core.Entities.Repositories;
using Nav.Infrastructure.Data;
using Ordering.Infrastructure.Repositories.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Repositories
{
    public class StoreRepository : Repository<Store>, IStoreRepository
    {
        private readonly StoresDBContext _dbContext;

        public StoreRepository(StoresDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Store> GetItemsListByStoreId(int storeId)
        {
            return await _dbContext.Stores.Include(store => store.StoreDetails).FirstOrDefaultAsync(store => store.Id == storeId);
        }

        public async Task<IEnumerable<Store>> GetStoresByUserLocation(Location  location)
        {
           // var createdPath =  .Paths.FromSqlRaw("AddNodeWithPathProc  {0}, {1}", nodeTitle, parentPathString).ToList();

            return await _dbContext.Stores.FromSqlRaw("exec GetStoreListByUserGeoLocation    {0}, {1}", location.Lat,location.Lng).ToListAsync();
        }
    }
}
