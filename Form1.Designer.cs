namespace PS1B___Tema_10___Ciobanu_Victor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textError = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSqrt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textIterations = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textSqrt2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textDifference = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(200, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Babylonian square-root algorithm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Error";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(129, 17);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(204, 22);
            this.textNumber.TabIndex = 3;
            // 
            // textError
            // 
            this.textError.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.textError.BackColor = System.Drawing.SystemColors.Window;
            this.textError.Location = new System.Drawing.Point(129, 63);
            this.textError.Name = "textError";
            this.textError.Size = new System.Drawing.Size(204, 22);
            this.textError.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Square-root";
            // 
            // textSqrt
            // 
            this.textSqrt.Location = new System.Drawing.Point(127, 17);
            this.textSqrt.Name = "textSqrt";
            this.textSqrt.Size = new System.Drawing.Size(204, 22);
            this.textSqrt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Iterations";
            // 
            // textIterations
            // 
            this.textIterations.Location = new System.Drawing.Point(127, 168);
            this.textIterations.Name = "textIterations";
            this.textIterations.Size = new System.Drawing.Size(204, 22);
            this.textIterations.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(175, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(9, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Square-root\r\nMath.Sqrt";
            // 
            // textSqrt2
            // 
            this.textSqrt2.Location = new System.Drawing.Point(127, 68);
            this.textSqrt2.Name = "textSqrt2";
            this.textSqrt2.Size = new System.Drawing.Size(204, 22);
            this.textSqrt2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(9, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Difference";
            // 
            // textDifference
            // 
            this.textDifference.Location = new System.Drawing.Point(127, 121);
            this.textDifference.Name = "textDifference";
            this.textDifference.Size = new System.Drawing.Size(204, 22);
            this.textDifference.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textError);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(48, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 147);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textSqrt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textDifference);
            this.panel2.Controls.Add(this.textIterations);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textSqrt2);
            this.panel2.Location = new System.Drawing.Point(464, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 211);
            this.panel2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSqrt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textIterations;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textDifference;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSqrt2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

