/*
Purpose of the code is make a login console screen.

Developer: Barış Someroğlu
Date: 27.11.2024 - 11:00 am
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // original values
            string UserName = "Baris";
            string Password = "123456";

            // right counter
            byte Counter = 3;


            do
            {
                // get name from user
                Console.WriteLine("Please Enter Your Name: ");
                string UserName2 = Console.ReadLine();

                // get password from user
                Console.WriteLine("Please Enter Your Password: ");
                string Password2 = Console.ReadLine();

                // check true condition
                if (UserName2 == UserName && Password2 == Password)
                {
                    Console.WriteLine("Login succed!");

                    break;
                    // if we use while(false) at the end of the code, there will be 2 proccess after succed log in
                    // but with break command, after succedd login there is no logic to another control

                }

                // check false condition 1
                else if (UserName2 == UserName && Password2 != Password)
                {
                    Counter--;

                    Console.WriteLine("Wrong Password!");
                    Console.WriteLine("Last " + Counter + " Right");

                }

                // check false condition 2
                else if (UserName2 != UserName && Password2 == Password)
                {
                    Counter--;

                    Console.WriteLine("Wrong Username!");
                    Console.WriteLine("Last " + Counter + " Right");
                }

                // check false condition 3
                else
                {
                    Counter--;

                    Console.WriteLine("Wrong Password and Wrong Username!");
                    Console.WriteLine("Last " + Counter + " Right");
                }
            }
            while (Counter > 0);

            // check right of user to login
            if (Counter == 0)
            {
                Console.WriteLine("There is no right for new attempt!");
            }

            Console.WriteLine("Turning off the program");

            Console.ReadKey();

        }
    }
}
