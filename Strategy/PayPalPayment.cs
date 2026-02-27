using System;

namespace BehavioralPatterns.Strategy
{
    public class PayPalPayment : IPaymentStrategy
    {
        private string _email;

        public PayPalPayment(string email)
        {
            _email = email;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"[PayPal] Paid {amount}$ using account {_email}");
        }
    }
}
