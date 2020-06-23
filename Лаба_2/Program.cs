using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Лаба_2
{
    public class models
    {
        public models()
        {

        }
        public models(string name, double displacement, double speed)  //название, водоимещение (т), скорость
        {
            Console.WriteLine("");
            Console.WriteLine("название: " + name);
            Console.WriteLine("водоимещениe: " + displacement + " Т");
            Console.WriteLine("скорость: " + speed + " узлов");
            Console.WriteLine("Вы создали судно");
        }
        public models(string name, double displacement, double speed, double width)  //название, водоимещение (т), скорость, высота
        {
            Console.WriteLine("");
            Console.WriteLine("название: " + name);
            Console.WriteLine("водоимещениe: " + displacement + " Т");
            Console.WriteLine("скорость: " + speed + " узлов");
            Console.WriteLine("ширину: " + width + "м");
            Console.WriteLine("Вы создали судно");
        }
        public models(string name, double displacement, double speed, double width, double length)  //название, водоимещение (т), скорость, высота, длина
        {
            Console.WriteLine("");
            Console.WriteLine("Вы создали судно: ");
            Console.WriteLine("название: " + name);
            Console.WriteLine("водоимещениe: " + displacement + " Т");
            Console.WriteLine("скорость: " + speed + " узлов");
            Console.WriteLine("ширинa: " + width + " м");
            Console.WriteLine("длиннa: " + length + " м");
        }



    }

    public class Ships
    {
        public static void Main(string[] args)
        {
            byte menu = 0;

            byte serialNumberShip = 1;

            int ns = 0;
            int n = 0;

            string name = "";
            double displacement = 0;
            double speed = 0;
            double width = 0;
            double length = 0;

            //int dopShip = 0;
            Console.Write("Введите кольчество создаваемых вами кораблей:\t");
            int NumShip = int.Parse(Console.ReadLine());
            double[] ShipsD = new double[NumShip * 4];
            string[] ShipsS = new string[NumShip];

            byte x = 0;
            while (true)
            {
                if (x != 0)
                {
                    Console.Clear();
                    Console.WriteLine("1: Просмотр существующих");
                    Console.WriteLine("2: Выход");
                    Console.WriteLine("3: Не активна");
                    menu = byte.Parse(Console.ReadLine());

                    if (menu == 1)
                    {
                        byte ix = 0;
                        byte r = 0;
                        byte i = 0;
                        for (; r < NumShip; r++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(serialNumberShip + "-й корaбль");
                            serialNumberShip++;

                            Console.WriteLine("Название: " + ShipsS[ix]);
                            ix++;
                            Console.WriteLine("Водоимещения (Т): " + ShipsD[i]);
                            i++;
                            Console.WriteLine("Скорость (узлов): " + ShipsD[i]);
                            i++;
                            Console.WriteLine("Ширина (м): " + ShipsD[i]);
                            i++;
                            Console.WriteLine("Длинна (м): " + ShipsD[i]);
                            i++;
                            
                        }
                    }
                    else if (menu == 2)
                    {
                        Environment.Exit(0);
                    }

                    if(menu == 3)
                    {
                        Environment.Exit(0);
                    }
                }

                x++;

                #region создание кораблей
                for (int i = 0; i < NumShip; i++)
                {
                    if (i != 0)
                    {
                        Console.WriteLine("");
                        ns++;
                    }

                    Console.Write("Введите название: ");
                    name = Console.ReadLine();
                    ShipsS[ns] = name;

                    Console.Write("Введите водоимещения (Т): ");
                    displacement = double.Parse(Console.ReadLine());
                    ShipsD[n] = displacement;
                    n++;
                    Console.Write("Введите значение скорости (узлов): ");
                    speed = double.Parse(Console.ReadLine());
                    ShipsD[n] = speed;
                    n++;
                    Console.Write("Введите ширину (м): ");
                    width = double.Parse(Console.ReadLine());
                    ShipsD[n] = width;
                    n++;
                    Console.Write("Введите длинну (м): ");
                    length = double.Parse(Console.ReadLine());
                    ShipsD[n] = length;
                    n++;
                    models parametrs = new models(name, displacement, speed, width, length);
                }
            }
            #endregion

        }
    }

    #region Наследование
    public class inheritable
    {

    }

    class heir : inheritable
    {

    }
    #endregion
}