using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Randy : Player
    {
        Random r;

        public Randy(Random r) : base("Randy")
        {
            this.r = r;
        }

        
    }
}
