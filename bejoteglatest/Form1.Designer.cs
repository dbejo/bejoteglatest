
namespace bejoteglatest
{
    partial class FormTeglatest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numAoldal = new System.Windows.Forms.NumericUpDown();
            this.numBoldal = new System.Windows.Forms.NumericUpDown();
            this.numTestatlo = new System.Windows.Forms.NumericUpDown();
            this.numFelszin = new System.Windows.Forms.NumericUpDown();
            this.numTerfogat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSzamol = new System.Windows.Forms.Button();
            this.numColdal = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAoldal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoldal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTestatlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFelszin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTerfogat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColdal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "A oldal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "B oldal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numAoldal
            // 
            this.numAoldal.DecimalPlaces = 2;
            this.numAoldal.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numAoldal.Location = new System.Drawing.Point(147, 18);
            this.numAoldal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAoldal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAoldal.Name = "numAoldal";
            this.numAoldal.Size = new System.Drawing.Size(120, 26);
            this.numAoldal.TabIndex = 2;
            this.numAoldal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBoldal
            // 
            this.numBoldal.DecimalPlaces = 2;
            this.numBoldal.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numBoldal.Location = new System.Drawing.Point(147, 58);
            this.numBoldal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBoldal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numBoldal.Name = "numBoldal";
            this.numBoldal.Size = new System.Drawing.Size(120, 26);
            this.numBoldal.TabIndex = 3;
            this.numBoldal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numTestatlo
            // 
            this.numTestatlo.DecimalPlaces = 2;
            this.numTestatlo.Location = new System.Drawing.Point(147, 138);
            this.numTestatlo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTestatlo.Name = "numTestatlo";
            this.numTestatlo.ReadOnly = true;
            this.numTestatlo.Size = new System.Drawing.Size(120, 26);
            this.numTestatlo.TabIndex = 4;
            // 
            // numFelszin
            // 
            this.numFelszin.DecimalPlaces = 2;
            this.numFelszin.Location = new System.Drawing.Point(147, 178);
            this.numFelszin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numFelszin.Name = "numFelszin";
            this.numFelszin.ReadOnly = true;
            this.numFelszin.Size = new System.Drawing.Size(120, 26);
            this.numFelszin.TabIndex = 5;
            // 
            // numTerfogat
            // 
            this.numTerfogat.DecimalPlaces = 2;
            this.numTerfogat.Location = new System.Drawing.Point(147, 218);
            this.numTerfogat.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTerfogat.Name = "numTerfogat";
            this.numTerfogat.ReadOnly = true;
            this.numTerfogat.Size = new System.Drawing.Size(120, 26);
            this.numTerfogat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Testátló";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(21, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Felszín";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(21, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Térfogat";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonSzamol
            // 
            this.buttonSzamol.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSzamol.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSzamol.Location = new System.Drawing.Point(581, 12);
            this.buttonSzamol.Name = "buttonSzamol";
            this.buttonSzamol.Size = new System.Drawing.Size(207, 70);
            this.buttonSzamol.TabIndex = 10;
            this.buttonSzamol.Text = "Számol";
            this.buttonSzamol.UseVisualStyleBackColor = false;
            this.buttonSzamol.Click += new System.EventHandler(this.buttonSzamol_Click);
            // 
            // numColdal
            // 
            this.numColdal.DecimalPlaces = 2;
            this.numColdal.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numColdal.Location = new System.Drawing.Point(147, 98);
            this.numColdal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numColdal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numColdal.Name = "numColdal";
            this.numColdal.Size = new System.Drawing.Size(120, 26);
            this.numColdal.TabIndex = 12;
            this.numColdal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(21, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "C oldal";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(581, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 70);
            this.button1.TabIndex = 13;
            this.button1.Text = "N szám összege";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTeglatest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numColdal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSzamol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTerfogat);
            this.Controls.Add(this.numFelszin);
            this.Controls.Add(this.numTestatlo);
            this.Controls.Add(this.numBoldal);
            this.Controls.Add(this.numAoldal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTeglatest";
            this.Text = "Téglatest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAoldal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoldal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTestatlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFelszin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTerfogat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColdal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAoldal;
        private System.Windows.Forms.NumericUpDown numBoldal;
        private System.Windows.Forms.NumericUpDown numTestatlo;
        private System.Windows.Forms.NumericUpDown numFelszin;
        private System.Windows.Forms.NumericUpDown numTerfogat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSzamol;
        private System.Windows.Forms.NumericUpDown numColdal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

