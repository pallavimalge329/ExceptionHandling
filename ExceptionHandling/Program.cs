using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling
{

    class Program
    {
        public void CalculateSum()
        {
            int i;
            int sum = 0;
            int[] number = new int[5] { 1, 2, 3, 4, 5 };
            try
            {
                for (i = 0; i < 5; i++)
                {
                    sum += number[i];
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please check the iterations of the list");
            }
            finally
            {
                Console.WriteLine("Total : {0}", sum);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Handling System Exception ");
            ArrayOutOfIndex obj = new ArrayOutOfIndex();
            obj.CalculateSum();
            Console.ReadKey();

        }
    }
}


    



    

