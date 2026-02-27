using System;

namespace BehavioralPatterns.Observer
{
    public class MobileAppSubscriber : IObserver
    {
        public void Update(string currency, decimal rate)
        {
            Console.WriteLine($"[Mobile App] Updated rate: {currency} → {rate}");
        }
    }
}
