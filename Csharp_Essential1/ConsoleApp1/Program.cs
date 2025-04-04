﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

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

            #region Object Initializer
            /*
            This is the first value assign for properties when an object created.

            In this form, we can only use fields and properties. We can not use methods in this form.

            */
            #endregion

            #region Deep Copy & Shallow Copy
            /*
            Deep Copy: this is a copy method for value type variable. With deep copy, we can directly copy the value type variable.
                       So with deep copy, a variable can has many copy (copy of itself)

                       int a = 10; int b = a;

            Shallow Copy: this is a copy method for reference type variable. With shallow copy, we can copy reference of an object.
                          So with shallow copy, a variable's reference has many copy (copy of reference)

                          MyClass myclass = new MyClass();
                          MyClass m2 = m1;
            */
            #endregion

            #region Encapsulation
            /*
            We cover our objects with encapsulation to avoid access from 3rd party user(s)
            With encapsulation, we show our field in control.

            We can actualize encapsulation with 2 way:
            1. Encapsulation with method
            2. Encapsulation with property
            */
            #endregion

            #region Constructor
            /*
            There are special structures that will allow us to define the operations to be performed on the object to be produced
            from a class during the production of this object, and also to define the operations to be performed for the last time during the destruction of this produced object.
            These are called "special members".

            Special members:
            1. Constructor
            2. Static Constructor
            3. Destructor

            These special members have structures that can be used in common in all classes.

            *What is Constructor?
            -It is a method
            -It's the first worked method when an object created.
            -Constructor must work when an object created.

            ...... = new MyClass()  (): this is contructor method

            * Constructor's Behaviour Model
            -Constructor is triggered after a request to create an object with "new" is received and memory is allocated for the relevant object.
            -Constructor can be responsible for assigning initial values ​​to the files in the creation phase of the objects from a functional point of view. In other words, we can use it for other functions as well.
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

            //object initializer example
            //TryClass tryObject = new TryClass()
            //{
            //    MyProperty1 = 10,
            //    MyProperty2 = 20,
            //    MyProperty3 = 30,
            //};
            //Console.WriteLine();
            //Console.WriteLine(tryObject.MyProperty1);

            TryClass tryClass = new TryClass();

            Console.WriteLine();
            Console.WriteLine($"MyProperty1 (constructor) = {tryClass.MyProperty1}"); // we should see 1 on the console

            Console.ReadKey();
        }
    }
}
