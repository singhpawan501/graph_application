namespace Graph
{
    partial class FormGraph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGraph));
            this.menuStripGraph = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItemGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxOption = new System.Windows.Forms.GroupBox();
            this.checkBoxShowPoints = new System.Windows.Forms.CheckBox();
            this.checkBoxShowGrid = new System.Windows.Forms.CheckBox();
            this.groupBoxPointRange = new System.Windows.Forms.GroupBox();
            this.textBoxYMax = new System.Windows.Forms.TextBox();
            this.textBoxXMax = new System.Windows.Forms.TextBox();
            this.textBoxYMin = new System.Windows.Forms.TextBox();
            this.textBoxXMin = new System.Windows.Forms.TextBox();
            this.labelYMax = new System.Windows.Forms.Label();
            this.labelXMax = new System.Windows.Forms.Label();
            this.labelYMin = new System.Windows.Forms.Label();
            this.labelXMin = new System.Windows.Forms.Label();
            this.groupBoxGridSettings = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxDx = new System.Windows.Forms.TextBox();
            this.textBoxDy = new System.Windows.Forms.TextBox();
            this.labelDy = new System.Windows.Forms.Label();
            this.labelDx = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.checkBoxStartPoint = new System.Windows.Forms.CheckBox();
            this.checkBoxGridSpacing = new System.Windows.Forms.CheckBox();
            this.labelXAxis = new System.Windows.Forms.Label();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.panelXAxis = new System.Windows.Forms.Panel();
            this.panelYAxis = new System.Windows.Forms.Panel();
            this.panelGraphName = new System.Windows.Forms.Panel();
            this.menuStripGraph.SuspendLayout();
            this.groupBoxOption.SuspendLayout();
            this.groupBoxPointRange.SuspendLayout();
            this.groupBoxGridSettings.SuspendLayout();
            this.panelGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripGraph
            // 
            this.menuStripGraph.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStripGraph.Location = new System.Drawing.Point(0, 0);
            this.menuStripGraph.Name = "menuStripGraph";
            this.menuStripGraph.Size = new System.Drawing.Size(891, 24);
            this.menuStripGraph.TabIndex = 0;
            this.menuStripGraph.Text = "menuStripGraph";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItemGraph});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItemGraph
            // 
            this.aboutToolStripMenuItemGraph.Name = "aboutToolStripMenuItemGraph";
            this.aboutToolStripMenuItemGraph.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItemGraph.Size = new System.Drawing.Size(145, 22);
            this.aboutToolStripMenuItemGraph.Text = "&About";
            this.aboutToolStripMenuItemGraph.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBoxOption
            // 
            this.groupBoxOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOption.Controls.Add(this.checkBoxShowPoints);
            this.groupBoxOption.Controls.Add(this.checkBoxShowGrid);
            this.groupBoxOption.Location = new System.Drawing.Point(688, 27);
            this.groupBoxOption.Name = "groupBoxOption";
            this.groupBoxOption.Size = new System.Drawing.Size(191, 63);
            this.groupBoxOption.TabIndex = 1;
            this.groupBoxOption.TabStop = false;
            this.groupBoxOption.Text = " Options";
            // 
            // checkBoxShowPoints
            // 
            this.checkBoxShowPoints.AutoSize = true;
            this.checkBoxShowPoints.Enabled = false;
            this.checkBoxShowPoints.Location = new System.Drawing.Point(11, 42);
            this.checkBoxShowPoints.Name = "checkBoxShowPoints";
            this.checkBoxShowPoints.Size = new System.Drawing.Size(85, 17);
            this.checkBoxShowPoints.TabIndex = 1;
            this.checkBoxShowPoints.Text = "Show Points";
            this.checkBoxShowPoints.UseVisualStyleBackColor = true;
            this.checkBoxShowPoints.CheckedChanged += new System.EventHandler(this.checkBoxShowPoints_CheckedChanged);
            // 
            // checkBoxShowGrid
            // 
            this.checkBoxShowGrid.AutoSize = true;
            this.checkBoxShowGrid.Enabled = false;
            this.checkBoxShowGrid.Location = new System.Drawing.Point(11, 19);
            this.checkBoxShowGrid.Name = "checkBoxShowGrid";
            this.checkBoxShowGrid.Size = new System.Drawing.Size(75, 17);
            this.checkBoxShowGrid.TabIndex = 0;
            this.checkBoxShowGrid.Text = "Show Grid";
            this.checkBoxShowGrid.UseVisualStyleBackColor = true;
            this.checkBoxShowGrid.Click += new System.EventHandler(this.checkBoxShowGrid_Click);
            // 
            // groupBoxPointRange
            // 
            this.groupBoxPointRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPointRange.Controls.Add(this.textBoxYMax);
            this.groupBoxPointRange.Controls.Add(this.textBoxXMax);
            this.groupBoxPointRange.Controls.Add(this.textBoxYMin);
            this.groupBoxPointRange.Controls.Add(this.textBoxXMin);
            this.groupBoxPointRange.Controls.Add(this.labelYMax);
            this.groupBoxPointRange.Controls.Add(this.labelXMax);
            this.groupBoxPointRange.Controls.Add(this.labelYMin);
            this.groupBoxPointRange.Controls.Add(this.labelXMin);
            this.groupBoxPointRange.Location = new System.Drawing.Point(688, 96);
            this.groupBoxPointRange.Name = "groupBoxPointRange";
            this.groupBoxPointRange.Size = new System.Drawing.Size(191, 108);
            this.groupBoxPointRange.TabIndex = 2;
            this.groupBoxPointRange.TabStop = false;
            this.groupBoxPointRange.Text = "Point Range(For curent input)";
            // 
            // textBoxYMax
            // 
            this.textBoxYMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYMax.Enabled = false;
            this.textBoxYMax.Location = new System.Drawing.Point(57, 85);
            this.textBoxYMax.Name = "textBoxYMax";
            this.textBoxYMax.ReadOnly = true;
            this.textBoxYMax.Size = new System.Drawing.Size(121, 13);
            this.textBoxYMax.TabIndex = 11;
            this.textBoxYMax.Visible = false;
            // 
            // textBoxXMax
            // 
            this.textBoxXMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxXMax.Enabled = false;
            this.textBoxXMax.Location = new System.Drawing.Point(57, 65);
            this.textBoxXMax.Name = "textBoxXMax";
            this.textBoxXMax.ReadOnly = true;
            this.textBoxXMax.Size = new System.Drawing.Size(121, 13);
            this.textBoxXMax.TabIndex = 10;
            this.textBoxXMax.Visible = false;
            // 
            // textBoxYMin
            // 
            this.textBoxYMin.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxYMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYMin.Enabled = false;
            this.textBoxYMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxYMin.Location = new System.Drawing.Point(54, 40);
            this.textBoxYMin.Name = "textBoxYMin";
            this.textBoxYMin.ReadOnly = true;
            this.textBoxYMin.Size = new System.Drawing.Size(124, 13);
            this.textBoxYMin.TabIndex = 9;
            this.textBoxYMin.Visible = false;
            // 
            // textBoxXMin
            // 
            this.textBoxXMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxXMin.Enabled = false;
            this.textBoxXMin.Location = new System.Drawing.Point(54, 20);
            this.textBoxXMin.Name = "textBoxXMin";
            this.textBoxXMin.ReadOnly = true;
            this.textBoxXMin.Size = new System.Drawing.Size(124, 13);
            this.textBoxXMin.TabIndex = 8;
            this.textBoxXMin.Visible = false;
            // 
            // labelYMax
            // 
            this.labelYMax.AutoSize = true;
            this.labelYMax.Location = new System.Drawing.Point(11, 85);
            this.labelYMax.Name = "labelYMax";
            this.labelYMax.Size = new System.Drawing.Size(43, 13);
            this.labelYMax.TabIndex = 3;
            this.labelYMax.Text = "Y Max :";
            // 
            // labelXMax
            // 
            this.labelXMax.AutoSize = true;
            this.labelXMax.Location = new System.Drawing.Point(11, 65);
            this.labelXMax.Name = "labelXMax";
            this.labelXMax.Size = new System.Drawing.Size(43, 13);
            this.labelXMax.TabIndex = 2;
            this.labelXMax.Text = "X Max :";
            // 
            // labelYMin
            // 
            this.labelYMin.AutoSize = true;
            this.labelYMin.Location = new System.Drawing.Point(11, 40);
            this.labelYMin.Name = "labelYMin";
            this.labelYMin.Size = new System.Drawing.Size(40, 13);
            this.labelYMin.TabIndex = 1;
            this.labelYMin.Text = "Y Min :";
            // 
            // labelXMin
            // 
            this.labelXMin.AutoSize = true;
            this.labelXMin.Location = new System.Drawing.Point(11, 20);
            this.labelXMin.Name = "labelXMin";
            this.labelXMin.Size = new System.Drawing.Size(40, 13);
            this.labelXMin.TabIndex = 0;
            this.labelXMin.Text = "X Min :";
            // 
            // groupBoxGridSettings
            // 
            this.groupBoxGridSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGridSettings.Controls.Add(this.buttonRefresh);
            this.groupBoxGridSettings.Controls.Add(this.textBoxX);
            this.groupBoxGridSettings.Controls.Add(this.textBoxY);
            this.groupBoxGridSettings.Controls.Add(this.textBoxDx);
            this.groupBoxGridSettings.Controls.Add(this.textBoxDy);
            this.groupBoxGridSettings.Controls.Add(this.labelDy);
            this.groupBoxGridSettings.Controls.Add(this.labelDx);
            this.groupBoxGridSettings.Controls.Add(this.labelY);
            this.groupBoxGridSettings.Controls.Add(this.labelX);
            this.groupBoxGridSettings.Controls.Add(this.checkBoxStartPoint);
            this.groupBoxGridSettings.Controls.Add(this.checkBoxGridSpacing);
            this.groupBoxGridSettings.Location = new System.Drawing.Point(688, 209);
            this.groupBoxGridSettings.Name = "groupBoxGridSettings";
            this.groupBoxGridSettings.Size = new System.Drawing.Size(191, 227);
            this.groupBoxGridSettings.TabIndex = 2;
            this.groupBoxGridSettings.TabStop = false;
            this.groupBoxGridSettings.Text = "Grid Settings(For current input)";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Enabled = false;
            this.buttonRefresh.Location = new System.Drawing.Point(57, 191);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 25);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Enabled = false;
            this.textBoxX.Location = new System.Drawing.Point(37, 45);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(141, 20);
            this.textBoxX.TabIndex = 3;
            this.textBoxX.Text = "0";
            this.textBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX_KeyPress);
            // 
            // textBoxY
            // 
            this.textBoxY.Enabled = false;
            this.textBoxY.Location = new System.Drawing.Point(37, 71);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(141, 20);
            this.textBoxY.TabIndex = 4;
            this.textBoxY.Text = "0";
            this.textBoxY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX_KeyPress);
            // 
            // textBoxDx
            // 
            this.textBoxDx.Enabled = false;
            this.textBoxDx.Location = new System.Drawing.Point(37, 134);
            this.textBoxDx.Name = "textBoxDx";
            this.textBoxDx.Size = new System.Drawing.Size(141, 20);
            this.textBoxDx.TabIndex = 6;
            this.textBoxDx.Text = "0";
            this.textBoxDx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDx_KeyPress);
            // 
            // textBoxDy
            // 
            this.textBoxDy.Enabled = false;
            this.textBoxDy.Location = new System.Drawing.Point(37, 160);
            this.textBoxDy.Name = "textBoxDy";
            this.textBoxDy.Size = new System.Drawing.Size(141, 20);
            this.textBoxDy.TabIndex = 7;
            this.textBoxDy.Text = "0";
            this.textBoxDy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDx_KeyPress);
            // 
            // labelDy
            // 
            this.labelDy.AutoSize = true;
            this.labelDy.Location = new System.Drawing.Point(11, 163);
            this.labelDy.Name = "labelDy";
            this.labelDy.Size = new System.Drawing.Size(26, 13);
            this.labelDy.TabIndex = 7;
            this.labelDy.Text = "Dy :";
            // 
            // labelDx
            // 
            this.labelDx.AutoSize = true;
            this.labelDx.Location = new System.Drawing.Point(11, 137);
            this.labelDx.Name = "labelDx";
            this.labelDx.Size = new System.Drawing.Size(26, 13);
            this.labelDx.TabIndex = 6;
            this.labelDx.Text = "Dx :";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(11, 74);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(20, 13);
            this.labelY.TabIndex = 5;
            this.labelY.Text = "Y :";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(11, 48);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(20, 13);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "X :";
            // 
            // checkBoxStartPoint
            // 
            this.checkBoxStartPoint.AutoSize = true;
            this.checkBoxStartPoint.Enabled = false;
            this.checkBoxStartPoint.Location = new System.Drawing.Point(11, 19);
            this.checkBoxStartPoint.Name = "checkBoxStartPoint";
            this.checkBoxStartPoint.Size = new System.Drawing.Size(75, 17);
            this.checkBoxStartPoint.TabIndex = 2;
            this.checkBoxStartPoint.Text = "Start Point";
            this.checkBoxStartPoint.UseVisualStyleBackColor = true;
            this.checkBoxStartPoint.CheckedChanged += new System.EventHandler(this.checkBoxStartPoint_CheckedChanged);
            // 
            // checkBoxGridSpacing
            // 
            this.checkBoxGridSpacing.AutoSize = true;
            this.checkBoxGridSpacing.Enabled = false;
            this.checkBoxGridSpacing.Location = new System.Drawing.Point(11, 108);
            this.checkBoxGridSpacing.Name = "checkBoxGridSpacing";
            this.checkBoxGridSpacing.Size = new System.Drawing.Size(87, 17);
            this.checkBoxGridSpacing.TabIndex = 5;
            this.checkBoxGridSpacing.Text = "Grid Spacing";
            this.checkBoxGridSpacing.UseVisualStyleBackColor = true;
            this.checkBoxGridSpacing.CheckedChanged += new System.EventHandler(this.checkBoxGridSpacing_CheckedChanged);
            // 
            // labelXAxis
            // 
            this.labelXAxis.AutoSize = true;
            this.labelXAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXAxis.Location = new System.Drawing.Point(346, 513);
            this.labelXAxis.Name = "labelXAxis";
            this.labelXAxis.Size = new System.Drawing.Size(50, 16);
            this.labelXAxis.TabIndex = 2;
            this.labelXAxis.Text = "X Axis";
            // 
            // panelGraph
            // 
            this.panelGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGraph.BackColor = System.Drawing.Color.Black;
            this.panelGraph.Controls.Add(this.labelXAxis);
            this.panelGraph.Location = new System.Drawing.Point(132, 55);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(538, 371);
            this.panelGraph.TabIndex = 0;
            this.panelGraph.Visible = false;
            this.panelGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraph_Paint);
            // 
            // panelXAxis
            // 
            this.panelXAxis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelXAxis.BackColor = System.Drawing.Color.Transparent;
            this.panelXAxis.Location = new System.Drawing.Point(123, 432);
            this.panelXAxis.Name = "panelXAxis";
            this.panelXAxis.Size = new System.Drawing.Size(553, 89);
            this.panelXAxis.TabIndex = 0;
            this.panelXAxis.Visible = false;
            this.panelXAxis.Paint += new System.Windows.Forms.PaintEventHandler(this.panelXAxis_Paint);
            // 
            // panelYAxis
            // 
            this.panelYAxis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelYAxis.BackColor = System.Drawing.Color.Transparent;
            this.panelYAxis.Location = new System.Drawing.Point(29, 46);
            this.panelYAxis.Name = "panelYAxis";
            this.panelYAxis.Size = new System.Drawing.Size(97, 391);
            this.panelYAxis.TabIndex = 0;
            this.panelYAxis.TabStop = true;
            this.panelYAxis.Visible = false;
            this.panelYAxis.Paint += new System.Windows.Forms.PaintEventHandler(this.panelYAxis_Paint);
            // 
            // panelGraphName
            // 
            this.panelGraphName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGraphName.Location = new System.Drawing.Point(132, 27);
            this.panelGraphName.Name = "panelGraphName";
            this.panelGraphName.Size = new System.Drawing.Size(538, 26);
            this.panelGraphName.TabIndex = 3;
            this.panelGraphName.Visible = false;
            this.panelGraphName.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraphName_Paint);
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 558);
            this.Controls.Add(this.panelGraphName);
            this.Controls.Add(this.panelYAxis);
            this.Controls.Add(this.panelXAxis);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.groupBoxPointRange);
            this.Controls.Add(this.groupBoxGridSettings);
            this.Controls.Add(this.groupBoxOption);
            this.Controls.Add(this.menuStripGraph);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripGraph;
            this.MinimumSize = new System.Drawing.Size(907, 597);
            this.Name = "FormGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.FormGraph_Load);
            this.SizeChanged += new System.EventHandler(this.FormGraph_SizeChanged);
            this.Resize += new System.EventHandler(this.FormGraph_Load);
            this.menuStripGraph.ResumeLayout(false);
            this.menuStripGraph.PerformLayout();
            this.groupBoxOption.ResumeLayout(false);
            this.groupBoxOption.PerformLayout();
            this.groupBoxPointRange.ResumeLayout(false);
            this.groupBoxPointRange.PerformLayout();
            this.groupBoxGridSettings.ResumeLayout(false);
            this.groupBoxGridSettings.PerformLayout();
            this.panelGraph.ResumeLayout(false);
            this.panelGraph.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripGraph;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxOption;
        private System.Windows.Forms.GroupBox groupBoxPointRange;
        private System.Windows.Forms.Label labelYMax;
        private System.Windows.Forms.Label labelXMax;
        private System.Windows.Forms.Label labelYMin;
        private System.Windows.Forms.Label labelXMin;
        private System.Windows.Forms.GroupBox groupBoxGridSettings;
        private System.Windows.Forms.Label labelDy;
        private System.Windows.Forms.Label labelDx;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelXAxis;
        internal System.Windows.Forms.CheckBox checkBoxShowPoints;
        internal System.Windows.Forms.CheckBox checkBoxShowGrid;
        internal System.Windows.Forms.CheckBox checkBoxStartPoint;
        internal System.Windows.Forms.CheckBox checkBoxGridSpacing;
        internal System.Windows.Forms.TextBox textBoxX;
        internal System.Windows.Forms.TextBox textBoxY;
        internal System.Windows.Forms.TextBox textBoxDx;
        internal System.Windows.Forms.TextBox textBoxDy;
        internal System.Windows.Forms.Panel panelGraph;
        internal System.Windows.Forms.Panel panelXAxis;
        internal System.Windows.Forms.Panel panelYAxis;
        internal System.Windows.Forms.Panel panelGraphName;
        public System.Windows.Forms.TextBox textBoxYMax;
        public System.Windows.Forms.TextBox textBoxXMax;
        public System.Windows.Forms.TextBox textBoxYMin;
        public System.Windows.Forms.TextBox textBoxXMin;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItemGraph;
    }
}

