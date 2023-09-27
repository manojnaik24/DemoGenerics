using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Generics<int> generics=new Generics<int>(25);
          Generics<string> ge=new Generics<string>("Manoj");
          Generics<double> gen=new Generics<double>(25.5);
          Generics<bool> gene=new Generics<bool>(true);
            Console.WriteLine();

            generics.DemoMethod(21);
            ge.DemoMethod("Kumar");
            gen.DemoMethod(26.555);
            gene.DemoMethod(true);
            Console.WriteLine();

            Generics g=new Generics();
            g.GenericsMethod(1);
            g.GenericsMethod("Manoj");
            g.GenericsMethod(37.88);
            g.GenericsMethod<int>(2);
            g.GenericsMethod<string>("jaswanth");
            g.GenericsMethod<double>(37.88);
            Console.ReadLine();
        }
    }
}
