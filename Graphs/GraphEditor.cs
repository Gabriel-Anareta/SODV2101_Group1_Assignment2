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

namespace Graphs
{
    public partial class GraphEditor : Form
    {
        private Line? CurrentLine;

        public GraphEditor()
        {
            InitializeComponent();

            CurrentLine = null;

            LinePlot.NewLine += UpdateLines_OnNewline;
            ms_Lines.CanOverflow = true;
            /*// Create a new ContextMenuStrip control.
            fruitContextMenuStrip = new ContextMenuStrip();

            // Attach an event handler for the 
            // ContextMenuStrip control's Opening event.
            *//*fruitContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(cms_Opening);*//*

            // Create a new ToolStrip control.
            ToolStrip ts = new ToolStrip();

            // Create a ToolStripDropDownButton control and add it
            // to the ToolStrip control's Items collections.
            ToolStripDropDownButton fruitToolStripDropDownButton = new ToolStripDropDownButton("Fruit", null, null, "Fruit");
            ts.Items.Add(fruitToolStripDropDownButton);

            // Dock the ToolStrip control to the top of the form.
            ts.Dock = DockStyle.Top;

            // Assign the ContextMenuStrip control as the 
            // ToolStripDropDownButton control's DropDown menu.
            fruitToolStripDropDownButton.DropDown = fruitContextMenuStrip;

            // Create a new MenuStrip control and add a ToolStripMenuItem.
            MenuStrip ms = new MenuStrip();
            ToolStripMenuItem fruitToolStripMenuItem = new ToolStripMenuItem("Fruit", null, null, "Fruit");
            *//*ms.Items.Add(fruitToolStripMenuItem);*//*
            ms.Items.Add();

            // Dock the MenuStrip control to the top of the form.
            ms.Dock = DockStyle.Top;

            // Assign the MenuStrip control as the 
            // ToolStripMenuItem's DropDown menu.
            //fruitToolStripMenuItem.DropDown = fruitContextMenuStrip;

            // Assign the ContextMenuStrip to the form's 
            // ContextMenuStrip property.
            *//*this.ContextMenuStrip = fruitContextMenuStrip;*//*

            // Add the ToolStrip control to the Controls collection.
            this.Controls.Add(ts);

            //Add a button to the form and assign its ContextMenuStrip.
            Button b = new Button();
            b.Location = new System.Drawing.Point(60, 60);
            this.Controls.Add(b);
            b.Click += b_Click;
            b.ContextMenuStrip = fruitContextMenuStrip;

            // Add the MenuStrip control last.
            // This is important for correct placement in the z-order.
            this.Controls.Add(ms);*/
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

        private void btn_AddPoint_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeletePoint_Click(object sender, EventArgs e)
        {

        }

        private void btn_SaveLine_Click(object sender, EventArgs e)
        {

        }

        private void btn_OpenAddLine_Click(object sender, EventArgs e)
        {
            AddLineVisibility(true);
        }

        private void btn_AddLine_Click(object sender, EventArgs e)
        {
            string lineName = tb_LineName.Text.Trim();
            if (lineName == "")
                return;

            tb_LineName.Text = "";
            AddLineVisibility(false);

            LinePlot.AddNewLine(new Line(lineName));
        }


        private void UpdateLines_OnNewline(object? sender, EventArgs e)
        {
            Line line = sender as Line;
            CreateNewMenuItem(line);
            SetCurrentLine(line);
        }


        // Helper functions

        private void CreateNewMenuItem(Line line)
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
            dgv_LineInfo.DataSource = CurrentLine.Points;
        }

        private void SetEditingControls(bool isEditable)
        {
            EditLineVisibility(isEditable);
            AddLineVisibility(false);
        }

        private void AddLineVisibility(bool visibility)
        {
            lbl_LineName.Visible = visibility;
            tb_LineName.Visible = visibility;
            tb_LineName.Enabled = visibility;
            btn_AddLine.Visible = visibility;
            btn_AddLine.Enabled = visibility;
        }

        private void EditLineVisibility(bool visibility)
        {
            dgv_LineInfo.Visible = visibility;
            dgv_LineInfo.Enabled = visibility;
            btn_AddPoint.Visible = visibility;
            btn_AddPoint.Enabled = visibility;
            btn_DeletePoint.Visible = visibility;
            btn_DeletePoint.Enabled = visibility;
            btn_SaveLine.Visible = visibility;
            btn_SaveLine.Enabled = visibility;

            if (visibility)
            {
                btn_OpenAddLine.Location = new System.Drawing.Point(298, 218);
                lbl_LineName.Location = new System.Drawing.Point(298, 250);
                tb_LineName.Location = new System.Drawing.Point(298, 273);
                btn_AddLine.Location = new System.Drawing.Point(298, 306);
            }
            else
            {
                btn_OpenAddLine.Location = new System.Drawing.Point(13, 73);
                lbl_LineName.Location = new System.Drawing.Point(13, 105);
                tb_LineName.Location = new System.Drawing.Point(13, 128);
                btn_AddLine.Location = new System.Drawing.Point(13, 161);
            }
        }
    }
}
