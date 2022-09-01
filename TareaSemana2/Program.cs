using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSemana2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Variables

            int x1, y1;
            int x2, y2;
            int x3, y3;

            //Ingresado por consola
            Console.WriteLine("Ingrese la coordenada X del vertice A (?, y): ");
            x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la coordenada Y del vertice A (x, ?): ");
            y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la coordenada X del vertice B (?, y): ");
            x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la coordenada Y del vertice B (x, ?): ");
            y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la coordenada X del vertice C (?, y): ");
            x3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la coordenada Y del vertice C (x, ?): ");
            y3 = int.Parse(Console.ReadLine());



            // vertice A
            Vertice v1 = new Vertice { x= x1, y = y1};
            //Vertice B
            Vertice v2 = new Vertice { x = x2, y = y2 };
            //Vertice C
            Vertice v3 = new Vertice { x = x3, y= y3};
            //Vertice D
            //Vertice v4 = new Vertice { x = 5, y=1};

            Rectangulo rectangulo = new Rectangulo();

            rectangulo.V1 = v1;
            rectangulo.V2 = v2;
            rectangulo.V3 = v3;
            //rectangulo.v4 = v4;

            Console.WriteLine("El área es: "+rectangulo.getArea());
            Console.WriteLine("El perimetro es: "+rectangulo.getPerimetro());

            Console.Read();
        }
    }
}
