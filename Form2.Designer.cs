namespace PS1B___Tema_10___Ciobanu_Victor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.textError = new System.Windows.Forms.TextBox();
            this.labelNr_values = new System.Windows.Forms.Label();
            this.textNr_values = new System.Windows.Forms.TextBox();
            this.textMin_value = new System.Windows.Forms.TextBox();
            this.labelMin_value = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelMax_value = new System.Windows.Forms.Label();
            this.textMax_value = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textAvg_error = new System.Windows.Forms.TextBox();
            this.labelAvg_difference = new System.Windows.Forms.Label();
            this.labelAvg_iterations = new System.Windows.Forms.Label();
            this.textAvg_iterations = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(699, 406);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(89, 32);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.Location = new System.Drawing.Point(12, 406);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(89, 32);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTest.Location = new System.Drawing.Point(304, 20);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(214, 27);
            this.labelTest.TabIndex = 21;
            this.labelTest.Text = "Test the algorithm";
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.labelError);
            this.panelInput.Controls.Add(this.textError);
            this.panelInput.Controls.Add(this.labelNr_values);
            this.panelInput.Controls.Add(this.textNr_values);
            this.panelInput.Controls.Add(this.textMin_value);
            this.panelInput.Controls.Add(this.labelMin_value);
            this.panelInput.Controls.Add(this.buttonTest);
            this.panelInput.Controls.Add(this.labelMax_value);
            this.panelInput.Controls.Add(this.textMax_value);
            this.panelInput.Location = new System.Drawing.Point(12, 66);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(367, 246);
            this.panelInput.TabIndex = 22;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelError.Location = new System.Drawing.Point(11, 160);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(47, 20);
            this.labelError.TabIndex = 12;
            this.labelError.Text = "Error";
            // 
            // textError
            // 
            this.textError.BackColor = System.Drawing.SystemColors.Window;
            this.textError.Location = new System.Drawing.Point(129, 160);
            this.textError.Name = "textError";
            this.textError.Size = new System.Drawing.Size(204, 22);
            this.textError.TabIndex = 13;
            // 
            // labelNr_values
            // 
            this.labelNr_values.AutoSize = true;
            this.labelNr_values.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNr_values.Location = new System.Drawing.Point(11, 112);
            this.labelNr_values.Name = "labelNr_values";
            this.labelNr_values.Size = new System.Drawing.Size(103, 20);
            this.labelNr_values.TabIndex = 10;
            this.labelNr_values.Text = "Nr. of values";
            // 
            // textNr_values
            // 
            this.textNr_values.BackColor = System.Drawing.SystemColors.Window;
            this.textNr_values.Location = new System.Drawing.Point(129, 112);
            this.textNr_values.Name = "textNr_values";
            this.textNr_values.Size = new System.Drawing.Size(204, 22);
            this.textNr_values.TabIndex = 11;
            // 
            // textMin_value
            // 
            this.textMin_value.Location = new System.Drawing.Point(129, 17);
            this.textMin_value.Name = "textMin_value";
            this.textMin_value.Size = new System.Drawing.Size(204, 22);
            this.textMin_value.TabIndex = 3;
            // 
            // labelMin_value
            // 
            this.labelMin_value.AutoSize = true;
            this.labelMin_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMin_value.Location = new System.Drawing.Point(11, 17);
            this.labelMin_value.Name = "labelMin_value";
            this.labelMin_value.Size = new System.Drawing.Size(84, 20);
            this.labelMin_value.TabIndex = 1;
            this.labelMin_value.Text = "Min. value";
            // 
            // buttonTest
            // 
            this.buttonTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTest.Location = new System.Drawing.Point(195, 199);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(68, 32);
            this.buttonTest.TabIndex = 9;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelMax_value
            // 
            this.labelMax_value.AutoSize = true;
            this.labelMax_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMax_value.Location = new System.Drawing.Point(11, 63);
            this.labelMax_value.Name = "labelMax_value";
            this.labelMax_value.Size = new System.Drawing.Size(88, 20);
            this.labelMax_value.TabIndex = 2;
            this.labelMax_value.Text = "Max. value";
            // 
            // textMax_value
            // 
            this.textMax_value.BackColor = System.Drawing.SystemColors.Window;
            this.textMax_value.Location = new System.Drawing.Point(129, 63);
            this.textMax_value.Name = "textMax_value";
            this.textMax_value.Size = new System.Drawing.Size(204, 22);
            this.textMax_value.TabIndex = 4;
            // 
            // chart
            // 
            chartArea1.AxisX.Title = "Iterations";
            chartArea1.AxisY.Title = "Number of iterations";
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(424, 66);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Iterations";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(349, 205);
            this.chart.TabIndex = 23;
            this.chart.Text = "chart";
            title1.DockedToChartArea = "ChartArea1";
            title1.Name = "Iterssa";
            this.chart.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textAvg_error);
            this.panel1.Controls.Add(this.labelAvg_difference);
            this.panel1.Controls.Add(this.labelAvg_iterations);
            this.panel1.Controls.Add(this.textAvg_iterations);
            this.panel1.Location = new System.Drawing.Point(424, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 103);
            this.panel1.TabIndex = 23;
            // 
            // textAvg_error
            // 
            this.textAvg_error.Location = new System.Drawing.Point(145, 17);
            this.textAvg_error.Name = "textAvg_error";
            this.textAvg_error.ReadOnly = true;
            this.textAvg_error.Size = new System.Drawing.Size(204, 22);
            this.textAvg_error.TabIndex = 3;
            // 
            // labelAvg_difference
            // 
            this.labelAvg_difference.AutoSize = true;
            this.labelAvg_difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAvg_difference.Location = new System.Drawing.Point(11, 17);
            this.labelAvg_difference.Name = "labelAvg_difference";
            this.labelAvg_difference.Size = new System.Drawing.Size(82, 20);
            this.labelAvg_difference.TabIndex = 1;
            this.labelAvg_difference.Text = "Avg. error";
            // 
            // labelAvg_iterations
            // 
            this.labelAvg_iterations.AutoSize = true;
            this.labelAvg_iterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAvg_iterations.Location = new System.Drawing.Point(11, 63);
            this.labelAvg_iterations.Name = "labelAvg_iterations";
            this.labelAvg_iterations.Size = new System.Drawing.Size(115, 20);
            this.labelAvg_iterations.TabIndex = 2;
            this.labelAvg_iterations.Text = "Avg. iterations";
            // 
            // textAvg_iterations
            // 
            this.textAvg_iterations.BackColor = System.Drawing.SystemColors.Control;
            this.textAvg_iterations.Location = new System.Drawing.Point(145, 63);
            this.textAvg_iterations.Name = "textAvg_iterations";
            this.textAvg_iterations.ReadOnly = true;
            this.textAvg_iterations.Size = new System.Drawing.Size(204, 22);
            this.textAvg_iterations.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 330);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(366, 23);
            this.progressBar.TabIndex = 24;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExit);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox textMin_value;
        private System.Windows.Forms.Label labelMin_value;
        private System.Windows.Forms.Label labelMax_value;
        private System.Windows.Forms.TextBox textMax_value;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelNr_values;
        private System.Windows.Forms.TextBox textNr_values;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textAvg_error;
        private System.Windows.Forms.Label labelAvg_difference;
        private System.Windows.Forms.Label labelAvg_iterations;
        private System.Windows.Forms.TextBox textAvg_iterations;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textError;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}