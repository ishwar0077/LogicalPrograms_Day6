using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static void checkPrime()
        {
            int startNum, endNum;
            int count = 0;
            Console.WriteLine("Enter first the number: ");
            startNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entet last the numbr: ");
            endNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("prime Number between {0} to {1} are: ", startNum, endNum);
            for (int i = startNum; i <= endNum; i++)
            {
                count = 0;
                for (int j = 1; j <= i;j++)
                {
                   
                    if(i % j == 0)
                    {
                        count += 1;
                    }

                }
                if (count == 2)
                {

                    Console.WriteLine("{0} ", i);

                }
           
            }
        }
    }
}
