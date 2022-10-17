using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpoonsWorld.Models
{
    public class Spoon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Brand { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal weight { get; set; }
        public int NumberOfPieces { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rating { get; set; }
    }
}
