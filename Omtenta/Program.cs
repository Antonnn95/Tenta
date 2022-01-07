using Omtenta.Klasser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFloors = 7;
        start: Building building = new Building(numberOfFloors, 200);
            int floor;
            Person Erik = new Person(70);
            Person Sara = new Person(50);
            Furnature Chair = new Furnature(60);
            Furnature Soffa = new Furnature(100);
            building.elevator.AddLoad(Erik);
            building.elevator.AddLoad(Sara);
            building.elevator.AddLoad(Chair);
            building.elevator.AddLoad(Soffa);

            while (true)
            {
                try
                {
                    Console.WriteLine("Vilken våning?");
                    floor = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine("Skriv talet med en siffra, tack.");

                }

            }
            while (true)
            {
                if (floor > -1 && floor < 7)
                {
                    building.elevator.GetWeight();
                    if (floor < building.elevator.FloorNumber && building.elevator.IsOverLoaded() == false)
                    {
                        building.elevator.MoveDown();
                    }
                    else if (floor > building.elevator.FloorNumber && building.elevator.IsOverLoaded() == false)
                    {
                        building.elevator.MoveUp();
                    }
                    else if (floor == building.elevator.FloorNumber)
                    {
                        Console.WriteLine($"Framme på våning {floor}");
                        break;
                    }
                    else if (building.elevator.IsOverLoaded())
                    {
                        Console.WriteLine("För mycket vikt på hissen, lasta av något");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Våning {floor} finns ej, prova igen");
                    goto start;
                }


            }



        }

        private static void Uppgift8()
        {
            Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 20; ++i)
            {
                list.Add(random.Next(1000));
            }

            GetSmallestNumber(list);
        }

        private static void uppgift3()
        {
            Random random = new Random();
            int[] numbers = new int[20];
            int numberOfFoursAndFives = 0;
            for (int i = 0; i < 20; ++i)
            {
                numbers[i] = random.Next(10);
            }

            for (int i = 0; i < numbers.Length; ++i)
            {

                if (numbers[i] == 4 || numbers[i] == 5)
                {
                    ++numberOfFoursAndFives;
                }
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine($"Talen fyra och fem finns med i {numberOfFoursAndFives} element");
        }

        public static void GetSmallestNumber(List<int> list)
        {
            int smallest = int.MaxValue;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i] < smallest)
                {
                    smallest = list[i];
                    list.RemoveAt(i);
                    Console.WriteLine($"Det nya minsta numret är: {smallest}");
                }
                else
                {
                    Console.WriteLine($"Det minsta numret är: {smallest}");
                }


            }
        }
    }
}
