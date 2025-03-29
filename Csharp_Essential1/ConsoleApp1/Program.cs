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

            Console.WriteLine("");

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
            private int _age;

            public int Age
            {

            get { return [anything]; }
            set { value=_name; }

            }

           }

            - Prop property: Prop properties create their own fields in the background when they are compiled. Therefore, there is no need to define a field.

            A prop property can be read only but it can't be write only

            public int Age { get; set; }


            - Auto property initializers: we can assign value to read only prop with auto property initializer

            class InsanEntity
            {
              public int Age { get; set; } = 23;
            }

            Since the structure here is ‘prop’, it will create the field in the background and a value will be assigned to it by default. Here we interfere with the default value with the first assignment.


            - Ref Readonly Returns: It is the property that allows us to return the field in a class with its reference and on the other hand makes the value of this variable read only.

            string _adi = "Barış Someroğlu";
            public ref readonly string Adi => ref _adi;

            When we call this property (Adi), I reach field not field's value.


            - Expression Bodied: It allows us to use Lambda Expression for properties. We can use this only for read only situations.

            public string Gender
            {
              get
              {
                return "Male";
              }

            } ----->  public string Gender => "Male";


            - Init Only / Init Accessor: we can assign first value to an object with Init Only prop. and it is guaranteed that this value is not changed in the following process.

            */
            #endregion

            #region Auto Initializer vs Init Only
            /*
            
            Auto Initializer x Object Initializer --> no
            Init Only x Object Initializer --> yes

            // Object Initializer
            Book b1 = new Book
            {
             
              Author = ".....";
              Name = ".......";

            };

            */
            #endregion

            #region Method

            // They are the basic programmatic parts that allow us to perform operations on the object, on the values ​​in the fields or on the values ​​coming from outside with parameters.

            // For property, when we get value or read value we act like a variable
            // But for methods, we act like a method
            // MyClass o1 = new MyClass();
            // o1.X(); ---> X is a method
            // o1.X; ---> X is a property

            // We use methods to make proccess (such as arithmetic proccess etc.)
            // We use property for Encapsulation
            #endregion

            #region this keyword
            /*
            1. It represents class's object
            2. It is used to separate method parameters with the same name
            3. It is used to call another constructor from a constructor

            this keyword cannot be called from anywhere, it can only be called from within members
            */
            #endregion

            int AccountBalance = 0;

            // Getting ballance from user
            Console.Write("Please Enter Yours Balance: ");
            AccountBalance = Convert.ToInt32(Console.ReadLine());

            Bank b1 = new Bank();
            // Bank: the class which we produce object from
            // (): constructor method
            // b1: reference whice references the produced object

            // new Bank(): in the heap area
            // Bank b1: in the stack are

            // Target-Typed new expression
            // We can use "Type x = new()" instead of "Type x = new Type()"

            b1.Balance = AccountBalance;

            Console.WriteLine($"NewBalance: {b1.Balance}");

            // The way to make an object from nested class
            Bank.SubBankAccount subClass = new Bank.SubBankAccount();

            subClass.SubAccount();

            thisClass myObject = new thisClass();

            myObject.X();

            Console.ReadKey();
        }
    }
}
