﻿namespace WindowsTransporteAereo
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
            this.btnJett = new System.Windows.Forms.Button();
            this.btnHelicoptero = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJett
            // 
            this.btnJett.Location = new System.Drawing.Point(182, 63);
            this.btnJett.Name = "btnJett";
            this.btnJett.Size = new System.Drawing.Size(114, 23);
            this.btnJett.TabIndex = 0;
            this.btnJett.Text = "Instanciar Jett";
            this.btnJett.UseVisualStyleBackColor = true;
            this.btnJett.Click += new System.EventHandler(this.btnJett_Click);
            // 
            // btnHelicoptero
            // 
            this.btnHelicoptero.Location = new System.Drawing.Point(356, 63);
            this.btnHelicoptero.Name = "btnHelicoptero";
            this.btnHelicoptero.Size = new System.Drawing.Size(144, 23);
            this.btnHelicoptero.TabIndex = 1;
            this.btnHelicoptero.Text = "Instanciar Helicoptero";
            this.btnHelicoptero.UseVisualStyleBackColor = true;
            this.btnHelicoptero.Click += new System.EventHandler(this.btnHelicoptero_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHelicoptero);
            this.Controls.Add(this.btnJett);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJett;
        private System.Windows.Forms.Button btnHelicoptero;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

