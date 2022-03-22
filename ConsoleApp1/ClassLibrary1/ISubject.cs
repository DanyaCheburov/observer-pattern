using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ISubject
    {
        void RegisterObserver(IObserver item);
        void RemoveObserver(IObserver item);
        void NotifyObserver();
    }
}