using Graphs.PlotInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sd = System.Drawing;
using gpi = Graphs.PlotInfo;

namespace Graphs
{
    public partial class GraphEditor : Form
    {
        public static event EventHandler LineUpdate;
        private Line? CurrentLine;

        // groups form elements for easier handling of element visibility
        private List<dynamic> NewLineControl;
        private List<dynamic> EditLineControl;
        private List<dynamic> AddPointControl;
        private List<dynamic> DeletePointControl;


        public GraphEditor()
        {
            InitializeComponent();

            NewLineControl = new List<dynamic>
            {
                lbl_LineName,
                tb_LineName,
                btn_AddLine
            };

            AddPointControl = new List<dynamic>
            {
                btn_AddPoint,
                lbl_XValue,
                lbl_YValue,
                tb_XValue,
                tb_YValue,
            };

            DeletePointControl = new List<dynamic>
            {
                btn_DeletePoint,
                lbl_PointIndex,
                tb_PointIndex,
            };

            EditLineControl = new List<dynamic>
            {
                dgv_LineInfo,
                btn_OpenAddPoint,
                btn_OpenDeletePoint,
                btn_CloseWindow
            };

            CurrentLine = null;

            LinePlot.NewLine += UpdateLines_OnNewline;
            Line.PlotUpdate += UpdateData_OnPlotUpdate;
            ms_Lines.CanOverflow = true;
        }

        private void GraphEditor_Load(object sender, EventArgs e)
        {
            bool windowState = LinePlot.Plot.Count > 0;

            if (windowState)
            {
                foreach (Line line in LinePlot.Plot)
                    CreateNewMenuItem(line);

                SetCurrentLine(LinePlot.Plot.First());
            }

            SetEditingControls(windowState);
        }

        private void btn_OpenAddPoint_Click(object sender, EventArgs e)
        {
            SetVisibility(AddPointControl, true);
            tb_XValue.Focus();
        }

        private void btn_OpenDeletePoint_Click(object sender, EventArgs e)
        {
            SetVisibility(DeletePointControl, true);
            tb_PointIndex.Focus();
        }

        private void btn_OpenAddLine_Click(object sender, EventArgs e)
        {
            SetVisibility(NewLineControl, true);
            tb_LineName.Focus();
        }

        private void btn_AddPoint_Click(object sender, EventArgs e)
        {
            // Check for empty values
            if (tb_XValue.Text.Trim() == "" || tb_YValue.Text.Trim() == "")
                return;

            // Get parsed values
            double xValue = 0;
            double yValue = 0;
            bool canParseX = double.TryParse(tb_XValue.Text, out xValue);
            bool canParseY = double.TryParse(tb_YValue.Text, out yValue);

            if (!(canParseX && canParseY))
                return;

            int index = CurrentLine.Points.Count + 1;
            gpi.Point point = new gpi.Point(index, xValue, yValue);
            CurrentLine.AddPoint(point);

            tb_XValue.Text = "";
            tb_YValue.Text = "";
            this.ActiveControl = null;
        }

        private void btn_DeletePoint_Click(object sender, EventArgs e)
        {
            // Check for empty values
            if (tb_PointIndex.Text.Trim() == "")
                return;

            // Get parsed values
            int indexValue = 0;
            bool canParseIndex = int.TryParse(tb_PointIndex.Text, out indexValue);

            if (!canParseIndex)
                return;

            gpi.Point? foundPoint = CurrentLine.Points.Find(point => point.Index == indexValue);
            if (foundPoint == null)
                return;
            CurrentLine.RemovePoint(foundPoint);

            tb_PointIndex.Text = "";
            this.ActiveControl = null;
        }

        private void btn_AddLine_Click(object sender, EventArgs e)
        {
            string lineName = tb_LineName.Text.Trim();

            // Check for empty values
            if (lineName == "")
                return;

            // Check for values that already exist
            if (LinePlot.Plot.Any(line => line.Name == lineName))
                return;

            tb_LineName.Text = "";
            SetVisibility(NewLineControl, false);

            LinePlot.AddNewLine(new Line(lineName));
        }


        // Event subscribers

        private void UpdateLines_OnNewline(object? sender, EventArgs e)
        {
            Line line = sender as Line;
            CreateNewMenuItem(line);
            SetCurrentLine(line);
        }

        private void UpdateData_OnPlotUpdate(object? sender, EventArgs e)
        {
            dgv_LineInfo.DataSource = null;
            dgv_LineInfo.DataSource = CurrentLine.Points
                .OrderBy(point => point.Index)
                .ToList();
        }

        private void btn_CloseWindw_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Helper functions

        private void CreateNewMenuItem(Line line) // Creates tabs for top bar
        {
            ToolStripMenuItem lineItem = new ToolStripMenuItem(line.Name);
            lineItem.Overflow = ToolStripItemOverflow.AsNeeded;
            lineItem.Click += UpdateCurrentLine;
            ms_Lines.Items.Add(lineItem);

            SetEditingControls(true);
        }

        private void UpdateCurrentLine(object? sender, EventArgs e)
        {
            ToolStripMenuItem lineItem = sender as ToolStripMenuItem;
            string lineName = lineItem.Text;

            SetCurrentLine(LinePlot.Plot.Find(line => line.Name == lineName));
        }

        private void SetCurrentLine(Line line)
        {
            CurrentLine = line;
            lbl_CurrentLine.Text = $"Current Line: {CurrentLine.Name}";
            dgv_LineInfo.DataSource = CurrentLine.Points
                .OrderBy(point => point.Index)
                .ToList();
        }

        private void SetEditingControls(bool isEditable) // controls when certain elements should be displayed
        {
            MoveNewLineControl(isEditable);
            SetVisibility(EditLineControl, isEditable);
            SetVisibility(AddPointControl, false);
            SetVisibility(DeletePointControl, false);
            SetVisibility(NewLineControl, false);
        }

        private void SetVisibility(List<dynamic> elements, bool visibility) // used to simplify visibility controls
        {
            foreach (dynamic element in elements)
            {
                element.Visible = visibility;
                element.Enabled = visibility;
            }
        }

        private void MoveNewLineControl(bool windowState)
        {
            if (windowState)
            {
                // Positions for adding line when at least one line is present
                btn_OpenAddLine.Location = new sd.Point(609, 340);
                lbl_LineName.Location = new sd.Point(609, 284);
                tb_LineName.Location = new sd.Point(609, 307);
                btn_AddLine.Location = new sd.Point(609, 340);
            }
            else
            {
                // Positions for adding line when no lines are present
                btn_OpenAddLine.Location = new sd.Point(13, 73);
                lbl_LineName.Location = new sd.Point(13, 105);
                tb_LineName.Location = new sd.Point(13, 128);
                btn_AddLine.Location = new sd.Point(13, 161);
            }
        }
    }
}
