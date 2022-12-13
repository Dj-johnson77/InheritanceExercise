using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() { }
        public bool hasScales { get; set; }
        public bool isColdBlooded { get; set; }
        public bool dinosaurLike { get; set; }
        public bool hasTail { get; set; }

    }
}
