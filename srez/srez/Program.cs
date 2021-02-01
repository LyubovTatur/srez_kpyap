using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LubochkinaLibochka;

namespace srez
{
    class Program
    {
        static void Main(string[] args)
        {
            Persone[] persones = new Persone[] { new Persone("qwe", 4, 7, 9), new Persone("ghf", 44, 67, 89), new Persone("kl", 44, 47, 944) };
            Loader.Save("1.txt", persones);
            var persones2 = Loader.Load("1.txt");
            foreach (var item in persones2)
            {
                Console.WriteLine(item.ToString()) ;
            }
            Console.ReadLine();
        }
    }
}
