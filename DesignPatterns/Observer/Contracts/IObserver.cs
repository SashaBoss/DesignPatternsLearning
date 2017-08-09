namespace Observer.Contracts
{
    public interface IObserver
    {
        void Update(double temp, double humidity, double pressure);
    }
}