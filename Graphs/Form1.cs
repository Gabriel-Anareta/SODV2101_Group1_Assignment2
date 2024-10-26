using Graphs.PlotInfo;
using ScottPlot;
using static System.Runtime.InteropServices.JavaScript.JSType;
using gpi = Graphs.PlotInfo;

namespace Graphs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GraphEditor.LineUpdate += UpdatePlot_OnLineUpddate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (gpi.Line line in LinePlot.Plot)
                AddLineToPlot(line);
        }

        private void btn_EditGraph_Click(object sender, EventArgs e)
        {
            var graphEditor = new GraphEditor();
            graphEditor.Show();
        }


        // Event Subscriber
        private void UpdatePlot_OnLineUpddate(object? sender, EventArgs e)
        {
            gpi.Line line = sender as gpi.Line;
            AddLineToPlot(line);

        }


        // Helper functions

        private void AddLineToPlot(gpi.Line line)
        {
            double[] xValues = line.AxisValues("X").ToArray();
            double[] yValues = line.AxisValues("Y").ToArray();
            
            fp_MainPlot.Plot.Add.Scatter(xValues, yValues);
            fp_MainPlot.Plot.Axes.AutoScale();
            fp_MainPlot.Refresh();
        }

        private void UpdatePlot()
        {
            fp_MainPlot.Plot.Clear();
            foreach(gpi.Line line in LinePlot.Plot)
            {
                double[] xValues = line.AxisValues("X").ToArray();
                double[] yValues = line.AxisValues("Y").ToArray();
                fp_MainPlot.Plot.Add.Scatter(xValues, yValues);
            }

            fp_MainPlot.Plot.Axes.AutoScale();
            fp_MainPlot.Refresh();
        }
    }
}
