using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuritySurveillanceObserver
{
    
        public class Observer:IObserver
{
           
  public string ObserverName { get;private set; }
  public Observer(string name)
  {
    this.ObserverName = name;
  }
  public String Update()
  {
      return this.ObserverName;
     
  }
}

interface IObserver
{
 String Update();
}
    }

