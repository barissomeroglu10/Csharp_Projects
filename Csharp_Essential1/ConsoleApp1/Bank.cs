using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    /// <summary>
    /// This is the main bank class
    /// </summary>
    public class Bank
    {
        int _balance; // this will be private as default

        public int Balance
        {
            get
            {
                if (_balance < 0)
                {
                    return 0;
                }
                else
                {
                    return (_balance * 10) / 100; // (2) calculate %10 of the balance
                }
            }

            set
            {
                if (value < 10)
                {
                    _balance = value;
                }

                else
                {
                    _balance = (value * 95) / 100; // (1) calculate %95 of the balance
                }
            }
        }

        #region Is a class a member of a class
        /*
        No, a class is not a member of another class (which defined in a class)

        The members of a class are:
        1- Field
        2- Property
        3- Method
        4- Indexer
        */
        #endregion

        /// <summary>
        /// This is the sub account class
        /// </summary>
        public class SubBankAccount
        {
            public void SubAccount()
            {
                Console.WriteLine("\nSub Account Opened!");
            }
        }
    }

    public class thisClass
    {
        int a;
        public void X()
        {
            // When the X method is called on the object created from thisClass, it will call the X method of the current object again.
            // this.X();
        }

        // This keyword corresponds to the current object of the relevant class structure.
        // We do not have to use this keyword because it is done automatically by the compiler.
        public void X(int a)
        {
            // a = filed a 
            this.a = a;
        }
    }
}
