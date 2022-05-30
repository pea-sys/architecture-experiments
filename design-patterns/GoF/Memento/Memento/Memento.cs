using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Memento
    {
        private int money;
        private IList<string> fruits = new List<string>();
        public int GetMoney()
        {
            return money;
        }
        public Memento(int money)
        {
            this.money = money;     
            this.fruits = new List<string>();
        }
        public void AddFruit(string fruit)
        {
            fruits.Add(fruit);
        }
        public IList<string> GetFruits()
        {
            return fruits;
        }

    }
}
