using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.PlotInfo
{
    public class Line
    {
        public string Name { get; set; }
        public List<Point> Points { get; set; }
        public static event EventHandler PlotUpdate;    // Raised whenever a line is updated

        public Line(string name)
        {
            Name = name;
            Points = new List<Point>();
        }

        public void AddPoint(Point point)
        {
            Points.Add(point);
            SortPoints(Points);
            OnPlotUpdate(this, EventArgs.Empty);
        }

        public void SetPoints(List<Point> points)
        {
            Points = points;
            OnPlotUpdate(this, EventArgs.Empty);
        }

        public void RemovePoint(Point point)
        {
            Points.Remove(point);
            Points = SetPointIndecies(Points);
            OnPlotUpdate(this, EventArgs.Empty);
        }

        private void OnPlotUpdate(object sender, EventArgs e)
        {
            PlotUpdate?.Invoke(sender, e);
        }

        public List<double> AxisValues(string axis)
        {
            List<double> values = new List<double>();
            List<Point> points = Points
                .OrderBy(point => point.Index)
                .ToList();

            foreach (Point point in points)
            {
                if (axis == "X")
                    values.Add(point.X_Value);
                if (axis == "Y")
                    values.Add(point.Y_Value);
            }

            return values;
        }

        private List<Point> SortPoints(List<Point> points)
        {
            points = points
                .OrderBy(point => point.X_Value)
                .ToList();

            points = SetPointIndecies(points);

            return points;
        }

        private List<Point> SetPointIndecies(List<Point> points)
        {
            for (int i = 0; i < points.Count; i++)
                points[i].SetValues(i + 1, points[i].X_Value, points[i].Y_Value);

            return points;
        }
    }
}
