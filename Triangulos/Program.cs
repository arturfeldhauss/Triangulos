using System;

namespace Triangulos
{
    internal class Program
    {
        static void Main(string[] args)

        {
            do
            {
                Console.WriteLine("Digite em cm os lados do triangulo!!");
                Console.WriteLine("Lembre-se que para contruir um triangulo a medida de um dos lados tem que ser menor que a soma dos outros dois!! ");
                string x = Console.ReadLine();
                string y = Console.ReadLine();
                string z = Console.ReadLine();
                int xx = Convert.ToInt32(x);
                int yy = Convert.ToInt32(y);
                int zz = Convert.ToInt32(z);
                if (xx + yy < zz || yy + zz < xx || xx + yy < zz)
                {
                   
                    Console.WriteLine("Triangulo invalido!!!!");
                    Console.WriteLine("Aperte enter para tentar novamente!!!");

                }
                else if (xx == zz && zz != yy || xx == yy && yy != zz || yy == zz && zz != xx)
                {
                    Console.WriteLine("O triangulo é isoceles!!!");
                }
                else if (xx != yy && yy != zz)
                {
                    Console.WriteLine("O triangulo é escaleno");
                }
                else if (xx == yy && yy == zz)
                {
                    Console.WriteLine("O triangulo é equilatero!!");
                }





                Console.WriteLine("Aperte alguma tecla para fazer novamente!!");
                Console.ReadLine();
            } while (true);
        }
    }
}
