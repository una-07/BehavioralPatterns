using System;

namespace BehavioralPatterns.Observer
{
    public class EmailSubscriber : IObserver
    {
        public void Update(string currency, decimal rate)
        {
            Console.WriteLine($"[Email] {currency} rate is now {rate}");
        }
    }
}
