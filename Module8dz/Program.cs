/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Module8dz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sarr squararr = new Sarr(6);
            squararr[0] = 8;
            squararr[1] = 10;
            squararr[2] = 5;
            squararr[3] = 1;
            squararr[4] = 2;
            squararr[5] = 7;


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Значение  = {squararr[i]}");
            }

            Console.ReadKey();


        }

        class Sarr
        {
            private int[] array;

            public Sarr(int size)
            {
                array = new int[size];
            }

            public int this[int index]
            {
                get
                {
                    if (index >= 0 && index < array.Length)
                    {
                        return array[index];
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
              }
                set
                {
                    if (index >= 0 && index < array.Length)
                    {
                        array[index] = value * value;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
            }
        }

    }
}
*/

//2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8dz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Площадь: ");
            double ploshad = double.Parse(Console.ReadLine());

            Console.Write("Количество людей: ");
            int people = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сезон: ");
            string season = Console.ReadLine().ToLower();

            Console.Write("Льготы: ");
            string Sale = Console.ReadLine().ToLower();

            double otoplenie = 5.0;
            double water = 7.0;
            double gas = 8.0;
            double remont = 4.0;

            if (season == "осень" || season == "зима")
            {
                otoplenie *= 1.5;
            }

            double otop = ploshad * otoplenie;
            double voda = people * water;
            double gaz = people * gas;
            double remontt = ploshad * remont;

            double salee = 0.0;

            if (Sale == "да")
            {
                salee = otop * 0.3;
            }

            double totalOtop = otop - salee;
            double totalWater = voda;
            double totalGas = gaz;
            double totalRemont = remontt;
            double totalPay = totalOtop + totalWater + totalGas + totalRemont;

            Console.WriteLine("Вид платежа\t\tНачислено\tЛьготная скидка\tИтого");
            Console.WriteLine($"Отопление\t\t{otop:C}\t\t{salee:C}\t\t{totalOtop:C}");
            Console.WriteLine($"Вода\t\t\t{voda:C}\t\t\t-\t\t{totalWater:C}");
            Console.WriteLine($"Газ\t\t\t{gaz:C}\t\t\t-\t\t{totalGas:C}");
            Console.WriteLine($"Ремонт\t\t\t{remontt:C}\t\t\t-\t\t{totalRemont:C}");
            Console.WriteLine($"Итого\t\t\t\t{totalPay:C}");

            Console.ReadKey();
        }
    }
}

