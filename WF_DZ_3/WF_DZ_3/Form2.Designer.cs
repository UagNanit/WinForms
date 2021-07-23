namespace WF_DZ_3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.trackBar_red = new System.Windows.Forms.TrackBar();
            this.trackBar_green = new System.Windows.Forms.TrackBar();
            this.trackBar_blue = new System.Windows.Forms.TrackBar();
            this.label_color_info = new System.Windows.Forms.Label();
            this.button_color = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar_red
            // 
            resources.ApplyResources(this.trackBar_red, "trackBar_red");
            this.trackBar_red.BackColor = System.Drawing.Color.Red;
            this.trackBar_red.Maximum = 255;
            this.trackBar_red.Name = "trackBar_red";
            this.trackBar_red.TickFrequency = 2;
            this.trackBar_red.Scroll += new System.EventHandler(this.trackBar_col_Scroll);
            // 
            // trackBar_green
            // 
            resources.ApplyResources(this.trackBar_green, "trackBar_green");
            this.trackBar_green.BackColor = System.Drawing.Color.Green;
            this.trackBar_green.Maximum = 255;
            this.trackBar_green.Name = "trackBar_green";
            this.trackBar_green.TickFrequency = 2;
            this.trackBar_green.Scroll += new System.EventHandler(this.trackBar_col_Scroll);
            // 
            // trackBar_blue
            // 
            resources.ApplyResources(this.trackBar_blue, "trackBar_blue");
            this.trackBar_blue.BackColor = System.Drawing.Color.Blue;
            this.trackBar_blue.Maximum = 255;
            this.trackBar_blue.Name = "trackBar_blue";
            this.trackBar_blue.TickFrequency = 2;
            this.trackBar_blue.Scroll += new System.EventHandler(this.trackBar_col_Scroll);
            // 
            // label_color_info
            // 
            resources.ApplyResources(this.label_color_info, "label_color_info");
            this.label_color_info.Name = "label_color_info";
            this.label_color_info.Text = Resource1.color_info;
            // 
            // button_color
            // 
            resources.ApplyResources(this.button_color, "button_color");
            this.button_color.Name = "button_color";
            this.button_color.Text = global::WF_DZ_3.Resource1.button_color;
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_color);
            this.Controls.Add(this.label_color_info);
            this.Controls.Add(this.trackBar_blue);
            this.Controls.Add(this.trackBar_green);
            this.Controls.Add(this.trackBar_red);
            this.Name = "Form2";
           
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar_red;
        private System.Windows.Forms.TrackBar trackBar_green;
        private System.Windows.Forms.TrackBar trackBar_blue;
        private System.Windows.Forms.Label label_color_info;
        private System.Windows.Forms.Button button_color;
    }
}