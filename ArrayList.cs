using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList alNumList = new ArrayList();
            alNumList.Add(100);
            alNumList.Add(200);

            Console.WriteLine("Current List: ");
            for(int i = 0; i < alNumList.Count; i++)
            {
                Console.WriteLine(alNumList[i]);
            }            
            UpdateList(alNumList);

            Console.ReadKey();
            
        }
        public static void UpdateList(ArrayList alNumList)
        {
            int nPosition;
           
            while (true)
            {
                Console.WriteLine("Enter Position (Enter 0 to exit): ");
                nPosition = Convert.ToInt32(Console.ReadLine());
                if (nPosition == 0)
                {
                    break;
                }
                else if (nPosition < 2 || nPosition > alNumList.Count)
                {
                    Console.WriteLine("Position should be greator then 1 and less than ." + alNumList.Count + " Try Again.");
                    nPosition = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    int num1 = Convert.ToInt32(alNumList[nPosition - 2]);
                    int num2 = Convert.ToInt32(alNumList[nPosition - 1]);
                    int result = (num1 + num2) / 2;

                    Console.WriteLine("New number between " + num1 + " and " + num2 + " is " + result);

                    alNumList.Insert(nPosition - 1, result);
                    // Printing Updated List
                    Console.WriteLine("Updated List is: ");
                    for (int i = 0; i < alNumList.Count; i++)
                    {
                        Console.WriteLine(alNumList[i]);
                    }
                    continue;
                }
            }           
        }
    }
}
