using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    class Coin : ICoin
    {
        public decimal Amount { get; private set; }

        public decimal Volume { get; private set; }

        public Coin(decimal amount, decimal volume)
        {
            Amount = amount;
            Volume = volume;
        }
    }
}
