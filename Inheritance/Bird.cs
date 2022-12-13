using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() { }
        public int wings { get; set; }
        public void chirp()
        {
            Console.WriteLine("insert nice sound here");
        }
        public bool canFly { get; set; }

        public bool hasBeak { get; set; }
        

        

    }
}
