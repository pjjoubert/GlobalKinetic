using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    class Quarter : ICoin
    {
        public decimal Amount => 0.25M;

        public decimal Volume => 0.0273464146M;
    }
}
