using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.PlotInfo
{
    public class Point
    {
        public int Index { get; private set; }
        public double X_Value { get; private set; } 
        public double Y_Value { get; private set; }

        public Point(int index, double x, double y) 
        {
            Index = index;
            X_Value = x;
            Y_Value = y;
        }

        public void SetValues(int index, double x, double y)
        {
            Index = index;
            X_Value = x;
            Y_Value = y;
        }
    }
}
