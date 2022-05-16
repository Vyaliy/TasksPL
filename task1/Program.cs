using System;
using System.Linq;
using System.Text;

public class task1
{
    public static int Main(string[] args)
    {
        // Небольшая проверка входных данных
        if (args.Length != 2)
        {
            Console.WriteLine("Неверное количество элементов командной строки");
            Console.ReadKey();
            return -1;
        }
        int n, m;
        if (!Int32.TryParse(args[0], out n))
        {
            Console.WriteLine("Первый аргумент командной строки не является числом");
            Console.ReadKey();
            return -1;
        }
        if (!Int32.TryParse(args[1], out m))
        {
            Console.WriteLine("Первый аргумент командной строки не является числом");
            Console.ReadKey();
            return -1;
        }
        //Конец проверки
        int currIndex = 0;
        int result = 0;
		do
        {
            result = result * 10 + currIndex+1;
            currIndex = currIndex + m - 1;
            if (currIndex >= n)
            {
                currIndex = currIndex - n;
            }
        } while (currIndex != 0);
        Console.WriteLine(result);
        Console.ReadKey();
        return result;
    }
}