using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    internal interface IWeatherObserver
    {
        void Update(double temperature);
    }

    internal interface IWeatherSubject
    { 
        void AddObserver(IWeatherObserver observer);    
        void RemoveObserver(IWeatherObserver observer);
        void NotifyObservers();
    }

}
