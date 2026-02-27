using System;
using BehavioralPatterns.Strategy;
using BehavioralPatterns.Observer;

namespace BehavioralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("=== STRATEGY PATTERN ===");
            PaymentContext context = new PaymentContext();

            Console.WriteLine("Choose payment method:");
            Console.WriteLine("1 - Credit Card");
            Console.WriteLine("2 - PayPal");
            Console.WriteLine("3 - Crypto");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    context.SetStrategy(new CreditCardPayment("1234-5678-9999"));
                    break;
                case 2:
                    context.SetStrategy(new PayPalPayment("user@mail.com"));
                    break;
                case 3:
                    context.SetStrategy(new CryptoPayment("0xABCDEF"));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            context.ProcessPayment(150);

            
            Console.WriteLine("\n=== OBSERVER PATTERN ===");

            CurrencyExchange exchange = new CurrencyExchange();

            var email = new EmailSubscriber();
            var sms = new SmsSubscriber();
            var mobile = new MobileAppSubscriber();

            exchange.Attach(email);
            exchange.Attach(sms);
            exchange.Attach(mobile);

            exchange.ChangeRate("USD", 470);
            exchange.ChangeRate("EUR", 510);

            exchange.Detach(sms);

            exchange.ChangeRate("BTC", 30000);

            Console.ReadLine();
        }
    }
}
