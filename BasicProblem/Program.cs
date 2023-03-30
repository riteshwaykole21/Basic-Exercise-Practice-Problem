using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Print Hello");
            Console.WriteLine("2 : Sum Of Two Number");
            Console.WriteLine("3 : Dividing Two Number");
            Console.WriteLine("4 : Print Result Of Specified opration");
            Console.WriteLine("5 : Swapping Two Number");
            Console.WriteLine("6 : Three Number Multiplication");
            Console.WriteLine("7 : All Opration Performs");
            Console.WriteLine("8 : Multiplication Table");
            Console.WriteLine("Enter A Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Basics basics = new Basics();
                    basics.Hello();
                    break;
                case 2:
                    Sum sum = new Sum();
                    sum.Add();
                    break;
                case 3:
                    Dividing dividing = new Dividing();
                    dividing.divide();
                   break;
                case 4:
                    SpecificOpration specificOpration = new SpecificOpration();
                    specificOpration.Special();
                    break;
                case 5:
                    SwapingtwoNum swapingtwoNum = new SwapingtwoNum();
                    swapingtwoNum.Swap();
                    break;
                case 6:
                    Multiplication multiplication = new Multiplication();
                    multiplication.Three();
                    break;
                case 7:
                    Oprations oprations = new Oprations();
                    oprations.Addition();
                    break;
                case 8:
                    MultiplicationTable multiplicationTable = new MultiplicationTable();
                    multiplicationTable.Multiply();
                    break;
            }
            Console.ReadLine();

        }
    }
}
