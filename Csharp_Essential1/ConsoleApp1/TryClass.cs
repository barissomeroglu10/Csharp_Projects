using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    public class TryClass
    {
        // make properties
        // this is an example
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }

        #region Rules to Define Constructor
        /*
         * Constructor's name must be same with class name (only special members name can be same with class name)
         * There is no "return value" for Constructor
         * Access modfier must be public for Constructor
         
        */
        #endregion

        // define a constructor
        public TryClass()
        {
            // assign to fields/properties
            MyProperty1 = 1;
            MyProperty2 = 2;
            MyProperty3 = 3;
        }
    }
}
