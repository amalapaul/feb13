using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newlearn
{
    internal class human
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}
