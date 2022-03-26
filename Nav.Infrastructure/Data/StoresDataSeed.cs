using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Nav.Core.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
 

namespace Nav.Infrastructure.Data
{
    public   class StoresDataSeed
    {
        public static async Task StoresSeedAsync(StoresDBContext storesDbContext, ILoggerFactory loggerFactory, int tries = 3)
        {
            int numberOfRetries = tries;
            try
            {
                storesDbContext.Database.Migrate();
                if (!storesDbContext.Stores.Any())
                {
                    storesDbContext.Stores.AddRange(GetListOfStores());
                    await storesDbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoresDataSeed>();
                logger.LogError(ex.Message);
                if (numberOfRetries < 3)
                {
                    numberOfRetries++;
                    await StoresSeedAsync(storesDbContext, loggerFactory, numberOfRetries);
                }
            }
        }

        private static List<Store> GetListOfStores()
        {
            string fileName = "dummydata.json";
            string jsonString = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<List<Store>>(jsonString);
        }
    }

}
