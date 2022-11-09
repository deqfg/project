using System;
namespace MyProgram
{
    class ADAM
    {
        static void table()
        {
            int [,]tab = new int [10,10];
            for (int r = 1; r <= tab.Length; r++)
            {
                Console.Write(r+'\t');
                for (int col = 1; col <= tab.Length; col++)
                {
                     Console.Write( r * col+'\t');
                }
            }
        }
        static void Main()
        {
        Console.WriteLine("Три программы\n");
        Console.WriteLine("1. Угадай число \n 2. Таблица умножения \n 3. Вывести делители\n");
        while (true)
        {
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    int num = 0;
                    Random r = new Random();
                    int res = r.Next(0,101);
                    while (num != res)
                    {
                        num = Convert.ToInt32(Console.ReadLine());
                        if (num > res)
                        {
                            Console.WriteLine("число должно быть меньше\n");
                            continue;
                        }
                        else if (num < res)
                        {
                            Console.WriteLine("число должно быть больше\n");
                            continue;
                        }
                        else
                            Console.WriteLine("Вы угадали число!\n");
                            break;
                    }
                    break;
                case 2:
                    table();
                    break;
                case 3:
                    while(true)
                        {
                            int number = Convert.ToInt32(Console.ReadLine());
                            for (int stage = 1; stage <= number; stage++)
                            {
                                if ((number%stage) == 0)
                                Console.Write(" {0} ",stage);
                            }
                            Console.Write("\n");
                            break;
                            }
                    break;

            }
        }
        }
    }
}