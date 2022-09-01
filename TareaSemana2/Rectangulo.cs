using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSemana2
{
    public class Rectangulo
    {
        public Vertice V1 { get; set; }
        public Vertice V2 { get; set; }
        public Vertice V3 { get; set; }
        public Vertice V4 { get; set; }

        public double getPerimetro()
        {
            double baseP = Math.Sqrt(Math.Pow(V2.x - V1.x, 2) + Math.Pow(V2.y - V1.y, 2));
            double alturaP = Math.Sqrt(Math.Pow(V3.x - V2.x, 2) + Math.Pow(V3.y - V2.y, 2));
            return 2*(baseP + alturaP);
            
        }

        public int getArea()
        {
            //Para hallar una diagonal
            //double base1 = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + Math.Pow(v2.y-v1.y, 2));
            int baseR = V2.x- V1.x;
            int alturaR = V2.y - V3.y;
            int area = baseR * alturaR;
            if (area > 0)
            {
                return area;
            } else
            {
                return -1 * area;
            }
        }

    }
}
