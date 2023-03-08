namespace RestauranteLaIndita
{
    partial class Mesas
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
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.Modificaciones = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdMesa = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.Altas = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIdMesa2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.Modificaciones.SuspendLayout();
            this.Altas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMesas
            // 
            this.dgvMesas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvMesas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvMesas.Location = new System.Drawing.Point(296, 267);
            this.dgvMesas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.RowHeadersWidth = 57;
            this.dgvMesas.Size = new System.Drawing.Size(262, 122);
            this.dgvMesas.TabIndex = 88;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdMesa";
            this.Column1.MinimumWidth = 7;
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 7;
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(105, 64);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 29);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(219, 64);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 29);
            this.btnModificar.TabIndex = 58;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Modificaciones
            // 
            this.Modificaciones.BackColor = System.Drawing.Color.PeachPuff;
            this.Modificaciones.BackgroundImage = global::RestauranteLaIndita.Properties.Resources.fondoMenus;
            this.Modificaciones.Controls.Add(this.label1);
            this.Modificaciones.Controls.Add(this.txtNombre2);
            this.Modificaciones.Controls.Add(this.label8);
            this.Modificaciones.Controls.Add(this.txtIdMesa2);
            this.Modificaciones.Controls.Add(this.btnModificar);
            this.Modificaciones.Controls.Add(this.btnBuscar);
            this.Modificaciones.Location = new System.Drawing.Point(451, 133);
            this.Modificaciones.Margin = new System.Windows.Forms.Padding(2);
            this.Modificaciones.Name = "Modificaciones";
            this.Modificaciones.Padding = new System.Windows.Forms.Padding(2);
            this.Modificaciones.Size = new System.Drawing.Size(392, 114);
            this.Modificaciones.TabIndex = 89;
            this.Modificaciones.TabStop = false;
            this.Modificaciones.Text = "Modificaciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(223, 68);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 29);
            this.btnSalir.TabIndex = 78;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(223, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 72;
            // 
            // txtIdMesa
            // 
            this.txtIdMesa.Location = new System.Drawing.Point(64, 32);
            this.txtIdMesa.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdMesa.Name = "txtIdMesa";
            this.txtIdMesa.Size = new System.Drawing.Size(90, 20);
            this.txtIdMesa.TabIndex = 69;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(116, 68);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(56, 29);
            this.btnAñadir.TabIndex = 74;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // Altas
            // 
            this.Altas.BackColor = System.Drawing.Color.PeachPuff;
            this.Altas.BackgroundImage = global::RestauranteLaIndita.Properties.Resources.fondoMenus;
            this.Altas.Controls.Add(this.label3);
            this.Altas.Controls.Add(this.label2);
            this.Altas.Controls.Add(this.btnAñadir);
            this.Altas.Controls.Add(this.txtIdMesa);
            this.Altas.Controls.Add(this.txtNombre);
            this.Altas.Controls.Add(this.btnSalir);
            this.Altas.Location = new System.Drawing.Point(48, 133);
            this.Altas.Name = "Altas";
            this.Altas.Size = new System.Drawing.Size(381, 114);
            this.Altas.TabIndex = 90;
            this.Altas.TabStop = false;
            this.Altas.Text = "Altas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "IdMesa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::RestauranteLaIndita.Properties.Resources.zyro_image_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(748, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // txtIdMesa2
            // 
            this.txtIdMesa2.Location = new System.Drawing.Point(70, 31);
            this.txtIdMesa2.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdMesa2.Name = "txtIdMesa2";
            this.txtIdMesa2.Size = new System.Drawing.Size(90, 20);
            this.txtIdMesa2.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "Nombre";
            // 
            // txtNombre2
            // 
            this.txtNombre2.Enabled = false;
            this.txtNombre2.Location = new System.Drawing.Point(235, 32);
            this.txtNombre2.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(128, 20);
            this.txtNombre2.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "IdMesa";
            // 
            // Mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestauranteLaIndita.Properties.Resources.FondoRestaurante;
            this.ClientSize = new System.Drawing.Size(910, 435);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Altas);
            this.Controls.Add(this.Modificaciones);
            this.Controls.Add(this.dgvMesas);
            this.Name = "Mesas";
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.Mesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.Modificaciones.ResumeLayout(false);
            this.Modificaciones.PerformLayout();
            this.Altas.ResumeLayout(false);
            this.Altas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox Modificaciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdMesa;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.GroupBox Altas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdMesa2;
    }
}