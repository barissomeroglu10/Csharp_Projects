using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
    }
}
