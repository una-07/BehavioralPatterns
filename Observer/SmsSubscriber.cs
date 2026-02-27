using System;

namespace BehavioralPatterns.Observer
{
    public class SmsSubscriber : IObserver
    {
        public void Update(string currency, decimal rate)
        {
            Console.WriteLine($"[SMS] Alert! {currency} = {rate}");
        }
    }
}
