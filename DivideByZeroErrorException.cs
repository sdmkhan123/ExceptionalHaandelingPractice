using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionalHaandelingPractice
{
    public class DivideByZeroErrorException
    {
        public static void divideByeZeroError()
        {
            try
            {
                Console.WriteLine("Enter 1st num");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd num");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y == 1)
                {
                    return;
                    //but finally block code still executed after return that is speciality of finally block
                }
                if (y % 2 > 0)
                {
                    throw new CustomExceptionHandling();
                }
                int z = x / y;
                Console.WriteLine(z);
            }
            catch(DivideByZeroException ex1)
            {
                Console.WriteLine("DivideByZeroException catch block is executed");
                //Inbuilt error message show
                Console.WriteLine(ex1.Message);
            }
            catch(FormatException ex2)
            {
                //user defined errot message show
                Console.WriteLine("FormatException catch block is executed");
                Console.WriteLine("Enter Input must be in given format");
            }
            catch(OverflowException ex3)
            {
                Console.WriteLine("OverflowException catch block is executed");
                Console.WriteLine(ex3.Message);
            }
            catch(CustomExceptionHandling ex4)
            {
                Console.WriteLine("CustomExceptionHandling catch block is executed");
                Console.WriteLine(ex4.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Default Exception catch block is executed");
                Console.WriteLine("Handle all other excetions");
            }
            finally
            {
                Console.WriteLine("Finally block code will always executed at any cost " +
                    "or in every condition even return the method even there is abnormal termination happen" +
                    "due to there is no catch block, finally block will stilll executed");
            }
            Console.WriteLine("End of Program");
        }
    }
}
