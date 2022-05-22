﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Directory : Entry
    {
        private string name;
        private List<Entry> directory = new List<Entry>();
        public Directory(string someName)
        {
            this.name = someName;
        }
        public override string GetName()
        {
            return name;
        }
        public override int GetSize()
        {
            int size = directory.Sum(x => x.GetSize());
            return size;
        }
        public override Entry Add(Entry entry)
        {
            directory.Add(entry);
            return this;
        }
        public override void PrintList(string prefix)
        {
            Console.WriteLine($"{prefix}/{this}");
            foreach(Entry entry in directory)
            {
                entry.PrintList($"{prefix}/{name}");
            }
        }
    }
}
