﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    interface ICoinJar
    {
        void AddCoin(ICoin coin);
        decimal TotalAmount { get; }
        void Reset();
    }
}
