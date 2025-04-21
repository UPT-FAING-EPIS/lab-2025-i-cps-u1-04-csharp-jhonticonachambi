namespace Observer.Domain
{
    public interface IObserver
    {
        void Update(string message);
    }
}