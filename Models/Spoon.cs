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
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Material { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Brand { get; set; }
        [Range(1, 1000)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal weight { get; set; }
        [Range(1, 100)]
        public int NumberOfPieces { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        
        [Range(1,5)]
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rating { get; set; }
    }
}
