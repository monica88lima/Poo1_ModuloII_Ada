﻿using System.Linq.Expressions;

namespace exercicio_03_classeTv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("TV");
                TV tv = new TV("Desligada", 10, 2);
                Console.WriteLine(tv.ligada);
                Console.WriteLine(tv.canal);
                Console.WriteLine(tv.volume);

                //tv.MudaCanal(6);
                tv.Power("liga");
                Console.WriteLine(tv.ligada);
                tv.AumentaVolume();
                Console.WriteLine(tv.volume);
                tv.MudaCanal(2);
                Console.WriteLine(tv.canal);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
            
        }
    }
}