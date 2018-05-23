using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    interface ICoinValidator
    {
        Boolean IsValidCoin(ICoin coin);
    }
}
