using Nav.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nav.Core.Entities
{
    public class Store:Entity
    {
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Logo { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Slug { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Cuisines { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string StartWorkAt { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string EndWorkAt { get; set; }
        [Column(TypeName = "decimal(8,6)")]
        public decimal Lat { get; set; }
        [Column(TypeName = "decimal(9,6)")]
        public decimal Lng { get; set; }
        public virtual ICollection<StoreDetail> StoreDetails { get; set; }
    }
}
