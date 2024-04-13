using System;
using System.Linq;

namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main()
        {
            int[] array = { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            bool allEven = array.All(x => x % 2 == 0);
            Console.WriteLine($"Все ли элементы в массиве чётные: {allEven}");

            bool allBetween10And45 = array.All(x => x > 10 && x < 45);
            Console.WriteLine($"Все ли элементы в массиве больше 10 и меньше 45: {allBetween10And45}");

            bool anyNegative = array.Any(x => x < 0);
            Console.WriteLine($"Есть ли в массиве хотя бы один отрицательный элемент: {anyNegative}");

            bool anyOddNegative = array.Any(x => x % 2 != 0 && x < 0);
            Console.WriteLine($"Есть ли в массиве хотя бы один нечетный, отрицательный элемент: {anyOddNegative}");

            bool contains7 = array.Contains(7);
            Console.WriteLine($"Есть ли в массиве значение 7: {contains7}");

            int firstAbove723 = array.FirstOrDefault(x => x > 723);
            Console.WriteLine($"Первый элемент больше 723: {firstAbove723}");

            int lastNegative = array.LastOrDefault(x => x < 0);
            Console.WriteLine($"Последний отрицательный элемент: {lastNegative}");
        }
    }

}
