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
            btn_OpenAddLine = new Button();
            dgv_LineInfo = new DataGridView();
            ms_Lines = new MenuStrip();
            btn_AddPoint = new Button();
            btn_DeletePoint = new Button();
            btn_SaveLine = new Button();
            lbl_LineName = new Label();
            tb_LineName = new TextBox();
            btn_AddLine = new Button();
            lbl_CurrentLine = new Label();
            tb_XValue = new TextBox();
            lbl_XValue = new Label();
            tb_YValue = new TextBox();
            lbl_YValue = new Label();
            tb_PointIndex = new TextBox();
            lbl_PointIndex = new Label();
            btn_OpenAddPoint = new Button();
            btn_OpenDeletePoint = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_LineInfo).BeginInit();
            SuspendLayout();
            // 
            // btn_OpenAddLine
            // 
            btn_OpenAddLine.Location = new Point(609, 252);
            btn_OpenAddLine.Name = "btn_OpenAddLine";
            btn_OpenAddLine.Size = new Size(100, 29);
            btn_OpenAddLine.TabIndex = 1;
            btn_OpenAddLine.Text = "New Line";
            btn_OpenAddLine.UseVisualStyleBackColor = true;
            btn_OpenAddLine.Click += btn_OpenAddLine_Click;
            // 
            // dgv_LineInfo
            // 
            dgv_LineInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_LineInfo.Location = new Point(13, 61);
            dgv_LineInfo.Name = "dgv_LineInfo";
            dgv_LineInfo.RowHeadersWidth = 51;
            dgv_LineInfo.Size = new Size(316, 307);
            dgv_LineInfo.TabIndex = 2;
            // 
            // ms_Lines
            // 
            ms_Lines.ImageScalingSize = new Size(20, 20);
            ms_Lines.Location = new Point(0, 0);
            ms_Lines.Name = "ms_Lines";
            ms_Lines.Size = new Size(751, 24);
            ms_Lines.TabIndex = 3;
            ms_Lines.Text = "menuStrip1";
            // 
            // btn_AddPoint
            // 
            btn_AddPoint.Location = new Point(363, 215);
            btn_AddPoint.Name = "btn_AddPoint";
            btn_AddPoint.Size = new Size(100, 29);
            btn_AddPoint.TabIndex = 4;
            btn_AddPoint.Text = "Add";
            btn_AddPoint.UseVisualStyleBackColor = true;
            btn_AddPoint.Click += btn_AddPoint_Click;
            // 
            // btn_DeletePoint
            // 
            btn_DeletePoint.Location = new Point(490, 153);
            btn_DeletePoint.Name = "btn_DeletePoint";
            btn_DeletePoint.Size = new Size(100, 29);
            btn_DeletePoint.TabIndex = 5;
            btn_DeletePoint.Text = "Delete";
            btn_DeletePoint.UseVisualStyleBackColor = true;
            btn_DeletePoint.Click += btn_DeletePoint_Click;
            // 
            // btn_SaveLine
            // 
            btn_SaveLine.Location = new Point(363, 339);
            btn_SaveLine.Name = "btn_SaveLine";
            btn_SaveLine.Size = new Size(100, 29);
            btn_SaveLine.TabIndex = 6;
            btn_SaveLine.Text = "Save Line";
            btn_SaveLine.UseVisualStyleBackColor = true;
            btn_SaveLine.Click += btn_SaveLine_Click;
            // 
            // lbl_LineName
            // 
            lbl_LineName.AutoSize = true;
            lbl_LineName.Location = new Point(609, 284);
            lbl_LineName.Name = "lbl_LineName";
            lbl_LineName.Size = new Size(80, 20);
            lbl_LineName.TabIndex = 7;
            lbl_LineName.Text = "Line name:";
            // 
            // tb_LineName
            // 
            tb_LineName.Location = new Point(610, 307);
            tb_LineName.Name = "tb_LineName";
            tb_LineName.Size = new Size(113, 27);
            tb_LineName.TabIndex = 8;
            // 
            // btn_AddLine
            // 
            btn_AddLine.Location = new Point(610, 340);
            btn_AddLine.Name = "btn_AddLine";
            btn_AddLine.Size = new Size(100, 29);
            btn_AddLine.TabIndex = 9;
            btn_AddLine.Text = "Add";
            btn_AddLine.UseVisualStyleBackColor = true;
            btn_AddLine.Click += btn_AddLine_Click;
            // 
            // lbl_CurrentLine
            // 
            lbl_CurrentLine.AutoSize = true;
            lbl_CurrentLine.Location = new Point(13, 38);
            lbl_CurrentLine.Name = "lbl_CurrentLine";
            lbl_CurrentLine.Size = new Size(118, 20);
            lbl_CurrentLine.TabIndex = 10;
            lbl_CurrentLine.Text = "No Current Lines";
            // 
            // tb_XValue
            // 
            tb_XValue.Location = new Point(362, 120);
            tb_XValue.Name = "tb_XValue";
            tb_XValue.Size = new Size(113, 27);
            tb_XValue.TabIndex = 13;
            // 
            // lbl_XValue
            // 
            lbl_XValue.AutoSize = true;
            lbl_XValue.Location = new Point(361, 97);
            lbl_XValue.Name = "lbl_XValue";
            lbl_XValue.Size = new Size(61, 20);
            lbl_XValue.TabIndex = 12;
            lbl_XValue.Text = "X Value:";
            // 
            // tb_YValue
            // 
            tb_YValue.Location = new Point(363, 182);
            tb_YValue.Name = "tb_YValue";
            tb_YValue.Size = new Size(113, 27);
            tb_YValue.TabIndex = 15;
            // 
            // lbl_YValue
            // 
            lbl_YValue.AutoSize = true;
            lbl_YValue.Location = new Point(362, 159);
            lbl_YValue.Name = "lbl_YValue";
            lbl_YValue.Size = new Size(60, 20);
            lbl_YValue.TabIndex = 14;
            lbl_YValue.Text = "Y Value:";
            // 
            // tb_PointIndex
            // 
            tb_PointIndex.Location = new Point(490, 120);
            tb_PointIndex.Name = "tb_PointIndex";
            tb_PointIndex.Size = new Size(113, 27);
            tb_PointIndex.TabIndex = 17;
            // 
            // lbl_PointIndex
            // 
            lbl_PointIndex.AutoSize = true;
            lbl_PointIndex.Location = new Point(489, 97);
            lbl_PointIndex.Name = "lbl_PointIndex";
            lbl_PointIndex.Size = new Size(85, 20);
            lbl_PointIndex.TabIndex = 16;
            lbl_PointIndex.Text = "Point Index:";
            // 
            // btn_OpenAddPoint
            // 
            btn_OpenAddPoint.Location = new Point(361, 61);
            btn_OpenAddPoint.Name = "btn_OpenAddPoint";
            btn_OpenAddPoint.Size = new Size(100, 29);
            btn_OpenAddPoint.TabIndex = 19;
            btn_OpenAddPoint.Text = "Add Point";
            btn_OpenAddPoint.UseVisualStyleBackColor = true;
            btn_OpenAddPoint.Click += btn_OpenAddPoint_Click;
            // 
            // btn_OpenDeletePoint
            // 
            btn_OpenDeletePoint.Location = new Point(490, 61);
            btn_OpenDeletePoint.Name = "btn_OpenDeletePoint";
            btn_OpenDeletePoint.Size = new Size(100, 29);
            btn_OpenDeletePoint.TabIndex = 20;
            btn_OpenDeletePoint.Text = "Delete Point";
            btn_OpenDeletePoint.UseVisualStyleBackColor = true;
            btn_OpenDeletePoint.Click += btn_OpenDeletePoint_Click;
            // 
            // GraphEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 456);
            Controls.Add(btn_OpenDeletePoint);
            Controls.Add(btn_OpenAddPoint);
            Controls.Add(tb_PointIndex);
            Controls.Add(lbl_PointIndex);
            Controls.Add(tb_YValue);
            Controls.Add(lbl_YValue);
            Controls.Add(tb_XValue);
            Controls.Add(lbl_XValue);
            Controls.Add(lbl_CurrentLine);
            Controls.Add(btn_AddLine);
            Controls.Add(tb_LineName);
            Controls.Add(lbl_LineName);
            Controls.Add(btn_SaveLine);
            Controls.Add(btn_DeletePoint);
            Controls.Add(btn_AddPoint);
            Controls.Add(ms_Lines);
            Controls.Add(dgv_LineInfo);
            Controls.Add(btn_OpenAddLine);
            MainMenuStrip = ms_Lines;
            Name = "GraphEditor";
            Text = "GraphEditor";
            Load += GraphEditor_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_LineInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_OpenAddLine;
        private DataGridView dgv_LineInfo;
        private MenuStrip ms_Lines;
        private Button btn_AddPoint;
        private Button btn_DeletePoint;
        private Button btn_SaveLine;
        private Label lbl_LineName;
        private TextBox tb_LineName;
        private Button btn_AddLine;
        private Label lbl_CurrentLine;
        private TextBox tb_XValue;
        private Label lbl_XValue;
        private TextBox tb_YValue;
        private Label lbl_YValue;
        private TextBox tb_PointIndex;
        private Label lbl_PointIndex;
        private Button btn_OpenAddPoint;
        private Button btn_OpenDeletePoint;
    }
}