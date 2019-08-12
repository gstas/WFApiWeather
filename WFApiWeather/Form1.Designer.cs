namespace WFApiWeather
{
    partial class MainForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_city = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clouds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weather = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Tmin,
            this.Tmax,
            this.Pressure,
            this.Humidity,
            this.Clouds,
            this.Weather,
            this.Wind,
            this.Rain});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(1092, 389);
            this.dgv.TabIndex = 0;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(1014, 413);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(90, 31);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update Data";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(664, 422);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(105, 13);
            this.lbl_city.TabIndex = 2;
            this.lbl_city.Text = "Населённый пункт:";
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(785, 419);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.ReadOnly = true;
            this.textBox_city.Size = new System.Drawing.Size(213, 20);
            this.textBox_city.TabIndex = 3;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Tmin
            // 
            this.Tmin.HeaderText = "Tmin, °C";
            this.Tmin.Name = "Tmin";
            this.Tmin.ReadOnly = true;
            // 
            // Tmax
            // 
            this.Tmax.HeaderText = "Tmax,°C";
            this.Tmax.Name = "Tmax";
            this.Tmax.ReadOnly = true;
            // 
            // Pressure
            // 
            this.Pressure.HeaderText = "Pressure, kPa";
            this.Pressure.Name = "Pressure";
            this.Pressure.ReadOnly = true;
            // 
            // Humidity
            // 
            this.Humidity.HeaderText = "Humidity, %";
            this.Humidity.Name = "Humidity";
            this.Humidity.ReadOnly = true;
            // 
            // Clouds
            // 
            this.Clouds.HeaderText = "Clouds, %";
            this.Clouds.Name = "Clouds";
            this.Clouds.ReadOnly = true;
            // 
            // Weather
            // 
            this.Weather.HeaderText = "Weather";
            this.Weather.Name = "Weather";
            this.Weather.ReadOnly = true;
            // 
            // Wind
            // 
            this.Wind.HeaderText = "Wind, m/sec";
            this.Wind.Name = "Wind";
            this.Wind.ReadOnly = true;
            // 
            // Rain
            // 
            this.Rain.HeaderText = "Rain/Snow, mm";
            this.Rain.Name = "Rain";
            this.Rain.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dgv);
            this.Name = "MainForm";
            this.Text = "Open Weather Map";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tmax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clouds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weather;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rain;
    }
}

