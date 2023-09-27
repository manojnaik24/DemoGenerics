using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenerics
{
    //Generrics is a single form 
    //It does not specify a particular type
    //Generic allow us to a single class or method that ca be used for different data types.
    //<T> with type parameter
    //type parameter
    internal class Generics<T>
    {
        //public string data;
        public T data;
        public Generics(T data)
        {
            this.data = data;
            Console.WriteLine(this.data);
        }
        public void DemoMethod(T no)
        {
            Console.WriteLine(no);
        }
    }

    public class Generics
    {
        public void GenericsMethod<T>(T num)
        {
            Console.WriteLine(num);
        }
    }
}
