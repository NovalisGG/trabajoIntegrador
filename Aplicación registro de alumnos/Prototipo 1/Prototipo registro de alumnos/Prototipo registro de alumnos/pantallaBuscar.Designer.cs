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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_Buscar = new Prototipo_registro_de_alumnos.BotonPersonalizado();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbox_barraBusqueda = new Prototipo_registro_de_alumnos.TextBoxPersonalizado();
            this.cmb_tutorOalumno = new Prototipo_registro_de_alumnos.ComboboxPersonalizado();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_eliminarRegistro = new Prototipo_registro_de_alumnos.BotonPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAlumnos.Location = new System.Drawing.Point(0, 198);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 62;
            this.dgvAlumnos.RowTemplate.Height = 33;
            this.dgvAlumnos.Size = new System.Drawing.Size(1367, 277);
            this.dgvAlumnos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Búsqueda de datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(676, 9);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(112, 31);
            this.btn_volver.TabIndex = 6;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
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
            this.btn_Buscar.Location = new System.Drawing.Point(1043, 120);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(99, 46);
            this.btn_Buscar.TabIndex = 7;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextColor = System.Drawing.Color.Black;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // tbox_barraBusqueda
            // 
            this.tbox_barraBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.tbox_barraBusqueda.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbox_barraBusqueda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbox_barraBusqueda.BorderSize = 2;
            this.tbox_barraBusqueda.ForeColor = System.Drawing.Color.DimGray;
            this.tbox_barraBusqueda.Location = new System.Drawing.Point(366, 124);
            this.tbox_barraBusqueda.Multiline = false;
            this.tbox_barraBusqueda.Name = "tbox_barraBusqueda";
            this.tbox_barraBusqueda.Padding = new System.Windows.Forms.Padding(7);
            this.tbox_barraBusqueda.PasswordChar = false;
            this.tbox_barraBusqueda.Size = new System.Drawing.Size(671, 40);
            this.tbox_barraBusqueda.TabIndex = 8;
            this.tbox_barraBusqueda.Texts = "";
            this.tbox_barraBusqueda.UnderlinedStyle = false;
            this.tbox_barraBusqueda._TextChanged += new System.EventHandler(this.textBoxPersonalizado1__TextChanged);
            this.tbox_barraBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_barraBusqueda_KeyPress);
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
            this.cmb_tutorOalumno.Location = new System.Drawing.Point(186, 124);
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
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(113, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar:";
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
            this.btn_eliminarRegistro.Location = new System.Drawing.Point(1148, 120);
            this.btn_eliminarRegistro.Name = "btn_eliminarRegistro";
            this.btn_eliminarRegistro.Size = new System.Drawing.Size(99, 46);
            this.btn_eliminarRegistro.TabIndex = 11;
            this.btn_eliminarRegistro.Text = "Eliminar";
            this.btn_eliminarRegistro.TextColor = System.Drawing.Color.Black;
            this.btn_eliminarRegistro.UseVisualStyleBackColor = false;
            this.btn_eliminarRegistro.Click += new System.EventHandler(this.btn_eliminarRegistro_Click);
            // 
            // pantallaBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1367, 475);
            this.Controls.Add(this.btn_eliminarRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_tutorOalumno);
            this.Controls.Add(this.tbox_barraBusqueda);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAlumnos);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "pantallaBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar alumnos";
            this.Load += new System.EventHandler(this.pantallaBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvAlumnos;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_volver;
        private BotonPersonalizado btn_Buscar;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBoxPersonalizado tbox_barraBusqueda;
        private ComboboxPersonalizado cmb_tutorOalumno;
        private Label label2;
        private BotonPersonalizado btn_eliminarRegistro;
    }
}