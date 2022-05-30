using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class NumberGenerator
    {
        private ArrayList observers = new ArrayList();
        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }
        public void DeleteObserver(Observer observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (Observer observer in observers)
            {
                Observer o = (Observer)observer;
                o.Update(this);
            }
        }
        public abstract int GetNumber();
        public abstract void Execute();
    }
}
