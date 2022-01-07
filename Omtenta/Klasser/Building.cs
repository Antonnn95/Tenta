using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta.Klasser
{
    public class Building
    {
        public Floor[] Floors { get; private set; }

        public Elevator elevator { get; set; }

        public Building(int numberOfFloors, int maxWeight)
        {
            Floors = new Floor[numberOfFloors];

            for (int i = 0; i < numberOfFloors; ++i)
            {
                Floor floor = new Floor(i);
                Floors[i] = floor;
            }
            elevator = new Elevator(0, numberOfFloors - 1, maxWeight);
        }
    }
}
