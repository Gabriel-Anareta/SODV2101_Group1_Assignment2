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
            GraphEditor.LineUpdate += UpdatePlot_OnPlotUpddate;
            gpi.Line.PlotUpdate += UpdatePlot_OnPlotUpddate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdatePlot();
        }

        private void btn_EditGraph_Click(object sender, EventArgs e)
        {
            var graphEditor = new GraphEditor();
            graphEditor.Show();
        }

        private void btn_RefreshGraph_Click(object sender, EventArgs e)
        {
            UpdatePlot();
        }


        // Event Subscriber
        private void UpdatePlot_OnPlotUpddate(object? sender, EventArgs e)
        {
            UpdatePlot();
        }


        // Helper functions

        private void UpdatePlot()
        {
            fp_MainPlot.Plot.Clear();
            foreach (gpi.Line line in LinePlot.Plot)
            {
                double[] xValues = line.AxisValues("X").ToArray();
                double[] yValues = line.AxisValues("Y").ToArray();
                var scatter = fp_MainPlot.Plot.Add.Scatter(xValues, yValues);
                scatter.LegendText = line.Name;
            }

            fp_MainPlot.Plot.Axes.AutoScale();
            fp_MainPlot.Refresh();
        }
    }
}
