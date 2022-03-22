using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilzenConsolePlayground.Types.Interfaces
{
    class Fall : ISeasons
    {
        public void FallIsHere()
        {
            Console.WriteLine("Leaves are orange and red.");
        }
    }
}
