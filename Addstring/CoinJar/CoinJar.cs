using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    class CoinJar : ICoinJar
    {
        public decimal TotalAmount { get; private set; }
        private decimal TotalVolume;
        private HashSet<ICoin> _addedCoins = new HashSet<ICoin>(); //keeping a hashset of all the coins added to make sure that we do not add the same coin more than once
        private ICoinValidator _validator; 


        public CoinJar(ICoinValidator validator)
        {
            _validator = validator;
        }

        public void AddCoin(ICoin coin)
        {
            if (_validator.IsValidCoin(coin))
            {
                if (!_addedCoins.Contains(coin))
                {
                    if (TotalVolume + coin.Volume <= 42) //check that the current volume plus the coin volume is less than or equal to the volume of the jar. NB Very specific to this implementation
                    {
                        TotalAmount += coin.Amount;
                        TotalVolume += coin.Volume;
                        _addedCoins.Add(coin);
                    }
                    else
                    {
                        throw new Exception("CoinJar is too full!");
                    }
                }
            }
            else
            {
                throw new Exception("Trying to add an invalid coin to the CoinJar.");
            }
        }

        public void Reset()
        {
            TotalAmount = 0;
            TotalVolume = 0;
            _addedCoins.Clear();
        }
    }
}
