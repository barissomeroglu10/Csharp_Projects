using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    public class Encapsulation
    {
        int _age; // this will be private as default
        private string _name;
        private string _surname;

        #region Encapsulation with Property
        public int Age // encapsulation for age
        {
            get { return _age; }
            set { _age = value; }
        }

        // public int Age { get => _age; set => _age = value; }

        public string Name // encapsulation for name
        {
            get { return _name; }
            set { _name = value; }
        }

        // public string Name { get => _name; set => _name = value; }

        public string Surname // encapsulation for surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        // public string Surname { get => _surname; set => _surname = value; }
        #endregion

        #region Encapsulation with Method
        //public int AGet()
        //{
        //    return this._age;
        //}

        //public void ASet(int value)
        //{
        //    this._age = value;
        //}
        #endregion
    }
}
