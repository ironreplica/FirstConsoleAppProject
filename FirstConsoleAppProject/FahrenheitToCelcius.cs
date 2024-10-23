using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleAppProject
{
    internal class FahrenheitToCelcius
    {
        public int FtoC(int f)
        {
            return (int)MathF.Round(((f - 32) * 5) / 9);
        }
    }
}
