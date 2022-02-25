namespace PRESENTACION
{ using System.Windows.Forms.DataVisualization;
    partial class Integrantes
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_integrantes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_idUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_integrantes)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_integrantes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 763);
            this.panel3.TabIndex = 0;
            // 
            // dgv_integrantes
            // 
            this.dgv_integrantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_integrantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_integrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_integrantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_integrantes.Location = new System.Drawing.Point(0, 0);
            this.dgv_integrantes.Name = "dgv_integrantes";
            this.dgv_integrantes.ReadOnly = true;
            this.dgv_integrantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_integrantes.Size = new System.Drawing.Size(232, 763);
            this.dgv_integrantes.TabIndex = 0;
            this.dgv_integrantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_integrantes_CellClick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 763);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 25);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.iconButton1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1336, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 788);
            this.panel5.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chart1.Location = new System.Drawing.Point(232, 556);
            this.chart1.Name = "chart1";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.HorizontalBrick;
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series1.BackImageTransparentColor = System.Drawing.Color.SaddleBrown;
            series1.BackSecondaryColor = System.Drawing.Color.Coral;
            series1.BorderColor = System.Drawing.Color.SaddleBrown;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.SaddleBrown;
            series1.CustomProperties = "DrawingStyle=Cylinder, EmptyPointValue=Zero, LabelStyle=Bottom";
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1104, 207);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // chart3
            // 
            this.chart3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.chart3.AllowDrop = true;
            lineAnnotation1.Name = "LineAnnotation1";
            this.chart3.Annotations.Add(lineAnnotation1);
            this.chart3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart3.BorderlineColor = System.Drawing.Color.Black;
            this.chart3.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart3.BorderlineWidth = 0;
            this.chart3.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart3.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart3.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart3.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart3.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Inclination = 10;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.BorderWidth = 0;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.Blue;
            legend1.BorderWidth = 0;
            legendItem1.BorderColor = System.Drawing.Color.White;
            legendItem1.SeparatorColor = System.Drawing.Color.White;
            legend1.CustomItems.Add(legendItem1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Enabled = false;
            legend1.ForeColor = System.Drawing.Color.DarkRed;
            legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine;
            legend1.HeaderSeparatorColor = System.Drawing.Color.Maroon;
            legend1.InterlacedRows = true;
            legend1.InterlacedRowsColor = System.Drawing.Color.Blue;
            legend1.IsEquallySpacedItems = true;
            legend1.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Maroon;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            legend1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            legend1.TitleForeColor = System.Drawing.Color.Maroon;
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend1.TitleSeparatorColor = System.Drawing.Color.Maroon;
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(427, 51);
            this.chart3.Margin = new System.Windows.Forms.Padding(0);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.Transparent;
            series2.CustomProperties = "DoughnutRadius=50";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series2.LabelBorderWidth = 0;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerSize = 1;
            series2.Name = "Series1";
            series2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series2.ShadowOffset = 3;
            series2.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series2.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Diamond;
            series2.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.RoyalBlue;
            series2.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series2.SmartLabelStyle.CalloutLineWidth = 2;
            series2.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series2.SmartLabelStyle.MaxMovingDistance = 25D;
            series2.SmartLabelStyle.MinMovingDistance = 30D;
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(269, 186);
            this.chart3.TabIndex = 1;
            this.chart3.Text = "chart3";
            title1.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            title1.DockedToChartArea = "ChartArea1";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.DockingOffset = 10;
            title1.ForeColor = System.Drawing.Color.Gainsboro;
            title1.Name = "Title1";
            title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chart3.Titles.Add(title1);
            // 
            // txt_idUsuario
            // 
            this.txt_idUsuario.Location = new System.Drawing.Point(180, 103);
            this.txt_idUsuario.Name = "txt_idUsuario";
            this.txt_idUsuario.Size = new System.Drawing.Size(100, 20);
            this.txt_idUsuario.TabIndex = 1;
            this.txt_idUsuario.Visible = false;
            this.txt_idUsuario.TextChanged += new System.EventHandler(this.txt_idUsuario_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chart2);
            this.panel2.Controls.Add(this.chart4);
            this.panel2.Controls.Add(this.chart3);
            this.panel2.Controls.Add(this.txt_idUsuario);
            this.panel2.Location = new System.Drawing.Point(600, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 454);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(176, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Placas  del Mes Actual";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(491, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Promedio del Mes";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(491, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Placas  Anual";
            this.label1.Visible = false;
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            this.chart2.IsSoftShadows = false;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 183);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.CustomProperties = "DrawSideBySide=True, BarLabelStyle=Right, EmptyPointValue=Zero";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.IsXValueIndexed = true;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series3.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.White;
            series3.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(421, 265);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            // 
            // chart4
            // 
            this.chart4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.chart4.AllowDrop = true;
            lineAnnotation2.Name = "LineAnnotation1";
            this.chart4.Annotations.Add(lineAnnotation2);
            this.chart4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart4.BorderlineColor = System.Drawing.Color.Black;
            this.chart4.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart4.BorderlineWidth = 0;
            this.chart4.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart4.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart4.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart4.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart4.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea4.Area3DStyle.Inclination = 10;
            chartArea4.Area3DStyle.IsClustered = true;
            chartArea4.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea4.BorderColor = System.Drawing.Color.Transparent;
            chartArea4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.BorderWidth = 0;
            chartArea4.IsSameFontSizeForAllAxes = true;
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend3.Alignment = System.Drawing.StringAlignment.Far;
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend3.BackImageTransparentColor = System.Drawing.Color.Transparent;
            legend3.BorderColor = System.Drawing.Color.Blue;
            legend3.BorderWidth = 0;
            legendItem2.BorderColor = System.Drawing.Color.White;
            legendItem2.SeparatorColor = System.Drawing.Color.White;
            legend3.CustomItems.Add(legendItem2);
            legend3.DockedToChartArea = "ChartArea1";
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Enabled = false;
            legend3.ForeColor = System.Drawing.Color.DarkRed;
            legend3.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine;
            legend3.HeaderSeparatorColor = System.Drawing.Color.Maroon;
            legend3.InterlacedRows = true;
            legend3.InterlacedRowsColor = System.Drawing.Color.Blue;
            legend3.IsEquallySpacedItems = true;
            legend3.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend3.ItemColumnSeparatorColor = System.Drawing.Color.Maroon;
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend3.Name = "Legend1";
            legend3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            legend3.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend3.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            legend3.TitleForeColor = System.Drawing.Color.Maroon;
            legend3.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend3.TitleSeparatorColor = System.Drawing.Color.Maroon;
            this.chart4.Legends.Add(legend3);
            this.chart4.Location = new System.Drawing.Point(427, 261);
            this.chart4.Margin = new System.Windows.Forms.Padding(0);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series4.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Color = System.Drawing.Color.Transparent;
            series4.CustomProperties = "DoughnutRadius=50";
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsValueShownAsLabel = true;
            series4.IsVisibleInLegend = false;
            series4.IsXValueIndexed = true;
            series4.LabelBorderColor = System.Drawing.Color.Transparent;
            series4.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series4.LabelBorderWidth = 0;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.MarkerSize = 1;
            series4.Name = "Series1";
            series4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series4.ShadowOffset = 3;
            series4.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series4.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Diamond;
            series4.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.RoyalBlue;
            series4.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series4.SmartLabelStyle.CalloutLineWidth = 2;
            series4.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series4.SmartLabelStyle.MaxMovingDistance = 25D;
            series4.SmartLabelStyle.MinMovingDistance = 30D;
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(269, 186);
            this.chart4.TabIndex = 10;
            this.chart4.Text = "chart4";
            title2.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title2.BackColor = System.Drawing.Color.Transparent;
            title2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            title2.DockedToChartArea = "ChartArea1";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.DockingOffset = 10;
            title2.ForeColor = System.Drawing.Color.Gainsboro;
            title2.Name = "Title1";
            title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            title2.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chart4.Titles.Add(title2);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(274, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(323, 454);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(3, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(351, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(38, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Flames", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.iconButton1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(10, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(40, 788);
            this.iconButton1.TabIndex = 19;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Integrantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Integrantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Integrantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Integrantes_FormClosed);
            this.Load += new System.EventHandler(this.Integrantes_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_integrantes)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_integrantes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.TextBox txt_idUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}