namespace BehavioralPatterns.Observer
{
    public interface IObserver
    {
        void Update(string currency, decimal rate);
    }
}
