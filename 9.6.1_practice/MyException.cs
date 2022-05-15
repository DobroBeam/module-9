using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6._1_practice
{
    public class MyException : Exception
    {
        public MyException()
        {

        }
        public MyException(string message) : base(message)
        {

        }
    }
}
