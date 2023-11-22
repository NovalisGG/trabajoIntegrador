namespace Prototipo_registro_de_alumnos.Ventanas
{
    partial class ventanaAgregarServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaAgregarServidor));
            this.tbox_agregarServidor = new Prototipo_registro_de_alumnos.TextBoxPersonalizado();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agregar = new Prototipo_registro_de_alumnos.BotonPersonalizado();
            this.SuspendLayout();
            // 
            // tbox_agregarServidor
            // 
            this.tbox_agregarServidor.BackColor = System.Drawing.SystemColors.Window;
            this.tbox_agregarServidor.BorderColor = System.Drawing.Color.Crimson;
            this.tbox_agregarServidor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbox_agregarServidor.BorderSize = 2;
            this.tbox_agregarServidor.ForeColor = System.Drawing.Color.DimGray;
            this.tbox_agregarServidor.Location = new System.Drawing.Point(230, 77);
            this.tbox_agregarServidor.Multiline = false;
            this.tbox_agregarServidor.Name = "tbox_agregarServidor";
            this.tbox_agregarServidor.Padding = new System.Windows.Forms.Padding(7);
            this.tbox_agregarServidor.PasswordChar = false;
            this.tbox_agregarServidor.Size = new System.Drawing.Size(375, 40);
            this.tbox_agregarServidor.TabIndex = 0;
            this.tbox_agregarServidor.Texts = "";
            this.tbox_agregarServidor.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 225);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agregar servidor:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.White;
            this.btn_agregar.BackgroundColor = System.Drawing.Color.White;
            this.btn_agregar.BorderColor = System.Drawing.Color.Yellow;
            this.btn_agregar.BorderRadius = 40;
            this.btn_agregar.BorderSize = 0;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_agregar.Location = new System.Drawing.Point(631, 75);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(135, 42);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextColor = System.Drawing.Color.Black;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.botonPersonalizado1_Click);
            // 
            // ventanaAgregarServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_agregarServidor);
            this.Name = "ventanaAgregarServidor";
            this.Text = "ventanaAgregarServidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxPersonalizado tbox_agregarServidor;
        private Label label1;
        private Label label2;
        private BotonPersonalizado btn_agregar;
    }
}