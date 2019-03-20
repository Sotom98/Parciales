using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria {
    public class Class1 {
        double val1, val2;
        string nombre;
        int edad;

        public void Multi() {
            Console.Write("Ingrese valor 1: ");
            val1 = double.Parse(Console.ReadLine());

            if (val1 == 0) {
                Console.WriteLine("El producto de 0 por cualquier numero es 0");
            }
            else {
                Console.Write("Ingrese valor 2: ");
                val2 = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("Producto: " + (val1 * val2));
        }

        public void Divi() {
            Console.Write("Ingrese valor 1: ");
            val1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor 2: ");
            val2 = double.Parse(Console.ReadLine());

            if (val2 == 0) {
                Console.WriteLine("Error: no se puede dividir entre cero");
            }
            else {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Division: " + (val1 / val2));
            }
        }

        public void Names() {
            for (int i = 0; i < 5; i++) {
                Console.Write("Ingrese nombre " + (i + 1) + ": ");
                nombre = Console.ReadLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine("Nombre " + (i + 1) + ": " + nombre);
            }
        }

        public void Edad() {
            int i = 0;
             do {
                Console.Write("Ingrese edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine(edad);
                Console.WriteLine("---------------------------");
                Console.WriteLine("Edad : " + edad);
                i = i + 1;
            } while (i < 5);
        }
    }
}
