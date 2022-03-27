using Nav.Core.Entities;
using System.Collections.Generic;

namespace Nav.Application.Responses
{
    public class StoreDTOResponse
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Slug { get; set; }
        public string Cuisines { get; set; }
        public string StartWorkAt { get; set; }
        public string EndWorkAt { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public List<StoreDetailDTO>  StoreDetails { get; set; }
    }
}
