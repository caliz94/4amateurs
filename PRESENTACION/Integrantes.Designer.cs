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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation5 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem5 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Integrantes));
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation6 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem6 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_integrantes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_idUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_integrantes)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chart1.Location = new System.Drawing.Point(232, 556);
            this.chart1.Name = "chart1";
            series9.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series9.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.HorizontalBrick;
            series9.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series9.BackImageTransparentColor = System.Drawing.Color.SaddleBrown;
            series9.BackSecondaryColor = System.Drawing.Color.Coral;
            series9.BorderColor = System.Drawing.Color.SaddleBrown;
            series9.ChartArea = "ChartArea1";
            series9.Color = System.Drawing.Color.SaddleBrown;
            series9.CustomProperties = "DrawingStyle=Cylinder, EmptyPointValue=Zero, LabelStyle=Bottom";
            series9.IsValueShownAsLabel = true;
            series9.IsXValueIndexed = true;
            series9.LabelBackColor = System.Drawing.Color.Transparent;
            series9.LabelBorderColor = System.Drawing.Color.Transparent;
            series9.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series9.Name = "Series1";
            series9.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(1104, 207);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // chart3
            // 
            this.chart3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.chart3.AllowDrop = true;
            lineAnnotation5.Name = "LineAnnotation1";
            this.chart3.Annotations.Add(lineAnnotation5);
            this.chart3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart3.BorderlineColor = System.Drawing.Color.Black;
            this.chart3.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart3.BorderlineWidth = 0;
            this.chart3.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart3.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart3.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart3.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart3.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea10.Area3DStyle.Inclination = 10;
            chartArea10.Area3DStyle.IsClustered = true;
            chartArea10.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea10.BackColor = System.Drawing.Color.Transparent;
            chartArea10.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea10.BorderColor = System.Drawing.Color.Transparent;
            chartArea10.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea10.BorderWidth = 0;
            chartArea10.IsSameFontSizeForAllAxes = true;
            chartArea10.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea10);
            legend7.Alignment = System.Drawing.StringAlignment.Far;
            legend7.BackColor = System.Drawing.Color.Transparent;
            legend7.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend7.BackImageTransparentColor = System.Drawing.Color.Transparent;
            legend7.BorderColor = System.Drawing.Color.Blue;
            legend7.BorderWidth = 0;
            legendItem5.BorderColor = System.Drawing.Color.White;
            legendItem5.SeparatorColor = System.Drawing.Color.White;
            legend7.CustomItems.Add(legendItem5);
            legend7.DockedToChartArea = "ChartArea1";
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend7.Enabled = false;
            legend7.ForeColor = System.Drawing.Color.DarkRed;
            legend7.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine;
            legend7.HeaderSeparatorColor = System.Drawing.Color.Maroon;
            legend7.InterlacedRows = true;
            legend7.InterlacedRowsColor = System.Drawing.Color.Blue;
            legend7.IsEquallySpacedItems = true;
            legend7.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend7.ItemColumnSeparatorColor = System.Drawing.Color.Maroon;
            legend7.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend7.Name = "Legend1";
            legend7.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            legend7.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend7.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            legend7.TitleForeColor = System.Drawing.Color.Maroon;
            legend7.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend7.TitleSeparatorColor = System.Drawing.Color.Maroon;
            this.chart3.Legends.Add(legend7);
            this.chart3.Location = new System.Drawing.Point(427, 51);
            this.chart3.Margin = new System.Windows.Forms.Padding(0);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series10.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series10.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series10.Color = System.Drawing.Color.Transparent;
            series10.CustomProperties = resources.GetString("series10.CustomProperties");
            series10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series10.IsValueShownAsLabel = true;
            series10.IsVisibleInLegend = false;
            series10.IsXValueIndexed = true;
            series10.LabelBorderColor = System.Drawing.Color.Transparent;
            series10.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series10.LabelBorderWidth = 0;
            series10.LabelForeColor = System.Drawing.Color.RoyalBlue;
            series10.Legend = "Legend1";
            series10.MarkerSize = 1;
            series10.Name = "Series1";
            series10.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series10.ShadowOffset = 3;
            series10.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series10.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Diamond;
            series10.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.RoyalBlue;
            series10.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series10.SmartLabelStyle.CalloutLineWidth = 2;
            series10.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series10.SmartLabelStyle.MaxMovingDistance = 25D;
            series10.SmartLabelStyle.MinMovingDistance = 30D;
            this.chart3.Series.Add(series10);
            this.chart3.Size = new System.Drawing.Size(269, 186);
            this.chart3.TabIndex = 1;
            this.chart3.Text = "chart3";
            title5.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title5.BackColor = System.Drawing.Color.Transparent;
            title5.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            title5.DockedToChartArea = "ChartArea1";
            title5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title5.DockingOffset = 10;
            title5.ForeColor = System.Drawing.Color.Gainsboro;
            title5.Name = "Title1";
            title5.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            title5.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chart3.Titles.Add(title5);
            // 
            // txt_idUsuario
            // 
            this.txt_idUsuario.Location = new System.Drawing.Point(141, 100);
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
            this.panel2.Location = new System.Drawing.Point(631, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 454);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(3, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(421, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(3, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(141, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Placas  del Mes Actual";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(534, 241);
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
            this.label1.Location = new System.Drawing.Point(542, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Placas  Anual";
            this.label1.Visible = false;
            // 
            // chart2
            // 
            chartArea11.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea11);
            this.chart2.IsSoftShadows = false;
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(3, 183);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series11.CustomProperties = "DrawSideBySide=True, BarLabelStyle=Right, EmptyPointValue=Zero";
            series11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            series11.IsValueShownAsLabel = true;
            series11.IsVisibleInLegend = false;
            series11.IsXValueIndexed = true;
            series11.LabelForeColor = System.Drawing.Color.White;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            series11.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series11.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.White;
            series11.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            this.chart2.Series.Add(series11);
            this.chart2.Size = new System.Drawing.Size(468, 265);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            // 
            // chart4
            // 
            this.chart4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.chart4.AllowDrop = true;
            lineAnnotation6.Name = "LineAnnotation1";
            this.chart4.Annotations.Add(lineAnnotation6);
            this.chart4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart4.BorderlineColor = System.Drawing.Color.Black;
            this.chart4.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart4.BorderlineWidth = 0;
            this.chart4.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart4.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart4.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart4.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart4.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea12.Area3DStyle.Inclination = 10;
            chartArea12.Area3DStyle.IsClustered = true;
            chartArea12.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea12.BackColor = System.Drawing.Color.Transparent;
            chartArea12.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea12.BorderColor = System.Drawing.Color.Transparent;
            chartArea12.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea12.BorderWidth = 0;
            chartArea12.IsSameFontSizeForAllAxes = true;
            chartArea12.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea12);
            legend9.Alignment = System.Drawing.StringAlignment.Far;
            legend9.BackColor = System.Drawing.Color.Transparent;
            legend9.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend9.BackImageTransparentColor = System.Drawing.Color.Transparent;
            legend9.BorderColor = System.Drawing.Color.Blue;
            legend9.BorderWidth = 0;
            legendItem6.BorderColor = System.Drawing.Color.White;
            legendItem6.SeparatorColor = System.Drawing.Color.White;
            legend9.CustomItems.Add(legendItem6);
            legend9.DockedToChartArea = "ChartArea1";
            legend9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend9.Enabled = false;
            legend9.ForeColor = System.Drawing.Color.DarkRed;
            legend9.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine;
            legend9.HeaderSeparatorColor = System.Drawing.Color.Maroon;
            legend9.InterlacedRows = true;
            legend9.InterlacedRowsColor = System.Drawing.Color.Blue;
            legend9.IsEquallySpacedItems = true;
            legend9.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend9.ItemColumnSeparatorColor = System.Drawing.Color.Maroon;
            legend9.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend9.Name = "Legend1";
            legend9.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            legend9.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend9.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            legend9.TitleForeColor = System.Drawing.Color.Maroon;
            legend9.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend9.TitleSeparatorColor = System.Drawing.Color.Maroon;
            this.chart4.Legends.Add(legend9);
            this.chart4.Location = new System.Drawing.Point(427, 261);
            this.chart4.Margin = new System.Windows.Forms.Padding(0);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series12.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series12.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series12.Color = System.Drawing.Color.Transparent;
            series12.CustomProperties = resources.GetString("series12.CustomProperties");
            series12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series12.IsValueShownAsLabel = true;
            series12.IsVisibleInLegend = false;
            series12.IsXValueIndexed = true;
            series12.LabelBorderColor = System.Drawing.Color.Transparent;
            series12.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series12.LabelBorderWidth = 0;
            series12.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series12.Legend = "Legend1";
            series12.MarkerSize = 1;
            series12.Name = "Series1";
            series12.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series12.ShadowOffset = 3;
            series12.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series12.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Diamond;
            series12.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.RoyalBlue;
            series12.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series12.SmartLabelStyle.CalloutLineWidth = 2;
            series12.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series12.SmartLabelStyle.MaxMovingDistance = 25D;
            series12.SmartLabelStyle.MinMovingDistance = 30D;
            this.chart4.Series.Add(series12);
            this.chart4.Size = new System.Drawing.Size(269, 186);
            this.chart4.TabIndex = 10;
            this.chart4.Text = "chart4";
            title6.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title6.BackColor = System.Drawing.Color.Transparent;
            title6.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            title6.DockedToChartArea = "ChartArea1";
            title6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title6.DockingOffset = 10;
            title6.ForeColor = System.Drawing.Color.Gainsboro;
            title6.Name = "Title1";
            title6.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            title6.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chart4.Titles.Add(title6);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(254, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 435);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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