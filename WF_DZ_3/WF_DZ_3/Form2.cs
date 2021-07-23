using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_DZ_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            trackBar_red.Value = this.BackColor.R;
            trackBar_green.Value = this.BackColor.G;
            trackBar_blue.Value = this.BackColor.B;
        }
        public Form2(Form f)
        {
            InitializeComponent();
            this.BackColor = f.BackColor;
            trackBar_red.Value = this.BackColor.R;
            trackBar_green.Value = this.BackColor.G;
            trackBar_blue.Value = this.BackColor.B;
        }

        private void trackBar_col_Scroll(object sender, EventArgs e)
        {
            TrackBar tb = sender as TrackBar;
            switch (tb.Name)
            {
                case "trackBar_red":
                    this.BackColor = Color.FromArgb(tb.Value, this.BackColor.G, this.BackColor.B);
                    break;
                case "trackBar_green":
                    this.BackColor = Color.FromArgb(this.BackColor.R, tb.Value, this.BackColor.B);
                    break;
                case "trackBar_blue":
                    this.BackColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, tb.Value);
                    break;

            }
        }

        private void button_color_Click(object sender, EventArgs e)
        {
            Form1.form1.BackColor = this.BackColor;
        }

        
    }
}
