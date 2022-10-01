namespace CelciusToFahrenheit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCelsius = new System.Windows.Forms.Label();
            this.lbFahrenheit = new System.Windows.Forms.Label();
            this.tbCelsius = new System.Windows.Forms.TextBox();
            this.tbFahrenheit = new System.Windows.Forms.TextBox();
            this.btCelsius = new System.Windows.Forms.Button();
            this.btFahrenheit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCelsius
            // 
            this.lbCelsius.AutoSize = true;
            this.lbCelsius.Location = new System.Drawing.Point(196, 195);
            this.lbCelsius.Name = "lbCelsius";
            this.lbCelsius.Size = new System.Drawing.Size(44, 15);
            this.lbCelsius.TabIndex = 0;
            this.lbCelsius.Text = "Celsius";
            // 
            // lbFahrenheit
            // 
            this.lbFahrenheit.AutoSize = true;
            this.lbFahrenheit.Location = new System.Drawing.Point(312, 195);
            this.lbFahrenheit.Name = "lbFahrenheit";
            this.lbFahrenheit.Size = new System.Drawing.Size(63, 15);
            this.lbFahrenheit.TabIndex = 1;
            this.lbFahrenheit.Text = "Fahrenheit";
            // 
            // tbCelsius
            // 
            this.tbCelsius.Location = new System.Drawing.Point(161, 213);
            this.tbCelsius.Name = "tbCelsius";
            this.tbCelsius.Size = new System.Drawing.Size(100, 23);
            this.tbCelsius.TabIndex = 2;
            // 
            // tbFahrenheit
            // 
            this.tbFahrenheit.Location = new System.Drawing.Point(299, 213);
            this.tbFahrenheit.Name = "tbFahrenheit";
            this.tbFahrenheit.Size = new System.Drawing.Size(100, 23);
            this.tbFahrenheit.TabIndex = 3;
            // 
            // btCelsius
            // 
            this.btCelsius.Location = new System.Drawing.Point(175, 254);
            this.btCelsius.Name = "btCelsius";
            this.btCelsius.Size = new System.Drawing.Size(75, 23);
            this.btCelsius.TabIndex = 4;
            this.btCelsius.Text = "C to F";
            this.btCelsius.UseVisualStyleBackColor = true;
            this.btCelsius.Click += new System.EventHandler(this.btCelsius_Click);
            // 
            // btFahrenheit
            // 
            this.btFahrenheit.Location = new System.Drawing.Point(312, 254);
            this.btFahrenheit.Name = "btFahrenheit";
            this.btFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.btFahrenheit.TabIndex = 5;
            this.btFahrenheit.Text = "F to C";
            this.btFahrenheit.UseVisualStyleBackColor = true;
            this.btFahrenheit.Click += new System.EventHandler(this.btFahrenheit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btFahrenheit);
            this.Controls.Add(this.btCelsius);
            this.Controls.Add(this.tbFahrenheit);
            this.Controls.Add(this.tbCelsius);
            this.Controls.Add(this.lbFahrenheit);
            this.Controls.Add(this.lbCelsius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCelsius;
        private System.Windows.Forms.Label lbFahrenheit;
        private System.Windows.Forms.TextBox tbCelsius;
        private System.Windows.Forms.TextBox tbFahrenheit;
        private System.Windows.Forms.Button btCelsius;
        private System.Windows.Forms.Button btFahrenheit;
    }
}

