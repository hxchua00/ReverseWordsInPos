using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsInPos
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Sample text right here";
            string[] arr = text.Split(' ');

            Console.WriteLine($"Text to reverse: \n{text}");
            Console.WriteLine();

    
            
            
            for (int i = 0; i < arr.Length; i++)
            {
                string substr = arr[i];
                string temp = "";
                //Console.WriteLine($"arr[i]: {substr}");

                for (int j = substr.Length-1; j >=0; j--)
                {
                    temp += substr[j];
                }
                arr[i] = temp;
                Console.Write($"{arr[i]} ");
            }

            Console.ReadLine();
        }
    }
}
