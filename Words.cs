using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words =  {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

           
            foreach( string element in words){
                if(element.Contains(letter)){
                Console.WriteLine(element);
                
                count++;
                }
    
        }
           if(count == 0){
               Console.WriteLine("No match");
           }

            

        }
    }
}
