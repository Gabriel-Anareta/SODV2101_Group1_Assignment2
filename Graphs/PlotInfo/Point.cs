using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.PlotInfo
{
    public class Point
    {
        public double X_Value { get; private set; } 
        public double Y_Value { get; private set; }

        public Point(double x, double y) 
        {
            X_Value = x;
            Y_Value = y;
        }

        public void SetValues(double x, double y)
        {
            X_Value = x;
            Y_Value = y;
        }
    }
}
