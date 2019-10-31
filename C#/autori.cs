using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2{
    class Autori{
        public static void Main(string[] args){
            char[] line = Console.ReadLine().ToCharArray();
            bool dash = false;

            Console.Write(line[0]);

            foreach (char x in line){
                if (dash){
                    Console.Write(x);
                    dash = false;}

                if (x == 45){
                    dash = true;}
            }
        }
    }
}
