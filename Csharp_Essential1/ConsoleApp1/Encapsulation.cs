using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    public class Encapsulation
    {
        private int _age;
        private string _name;
        private string _surname;

        public int Age // encapsulation for age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Name // encapsulation for name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname // encapsulation for surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
    }
}
