using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
           // Арифметическая прогрессия
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.SetStart(10);
            arithProgression.SetStep(2);
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());
            // Сброс значения
            arithProgression.Reset();

            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());

            // Геометрическая прогрессия 
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.SetStart(10);
            geomProgression.SetStep(2);
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            // Сброс значения
            geomProgression.Reset();
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());

            Console.ReadKey();

        }
    }
}
