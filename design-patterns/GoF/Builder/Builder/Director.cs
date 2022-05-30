﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        private Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            this.builder.MakeTitle("Greeting");
            this.builder.MakeString("朝から昼にかけて");
            this.builder.MakeItems(new string[]
            {
                "おはようございます。",
                "こんにちは。",
            });
            this.builder.MakeString("夜に");
            this.builder.MakeItems(new string[]
            {
                "こんばんは。",
                "おやすみなさい。",
                "さようなら。",
            });
            this.builder.Close();
        }
    }
}
