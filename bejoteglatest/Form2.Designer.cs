
namespace bejoteglatest
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
            this.bttnTeglaSwitch = new System.Windows.Forms.Button();
            this.buttonSzamol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBxNszam = new System.Windows.Forms.TextBox();
            this.lblNszamOsszeg = new System.Windows.Forms.Label();
            this.txtBxOsszeg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttnTeglaSwitch
            // 
            this.bttnTeglaSwitch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnTeglaSwitch.Location = new System.Drawing.Point(581, 88);
            this.bttnTeglaSwitch.Name = "bttnTeglaSwitch";
            this.bttnTeglaSwitch.Size = new System.Drawing.Size(207, 70);
            this.bttnTeglaSwitch.TabIndex = 0;
            this.bttnTeglaSwitch.Text = "button1";
            this.bttnTeglaSwitch.UseVisualStyleBackColor = true;
            this.bttnTeglaSwitch.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSzamol
            // 
            this.buttonSzamol.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSzamol.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSzamol.Location = new System.Drawing.Point(581, 12);
            this.buttonSzamol.Name = "buttonSzamol";
            this.buttonSzamol.Size = new System.Drawing.Size(207, 70);
            this.buttonSzamol.TabIndex = 11;
            this.buttonSzamol.Text = "Számol";
            this.buttonSzamol.UseVisualStyleBackColor = false;
            this.buttonSzamol.Click += new System.EventHandler(this.buttonSzamol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Írj be egy tetszőleges N számot";
            // 
            // textBxNszam
            // 
            this.textBxNszam.Location = new System.Drawing.Point(18, 49);
            this.textBxNszam.Name = "textBxNszam";
            this.textBxNszam.Size = new System.Drawing.Size(306, 26);
            this.textBxNszam.TabIndex = 13;
            // 
            // lblNszamOsszeg
            // 
            this.lblNszamOsszeg.AutoSize = true;
            this.lblNszamOsszeg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNszamOsszeg.Location = new System.Drawing.Point(18, 82);
            this.lblNszamOsszeg.Name = "lblNszamOsszeg";
            this.lblNszamOsszeg.Size = new System.Drawing.Size(278, 29);
            this.lblNszamOsszeg.TabIndex = 14;
            this.lblNszamOsszeg.Text = "1-től N-ig a számok összege";
            this.lblNszamOsszeg.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBxOsszeg
            // 
            this.txtBxOsszeg.Location = new System.Drawing.Point(18, 118);
            this.txtBxOsszeg.Name = "txtBxOsszeg";
            this.txtBxOsszeg.Size = new System.Drawing.Size(306, 26);
            this.txtBxOsszeg.TabIndex = 15;
            this.txtBxOsszeg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxOsszeg);
            this.Controls.Add(this.lblNszamOsszeg);
            this.Controls.Add(this.textBxNszam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSzamol);
            this.Controls.Add(this.bttnTeglaSwitch);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnTeglaSwitch;
        private System.Windows.Forms.Button buttonSzamol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBxNszam;
        private System.Windows.Forms.Label lblNszamOsszeg;
        private System.Windows.Forms.TextBox txtBxOsszeg;
    }
}