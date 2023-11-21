namespace Prototipo_registro_de_alumnos
{
    partial class pantallaBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantallaBuscar));
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Buscar = new Prototipo_registro_de_alumnos.BotonPersonalizado();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cmb_tutorOalumno = new Prototipo_registro_de_alumnos.ComboboxPersonalizado();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_eliminarRegistro = new Prototipo_registro_de_alumnos.BotonPersonalizado();
            this.tbox_barraBusqueda = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonPersonalizado1 = new Prototipo_registro_de_alumnos.BotonPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AllowUserToResizeRows = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAlumnos.Location = new System.Drawing.Point(0, 180);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersWidth = 62;
            this.dgvAlumnos.RowTemplate.Height = 33;
            this.dgvAlumnos.Size = new System.Drawing.Size(1372, 277);
            this.dgvAlumnos.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.Gold;
            this.btn_Buscar.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_Buscar.BorderColor = System.Drawing.Color.Yellow;
            this.btn_Buscar.BorderRadius = 40;
            this.btn_Buscar.BorderSize = 0;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.ForeColor = System.Drawing.Color.Black;
            this.btn_Buscar.Location = new System.Drawing.Point(869, 130);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(99, 46);
            this.btn_Buscar.TabIndex = 7;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextColor = System.Drawing.Color.Black;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // cmb_tutorOalumno
            // 
            this.cmb_tutorOalumno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_tutorOalumno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_tutorOalumno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_tutorOalumno.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_tutorOalumno.BorderSize = 1;
            this.cmb_tutorOalumno.DisplayMember = "";
            this.cmb_tutorOalumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_tutorOalumno.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_tutorOalumno.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_tutorOalumno.Items.AddRange(new object[] {
            "Alumno",
            "Tutor"});
            this.cmb_tutorOalumno.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_tutorOalumno.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_tutorOalumno.Location = new System.Drawing.Point(12, 134);
            this.cmb_tutorOalumno.MinimumSize = new System.Drawing.Size(50, 30);
            this.cmb_tutorOalumno.Name = "cmb_tutorOalumno";
            this.cmb_tutorOalumno.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_tutorOalumno.SelectedItem = null;
            this.cmb_tutorOalumno.Size = new System.Drawing.Size(141, 40);
            this.cmb_tutorOalumno.TabIndex = 9;
            this.cmb_tutorOalumno.Texts = "";
            this.cmb_tutorOalumno.ValueMember = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tabla a buscar:";
            // 
            // btn_eliminarRegistro
            // 
            this.btn_eliminarRegistro.BackColor = System.Drawing.Color.Gold;
            this.btn_eliminarRegistro.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_eliminarRegistro.BorderColor = System.Drawing.Color.Yellow;
            this.btn_eliminarRegistro.BorderRadius = 40;
            this.btn_eliminarRegistro.BorderSize = 0;
            this.btn_eliminarRegistro.FlatAppearance.BorderSize = 0;
            this.btn_eliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarRegistro.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminarRegistro.Location = new System.Drawing.Point(974, 130);
            this.btn_eliminarRegistro.Name = "btn_eliminarRegistro";
            this.btn_eliminarRegistro.Size = new System.Drawing.Size(99, 46);
            this.btn_eliminarRegistro.TabIndex = 11;
            this.btn_eliminarRegistro.Text = "Eliminar";
            this.btn_eliminarRegistro.TextColor = System.Drawing.Color.Black;
            this.btn_eliminarRegistro.UseVisualStyleBackColor = false;
            this.btn_eliminarRegistro.Click += new System.EventHandler(this.btn_eliminarRegistro_Click);
            // 
            // tbox_barraBusqueda
            // 
            this.tbox_barraBusqueda.Location = new System.Drawing.Point(159, 138);
            this.tbox_barraBusqueda.Name = "tbox_barraBusqueda";
            this.tbox_barraBusqueda.Size = new System.Drawing.Size(664, 31);
            this.tbox_barraBusqueda.TabIndex = 12;
            this.tbox_barraBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_barraBusqueda_KeyPress);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(391, 99);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 25);
            this.label.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(159, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "(Busque por apellido o por DNI)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(-14, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1386, 82);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(245, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 63);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar alumno/tutor";
            // 
            // botonPersonalizado1
            // 
            this.botonPersonalizado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonPersonalizado1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonPersonalizado1.BorderColor = System.Drawing.Color.White;
            this.botonPersonalizado1.BorderRadius = 40;
            this.botonPersonalizado1.BorderSize = 2;
            this.botonPersonalizado1.FlatAppearance.BorderSize = 0;
            this.botonPersonalizado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPersonalizado1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botonPersonalizado1.ForeColor = System.Drawing.Color.White;
            this.botonPersonalizado1.Location = new System.Drawing.Point(918, 9);
            this.botonPersonalizado1.Name = "botonPersonalizado1";
            this.botonPersonalizado1.Size = new System.Drawing.Size(155, 51);
            this.botonPersonalizado1.TabIndex = 17;
            this.botonPersonalizado1.Text = "Volver";
            this.botonPersonalizado1.TextColor = System.Drawing.Color.White;
            this.botonPersonalizado1.UseVisualStyleBackColor = false;
            this.botonPersonalizado1.Click += new System.EventHandler(this.botonPersonalizado1_Click);
            // 
            // pantallaBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1090, 483);
            this.Controls.Add(this.botonPersonalizado1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbox_barraBusqueda);
            this.Controls.Add(this.btn_eliminarRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_tutorOalumno);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "pantallaBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar alumnos";
            this.Load += new System.EventHandler(this.pantallaBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvAlumnos;
        private PictureBox pictureBox1;
        private BotonPersonalizado btn_Buscar;
        private FolderBrowserDialog folderBrowserDialog1;
        private ComboboxPersonalizado cmb_tutorOalumno;
        private Label label2;
        private BotonPersonalizado btn_eliminarRegistro;
        private TextBox tbox_barraBusqueda;
        private Label label;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label1;
        private BotonPersonalizado botonPersonalizado1;
    }
}