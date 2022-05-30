using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class TextBuilder : Builder
    {
        private StringBuilder sb = new StringBuilder();
        public override void MakeTitle(string title)
        {
            sb.AppendLine("==============================");
            sb.AppendLine($"『" + title + "』");
            sb.AppendLine();
        }

        public override void MakeString(string str)
        {
            sb.AppendLine($"■" + str);
            sb.AppendLine();
        }

        public override void MakeItems(string[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                sb.AppendLine($"　・" + items[i]);
            }
            sb.AppendLine();
        }

        public override void Close()
        {
            sb.AppendLine("==============================");
        }
        public string Result
        {
            get { return sb.ToString(); }
        }
    }
}
