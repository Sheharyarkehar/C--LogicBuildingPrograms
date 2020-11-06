using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuritySurveillanceObserver
{
   public class Subject:ISubject
    {
       private List<Observer> observers = new List<Observer>();
       public static int count = 0;
            private int _int;
            public int CheckVideoRecord
            {
                get
                {
                    return _int;
                }
                set
    {
      
          if (value > _int)
             Notify();
          _int = value;
    }
            }
            public void AttachVideo(Observer observer)
            {
                observers.Add(observer);
                count++;
            }

            public void DetachVideo(Observer observer)
            {
                observers.Remove(observer);
                count--;
            }

            public void Notify()
            {
                observers.ForEach(x => x.Update());
            }
        }

        interface ISubject
        {
            void AttachVideo(Observer observer);
            void DetachVideo(Observer observer);
            void Notify();
        }
    }

