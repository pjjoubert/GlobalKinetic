using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    class Nickel : ICoin
    {
        public decimal Amount => 0.05M;

        public decimal Volume => 0.0232948184M;
    }
}
