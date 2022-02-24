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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation9 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem9 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation10 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem10 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            chartArea17.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea17);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chart1.Location = new System.Drawing.Point(232, 556);
            this.chart1.Name = "chart1";
            series17.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series17.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.HorizontalBrick;
            series17.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series17.BackImageTransparentColor = System.Drawing.Color.SaddleBrown;
            series17.BackSecondaryColor = System.Drawing.Color.Coral;
            series17.BorderColor = System.Drawing.Color.SaddleBrown;
            series17.ChartArea = "ChartArea1";
            series17.Color = System.Drawing.Color.SaddleBrown;
            series17.CustomProperties = "DrawingStyle=Cylinder, EmptyPointValue=Zero, LabelStyle=Bottom";
            series17.IsValueShownAsLabel = true;
            series17.IsXValueIndexed = true;
            series17.LabelBackColor = System.Drawing.Color.Transparent;
            series17.LabelBorderColor = System.Drawing.Color.Transparent;
            series17.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series17.Name = "Series1";
            series17.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chart1.Series.Add(series17);
            this.chart1.Size = new System.Drawing.Size(1104, 207);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // chart3
            // 
            this.chart3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.chart3.AllowDrop = true;
            lineAnnotation9.Name = "LineAnnotation1";
            this.chart3.Annotations.Add(lineAnnotation9);
            this.chart3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart3.BorderlineColor = System.Drawing.Color.Black;
            this.chart3.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart3.BorderlineWidth = 0;
            this.chart3.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart3.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart3.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart3.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart3.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea18.Area3DStyle.Inclination = 10;
            chartArea18.Area3DStyle.IsClustered = true;
            chartArea18.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea18.BackColor = System.Drawing.Color.Transparent;
            chartArea18.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea18.BorderColor = System.Drawing.Color.Transparent;
            chartArea18.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea18.BorderWidth = 0;
            chartArea18.IsSameFontSizeForAllAxes = true;
            chartArea18.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea18);
            legend13.Alignment = System.Drawing.StringAlignment.Far;
            legend13.BackColor = System.Drawing.Color.Transparent;
            legend13.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend13.BackImageTransparentColor = System.Drawing.Color.Transparent;
            legend13.BorderColor = System.Drawing.Color.Blue;
            legend13.BorderWidth = 0;
            legendItem9.BorderColor = System.Drawing.Color.White;
            legendItem9.SeparatorColor = System.Drawing.Color.White;
            legend13.CustomItems.Add(legendItem9);
            legend13.DockedToChartArea = "ChartArea1";
            legend13.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend13.Enabled = false;
            legend13.ForeColor = System.Drawing.Color.DarkRed;
            legend13.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine;
            legend13.HeaderSeparatorColor = System.Drawing.Color.Maroon;
            legend13.InterlacedRows = true;
            legend13.InterlacedRowsColor = System.Drawing.Color.Blue;
            legend13.IsEquallySpacedItems = true;
            legend13.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend13.ItemColumnSeparatorColor = System.Drawing.Color.Maroon;
            legend13.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend13.Name = "Legend1";
            legend13.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            legend13.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend13.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            legend13.TitleForeColor = System.Drawing.Color.Maroon;
            legend13.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend13.TitleSeparatorColor = System.Drawing.Color.Maroon;
            this.chart3.Legends.Add(legend13);
            this.chart3.Location = new System.Drawing.Point(427, 51);
            this.chart3.Margin = new System.Windows.Forms.Padding(0);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series18.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series18.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series18.Color = System.Drawing.Color.Transparent;
            series18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series18.IsValueShownAsLabel = true;
            series18.IsVisibleInLegend = false;
            series18.IsXValueIndexed = true;
            series18.LabelBorderColor = System.Drawing.Color.Transparent;
            series18.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series18.LabelBorderWidth = 0;
            series18.LabelForeColor = System.Drawing.Color.RoyalBlue;
            series18.Legend = "Legend1";
            series18.MarkerSize = 1;
            series18.Name = "Series1";
            series18.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series18.ShadowOffset = 3;
            series18.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series18.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Diamond;
            series18.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.RoyalBlue;
            series18.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series18.SmartLabelStyle.CalloutLineWidth = 2;
            series18.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series18.SmartLabelStyle.MaxMovingDistance = 25D;
            series18.SmartLabelStyle.MinMovingDistance = 30D;
            this.chart3.Series.Add(series18);
            this.chart3.Size = new System.Drawing.Size(269, 186);
            this.chart3.TabIndex = 1;
            this.chart3.Text = "chart3";
            title9.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title9.BackColor = System.Drawing.Color.Transparent;
            title9.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            title9.DockedToChartArea = "ChartArea1";
            title9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title9.DockingOffset = 10;
            title9.ForeColor = System.Drawing.Color.Gainsboro;
            title9.Name = "Title1";
            title9.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            title9.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chart3.Titles.Add(title9);
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
            this.panel2.Location = new System.Drawing.Point(600, 12);
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
            chartArea19.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea19);
            this.chart2.IsSoftShadows = false;
            legend14.Name = "Legend1";
            this.chart2.Legends.Add(legend14);
            this.chart2.Location = new System.Drawing.Point(3, 183);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series19.CustomProperties = "DrawSideBySide=True, BarLabelStyle=Right, EmptyPointValue=Zero";
            series19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            series19.IsValueShownAsLabel = true;
            series19.IsVisibleInLegend = false;
            series19.IsXValueIndexed = true;
            series19.LabelForeColor = System.Drawing.Color.White;
            series19.Legend = "Legend1";
            series19.Name = "Series1";
            series19.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series19.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.White;
            series19.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            this.chart2.Series.Add(series19);
            this.chart2.Size = new System.Drawing.Size(468, 265);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            // 
            // chart4
            // 
            this.chart4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.chart4.AllowDrop = true;
            lineAnnotation10.Name = "LineAnnotation1";
            this.chart4.Annotations.Add(lineAnnotation10);
            this.chart4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart4.BorderlineColor = System.Drawing.Color.Black;
            this.chart4.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart4.BorderlineWidth = 0;
            this.chart4.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart4.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart4.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart4.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart4.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea20.Area3DStyle.Inclination = 10;
            chartArea20.Area3DStyle.IsClustered = true;
            chartArea20.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea20.BackColor = System.Drawing.Color.Transparent;
            chartArea20.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea20.BorderColor = System.Drawing.Color.Transparent;
            chartArea20.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea20.BorderWidth = 0;
            chartArea20.IsSameFontSizeForAllAxes = true;
            chartArea20.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea20);
            legend15.Alignment = System.Drawing.StringAlignment.Far;
            legend15.BackColor = System.Drawing.Color.Transparent;
            legend15.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend15.BackImageTransparentColor = System.Drawing.Color.Transparent;
            legend15.BorderColor = System.Drawing.Color.Blue;
            legend15.BorderWidth = 0;
            legendItem10.BorderColor = System.Drawing.Color.White;
            legendItem10.SeparatorColor = System.Drawing.Color.White;
            legend15.CustomItems.Add(legendItem10);
            legend15.DockedToChartArea = "ChartArea1";
            legend15.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend15.Enabled = false;
            legend15.ForeColor = System.Drawing.Color.DarkRed;
            legend15.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine;
            legend15.HeaderSeparatorColor = System.Drawing.Color.Maroon;
            legend15.InterlacedRows = true;
            legend15.InterlacedRowsColor = System.Drawing.Color.Blue;
            legend15.IsEquallySpacedItems = true;
            legend15.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend15.ItemColumnSeparatorColor = System.Drawing.Color.Maroon;
            legend15.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend15.Name = "Legend1";
            legend15.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            legend15.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend15.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            legend15.TitleForeColor = System.Drawing.Color.Maroon;
            legend15.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend15.TitleSeparatorColor = System.Drawing.Color.Maroon;
            this.chart4.Legends.Add(legend15);
            this.chart4.Location = new System.Drawing.Point(427, 261);
            this.chart4.Margin = new System.Windows.Forms.Padding(0);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series20.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series20.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series20.Color = System.Drawing.Color.Transparent;
            series20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series20.IsValueShownAsLabel = true;
            series20.IsVisibleInLegend = false;
            series20.IsXValueIndexed = true;
            series20.LabelBorderColor = System.Drawing.Color.Transparent;
            series20.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series20.LabelBorderWidth = 0;
            series20.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series20.Legend = "Legend1";
            series20.MarkerSize = 1;
            series20.Name = "Series1";
            series20.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series20.ShadowOffset = 3;
            series20.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series20.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Diamond;
            series20.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.RoyalBlue;
            series20.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series20.SmartLabelStyle.CalloutLineWidth = 2;
            series20.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series20.SmartLabelStyle.MaxMovingDistance = 25D;
            series20.SmartLabelStyle.MinMovingDistance = 30D;
            this.chart4.Series.Add(series20);
            this.chart4.Size = new System.Drawing.Size(269, 186);
            this.chart4.TabIndex = 10;
            this.chart4.Text = "chart4";
            title10.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title10.BackColor = System.Drawing.Color.Transparent;
            title10.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            title10.DockedToChartArea = "ChartArea1";
            title10.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title10.DockingOffset = 10;
            title10.ForeColor = System.Drawing.Color.Gainsboro;
            title10.Name = "Title1";
            title10.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            title10.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chart4.Titles.Add(title10);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(274, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(323, 435);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 425);
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