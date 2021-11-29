using System;

namespace Open_Lab_03._04
{
    public class Numbers
    {
        public string EvenOrOdd(int number)
        {
             int a;
            Console.WriteLine("Napis cislo : ")
            a = int.Parse(Console.ReadLine());

            if(a % 2 == 0)
            {
            	
                Console.WriteLine(a + " Je parne cislo");
            }
            else
            {
            	
                Console.WriteLine(a + " Toto neni parne cislo nauc sa matiku");
                }

        }
    }
}
