using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            byte dia;

            Console.WriteLine("dame un día: ");
            dia = Convert.ToByte(Console.ReadLine());

            switch(dia)
            {
                case 1: Console.WriteLine("haz elegido lunes"); break;
                case 2: Console.WriteLine("has elegido martes"); break;
                case 3: Console.WriteLine("has elegido miercoles"); break;
                case 4: Console.WriteLine("has elegido jueves"); break;
                case 5: Console.WriteLine("haz elegido viernes"); break;
                case 6: Console.WriteLine("has elegido sabado"); break;
                case 7: Console.WriteLine(" haz elegido domingo"); break;
                default: Console.WriteLine("no es un dia"); break;

                   


            }
        }
    }
}
