using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace SpoonsWorld.Models
{
    public class SpoonMaterialViewModel
    {
        public List<Spoon> Spoon { get; set; }
        public SelectList Meterial { get; set; }
        public string SpoonMaterial { get; set; }
        public string SearchString { get; set; }

    }
}
