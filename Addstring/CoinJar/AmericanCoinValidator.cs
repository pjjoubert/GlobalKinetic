using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    class AmericanCoinValidator : ICoinValidator
    {
        public bool IsValidCoin(ICoin coin)
        {
            bool valid = false;

            switch(coin.Amount) //check that the coin amounts correspond to actual US currency
            {
                case 0.01M:
                    //if it does correspond to valid amounts, make sure that the volume is correct. Volumes calculated from specifications on https://en.m.wikipedia.org/wiki/Coins_of_the_United_States_dollar#Coins_in_circulation in cubic mm and converted to fluid ounces
                    if (coin.Volume == 0.0149386971M) //441.79mm^3
                    {
                        valid = true;
                    }                    
                    break;
                case 0.05M:
                    if (coin.Volume == 0.0232948184M) //688.91mm^3
                    {
                        valid = true;
                    }                    
                    break;
                case 0.1M:
                    if (coin.Volume == 0.0114964296M) //339.99mm^3
                    {
                        valid = true;
                    }                    
                    break;
                case 0.25M:
                    if (coin.Volume == 0.0273464146M) //808.73mm^3
                    {
                        valid = true;
                    }                    
                    break;
                case 0.5M:
                    if (coin.Volume == 0.05348938809M) //1581.87mm^3
                    {
                        valid = true;
                    }                    
                    break;
                case 1.0M:
                    if (coin.Volume == 0.09946191894M) //2941.44mm^3
                    {
                        valid = true;
                    }                    
                    break;
                default:
                    valid = false;
                    break;
            }

            return valid;
        }
    }
}
