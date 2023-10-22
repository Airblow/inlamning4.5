using System;
using System.Security.Cryptography.X509Certificates;

namespace inlamning4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string userInput = Console.ReadLine();
            string finalNumber = "";

            for (int i = 0; i < userInput.Length; i++)
            {
                string character = userInput[i].ToString();
                int number = int.Parse(character);

                if (number == 9)
                {
                    number = 0;
                }
                else
                {
                    number++;
                }

                finalNumber += number;

            }
            Console.WriteLine(finalNumber);
            Console.ReadKey();


        }          

    }

}
