using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// this class performs all the mathematical operations
    /// </summary>
    public class Calculator
    {
        public Calculator()
        {

        }
        /// <summary>
        /// constructor with parameters x , y , and op; to call a respective method. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="op"></param>
        public Calculator(double x,double y,char op)
        {
            
            switch (op)
            {
                case '+':
                    Console.WriteLine(Add(x, y));
                    break;
                case '-':
                    Console.WriteLine(Sub(x, y));
                    break;
                case '*':
                    Console.WriteLine(Mul(x, y));
                    break;
                case '/':
                    Console.WriteLine(Div(x, y));
                    break;
            }
        }
        /// <summary>
        /// this method performs addition of x and y and returns the result
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>result of type double</returns>
        public double Add(double x, double y)
        {
            if(((x==Double.MaxValue)&&(y>0))||((y== Double.MaxValue)&&(x>0))||((x == Double.MinValue) &&(y == Double.MinValue)))
            {
                throw new System.OverflowException("overflow exception");
            }
            if ((x+y > Double.MaxValue) || (x-y < Double.MinValue))
            {
                throw new System.OverflowException("overflow exception");
            }
            return x+y;
        }
        /// <summary>
        /// this method performs substraction of x and y and returns the result
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>result of type double</returns>
        public double Sub(double x, double y)
        {
            if ((x == Double.MaxValue) && (y ==Double.MinValue) || (y == Double.MaxValue) && (x ==Double.MinValue))
            {
                throw new System.OverflowException("overflow exception");
            }
            return x - y;
        }
        /// <summary>
        /// this method performs multiplication of x and y and returns the result
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>result of type double</returns>
        public double Mul(double x, double y)
        {
           if((x*y>Double.MaxValue)||(x * y < Double.MinValue))
            {
                throw new System.OverflowException("overflow exception");
            }
            return x * y;
        }
        /// <summary>
        /// this method performs division of x and y and returns the result
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>result of type double</returns>
        public double Div(double x, double y)
        {
            if (y==0)
            {
                throw new System.DivideByZeroException("DivideByZeroException");
            }
            if ((x / y > Double.MaxValue) || (x / y < Double.MinValue))
            {
                throw new System.OverflowException("overflow exception");
            }
            return x / y;
        }
       /// <summary>
       /// main method, to read inputs from the console
       /// </summary>
       /// <param name="args"></param>
        public static void Main(String[] args)
        {
            String val;
            Console.Write("Enter integer: ");
            val = Console.ReadLine();
            double num1 = Convert.ToDouble(val);
            Console.Write("Enter integer: ");
            val = Console.ReadLine();
            double num2 = Convert.ToDouble(val);
            Console.Write("Enter operation: ");
            val = Console.ReadLine();
            char a = Convert.ToChar(val);
            Calculator c = new Calculator(num1, num2, a);

            Console.ReadKey();
        }
    }
}
