using System;
using raktarApp.Model;

namespace raktarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tesztadatok
            RaktarKeszlet alma = new RaktarKeszlet("Alma", 1000, "kg", 450);
            Console.WriteLine(alma);
            alma.BeMennyiseg(30);
            Console.WriteLine(alma);
            alma.ArEmeles20();
            Console.WriteLine("\nÁremelés után:" + alma);
            RaktarKeszlet hagyma = new RaktarKeszlet("Hagyma", 300, "kg", 375);
            Console.WriteLine(hagyma);
        }
    }
}
