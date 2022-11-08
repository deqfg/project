
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pr2
{





    internal class Program
    {
        static void table()
        {
            int[,]tab=new int[10,10];
            for(int n = 1;n<tab.Length;n++)
            {
                Console.Write($"\t{n}");
                for(int d = 1;d<tab.Length;d++)
                {
                    Console.Write("\t"+ n*d);

                }
            }
            Console.Write("\n");
        }

        
        static void Main()
        {
            Console.WriteLine("1.угадай число \n\t2.таблица умн.\n\t3. делители числа\n\t");
            int ak;
            while (true)
            {
                ak=Convert.ToInt32(Console.ReadLine());
                switch(ak)
                {
                    case 1:
                   
                    Random r =new Random();
                    int res = r.Next(0,101);
                    while (true)
                    {
                        int num;
                        num =Convert.ToInt32(Console.ReadLine());
                        if(num>res)
                        {
                            Console.WriteLine("число должно быть меньше");
                            continue;

                        }
                        else if(num<res)
                        {
                          Console.WriteLine("число должно быть больше");
                          continue;
  
                        }
                        else
                        Console.WriteLine("вы угадали");
                        break;
                    }
                     break;
                     case 2:
                     table();
                     break;
                     
                     case 3:
                      
                                int main_N = Convert.ToInt32(Console.ReadLine());
                                for (int stage = 1; stage <= main_N; stage++)
                                {
                                    if ((main_N%stage) == 0)
                                    Console.Write(" - {0} - ",stage);
                                }
                            Console.Write("\n");
                            break;
                            case 4:
                            Environment.Exit(0);
                            break; 

                }
            }
    
       }
    }
} 
