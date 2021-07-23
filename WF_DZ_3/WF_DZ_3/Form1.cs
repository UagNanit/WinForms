using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;


namespace WF_DZ_3
{
    public partial class Form1 : Form
    {
        Decimal a95 = 25, a92 = 22, disel = 19, gas = 10;
        Decimal hotdog = 0, burger = 0, potato = 0, soda = 0;
        Decimal fuel = 0, cafe = 0, total=0, dayMany=0;
        public static Control form1;

        private void chb_hotdog_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                tb_hotdog_amount.Enabled = true;
            }
            else
            {
                tb_hotdog_amount.Enabled = false;
                tb_hotdog_amount.Clear();
            }
        }

        private void chb_burger_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                tb_burger_amount.Enabled = true;
            }
            else
            {
                tb_burger_amount.Enabled = false;
                tb_burger_amount.Clear();
            }
        }

        private void chb_potato_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                tb_potato_amount.Enabled = true;
            }
            else
            {
                tb_potato_amount.Enabled = false;
                tb_potato_amount.Clear();
            }
        }

        private void chb_soda_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                tb_soda_amount.Enabled = true;
            }
            else
            {
                tb_soda_amount.Enabled = false;
                tb_soda_amount.Clear();
            }
        }

        private void tb_burger_amount_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            string pattern = @"[0-9]$";
            if (Regex.IsMatch(tb.Text, pattern, RegexOptions.IgnoreCase) || tb.Text == "")
            {
                tb.BackColor = Color.White;
                bt_cheсk.Enabled = true;
                if (tb.Text != "")
                {
                    try
                    {
                        burger = Convert.ToDecimal(tb.Text) * Convert.ToDecimal(tb_burger_price.Text);
                    }
                    catch (Exception ) { tb.Text = ""; }
                }
                else
                {
                    burger = 0;
                }
                cafe = Math.Round(hotdog + burger + soda + potato, 2);
                lb_endPrice_cafe.Text = cafe.ToString();
            }
            else
            {
                tb.BackColor = Color.Red;
                bt_cheсk.Enabled = false;
            }
        }

        private void tb_potato_amount_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            string pattern = @"[0-9]$";
            if (Regex.IsMatch(tb.Text, pattern, RegexOptions.IgnoreCase) || tb.Text == "")
            {
                tb.BackColor = Color.White;
                bt_cheсk.Enabled = true;
                if (tb.Text != "")
                {
                    try
                    {
                        potato = Convert.ToDecimal(tb.Text) * Convert.ToDecimal(tb_potato_price.Text);
                    }
                    catch (Exception ) { tb.Text = ""; }
                }
                else
                {
                    potato = 0;
                }
                cafe = Math.Round(hotdog + burger + soda + potato, 2);
                lb_endPrice_cafe.Text = cafe.ToString();
            }
            else
            {
                tb.BackColor = Color.Red;
                bt_cheсk.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("За операционный день поступило "+dayMany+" грн.");
            // Сохраняем выбранный язык.
            //Properties.Settings.Default.Language = toolStripComboBox1.ComboBox.SelectedValue.ToString();
            Properties.Settings.Default.Save();
            
        }

        

        private void tb_soda_amount_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            string pattern = @"[0-9]$";
            if (Regex.IsMatch(tb.Text, pattern, RegexOptions.IgnoreCase) || tb.Text == "")
            {
                tb.BackColor = Color.White;
                bt_cheсk.Enabled = true;
                if (tb.Text != "")
                {
                    try
                    {
                        soda = Convert.ToDecimal(tb.Text) * Convert.ToDecimal(tb_soda_price.Text);
                    }
                    catch (Exception ) { tb.Text = ""; }
                }
                else
                {
                    soda = 0;
                }
                cafe = Math.Round(hotdog + burger + soda + potato, 2);
                lb_endPrice_cafe.Text = cafe.ToString();
            }
            else
            {
                tb.BackColor = Color.Red;
                bt_cheсk.Enabled = false;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var form = new Form2(this);
            form.ShowDialog(this);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox ts = sender as ToolStripComboBox;
            switch (ts.SelectedIndex)
            {
                case 0:
                    Properties.Settings.Default.Language = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").ToString();

                    break;
                case 1:
                    Properties.Settings.Default.Language = System.Globalization.CultureInfo.GetCultureInfo("en").ToString();
                    break;
                    
            
            }
        }

        private void bt_cheсk_Click(object sender, EventArgs e)
        {
            total = fuel + cafe;
            Math.Round(total, 2);
            lb_endPrice_total.Text = total.ToString();
            dayMany += total;

            Task.Delay(10000).Wait();
            bt_cheсk.Enabled = false;
            chb_hotdog.Checked = false;
            chb_burger.Checked = false; 
            chb_soda.Checked = false;
            chb_potato.Checked = false;
            rb_amount.Enabled = false;
            rb_sum.Enabled = false;
            tb_amount_liter.Clear();
            tb_price_fuel.Clear();
            cb_fuel.SelectedIndex = -1;
            cb_fuel.Text = "";
            hotdog = 0; burger = 0; potato = 0; soda = 0;
            fuel = 0; cafe = 0; total = 0;
            lb_endPrice_total.Text = total.ToString();
        }

        private void cb_fuel_SelectedIndexChanged(object sender, EventArgs e)
        {
                rb_amount.Enabled = true;
                rb_sum.Enabled = true;
                switch (cb_fuel.SelectedIndex)
                {
                    case 0:
                        tb_price_fuel.Text = a95.ToString();
                        break;
                    case 1:
                        tb_price_fuel.Text = a92.ToString();
                        break;
                    case 2:
                        tb_price_fuel.Text = disel.ToString();
                        break;
                    case 3:
                        tb_price_fuel.Text = gas.ToString();
                        break;
                    default:
                        break;
                }
        }

        public Form1()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }
            InitializeComponent();
            form1 = this;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 5000; 
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
           
            toolTip1.SetToolTip(this.bt_cheсk, Resource1.cheсk); 
            toolTip1.SetToolTip(this.cb_fuel, Resource1.fuel);
            toolTip1.SetToolTip(this.tb_price_fuel, Resource1.price_fuel);
            toolTip1.SetToolTip(this.gb_option, Resource1.option);
            toolTip1.SetToolTip(this.lb_endPrice_fuel, Resource1.endPrice_fuel);
            toolTip1.SetToolTip(this.lb_endPrice_cafe, Resource1.endPrice_cafe); 
            toolTip1.SetToolTip(this.lb_endPrice_total, Resource1.endPrice_total);

            notifyIcon1.ShowBalloonTip(20);

            toolStripComboBox1.ComboBox.DisplayMember = "NativeName";
            toolStripComboBox1.ComboBox.ValueMember = "Name";

            

            toolStripComboBox1.Items.AddRange(new System.Globalization.CultureInfo[]{
            System.Globalization.CultureInfo.GetCultureInfo("ru-RU"),
            System.Globalization.CultureInfo.GetCultureInfo("en")});

            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                switch (Properties.Settings.Default.Language)
                {
                    case "ru-RU":
                        toolStripComboBox1.SelectedIndex = 0;
                        break;
                    case "en":
                        toolStripComboBox1.SelectedIndex = 1;
                        break;
                }

            }
        }

        private void tb_hotdog_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            string pattern = @"[0-9]$";
            if (Regex.IsMatch(tb.Text, pattern, RegexOptions.IgnoreCase) || tb.Text == "")
            {
                tb.BackColor = Color.White;
                bt_cheсk.Enabled = true;
                if (tb.Text != "")
                {
                    try
                    {
                        hotdog = Convert.ToDecimal(tb.Text) * Convert.ToDecimal(tb_hotdog_price.Text);
                    }
                    catch (Exception ) { tb.Text = ""; }
                }
                else
                { 
                    hotdog = 0; 
                }
                cafe = Math.Round(hotdog + burger + soda + potato, 2);
                lb_endPrice_cafe.Text = cafe.ToString();
            }
            else
            {
                tb.BackColor = Color.Red;
                bt_cheсk.Enabled = false;
            }
        }
        private void tb_amount_liter_TextChanged(object sender, EventArgs e)
        {  
            TextBox tb = sender as TextBox;
            string pattern = @"[0-9,]$";
            if (Regex.IsMatch(tb.Text, pattern, RegexOptions.IgnoreCase) || tb.Text == "")
            {
                tb.BackColor = Color.White;
                bt_cheсk.Enabled = true;
                if (tb.Text != "")
                {
                    try
                    {
                        fuel = Convert.ToDecimal(tb.Text) * Convert.ToDecimal(tb_price_fuel.Text);
                        Math.Round(fuel, 2);
                        if(tb_sum.Enabled==false) tb_sum.Text = fuel.ToString();
                        lb_endPrice_fuel.Text = tb_sum.Text;
                    }
                    catch (Exception ) { tb.Text = ""; }
                }
                else
                {
                    fuel = 0;
                    tb_sum.Clear();
                    lb_endPrice_fuel.Text = fuel.ToString();
                }
            }
            else
            {
                tb.BackColor = Color.Red;
                bt_cheсk.Enabled = false;
            }
        }
        private void tb_sum_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            string pattern = @"[0-9,]$";
            if (Regex.IsMatch(tb.Text, pattern, RegexOptions.IgnoreCase) || tb.Text == "")
            {
                tb.BackColor = Color.White;
                bt_cheсk.Enabled = true;
                if (tb.Text != "")
                {
                    try
                    {
                        tb_amount_liter.Text = Math.Round((Convert.ToDecimal(tb.Text) / Convert.ToDecimal(tb_price_fuel.Text)), 2).ToString();
                    }catch (Exception ) { tb.Text = ""; }
                }
                else
                {
                    fuel = 0;
                    tb_amount_liter.Clear();
                    lb_endPrice_fuel.Text = fuel.ToString();
                }
            }
            else
            {
                tb.BackColor = Color.Red;
                bt_cheсk.Enabled = false;
            }     
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            switch (radioButton.Name)
            {
                case "rb_amount":
                    tb_amount_liter.Enabled = true;
                    tb_sum.Clear();
                    tb_sum.Enabled = false;
                    break;
                case "rb_sum":
                    tb_sum.Enabled = true;
                    tb_amount_liter.Clear();
                    tb_amount_liter.Enabled = false;
                    break;
                default:
                    break;
            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }


    }
}
