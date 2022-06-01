using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monostate
{
    internal class MonostateTheme
    {
        private static String theme = "classic";
        public String GetTheme()
        {
            return theme;
        }
        public void SetTheme(String theme)
        {
            MonostateTheme.theme = theme;
        }
    }
}
