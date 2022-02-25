namespace PRESENTACION
{
    
    partial class MenuPrincipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_inf = new System.Windows.Forms.Panel();
            this.panel_der = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_ingr = new System.Windows.Forms.TextBox();
            this.txt_nac = new System.Windows.Forms.TextBox();
            this.txt_cel = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_idUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_placas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_der.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_inf
            // 
            this.panel_inf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_inf.Location = new System.Drawing.Point(0, 763);
            this.panel_inf.Name = "panel_inf";
            this.panel_inf.Size = new System.Drawing.Size(1231, 25);
            this.panel_inf.TabIndex = 2;
            // 
            // panel_der
            // 
            this.panel_der.BackColor = System.Drawing.Color.Transparent;
            this.panel_der.Controls.Add(this.iconButton1);
            this.panel_der.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_der.Location = new System.Drawing.Point(1231, 0);
            this.panel_der.Name = "panel_der";
            this.panel_der.Size = new System.Drawing.Size(41, 788);
            this.panel_der.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumVioletRed;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Flames", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.iconButton1.IconColor = System.Drawing.Color.Green;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(41, 788);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chart3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal;
            this.chart3.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chart3.BackSecondaryColor = System.Drawing.SystemColors.ButtonShadow;
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(0, 0);
            this.chart3.Name = "chart3";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "DrawSideBySide=True, DrawingStyle=Cylinder, EmptyPointValue=Zero, PointWidth=0.5," +
    " LabelStyle=Center";
            series1.EmptyPointStyle.CustomProperties = "DrawingStyle=Cylinder, LabelStyle=Center";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series1.Label = "#VALX";
            series1.LabelAngle = -90;
            series1.LabelToolTip = " #VAL";
            series1.Legend = "Legend1";
            series1.LegendText = "Placas del Mes";
            series1.Name = "Placas del mes";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Square;
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Maroon;
            series1.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series1.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series1.SmartLabelStyle.MaxMovingDistance = 20D;
            series1.SmartLabelStyle.MinMovingDistance = 1D;
            series1.ToolTip = "#VALX";
            series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValuesPerPoint = 2;
            this.chart3.Series.Add(series1);
            this.chart3.Size = new System.Drawing.Size(1231, 216);
            this.chart3.TabIndex = 25;
            this.chart3.Text = "chart3";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chart1.BackSecondaryColor = System.Drawing.SystemColors.ButtonShadow;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(639, 222);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Top 5 del Mes";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(542, 257);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            // 
            // txt_ingr
            // 
            this.txt_ingr.BackColor = System.Drawing.Color.Coral;
            this.txt_ingr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ingr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_ingr.Location = new System.Drawing.Point(374, 410);
            this.txt_ingr.Name = "txt_ingr";
            this.txt_ingr.ReadOnly = true;
            this.txt_ingr.Size = new System.Drawing.Size(214, 20);
            this.txt_ingr.TabIndex = 39;
            // 
            // txt_nac
            // 
            this.txt_nac.BackColor = System.Drawing.Color.Coral;
            this.txt_nac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_nac.Location = new System.Drawing.Point(374, 368);
            this.txt_nac.Name = "txt_nac";
            this.txt_nac.ReadOnly = true;
            this.txt_nac.Size = new System.Drawing.Size(214, 20);
            this.txt_nac.TabIndex = 38;
            // 
            // txt_cel
            // 
            this.txt_cel.BackColor = System.Drawing.Color.Coral;
            this.txt_cel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cel.Location = new System.Drawing.Point(374, 331);
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.ReadOnly = true;
            this.txt_cel.Size = new System.Drawing.Size(214, 20);
            this.txt_cel.TabIndex = 37;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.Coral;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_usuario.Location = new System.Drawing.Point(374, 289);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.ReadOnly = true;
            this.txt_usuario.Size = new System.Drawing.Size(214, 20);
            this.txt_usuario.TabIndex = 36;
            // 
            // txt_idUsuario
            // 
            this.txt_idUsuario.BackColor = System.Drawing.Color.Coral;
            this.txt_idUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_idUsuario.Location = new System.Drawing.Point(374, 248);
            this.txt_idUsuario.Name = "txt_idUsuario";
            this.txt_idUsuario.ReadOnly = true;
            this.txt_idUsuario.Size = new System.Drawing.Size(214, 20);
            this.txt_idUsuario.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(123, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal;
            this.chart2.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chart2.BackSecondaryColor = System.Drawing.SystemColors.ButtonShadow;
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(0, 582);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Placas del Año";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(1231, 181);
            this.chart2.TabIndex = 23;
            this.chart2.Text = "chart2";
            // 
            // txt_placas
            // 
            this.txt_placas.BackColor = System.Drawing.Color.Coral;
            this.txt_placas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_placas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_placas.Location = new System.Drawing.Point(374, 451);
            this.txt_placas.Name = "txt_placas";
            this.txt_placas.ReadOnly = true;
            this.txt_placas.Size = new System.Drawing.Size(214, 20);
            this.txt_placas.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(371, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Codigo de Integrante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(374, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Integrante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(374, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(374, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Ubicacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(371, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Fecha de Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(374, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Placas del Mes";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1272, 788);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_placas);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.txt_ingr);
            this.Controls.Add(this.panel_inf);
            this.Controls.Add(this.txt_nac);
            this.Controls.Add(this.txt_cel);
            this.Controls.Add(this.panel_der);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_idUsuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel_der.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_inf;
        private System.Windows.Forms.Panel panel_der;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox txt_ingr;
        private System.Windows.Forms.TextBox txt_nac;
        private System.Windows.Forms.TextBox txt_cel;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_idUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.TextBox txt_placas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}