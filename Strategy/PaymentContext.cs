namespace BehavioralPatterns.Strategy
{
    public class PaymentContext
    {
        private IPaymentStrategy _strategy;

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ProcessPayment(decimal amount)
        {
            _strategy?.Pay(amount);
        }
    }
}
