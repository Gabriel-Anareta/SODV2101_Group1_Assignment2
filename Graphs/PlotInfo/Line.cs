using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.PlotInfo
{
    public class Line
    {
        public List<Point> Points;
        public static event EventHandler PlotUpdate;    // Raised whenever a line is updated

        public Line()
        {
            Points = new List<Point>();
        }

        public void AddPoint(Point point)
        {
            Points.Add(point);
            OnPlotUpdate(this, EventArgs.Empty);
        }

        public void SetPoints(List<Point> points)
        {
            Points = points;
            OnPlotUpdate(this, EventArgs.Empty);
        }

        private void OnPlotUpdate(object sender, EventArgs e)
        {
            PlotUpdate?.Invoke(sender, e);
        }

        public List<double> AxisValues(string axis)
        {
            List<double> values = new List<double>();

            foreach (Point point in Points)
            {
                if (axis == "X")
                    values.Add(point.X_Value);
                else
                    values.Add(point.Y_Value);
            }

            return values;
        }
    }
}
