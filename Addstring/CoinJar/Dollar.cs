using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    class Dollar : ICoin
    {
        public decimal Amount => 1.0M;

        public decimal Volume => 0.09946191894M;
    }
}
