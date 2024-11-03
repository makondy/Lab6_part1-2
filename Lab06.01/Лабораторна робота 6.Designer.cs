namespace Lab06._01
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
            this.btnMoon = new System.Windows.Forms.Button();
            this.btnEarth = new System.Windows.Forms.Button();
            this.lblMovement = new System.Windows.Forms.TextBox();
            this.lblLife = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMoon
            // 
            this.btnMoon.Location = new System.Drawing.Point(352, 134);
            this.btnMoon.Name = "btnMoon";
            this.btnMoon.Size = new System.Drawing.Size(75, 23);
            this.btnMoon.TabIndex = 0;
            this.btnMoon.Text = "Місяць";
            this.btnMoon.UseVisualStyleBackColor = true;
            this.btnMoon.Click += new System.EventHandler(this.btnMoon_Click);
            // 
            // btnEarth
            // 
            this.btnEarth.Location = new System.Drawing.Point(193, 134);
            this.btnEarth.Name = "btnEarth";
            this.btnEarth.Size = new System.Drawing.Size(75, 23);
            this.btnEarth.TabIndex = 1;
            this.btnEarth.Text = "Земля";
            this.btnEarth.UseVisualStyleBackColor = true;
            this.btnEarth.Click += new System.EventHandler(this.btnEarth_Click);
            // 
            // lblMovement
            // 
            this.lblMovement.Location = new System.Drawing.Point(193, 185);
            this.lblMovement.Name = "lblMovement";
            this.lblMovement.Size = new System.Drawing.Size(234, 20);
            this.lblMovement.TabIndex = 2;
            // 
            // lblLife
            // 
            this.lblLife.Location = new System.Drawing.Point(193, 227);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(234, 20);
            this.lblLife.TabIndex = 3;
            this.lblLife.TextChanged += new System.EventHandler(this.lblLife_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.lblMovement);
            this.Controls.Add(this.btnEarth);
            this.Controls.Add(this.btnMoon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoon;
        private System.Windows.Forms.Button btnEarth;
        private System.Windows.Forms.TextBox lblMovement;
        private System.Windows.Forms.TextBox lblLife;
    }
}

