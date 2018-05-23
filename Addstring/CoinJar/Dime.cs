using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    class Dime : ICoin
    {
        public decimal Amount => 0.1M;

        public decimal Volume => 0.0114964296M;
    }
}
