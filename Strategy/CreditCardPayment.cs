using System;

namespace BehavioralPatterns.Strategy
{
    public class CreditCardPayment : IPaymentStrategy
    {
        private string _cardNumber;

        public CreditCardPayment(string cardNumber)
        {
            _cardNumber = cardNumber;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"[Credit Card] Paid {amount}$ using card {_cardNumber}");
        }
    }
}
