using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SpoonsWorld.Models
{
    public class Spoon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Brand { get; set; }
        public decimal weight { get; set; }
        public int NumberOfPieces { get; set; }
        public decimal Price { get; set; }
    }
}
