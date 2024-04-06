using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class FuelTank
    {
        private int capacity;
        private int amount;

        public FuelTank(int capacity)
        {
            this.capacity = capacity;
        }
        public void fill(int amount)
        {
            if (amount < capacity)
            {
                this.amount = amount;
            }
            else
            {
                this.amount = capacity;
            }
        }
        public int GetAmount(int GetAmount)
        {
            return GetAmount;
        }
        public int GetLevel() {

            return amount / (capacity / 100); 
           }
    }
}
