using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Reflection
{
    class Person
    {
        private string name;
        public Person()
        {

        }
        public Person(string name)
        {
            this.name = name;
        }
        public int age
        {
            set;
            get;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
