using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }

        
        static int Points(int levels){
         int m=0;  
         int i=1;   
         while(i<=levels){  
                m=m+i;  
                i=i+1; 
                }
            return m; 
        }
        }

        }
