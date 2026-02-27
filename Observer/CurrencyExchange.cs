using System;
using System.Collections.Generic;

namespace BehavioralPatterns.Observer
{
    public class CurrencyExchange : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string currency, decimal rate)
        {
            foreach (var observer in _observers)
            {
                observer.Update(currency, rate);
            }
        }

        public void ChangeRate(string currency, decimal rate)
        {
            Console.WriteLine($"\nCurrency {currency} changed to {rate}");
            Notify(currency, rate);
        }
    }
}
