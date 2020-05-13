namespace Currency_Converter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnRupees = new System.Windows.Forms.RadioButton();
            this.rbnEuros = new System.Windows.Forms.RadioButton();
            this.rbnDollars = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUKMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConverted = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbnRupees);
            this.panel1.Controls.Add(this.rbnEuros);
            this.panel1.Controls.Add(this.rbnDollars);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(435, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 258);
            this.panel1.TabIndex = 0;
            // 
            // rbnRupees
            // 
            this.rbnRupees.AutoSize = true;
            this.rbnRupees.Location = new System.Drawing.Point(16, 183);
            this.rbnRupees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnRupees.Name = "rbnRupees";
            this.rbnRupees.Size = new System.Drawing.Size(87, 24);
            this.rbnRupees.TabIndex = 2;
            this.rbnRupees.Text = "Rupees";
            this.rbnRupees.UseVisualStyleBackColor = true;
            this.rbnRupees.CheckedChanged += new System.EventHandler(this.rbnRupees_CheckedChanged);
            // 
            // rbnEuros
            // 
            this.rbnEuros.AutoSize = true;
            this.rbnEuros.Location = new System.Drawing.Point(16, 98);
            this.rbnEuros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnEuros.Name = "rbnEuros";
            this.rbnEuros.Size = new System.Drawing.Size(74, 24);
            this.rbnEuros.TabIndex = 1;
            this.rbnEuros.Text = "Euros";
            this.rbnEuros.UseVisualStyleBackColor = true;
            this.rbnEuros.CheckedChanged += new System.EventHandler(this.rbnEuros_CheckedChanged);
            // 
            // rbnDollars
            // 
            this.rbnDollars.AutoSize = true;
            this.rbnDollars.Location = new System.Drawing.Point(16, 26);
            this.rbnDollars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnDollars.Name = "rbnDollars";
            this.rbnDollars.Size = new System.Drawing.Size(84, 24);
            this.rbnDollars.TabIndex = 0;
            this.rbnDollars.Text = "Dollars";
            this.rbnDollars.UseVisualStyleBackColor = true;
            this.rbnDollars.CheckedChanged += new System.EventHandler(this.rbnDollars_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currency Converter";
            // 
            // txtUKMoney
            // 
            this.txtUKMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUKMoney.Location = new System.Drawing.Point(220, 101);
            this.txtUKMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUKMoney.Name = "txtUKMoney";
            this.txtUKMoney.Size = new System.Drawing.Size(155, 27);
            this.txtUKMoney.TabIndex = 9;
            this.txtUKMoney.TextChanged += new System.EventHandler(this.txtUKMoney_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "UK Pounds:";
            // 
            // lblConverted
            // 
            this.lblConverted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConverted.Location = new System.Drawing.Point(220, 202);
            this.lblConverted.Name = "lblConverted";
            this.lblConverted.Size = new System.Drawing.Size(155, 25);
            this.lblConverted.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Converted Amount:";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(435, 321);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(112, 39);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(11, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 10);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(629, 384);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblConverted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUKMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert Pounds to Foreign Currency";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnRupees;
        private System.Windows.Forms.RadioButton rbnEuros;
        private System.Windows.Forms.RadioButton rbnDollars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUKMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConverted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel panel2;
    }
}

