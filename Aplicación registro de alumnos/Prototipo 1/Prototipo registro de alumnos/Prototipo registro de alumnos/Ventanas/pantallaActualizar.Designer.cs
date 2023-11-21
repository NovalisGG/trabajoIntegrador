namespace Prototipo_registro_de_alumnos
{
    partial class pantallaActualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantallaActualizar));
            this.tbox_dniApellido = new System.Windows.Forms.TextBox();
            this.cmb_tipoPersonaBuscar = new Prototipo_registro_de_alumnos.ComboboxPersonalizado();
            this.cmb_campos = new Prototipo_registro_de_alumnos.ComboboxPersonalizado();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_datoActualizado = new Prototipo_registro_de_alumnos.TextBoxPersonalizado();
            this.btn_actualizar = new Prototipo_registro_de_alumnos.BotonPersonalizado();
            this.btn_guardarFoto = new Prototipo_registro_de_alumnos.BotonPersonalizado();
            this.btn_volver = new Prototipo_registro_de_alumnos.BotonPersonalizado();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_dniApellido
            // 
            this.tbox_dniApellido.Location = new System.Drawing.Point(377, 226);
            this.tbox_dniApellido.Name = "tbox_dniApellido";
            this.tbox_dniApellido.Size = new System.Drawing.Size(274, 31);
            this.tbox_dniApellido.TabIndex = 143;
            this.tbox_dniApellido.TextChanged += new System.EventHandler(this.tbox_dniApellido_TextChanged);
            this.tbox_dniApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_barraBusqueda_KeyPress);
            // 
            // cmb_tipoPersonaBuscar
            // 
            this.cmb_tipoPersonaBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_tipoPersonaBuscar.BorderColor = System.Drawing.Color.Crimson;
            this.cmb_tipoPersonaBuscar.BorderSize = 1;
            this.cmb_tipoPersonaBuscar.DisplayMember = "";
            this.cmb_tipoPersonaBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_tipoPersonaBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_tipoPersonaBuscar.ForeColor = System.Drawing.Color.Black;
            this.cmb_tipoPersonaBuscar.IconColor = System.Drawing.Color.Crimson;
            this.cmb_tipoPersonaBuscar.Items.AddRange(new object[] {
            "Alumnos",
            "Tutores"});
            this.cmb_tipoPersonaBuscar.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_tipoPersonaBuscar.ListTextColor = System.Drawing.Color.Black;
            this.cmb_tipoPersonaBuscar.Location = new System.Drawing.Point(377, 172);
            this.cmb_tipoPersonaBuscar.MinimumSize = new System.Drawing.Size(50, 30);
            this.cmb_tipoPersonaBuscar.Name = "cmb_tipoPersonaBuscar";
            this.cmb_tipoPersonaBuscar.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_tipoPersonaBuscar.SelectedItem = null;
            this.cmb_tipoPersonaBuscar.Size = new System.Drawing.Size(175, 31);
            this.cmb_tipoPersonaBuscar.TabIndex = 145;
            this.cmb_tipoPersonaBuscar.Texts = "";
            this.cmb_tipoPersonaBuscar.ValueMember = "";
            // 
            // cmb_campos
            // 
            this.cmb_campos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_campos.BorderColor = System.Drawing.Color.Crimson;
            this.cmb_campos.BorderSize = 1;
            this.cmb_campos.DisplayMember = "";
            this.cmb_campos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_campos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_campos.ForeColor = System.Drawing.Color.Black;
            this.cmb_campos.IconColor = System.Drawing.Color.Crimson;
            this.cmb_campos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_campos.ListTextColor = System.Drawing.Color.Black;
            this.cmb_campos.Location = new System.Drawing.Point(377, 284);
            this.cmb_campos.MinimumSize = new System.Drawing.Size(50, 30);
            this.cmb_campos.Name = "cmb_campos";
            this.cmb_campos.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_campos.SelectedItem = null;
            this.cmb_campos.Size = new System.Drawing.Size(175, 31);
            this.cmb_campos.TabIndex = 147;
            this.cmb_campos.Texts = "";
            this.cmb_campos.ValueMember = "";
            this.cmb_campos.OnSelectedIndexChanged += new System.EventHandler(this.cmb_campos_OnSelectedIndexChanged);
            this.cmb_campos.Click += new System.EventHandler(this.cmb_campos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 63);
            this.label1.TabIndex = 148;
            this.label1.Text = "Actualizar alumnos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1111, 96);
            this.pictureBox1.TabIndex = 149;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(164, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 150;
            this.label2.Text = "Buscar alumno o tutor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(321, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 151;
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(192, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 152;
            this.label4.Text = "Campo a actualizar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(210, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 153;
            this.label5.Text = "Dato actualizado:";
            // 
            // tbox_datoActualizado
            // 
            this.tbox_datoActualizado.BackColor = System.Drawing.SystemColors.Window;
            this.tbox_datoActualizado.BorderColor = System.Drawing.Color.Crimson;
            this.tbox_datoActualizado.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbox_datoActualizado.BorderSize = 2;
            this.tbox_datoActualizado.ForeColor = System.Drawing.Color.Black;
            this.tbox_datoActualizado.Location = new System.Drawing.Point(377, 343);
            this.tbox_datoActualizado.Multiline = false;
            this.tbox_datoActualizado.Name = "tbox_datoActualizado";
            this.tbox_datoActualizado.Padding = new System.Windows.Forms.Padding(7);
            this.tbox_datoActualizado.PasswordChar = false;
            this.tbox_datoActualizado.Size = new System.Drawing.Size(270, 40);
            this.tbox_datoActualizado.TabIndex = 154;
            this.tbox_datoActualizado.Texts = "";
            this.tbox_datoActualizado.UnderlinedStyle = false;
            this.tbox_datoActualizado._TextChanged += new System.EventHandler(this.tbox_datoActualizado__TextChanged);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.White;
            this.btn_actualizar.BackgroundColor = System.Drawing.Color.White;
            this.btn_actualizar.BorderColor = System.Drawing.Color.Yellow;
            this.btn_actualizar.BorderRadius = 40;
            this.btn_actualizar.BorderSize = 0;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_actualizar.ForeColor = System.Drawing.Color.Black;
            this.btn_actualizar.Location = new System.Drawing.Point(313, 424);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(225, 60);
            this.btn_actualizar.TabIndex = 155;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextColor = System.Drawing.Color.Black;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_guardarFoto
            // 
            this.btn_guardarFoto.BackColor = System.Drawing.Color.White;
            this.btn_guardarFoto.BackgroundColor = System.Drawing.Color.White;
            this.btn_guardarFoto.BorderColor = System.Drawing.Color.Yellow;
            this.btn_guardarFoto.BorderRadius = 40;
            this.btn_guardarFoto.BorderSize = 0;
            this.btn_guardarFoto.Enabled = false;
            this.btn_guardarFoto.FlatAppearance.BorderSize = 0;
            this.btn_guardarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardarFoto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_guardarFoto.ForeColor = System.Drawing.Color.Black;
            this.btn_guardarFoto.Location = new System.Drawing.Point(377, 344);
            this.btn_guardarFoto.Name = "btn_guardarFoto";
            this.btn_guardarFoto.Size = new System.Drawing.Size(192, 51);
            this.btn_guardarFoto.TabIndex = 156;
            this.btn_guardarFoto.Text = "Guardar foto";
            this.btn_guardarFoto.TextColor = System.Drawing.Color.Black;
            this.btn_guardarFoto.UseVisualStyleBackColor = false;
            this.btn_guardarFoto.Visible = false;
            this.btn_guardarFoto.Click += new System.EventHandler(this.btn_guardarFoto_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_volver.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_volver.BorderColor = System.Drawing.Color.White;
            this.btn_volver.BorderRadius = 40;
            this.btn_volver.BorderSize = 2;
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_volver.Location = new System.Drawing.Point(665, 510);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(148, 47);
            this.btn_volver.TabIndex = 157;
            this.btn_volver.Text = "Volver";
            this.btn_volver.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(9, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 81);
            this.pictureBox2.TabIndex = 158;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Location = new System.Drawing.Point(143, 158);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(545, 260);
            this.pictureBox3.TabIndex = 159;
            this.pictureBox3.TabStop = false;
            // 
            // pantallaActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 569);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_guardarFoto);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.tbox_datoActualizado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_campos);
            this.Controls.Add(this.cmb_tipoPersonaBuscar);
            this.Controls.Add(this.tbox_dniApellido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.MaximizeBox = false;
            this.Name = "pantallaActualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actualizar alumno/tutor";
            this.Load += new System.EventHandler(this.pantallaActualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbox_dniApellido;
        private ComboboxPersonalizado cmb_tipoPersonaBuscar;
        private ComboboxPersonalizado cmb_campos;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBoxPersonalizado tbox_datoActualizado;
        private BotonPersonalizado btn_actualizar;
        private BotonPersonalizado btn_guardarFoto;
        private BotonPersonalizado btn_volver;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}