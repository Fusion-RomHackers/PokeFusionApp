using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeFusionApp
{
    public class PokeData
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PokeDataRoot
    {
        public PokeData[] pokemon { get; set; }
    }

}
