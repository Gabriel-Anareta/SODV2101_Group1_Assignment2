namespace Graphs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_EditGraph = new Button();
            fp_MainPlot = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // btn_EditGraph
            // 
            btn_EditGraph.Location = new Point(87, 409);
            btn_EditGraph.Name = "btn_EditGraph";
            btn_EditGraph.Size = new Size(94, 29);
            btn_EditGraph.TabIndex = 1;
            btn_EditGraph.Text = "Edit Graph";
            btn_EditGraph.UseVisualStyleBackColor = true;
            btn_EditGraph.Click += btn_EditGraph_Click;
            // 
            // fp_MainPlot
            // 
            fp_MainPlot.DisplayScale = 1.25F;
            fp_MainPlot.Location = new Point(51, 42);
            fp_MainPlot.Name = "fp_MainPlot";
            fp_MainPlot.Size = new Size(688, 342);
            fp_MainPlot.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fp_MainPlot);
            Controls.Add(btn_EditGraph);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_EditGraph;
        private Button btn_DeleteRow;
        private ScottPlot.WinForms.FormsPlot fp_MainPlot;
    }
}
