namespace BehavioralPatterns.Strategy
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
