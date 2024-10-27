using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.PlotInfo
{
    public static class LinePlot
    {
        public static List<Line> Plot = new List<Line>(); // created in static class for access across program
        public static EventHandler NewLine;

        public static void AddNewLine(Line line)
        {
            Plot.Add(line);
            OnNewLine(line, EventArgs.Empty);
        }

        private static void OnNewLine(object sender, EventArgs e)
        {
            NewLine?.Invoke(sender, e);
        }
    }
}
