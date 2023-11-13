using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace Prototipo_registro_de_alumnos
{
    [DefaultEvent("OnSelectedIndexChange")]
    public class ComboboxPersonalizado : UserControl
    {
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;

        //Items
        private ComboBox cmb_list;
        private Label lbl_Text;
        private Button btn_Icon;

        //Events
        public event EventHandler OnSelectedIndexChanged;

        //Constructor
        public ComboboxPersonalizado()
        {
            cmb_list = new ComboBox();
            lbl_Text = new Label();
            btn_Icon = new Button();
            this.SuspendLayout();

            //ComboBox: Dropdown List
            cmb_list.BackColor = backColor;
            cmb_list.Font = new Font(this.Font.Name, 10F);
            cmb_list.ForeColor = listTextColor;
            cmb_list.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged); //Default Event
            cmb_list.TextChanged += new EventHandler(ComboBox_TextChanged); //Refresh text

            //Button: Icon
            btn_Icon.Dock = DockStyle.Right;
            btn_Icon.FlatStyle = FlatStyle.Flat;
            btn_Icon.FlatAppearance.BorderSize = 0;
            btn_Icon.BackColor = backColor;
            btn_Icon.Size = new Size(30, 30);
            btn_Icon.Cursor = Cursors.Hand;
            btn_Icon.Click += new EventHandler(Icon_Click);
            btn_Icon.Paint += new PaintEventHandler(Icon_Paint);

            //Label: Text
            lbl_Text.Dock = DockStyle.Fill;
            lbl_Text.AutoSize = false;
            lbl_Text.BackColor = backColor;
            lbl_Text.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Text.Padding = new Padding(0, 0, 0, 0);
            lbl_Text.Font = new Font(this.Font.Name, 10F);
            lbl_Text.Click += new EventHandler(SurfaceClick); //Select ComboBox

            //User control
            this.Controls.Add(lbl_Text);
            this.Controls.Add(btn_Icon);
            this.Controls.Add(cmb_list);
            this.MinimumSize = new Size(50, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        //Private methods
        //Default event
        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
            {
                OnSelectedIndexChanged.Invoke(sender, e);
            }
            //Refresh text
            lbl_Text.Text = cmb_list.Text;
        }
        private void Icon_Paint(object? sender, PaintEventArgs e)
        {
            //Fields
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btn_Icon.Width - iconWidth) / 2, (btn_Icon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            //Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }

        }
        private void Icon_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void AdjustComboBoxDimensions()
        {
            cmb_list.Width = lbl_Text.Width;
            cmb_list.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmb_list.Width,
                Y = lbl_Text.Bottom - cmb_list.Height
            };
        }

        private void SurfaceClick(object? sender, EventArgs e)
        {
            //Open dropdown list
            cmb_list.Select();
            if (cmb_list.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                cmb_list.DroppedDown = true; 
            }
        }

        

       

        private void ComboBox_TextChanged(object? sender, EventArgs e)
        {
            //Refresh text
            lbl_Text.Text = cmb_list.Text;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ComboboxPersonalizado
            // 
            this.Name = "ComboboxPersonalizado";
            this.Load += new System.EventHandler(this.ComboboxPersonalizado_Load);
            this.ResumeLayout(false);

        }

        private void ComboboxPersonalizado_Load(object sender, EventArgs e)
        {

        }
    }
}
