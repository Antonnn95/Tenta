using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta.Klasser
{
    public class Furnature : ITransportable
    {
        private int Weight;

        public Furnature(int weight)
        {
            this.Weight = weight;
        }

        public int GetWeight()
        {
            return Weight;
        }
    }
}
