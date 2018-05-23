using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    class Half : ICoin
    {
        public decimal Amount => 0.5M;

        public decimal Volume => 0.05348938809M;
    }
}
