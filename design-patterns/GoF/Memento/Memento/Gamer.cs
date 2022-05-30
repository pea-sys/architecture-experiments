using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Gamer
    {
        private int money;
        private IList<string> fruits = new List<string>();
        private Random random = new Random();
        private static string[] fruitsname = { "リンゴ", "ぶどう", "バナナ", "みかん" };

        public Gamer(int money)
        {
            this.money = money;
        }
        public int GetMoney()
        {
            return money;
        }
        public void Bet()
        {
            int dice = random.Next(1, 6);
            switch (dice)
            {
                case 1:
                    money += 100;
                    Console.WriteLine("所持金が増えました。");
                    break;
                case 2:
                    money /= 2;
                    Console.WriteLine("所持金が半分になりました。");
                    break;
                case 6:
                    string fruit = GetFruit();
                    Console.WriteLine("フルーツをもらいました。");
                    fruits.Add(fruit);
                    break;
                default:
                    Console.WriteLine("何も起こりませんでした。");
                    break;
            }
        }
        public Memento CreateMemento()
        {
            Memento memento = new Memento(money);
            fruits.Where(fruit => fruit.StartsWith("おいしい")).ToList().
                ForEach(deliciousFruit => memento.AddFruit(deliciousFruit));
            return memento;
        }
        public void RestoreMemento(Memento memento)
        {
            money = memento.GetMoney();
            fruits = memento.GetFruits();
        }

        public override string ToString()
        {
            return $"[money = {money.ToString()}, fruits = {string.Join(",",fruits)}]";
        }
        public string GetFruit()
        {
            string prefix = String.Empty;
            if (random.Next(1)==1)
            {
                prefix = "おいしい";
            }
            return prefix + fruitsname[random.Next(fruitsname.Length - 1)];
        }
    }
}
