using System.Collections.Generic;

namespace Observer.Domain
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string state;
        
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                NotifyObservers();
            }
        }
        
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(state);
            }
        }
    }
}