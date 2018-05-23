using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    class Program
    {   //Very simple POC of the implementation of the interfaces that keep adding one of a coin type until the coinjar is full. 
        //NB - Adding "Coin" will result in an infinite loop since they will all be rejected unless defined specifically for US currency. See AmericanCoinValidator.cs for implementation details.
        static void Main(string[] args)
        {
            var validator = new AmericanCoinValidator();
            CoinJar coinJar = new CoinJar(validator);
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            bool notFull = true;

           while (notFull)
            {
                try
                {
                    var coin = new Penny();
                    coinJar.AddCoin(coin);
                    Console.WriteLine("Total amount : " + coinJar.TotalAmount);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occured -> Total Amount " + coinJar.TotalAmount);
                    notFull = false;                    
                }                
            }
            Console.ReadLine();
        }
    }
}
