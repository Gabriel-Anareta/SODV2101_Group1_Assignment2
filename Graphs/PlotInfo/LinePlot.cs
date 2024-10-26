using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.PlotInfo
{
    public class LinePlot
    {
        private List<Point> Points;
        public static event EventHandler PlotUpdate;

        public LinePlot()
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
    }
}
