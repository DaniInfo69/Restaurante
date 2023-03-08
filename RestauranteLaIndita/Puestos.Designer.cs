namespace RestauranteLaIndita
{
    partial class Puestos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Altas = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.txtIdPuesto = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Modificaciones = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPuesto2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdPuesto2 = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Altas.SuspendLayout();
            this.Modificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::RestauranteLaIndita.Properties.Resources.zyro_image_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(759, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // Altas
            // 
            this.Altas.BackColor = System.Drawing.Color.PeachPuff;
            this.Altas.BackgroundImage = global::RestauranteLaIndita.Properties.Resources.fondoMenus;
            this.Altas.Controls.Add(this.label3);
            this.Altas.Controls.Add(this.label2);
            this.Altas.Controls.Add(this.btnAñadir);
            this.Altas.Controls.Add(this.txtIdPuesto);
            this.Altas.Controls.Add(this.txtPuesto);
            this.Altas.Controls.Add(this.btnSalir);
            this.Altas.Location = new System.Drawing.Point(59, 166);
            this.Altas.Name = "Altas";
            this.Altas.Size = new System.Drawing.Size(381, 114);
            this.Altas.TabIndex = 94;
            this.Altas.TabStop = false;
            this.Altas.Text = "Altas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "IdPuesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Puesto";
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
            // txtIdPuesto
            // 
            this.txtIdPuesto.Enabled = false;
            this.txtIdPuesto.Location = new System.Drawing.Point(64, 32);
            this.txtIdPuesto.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdPuesto.Name = "txtIdPuesto";
            this.txtIdPuesto.Size = new System.Drawing.Size(90, 20);
            this.txtIdPuesto.TabIndex = 69;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(223, 32);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(2);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(128, 20);
            this.txtPuesto.TabIndex = 72;
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
            // Modificaciones
            // 
            this.Modificaciones.BackColor = System.Drawing.Color.PeachPuff;
            this.Modificaciones.BackgroundImage = global::RestauranteLaIndita.Properties.Resources.fondoMenus;
            this.Modificaciones.Controls.Add(this.label1);
            this.Modificaciones.Controls.Add(this.txtPuesto2);
            this.Modificaciones.Controls.Add(this.label8);
            this.Modificaciones.Controls.Add(this.txtIdPuesto2);
            this.Modificaciones.Controls.Add(this.btnModificar);
            this.Modificaciones.Controls.Add(this.btnBuscar);
            this.Modificaciones.Location = new System.Drawing.Point(462, 166);
            this.Modificaciones.Margin = new System.Windows.Forms.Padding(2);
            this.Modificaciones.Name = "Modificaciones";
            this.Modificaciones.Padding = new System.Windows.Forms.Padding(2);
            this.Modificaciones.Size = new System.Drawing.Size(392, 114);
            this.Modificaciones.TabIndex = 93;
            this.Modificaciones.TabStop = false;
            this.Modificaciones.Text = "Modificaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "IdPuesto";
            // 
            // txtPuesto2
            // 
            this.txtPuesto2.Enabled = false;
            this.txtPuesto2.Location = new System.Drawing.Point(235, 32);
            this.txtPuesto2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPuesto2.Name = "txtPuesto2";
            this.txtPuesto2.Size = new System.Drawing.Size(128, 20);
            this.txtPuesto2.TabIndex = 96;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "Puesto";
            // 
            // txtIdPuesto2
            // 
            this.txtIdPuesto2.Location = new System.Drawing.Point(70, 31);
            this.txtIdPuesto2.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdPuesto2.Name = "txtIdPuesto2";
            this.txtIdPuesto2.Size = new System.Drawing.Size(90, 20);
            this.txtIdPuesto2.TabIndex = 91;
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
            // dgvPuestos
            // 
            this.dgvPuestos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPuestos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPuestos.Location = new System.Drawing.Point(255, 299);
            this.dgvPuestos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.RowHeadersWidth = 57;
            this.dgvPuestos.Size = new System.Drawing.Size(262, 122);
            this.dgvPuestos.TabIndex = 92;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdPuesto";
            this.Column1.MinimumWidth = 7;
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Puesto";
            this.Column2.MinimumWidth = 7;
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestauranteLaIndita.Properties.Resources.FondoRestaurante;
            this.ClientSize = new System.Drawing.Size(920, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Altas);
            this.Controls.Add(this.Modificaciones);
            this.Controls.Add(this.dgvPuestos);
            this.Name = "Puestos";
            this.Text = "Puestos";
            this.Load += new System.EventHandler(this.Puestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Altas.ResumeLayout(false);
            this.Altas.PerformLayout();
            this.Modificaciones.ResumeLayout(false);
            this.Modificaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Altas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.TextBox txtIdPuesto;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox Modificaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPuesto2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdPuesto2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}