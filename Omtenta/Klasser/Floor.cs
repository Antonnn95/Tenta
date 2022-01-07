using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta.Klasser
{
    public class Floor
    {
        public int FloorNumber { get; private set; }

        public Floor(int floorNumber)
        {
            this.FloorNumber = floorNumber;
        }
    }
}
