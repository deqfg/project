using System.ComponentModel;

namespace Практическая__3
{
    internal class Program
    {
        
        static int[] onearray = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
        
        
        static int[] twoarray = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
        static int duration = 250;
    static void Main() 
        {


            Console.WriteLine("Выбор октавы F5 - F6");
            Console.WriteLine("Escape - Конец программы. ");
            while (true)
            {
                ConsoleKeyInfo Octave = Console.ReadKey();
                if (Octave.Key == ConsoleKey.F5)
                {
                    SoundFour();
                }
                else if (Octave.Key == ConsoleKey.F6)
                {
                    SoundFive();

                }
                
                else if (Octave.Key == ConsoleKey.Escape)
                {

                }
                break;
            }

        }

        

        static void SoundFour()
        {
            Console.WriteLine("Четвертая октава");
            Console.WriteLine("Escape - Выход");
            Console.WriteLine("F6 - Пятая октава");
            while (true)
            {
               
                switch (Console.ReadKey().Key)
            
                {
                    case ConsoleKey.A:
                        Console.Beep(onearray[0], duration);
                        break;
                    case ConsoleKey.Q:
                        Console.Beep(onearray[1], duration);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(onearray[2], duration);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(onearray[3], duration);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(onearray[4], duration);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(onearray[5], duration);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(onearray[6], duration);
                        break;
                    case ConsoleKey.R:
                        Console.Beep(onearray[7], duration);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(onearray[8], duration);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(onearray[9], duration);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(onearray[10], duration);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(onearray[11], duration);
                        break;
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.F6:
                        SoundFive();
                        return;
                       


                        
 

              



                }



            }
        }
        static void SoundFive()
        {
            Console.WriteLine("Пятая октава");
            Console.WriteLine("Escape - Выход");
            Console.WriteLine("F5 - Четвертая октава");

            while (true)
           {


                switch (Console.ReadKey().Key)

                {
                    case ConsoleKey.A:
                        Console.Beep(twoarray[0], duration);
                        break;
                    case ConsoleKey.Q:
                        Console.Beep(twoarray[1], duration);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(twoarray[2], duration);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(twoarray[3], duration);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(twoarray[4], duration);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(twoarray[5], duration);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(twoarray[6], duration);
                        break;
                    case ConsoleKey.R:
                        Console.Beep(twoarray[7], duration);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(twoarray[8], duration);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(twoarray[9], duration);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(twoarray[10], duration);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(twoarray[11], duration);
                        break;
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.F5:
                        SoundFour();
                        return;




           }    }

        }
    }
}