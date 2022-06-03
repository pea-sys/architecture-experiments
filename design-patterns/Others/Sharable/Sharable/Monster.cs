using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharable
{
    public class Monster
    {
        private String name;
        private int pos;
        private static Hashtable database = new Hashtable();
        public static Monster CreateMonster(String name)
        {
            lock(database)
            {
                Monster creature = (Monster)database[name];
                if (creature == null)
                {
                    creature = new Monster(name);
                    database.Add(name, creature);
                }
                return creature;
            }
        }
        private Monster(String name) { this.name = name; }
        public void GoRight() { pos++; }
        public void GoLeft() { pos--; }
        public String GetName() { return name; }
        public int GetPos() { return pos; }
        public override string ToString() { return $"[{name} at {pos}]"; }
    }
}
