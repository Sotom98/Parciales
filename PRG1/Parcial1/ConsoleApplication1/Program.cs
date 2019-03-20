using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            Class1 cl = new Class1();

            Console.WriteLine("Ingrese opcion (1 - 4)");
            int a = int.Parse(Console.ReadLine());

            switch (a) {
                case 1:
                    cl.Multi();
                    break;
                case 2:
                    cl.Divi();
                    break;
                case 3:
                    cl.Names();
                    break;
                case 4:
                    cl.Edad();
                    break;
                default:
                    Console.WriteLine("Valor incorrecto, fin programa");
                    break;
            }

            Console.ReadKey();
        }
    }
}
