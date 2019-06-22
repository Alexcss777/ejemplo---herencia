using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORMULA
{
    class Program
    {
        static void Main(string[] args)
        {
            int a= 0, b = 0, opc, c = 0,x=0;
            double p1 = 0, p2=0,p3=0,p4=0,x1=0,x2=0,p5=0;
            string N1,N2,N3,N4;



            do
            {
                
                Console.WriteLine("elige operacion 1:formula general / 2:binomio al cuadrado");
                N3 = Console.ReadLine();
                opc = Convert.ToInt32(N3);
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("ingresa a");
                        N1 = Console.ReadLine();
                        a = Convert.ToInt32(N1);


                        Console.WriteLine("ingresa b");
                        N2 = Console.ReadLine();
                        b = Convert.ToInt32(N2);

                        Console.WriteLine("ingresa c");
                        N4 = Console.ReadLine();
                        c = Convert.ToInt32(N4);
                        p1 = Math.Pow(b, 2);
                        Console.WriteLine(p1);
                        p2 = -4 * a * c;
                        Console.WriteLine(p2);
                        p3 = p1 + p2;
                        if (p3 <= 0)
                        {
                            Console.WriteLine("no se puede sacar la raiz a un numero negativo o a 0");
                        }
                        else
                        {
                            p4 = Math.Sqrt(p3);
                            Console.WriteLine(p4);

                            p5 = 2 * a;
                            Console.WriteLine(p5);
                            x1 = (-b - p4) / p5;
                            x2 = (-b + p4) / p5;
                            Console.WriteLine("x1 = " + x1);
                            Console.WriteLine("x2 = " + x2);

                        }





                        break;

                    case 2:





                        break;

                    default:
                        Console.WriteLine("el parametro introducido no es valido");
                        x = 1;
                        


                        break;


                }


                

            } while (x == 1);

          






            Console.ReadKey();







        }
    }
}
