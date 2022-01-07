using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta.Klasser
{
    public class Person : ITransportable
    {
        private int Weight;

        public Person(int weight)
        {
            this.Weight = weight;
        }

        public int GetWeight()
        {
            return Weight;
        }
    }
}
