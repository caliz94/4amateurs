namespace PRESENTACION
{
    partial class REGISTRO_PLACAS
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_cont = new System.Windows.Forms.Panel();
            this.dgv_placas_mes = new System.Windows.Forms.DataGridView();
            this.dgv_fechas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_placas = new System.Windows.Forms.TextBox();
            this.dgv_integrantes = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_semana = new System.Windows.Forms.TextBox();
            this.txt_mes = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_id_integrante = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_cont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_placas_mes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fechas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_integrantes)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_cont
            // 
            this.pnl_cont.BackColor = System.Drawing.Color.DimGray;
            this.pnl_cont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_cont.Controls.Add(this.dgv_placas_mes);
            this.pnl_cont.Controls.Add(this.dgv_fechas);
            this.pnl_cont.Controls.Add(this.label2);
            this.pnl_cont.Controls.Add(this.txt_placas);
            this.pnl_cont.Controls.Add(this.dgv_integrantes);
            this.pnl_cont.Controls.Add(this.iconButton1);
            this.pnl_cont.Controls.Add(this.label4);
            this.pnl_cont.Controls.Add(this.label3);
            this.pnl_cont.Controls.Add(this.lbl_nombre);
            this.pnl_cont.Controls.Add(this.label1);
            this.pnl_cont.Controls.Add(this.txt_semana);
            this.pnl_cont.Controls.Add(this.txt_mes);
            this.pnl_cont.Controls.Add(this.txt_Nombre);
            this.pnl_cont.Controls.Add(this.txt_id_integrante);
            this.pnl_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_cont.Location = new System.Drawing.Point(0, 0);
            this.pnl_cont.Name = "pnl_cont";
            this.pnl_cont.Size = new System.Drawing.Size(1157, 487);
            this.pnl_cont.TabIndex = 11;
            // 
            // dgv_placas_mes
            // 
            this.dgv_placas_mes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_placas_mes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgv_placas_mes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_placas_mes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_placas_mes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_placas_mes.Location = new System.Drawing.Point(495, 44);
            this.dgv_placas_mes.MultiSelect = false;
            this.dgv_placas_mes.Name = "dgv_placas_mes";
            this.dgv_placas_mes.ReadOnly = true;
            this.dgv_placas_mes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_placas_mes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_placas_mes.Size = new System.Drawing.Size(608, 390);
            this.dgv_placas_mes.TabIndex = 25;
            // 
            // dgv_fechas
            // 
            this.dgv_fechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fechas.Location = new System.Drawing.Point(202, 10);
            this.dgv_fechas.Name = "dgv_fechas";
            this.dgv_fechas.Size = new System.Drawing.Size(36, 16);
            this.dgv_fechas.TabIndex = 24;
            this.dgv_fechas.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(216, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "PLACAS";
            // 
            // txt_placas
            // 
            this.txt_placas.BackColor = System.Drawing.Color.White;
            this.txt_placas.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_placas.Location = new System.Drawing.Point(216, 371);
            this.txt_placas.Name = "txt_placas";
            this.txt_placas.Size = new System.Drawing.Size(196, 20);
            this.txt_placas.TabIndex = 22;
            // 
            // dgv_integrantes
            // 
            this.dgv_integrantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_integrantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_integrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_integrantes.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_integrantes.Location = new System.Drawing.Point(0, 0);
            this.dgv_integrantes.Name = "dgv_integrantes";
            this.dgv_integrantes.ReadOnly = true;
            this.dgv_integrantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_integrantes.Size = new System.Drawing.Size(196, 483);
            this.dgv_integrantes.TabIndex = 20;
            this.dgv_integrantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_integrantes_CellClick);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DimGray;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Flames", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Green;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(216, 397);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(181, 63);
            this.iconButton1.TabIndex = 19;
            this.iconButton1.Text = "AGREGAR";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(216, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "SEMANA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(216, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "MES";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.DimGray;
            this.lbl_nombre.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(216, 116);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(75, 19);
            this.lbl_nombre.TabIndex = 16;
            this.lbl_nombre.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID DEL INTEGRANTE";
            // 
            // txt_semana
            // 
            this.txt_semana.BackColor = System.Drawing.Color.White;
            this.txt_semana.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_semana.Location = new System.Drawing.Point(216, 291);
            this.txt_semana.Name = "txt_semana";
            this.txt_semana.Size = new System.Drawing.Size(196, 20);
            this.txt_semana.TabIndex = 14;
            // 
            // txt_mes
            // 
            this.txt_mes.BackColor = System.Drawing.Color.White;
            this.txt_mes.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_mes.Location = new System.Drawing.Point(216, 214);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(196, 20);
            this.txt_mes.TabIndex = 13;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.White;
            this.txt_Nombre.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_Nombre.Location = new System.Drawing.Point(216, 138);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(196, 20);
            this.txt_Nombre.TabIndex = 12;
            // 
            // txt_id_integrante
            // 
            this.txt_id_integrante.BackColor = System.Drawing.Color.White;
            this.txt_id_integrante.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_id_integrante.Location = new System.Drawing.Point(216, 66);
            this.txt_id_integrante.Name = "txt_id_integrante";
            this.txt_id_integrante.Size = new System.Drawing.Size(196, 20);
            this.txt_id_integrante.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.iconButton2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1157, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(41, 487);
            this.panel5.TabIndex = 15;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.DimGray;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumVioletRed;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Flames", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.iconButton2.IconColor = System.Drawing.Color.Green;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(41, 487);
            this.iconButton2.TabIndex = 21;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // REGISTRO_PLACAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 487);
            this.Controls.Add(this.pnl_cont);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "REGISTRO_PLACAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO_PLACAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.REGISTRO_PLACAS_FormClosed);
            this.Load += new System.EventHandler(this.REGISTRO_PLACAS_Load);
            this.pnl_cont.ResumeLayout(false);
            this.pnl_cont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_placas_mes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fechas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_integrantes)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_cont;
        private System.Windows.Forms.DataGridView dgv_integrantes;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_semana;
        private System.Windows.Forms.TextBox txt_mes;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_id_integrante;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_placas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_fechas;
        private System.Windows.Forms.DataGridView dgv_placas_mes;
    }
}