using System;

namespace Test1_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 5, 7, 9 };

            Console.Write("Testen Sie die Daten im Array: ");
            int iEingabe = Convert.ToInt16(Console.ReadLine());

            /*
            if(iEingabe = array)
            {
                Console.WriteLine("Die Daten sind korrekt.");
            }

            else
            {
                Console.WriteLine("Die Daten sind nicht korrekt.");
            }
            */

            Console.ReadKey();
        }
    }
}
