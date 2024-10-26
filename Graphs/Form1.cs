using Graphs.PlotInfo;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Graphs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Line.PlotUpdate += UpdatePlot_OnPlotUpddate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Line line in LinePlot.Plot)
                AddLineToPlot(line);
        }

        private void btn_EditGraph_Click(object sender, EventArgs e)
        {
            var graphEditor = new GraphEditor();
            graphEditor.Show();
        }


        // Event Subscriber
        private void UpdatePlot_OnPlotUpddate(object? sender, EventArgs e)
        {
            Line line = sender as Line;
            AddLineToPlot(line);
        }


        // Helper functions

        private void AddLineToPlot(Line line)
        {
            double[] xValues = line.AxisValues("X").ToArray();
            double[] yValues = line.AxisValues("Y").ToArray();
            
            fp_MainPlot.Plot.Add.Scatter(xValues, yValues);
            fp_MainPlot.Plot.Axes.AutoScale();
            fp_MainPlot.Refresh();
        }
    }
}
