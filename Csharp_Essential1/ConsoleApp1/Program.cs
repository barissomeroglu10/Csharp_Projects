using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");

            #region Class Members
            /*
            1. Field --> variable in class
            2. Property --> use this for encapsulation
            3. Method --> function
            4. Indexer --> use index logic in class
            */
            #endregion

            #region Field
            /*
            It is the most basic structure contained in an object in OOP.
            They are the areas where we store / hold data in the object. 
            They are the variables that define in the class.
            They can be in any type (such as int, string, double etc.)
            
            class MyClass
            {
              [access modifiers] int a; this is a field

              a will be 0 as default
            }

            */
            #endregion

            #region Property
            /*
            They are a method
            They don't get parametre and they have get/set block
            We use property to make encapsulation for the fields

            private int _name;

            public int Name
            {
             
            get { retrun [anything]; } value call for property
            set { value = [_name];  } value assignment for property
            }

            Encapsulation: It is the controlled opening of the data in an object (data in fields) to the outside and receiving data in a controlled manner.

            We use properties to make encapsulation.

            Property Signs:

            - Full property
            - Prop
            - Auto property initializers
            - Ref Readonly Returns
            - Computed
            - Expression Bodied
            - Read only
            - Init only and Init Accessor

            If I am going to do encapsulation with field, I must first prevent access to fields through the object. So access modifiers for fields are set as private.

            If the property will operate on which field, we need to define the property from that field type.

            class MyClass
            {

            private int _name;

            public int Name
            {

            get { return [anything]; }
            set { value=_name; }

            }

            }

            */
            #endregion

            int AccountBalance = 0;

            // Getting ballance from user
            Console.Write("Please Enter Yours Balance: ");
            AccountBalance = Convert.ToInt32(Console.ReadLine());

            Bank b1 = new Bank();

            b1.Balance = AccountBalance;

            Console.WriteLine($"NewBalance: {b1.Balance}");

            Console.ReadKey();
        }
    }
}
