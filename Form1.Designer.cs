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
            this.labelThe_Babylonian = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textError = new System.Windows.Forms.TextBox();
            this.labelSquare_root = new System.Windows.Forms.Label();
            this.textSqrt = new System.Windows.Forms.TextBox();
            this.labelIterations = new System.Windows.Forms.Label();
            this.textIterations = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelSquare_root_2 = new System.Windows.Forms.Label();
            this.textSqrt2 = new System.Windows.Forms.TextBox();
            this.labelError2 = new System.Windows.Forms.Label();
            this.textError2 = new System.Windows.Forms.TextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.panelInput.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelThe_Babylonian
            // 
            this.labelThe_Babylonian.AutoSize = true;
            this.labelThe_Babylonian.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThe_Babylonian.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelThe_Babylonian.Location = new System.Drawing.Point(200, 25);
            this.labelThe_Babylonian.Name = "labelThe_Babylonian";
            this.labelThe_Babylonian.Size = new System.Drawing.Size(435, 27);
            this.labelThe_Babylonian.TabIndex = 0;
            this.labelThe_Babylonian.Text = "The Babylonian square-root algorithm";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumber.Location = new System.Drawing.Point(11, 17);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(68, 20);
            this.labelNumber.TabIndex = 1;
            this.labelNumber.Text = "Number";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelError.Location = new System.Drawing.Point(11, 63);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(47, 20);
            this.labelError.TabIndex = 2;
            this.labelError.Text = "Error";
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
            this.textError.BackColor = System.Drawing.SystemColors.Window;
            this.textError.Location = new System.Drawing.Point(129, 63);
            this.textError.Name = "textError";
            this.textError.Size = new System.Drawing.Size(204, 22);
            this.textError.TabIndex = 4;
            // 
            // labelSquare_root
            // 
            this.labelSquare_root.AutoSize = true;
            this.labelSquare_root.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSquare_root.Location = new System.Drawing.Point(9, 17);
            this.labelSquare_root.Name = "labelSquare_root";
            this.labelSquare_root.Size = new System.Drawing.Size(97, 20);
            this.labelSquare_root.TabIndex = 5;
            this.labelSquare_root.Text = "Square-root";
            // 
            // textSqrt
            // 
            this.textSqrt.Location = new System.Drawing.Point(127, 17);
            this.textSqrt.Name = "textSqrt";
            this.textSqrt.ReadOnly = true;
            this.textSqrt.Size = new System.Drawing.Size(204, 22);
            this.textSqrt.TabIndex = 6;
            // 
            // labelIterations
            // 
            this.labelIterations.AutoSize = true;
            this.labelIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIterations.Location = new System.Drawing.Point(9, 168);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(78, 20);
            this.labelIterations.TabIndex = 7;
            this.labelIterations.Text = "Iterations";
            // 
            // textIterations
            // 
            this.textIterations.Location = new System.Drawing.Point(127, 168);
            this.textIterations.Name = "textIterations";
            this.textIterations.ReadOnly = true;
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
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCalculate.Location = new System.Drawing.Point(175, 104);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(104, 32);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSquare_root_2
            // 
            this.labelSquare_root_2.AutoSize = true;
            this.labelSquare_root_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSquare_root_2.Location = new System.Drawing.Point(9, 59);
            this.labelSquare_root_2.Name = "labelSquare_root_2";
            this.labelSquare_root_2.Size = new System.Drawing.Size(97, 40);
            this.labelSquare_root_2.TabIndex = 10;
            this.labelSquare_root_2.Text = "Square-root\r\nMath.Sqrt";
            // 
            // textSqrt2
            // 
            this.textSqrt2.Location = new System.Drawing.Point(127, 68);
            this.textSqrt2.Name = "textSqrt2";
            this.textSqrt2.ReadOnly = true;
            this.textSqrt2.Size = new System.Drawing.Size(204, 22);
            this.textSqrt2.TabIndex = 11;
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelError2.Location = new System.Drawing.Point(9, 121);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(47, 20);
            this.labelError2.TabIndex = 12;
            this.labelError2.Text = "Error";
            // 
            // textError2
            // 
            this.textError2.Location = new System.Drawing.Point(127, 121);
            this.textError2.Name = "textError2";
            this.textError2.ReadOnly = true;
            this.textError2.Size = new System.Drawing.Size(204, 22);
            this.textError2.TabIndex = 13;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.textNumber);
            this.panelInput.Controls.Add(this.labelNumber);
            this.panelInput.Controls.Add(this.labelError);
            this.panelInput.Controls.Add(this.textError);
            this.panelInput.Controls.Add(this.buttonCalculate);
            this.panelInput.Location = new System.Drawing.Point(32, 78);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(361, 147);
            this.panelInput.TabIndex = 14;
            // 
            // panelOutput
            // 
            this.panelOutput.Controls.Add(this.labelSquare_root);
            this.panelOutput.Controls.Add(this.textSqrt);
            this.panelOutput.Controls.Add(this.labelIterations);
            this.panelOutput.Controls.Add(this.textError2);
            this.panelOutput.Controls.Add(this.textIterations);
            this.panelOutput.Controls.Add(this.labelError2);
            this.panelOutput.Controls.Add(this.labelSquare_root_2);
            this.panelOutput.Controls.Add(this.textSqrt2);
            this.panelOutput.Location = new System.Drawing.Point(465, 78);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(354, 211);
            this.panelOutput.TabIndex = 16;
            // 
            // buttonTest
            // 
            this.buttonTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTest.Location = new System.Drawing.Point(161, 295);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(202, 32);
            this.buttonTest.TabIndex = 17;
            this.buttonTest.Text = "Test the algorithm";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(707, 295);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(89, 32);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(842, 347);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.labelThe_Babylonian);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelThe_Babylonian;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textError;
        private System.Windows.Forms.Label labelSquare_root;
        private System.Windows.Forms.TextBox textSqrt;
        private System.Windows.Forms.Label labelIterations;
        private System.Windows.Forms.TextBox textIterations;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textError2;
        private System.Windows.Forms.Label labelError2;
        private System.Windows.Forms.TextBox textSqrt2;
        private System.Windows.Forms.Label labelSquare_root_2;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonExit;
    }
}

