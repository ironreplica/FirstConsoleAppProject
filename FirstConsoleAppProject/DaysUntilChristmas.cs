using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleAppProject
{
    internal class DaysUntilChristmas
    {
        public string daysUntilChristmas() {
            DateTime today = DateTime.Today;
            DateTime christmas = new DateTime(today.Year, 12, 25);
            
            return $"Days until Christmas: {christmas.Subtract(today).Days.ToString()}";

        }
    }
}
