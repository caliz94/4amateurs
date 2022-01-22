namespace PRESENTACION
{
    partial class REGIST_USU_AMATEURS
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
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.BTN_ELIMINAR = new FontAwesome.Sharp.IconButton();
            this.BTN_EDITAR = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTN_GUARDAR = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.txt_comentario = new System.Windows.Forms.TextBox();
            this.txt_fecha_ingreso = new System.Windows.Forms.TextBox();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_id_integrante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_usuarios.Location = new System.Drawing.Point(637, 0);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.Size = new System.Drawing.Size(707, 694);
            this.dgv_usuarios.TabIndex = 20;
            // 
            // BTN_ELIMINAR
            // 
            this.BTN_ELIMINAR.FlatAppearance.BorderSize = 0;
            this.BTN_ELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BTN_ELIMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTN_ELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ELIMINAR.Font = new System.Drawing.Font("Flames", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ELIMINAR.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BTN_ELIMINAR.IconColor = System.Drawing.Color.Green;
            this.BTN_ELIMINAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_ELIMINAR.IconSize = 35;
            this.BTN_ELIMINAR.Location = new System.Drawing.Point(105, 7);
            this.BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            this.BTN_ELIMINAR.Size = new System.Drawing.Size(92, 51);
            this.BTN_ELIMINAR.TabIndex = 21;
            this.BTN_ELIMINAR.Text = "ELIMINAR";
            this.BTN_ELIMINAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTN_ELIMINAR.UseVisualStyleBackColor = true;
            this.BTN_ELIMINAR.Click += new System.EventHandler(this.BTN_ELIMINAR_Click);
            // 
            // BTN_EDITAR
            // 
            this.BTN_EDITAR.FlatAppearance.BorderSize = 0;
            this.BTN_EDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BTN_EDITAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTN_EDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EDITAR.Font = new System.Drawing.Font("Flames", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EDITAR.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BTN_EDITAR.IconColor = System.Drawing.Color.Green;
            this.BTN_EDITAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_EDITAR.IconSize = 35;
            this.BTN_EDITAR.Location = new System.Drawing.Point(7, 7);
            this.BTN_EDITAR.Name = "BTN_EDITAR";
            this.BTN_EDITAR.Size = new System.Drawing.Size(92, 51);
            this.BTN_EDITAR.TabIndex = 22;
            this.BTN_EDITAR.Text = "EDITAR";
            this.BTN_EDITAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTN_EDITAR.UseVisualStyleBackColor = true;
            this.BTN_EDITAR.Click += new System.EventHandler(this.BTN_EDITAR_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Flames", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.iconButton1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(1344, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(42, 788);
            this.iconButton1.TabIndex = 23;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 694);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 94);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTN_EDITAR);
            this.panel2.Controls.Add(this.BTN_ELIMINAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(890, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 94);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_id_integrante);
            this.panel3.Controls.Add(this.BTN_GUARDAR);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_celular);
            this.panel3.Controls.Add(this.txt_comentario);
            this.panel3.Controls.Add(this.txt_fecha_ingreso);
            this.panel3.Controls.Add(this.txt_pais);
            this.panel3.Controls.Add(this.txt_usuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 694);
            this.panel3.TabIndex = 25;
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.FlatAppearance.BorderSize = 0;
            this.BTN_GUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BTN_GUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTN_GUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_GUARDAR.Font = new System.Drawing.Font("Flames", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GUARDAR.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BTN_GUARDAR.IconColor = System.Drawing.Color.Green;
            this.BTN_GUARDAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_GUARDAR.IconSize = 35;
            this.BTN_GUARDAR.Location = new System.Drawing.Point(218, 254);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(150, 51);
            this.BTN_GUARDAR.TabIndex = 33;
            this.BTN_GUARDAR.Text = "Guardar";
            this.BTN_GUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTN_GUARDAR.UseVisualStyleBackColor = true;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Pais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fecha de Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Comentario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Usuario";
            // 
            // txt_celular
            // 
            this.txt_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celular.Location = new System.Drawing.Point(218, 101);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(150, 26);
            this.txt_celular.TabIndex = 25;
            // 
            // txt_comentario
            // 
            this.txt_comentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comentario.Location = new System.Drawing.Point(218, 209);
            this.txt_comentario.Name = "txt_comentario";
            this.txt_comentario.Size = new System.Drawing.Size(150, 26);
            this.txt_comentario.TabIndex = 24;
            // 
            // txt_fecha_ingreso
            // 
            this.txt_fecha_ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_ingreso.Location = new System.Drawing.Point(218, 169);
            this.txt_fecha_ingreso.Name = "txt_fecha_ingreso";
            this.txt_fecha_ingreso.Size = new System.Drawing.Size(150, 26);
            this.txt_fecha_ingreso.TabIndex = 23;
            // 
            // txt_pais
            // 
            this.txt_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pais.Location = new System.Drawing.Point(218, 135);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(150, 26);
            this.txt_pais.TabIndex = 21;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(218, 62);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(150, 26);
            this.txt_usuario.TabIndex = 20;
            // 
            // txt_id_integrante
            // 
            this.txt_id_integrante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_integrante.Location = new System.Drawing.Point(218, 30);
            this.txt_id_integrante.Name = "txt_id_integrante";
            this.txt_id_integrante.Size = new System.Drawing.Size(150, 26);
            this.txt_id_integrante.TabIndex = 34;
            // 
            // REGIST_USU_AMATEURS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "REGIST_USU_AMATEURS";
            this.Text = "REGIST_USU_AMATEURS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.REGIST_USU_AMATEURS_FormClosed);
            this.Load += new System.EventHandler(this.REGIST_USU_AMATEURS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private FontAwesome.Sharp.IconButton BTN_ELIMINAR;
        private FontAwesome.Sharp.IconButton BTN_EDITAR;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton BTN_GUARDAR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.TextBox txt_comentario;
        private System.Windows.Forms.TextBox txt_fecha_ingreso;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_id_integrante;
    }
}