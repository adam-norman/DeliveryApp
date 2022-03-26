using System;
using System.Collections.Generic;
using System.Text;

namespace Nav.Application.Responses
{
   public class StoreResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Slug { get; set; }
        public string Cuisines { get; set; }
        public string StartWorkAt { get; set; }
        public string EndWorkAt { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
    }
}
