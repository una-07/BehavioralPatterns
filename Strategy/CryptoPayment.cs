using System;

namespace BehavioralPatterns.Strategy
{
    public class CryptoPayment : IPaymentStrategy
    {
        private string _wallet;

        public CryptoPayment(string wallet)
        {
            _wallet = wallet;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"[Crypto] Paid {amount}$ using wallet {_wallet}");
        }
    }
}
