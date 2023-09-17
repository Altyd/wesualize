namespace Wesualize
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.siticoneButton1 = new ns1.SiticoneButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneDragControl1 = new ns1.SiticoneDragControl(this.components);
            this.siticoneButton2 = new ns1.SiticoneButton();
            this.siticoneSlider1 = new ns1.SiticoneSlider();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneTextBox1 = new ns1.SiticoneTextBox();
            this.siticoneButton3 = new ns1.SiticoneButton();
            this.siticoneButton4 = new ns1.SiticoneButton();
            this.siticoneButton5 = new ns1.SiticoneButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.siticoneTextBox2 = new ns1.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OpenCSV File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Show Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            chartArea4.AxisX2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            chartArea4.AxisY2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            chartArea4.BackSecondaryColor = System.Drawing.Color.White;
            chartArea4.BorderColor = System.Drawing.Color.White;
            chartArea4.CursorX.SelectionColor = System.Drawing.Color.White;
            chartArea4.CursorY.SelectionColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(4, 22);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(712, 185);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.siticoneButton1.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(28, 230);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(113, 22);
            this.siticoneButton1.TabIndex = 5;
            this.siticoneButton1.Text = "Load File";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 30);
            this.panel1.TabIndex = 6;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.panel1;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.siticoneButton2.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(28, 258);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(113, 22);
            this.siticoneButton2.TabIndex = 7;
            this.siticoneButton2.Text = "Load Data";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // siticoneSlider1
            // 
            this.siticoneSlider1.Location = new System.Drawing.Point(436, 230);
            this.siticoneSlider1.Name = "siticoneSlider1";
            this.siticoneSlider1.Size = new System.Drawing.Size(280, 60);
            this.siticoneSlider1.TabIndex = 8;
            this.siticoneSlider1.Scroll += new System.EventHandler(this.siticoneSlider1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Multiplier:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "00%";
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "Amount of months to predict";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.FocusedState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.siticoneTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.HoveredState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Location = new System.Drawing.Point(266, 230);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.ShadowDecoration.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Size = new System.Drawing.Size(177, 22);
            this.siticoneTextBox1.TabIndex = 11;
            this.siticoneTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.siticoneTextBox1.Click += new System.EventHandler(this.siticoneTextBox1_Click);
            this.siticoneTextBox1.Enter += new System.EventHandler(this.siticoneTextBox1_Enter);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.siticoneButton3.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(147, 230);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(113, 22);
            this.siticoneButton3.TabIndex = 12;
            this.siticoneButton3.Text = "Export Predictions";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
            this.siticoneButton4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.siticoneButton4.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
            this.siticoneButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.siticoneButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.siticoneButton4.HoveredState.Parent = this.siticoneButton4;
            this.siticoneButton4.Location = new System.Drawing.Point(147, 258);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
            this.siticoneButton4.Size = new System.Drawing.Size(177, 22);
            this.siticoneButton4.TabIndex = 13;
            this.siticoneButton4.Text = "Show Predictions CSV";
            this.siticoneButton4.Click += new System.EventHandler(this.siticoneButton4_Click);
            // 
            // siticoneButton5
            // 
            this.siticoneButton5.CheckedState.Parent = this.siticoneButton5;
            this.siticoneButton5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.siticoneButton5.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.siticoneButton5.CustomImages.Parent = this.siticoneButton5;
            this.siticoneButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.siticoneButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.siticoneButton5.HoveredState.Parent = this.siticoneButton5;
            this.siticoneButton5.Location = new System.Drawing.Point(330, 258);
            this.siticoneButton5.Name = "siticoneButton5";
            this.siticoneButton5.ShadowDecoration.Parent = this.siticoneButton5;
            this.siticoneButton5.Size = new System.Drawing.Size(113, 22);
            this.siticoneButton5.TabIndex = 14;
            this.siticoneButton5.Text = "Export Predictions";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.siticoneTextBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(112, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 146);
            this.panel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data";
            // 
            // siticoneTextBox2
            // 
            this.siticoneTextBox2.AutoScroll = true;
            this.siticoneTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.siticoneTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox2.DefaultText = "";
            this.siticoneTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.DisabledState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.siticoneTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.FocusedState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.HoveredState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Location = new System.Drawing.Point(53, 19);
            this.siticoneTextBox2.Multiline = true;
            this.siticoneTextBox2.Name = "siticoneTextBox2";
            this.siticoneTextBox2.PasswordChar = '\0';
            this.siticoneTextBox2.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.siticoneTextBox2.PlaceholderText = "Placeholder";
            this.siticoneTextBox2.SelectedText = "";
            this.siticoneTextBox2.ShadowDecoration.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Size = new System.Drawing.Size(200, 111);
            this.siticoneTextBox2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(717, 293);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.siticoneButton5);
            this.Controls.Add(this.siticoneButton4);
            this.Controls.Add(this.siticoneButton3);
            this.Controls.Add(this.siticoneTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.siticoneSlider1);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(167)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Wesualize";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ns1.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Panel panel1;
        private ns1.SiticoneDragControl siticoneDragControl1;
        private ns1.SiticoneButton siticoneButton2;
        private ns1.SiticoneSlider siticoneSlider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ns1.SiticoneTextBox siticoneTextBox1;
        private ns1.SiticoneButton siticoneButton3;
        private ns1.SiticoneButton siticoneButton4;
        private ns1.SiticoneButton siticoneButton5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private ns1.SiticoneTextBox siticoneTextBox2;
    }
}

