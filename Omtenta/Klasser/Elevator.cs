using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta.Klasser
{
    public class Elevator
    {
        private int TopFloor;
        private int Bottomfloor;
        private int maxWeight;
        public List<ITransportable> Transportables { get; private set; }
        public int FloorNumber { get; private set; }
        

        public Elevator(int bottomFloor, int topFloor, int maxweight)
        {
            this.Bottomfloor = bottomFloor;
            this.TopFloor = topFloor;
            FloorNumber = bottomFloor;
            this.maxWeight = maxweight;
            Transportables = new List<ITransportable>();
        }

        public void MoveDown()
        {
            
            if (IsOverLoaded())
            {
                if (FloorNumber != Bottomfloor)
                {
                    --FloorNumber;
                    Console.WriteLine($"Våning {FloorNumber}");
                }
                else
                {
                    Console.WriteLine("Hissen är redan på lägsta våningen, kan inte gå lägre. ");
                }
            }
            else
            {
                Console.WriteLine("Hissen är överfull, någon får gå av");
            }
            
        }

        public void MoveUp()
        {
            
            if (IsOverLoaded())
            {
                if (FloorNumber != TopFloor)
                {
                    ++FloorNumber;
                    Console.WriteLine($"Våning {FloorNumber}");
                }
                else
                {
                    Console.WriteLine("Hissen är redan på lägsta våningen, kan inte gå lägre. ");
                }
            }
            else
            {
                Console.WriteLine("Hissen är överfull, någon får gå av");
            }
        }

        public int GetWeight()
        {
            int weight = 0;
            for (int i = 0; i < Transportables.Count; ++i)
            {
                weight += Transportables[i].GetWeight(); 
            }
            

            return weight;
        }

        public bool IsOverLoaded()
        {
            return GetWeight() > maxWeight;
        }

        public void AddLoad(ITransportable transportable)
        {
            Transportables.Add(transportable); 
        }
    }
}
