namespace Prototipo_registro_de_alumnos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_registrar = new Prototipo_registro_de_alumnos.BotonPersonalizado();
            this.btn_buscar = new Prototipo_registro_de_alumnos.BotonPersonalizado();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_actualizar = new Prototipo_registro_de_alumnos.BotonPersonalizado();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ventanaAgregarServidor = new Prototipo_registro_de_alumnos.BotonPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_registrar.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btn_registrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_registrar.BackgroundImage")));
            this.btn_registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registrar.BorderColor = System.Drawing.Color.Yellow;
            this.btn_registrar.BorderRadius = 40;
            this.btn_registrar.BorderSize = 0;
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(70, 103);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(250, 254);
            this.btn_registrar.TabIndex = 2;
            this.btn_registrar.TextColor = System.Drawing.Color.White;
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_buscar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_buscar.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buscar.BorderColor = System.Drawing.Color.Yellow;
            this.btn_buscar.BorderRadius = 40;
            this.btn_buscar.BorderSize = 0;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(399, 103);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(250, 254);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.TextColor = System.Drawing.Color.White;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(61, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agregar alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(399, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar alumnos";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label25.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(234, 9);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(578, 63);
            this.label25.TabIndex = 47;
            this.label25.Text = "Registro de alumnos";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(234, 429);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(639, 38);
            this.label26.TabIndex = 48;
            this.label26.Text = "IPET N° 247 Ing. Carlos Cassaffousth";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(-4, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1072, 95);
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(687, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 37);
            this.label3.TabIndex = 51;
            this.label3.Text = "Actualizar alumnos";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_actualizar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_actualizar.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btn_actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.BackgroundImage")));
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.BorderColor = System.Drawing.Color.Yellow;
            this.btn_actualizar.BorderRadius = 40;
            this.btn_actualizar.BorderSize = 0;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_actualizar.Location = new System.Drawing.Point(722, 103);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(250, 254);
            this.btn_actualizar.TabIndex = 50;
            this.btn_actualizar.TextColor = System.Drawing.Color.White;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(188, 420);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 52);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ventanaAgregarServidor
            // 
            this.btn_ventanaAgregarServidor.BackColor = System.Drawing.Color.White;
            this.btn_ventanaAgregarServidor.BackgroundColor = System.Drawing.Color.White;
            this.btn_ventanaAgregarServidor.BorderColor = System.Drawing.Color.Yellow;
            this.btn_ventanaAgregarServidor.BorderRadius = 40;
            this.btn_ventanaAgregarServidor.BorderSize = 0;
            this.btn_ventanaAgregarServidor.FlatAppearance.BorderSize = 0;
            this.btn_ventanaAgregarServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventanaAgregarServidor.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ventanaAgregarServidor.ForeColor = System.Drawing.Color.Black;
            this.btn_ventanaAgregarServidor.Location = new System.Drawing.Point(881, 12);
            this.btn_ventanaAgregarServidor.Name = "btn_ventanaAgregarServidor";
            this.btn_ventanaAgregarServidor.Size = new System.Drawing.Size(176, 57);
            this.btn_ventanaAgregarServidor.TabIndex = 53;
            this.btn_ventanaAgregarServidor.Text = "Agregar servidor";
            this.btn_ventanaAgregarServidor.TextColor = System.Drawing.Color.Black;
            this.btn_ventanaAgregarServidor.UseVisualStyleBackColor = false;
            this.btn_ventanaAgregarServidor.Click += new System.EventHandler(this.btn_ventanaAgregarServidor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 478);
            this.Controls.Add(this.btn_ventanaAgregarServidor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BotonPersonalizado btn_registrar;
        private BotonPersonalizado btn_buscar;
        private Label label1;
        private Label label2;
        private Label label25;
        private Label label26;
        private PictureBox pictureBox2;
        private Label label3;
        private BotonPersonalizado btn_actualizar;
        private PictureBox pictureBox1;
        private BotonPersonalizado btn_ventanaAgregarServidor;
    }
}