using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patientSkeleton
{
    class patient:Patient_Record
    {
        Patient_Record pr = new Patient_Record();
        public patient()
        {
           
        }
        public void view()
        {
            
            Console.WriteLine(pr.getname());
            Console.WriteLine(pr.getage());
            Console.WriteLine(pr.getgender());
            Console.WriteLine(pr.getID());
            Console.WriteLine(pr.getdisease());
            Console.WriteLine(pr.getbirth_date());


        }
        public void login(string name,string id)
        {
            pr.setname(name);
            pr.setID(id);
        }
    }
}

