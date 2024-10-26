namespace Graphs
{
    partial class GraphEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_AddLine = new Button();
            dgv_LineInfo = new DataGridView();
            ms_Lines = new MenuStrip();
            btn_AddPoint = new Button();
            btn_DeletePoint = new Button();
            btn_SaveLine = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_LineInfo).BeginInit();
            SuspendLayout();
            // 
            // btn_AddLine
            // 
            btn_AddLine.Location = new Point(298, 218);
            btn_AddLine.Name = "btn_AddLine";
            btn_AddLine.Size = new Size(100, 29);
            btn_AddLine.TabIndex = 1;
            btn_AddLine.Text = "New Line";
            btn_AddLine.UseVisualStyleBackColor = true;
            btn_AddLine.Click += btn_AddLine_Click;
            // 
            // dgv_LineInfo
            // 
            dgv_LineInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_LineInfo.Location = new Point(12, 38);
            dgv_LineInfo.Name = "dgv_LineInfo";
            dgv_LineInfo.RowHeadersWidth = 51;
            dgv_LineInfo.Size = new Size(233, 330);
            dgv_LineInfo.TabIndex = 2;
            // 
            // ms_Lines
            // 
            ms_Lines.ImageScalingSize = new Size(20, 20);
            ms_Lines.Location = new Point(0, 0);
            ms_Lines.Name = "ms_Lines";
            ms_Lines.Size = new Size(424, 24);
            ms_Lines.TabIndex = 3;
            ms_Lines.Text = "menuStrip1";
            // 
            // btn_AddPoint
            // 
            btn_AddPoint.Location = new Point(298, 38);
            btn_AddPoint.Name = "btn_AddPoint";
            btn_AddPoint.Size = new Size(100, 29);
            btn_AddPoint.TabIndex = 4;
            btn_AddPoint.Text = "Add Point";
            btn_AddPoint.UseVisualStyleBackColor = true;
            // 
            // btn_DeletePoint
            // 
            btn_DeletePoint.Location = new Point(298, 73);
            btn_DeletePoint.Name = "btn_DeletePoint";
            btn_DeletePoint.Size = new Size(100, 29);
            btn_DeletePoint.TabIndex = 5;
            btn_DeletePoint.Text = "Delete Point";
            btn_DeletePoint.UseVisualStyleBackColor = true;
            // 
            // btn_SaveLine
            // 
            btn_SaveLine.Location = new Point(298, 142);
            btn_SaveLine.Name = "btn_SaveLine";
            btn_SaveLine.Size = new Size(100, 29);
            btn_SaveLine.TabIndex = 6;
            btn_SaveLine.Text = "Save Line";
            btn_SaveLine.UseVisualStyleBackColor = true;
            // 
            // GraphEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 405);
            Controls.Add(btn_SaveLine);
            Controls.Add(btn_DeletePoint);
            Controls.Add(btn_AddPoint);
            Controls.Add(ms_Lines);
            Controls.Add(dgv_LineInfo);
            Controls.Add(btn_AddLine);
            MainMenuStrip = ms_Lines;
            Name = "GraphEditor";
            Text = "GraphEditor";
            Load += GraphEditor_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_LineInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_AddLine;
        private DataGridView dgv_LineInfo;
        private MenuStrip ms_Lines;
        private Button btn_AddPoint;
        private Button btn_DeletePoint;
        private Button btn_SaveLine;
    }
}