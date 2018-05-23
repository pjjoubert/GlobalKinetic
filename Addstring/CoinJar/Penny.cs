using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    public class Penny : ICoin
    {
        public decimal Amount => 0.01M;

        public decimal Volume => 0.0149386971M;
    }
}
