using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    /// <summary>
    /// A method that includes just one statement can be written in lambda syntax.
    /// </summary>
    class ExpressionBodiedMethod
    {
        public void PrintMe(string message) => Console.Write("message");
    }
}
