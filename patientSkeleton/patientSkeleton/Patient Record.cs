using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patientSkeleton
{
  public  class Patient_Record
    {
        private string id;
        private string name;
        private string gender;
        private float age;
        private string birth_date;
        private string disease;

        public Patient_Record()
        {

        }

        public void setID(string id)
        {
            this.id = id;
        }
        public string getID()
        {
            return id;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return this.name;
        }
        public void setgender(string gender)
        {
            this.gender = gender;

        }
        public string getgender()
        {
            return this.gender;
        }
        public void setage(float age)
        {
            this.age = age;
        }
        public float getage()
        {
            return this.age;
        }
        public void setbirth_date(string birth_date)
        {
            this.birth_date = birth_date;
        }
        public string getbirth_date()
        {
            return this.birth_date;
        }
         public void setdisease(string disease)
        {
            this.disease = disease;
        }
        public string getdisease()
        {
            return this.disease;
        }
    }
    }

