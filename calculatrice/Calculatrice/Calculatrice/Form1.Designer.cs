﻿namespace Calculatrice
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
            this.ecran = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.effacer = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.egal = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ecran
            // 
            this.ecran.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ecran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecran.Location = new System.Drawing.Point(5, 13);
            this.ecran.Name = "ecran";
            this.ecran.Size = new System.Drawing.Size(348, 41);
            this.ecran.TabIndex = 0;
            this.ecran.Text = "0";
            this.ecran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.DarkGray;
            this.btn.Location = new System.Drawing.Point(3, 61);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(83, 42);
            this.btn.TabIndex = 1;
            this.btn.Text = "7";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.Chiffre_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(92, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "8";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Chiffre_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(181, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "9";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Chiffre_Click);
            // 
            // effacer
            // 
            this.effacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.effacer.Location = new System.Drawing.Point(270, 61);
            this.effacer.Name = "effacer";
            this.effacer.Size = new System.Drawing.Size(83, 42);
            this.effacer.TabIndex = 1;
            this.effacer.Text = "CE";
            this.effacer.UseVisualStyleBackColor = false;
            this.effacer.Click += new System.EventHandler(this.effacer_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.Location = new System.Drawing.Point(3, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 42);
            this.button4.TabIndex = 1;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Chiffre_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGray;
            this.button5.Location = new System.Drawing.Point(92, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 42);
            this.button5.TabIndex = 1;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Chiffre_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGray;
            this.button6.Location = new System.Drawing.Point(181, 109);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 42);
            this.button6.TabIndex = 1;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Chiffre_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(270, 109);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 42);
            this.button7.TabIndex = 1;
            this.button7.Text = "/";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Operation_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkGray;
            this.button8.Location = new System.Drawing.Point(3, 155);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 42);
            this.button8.TabIndex = 1;
            this.button8.Text = "1";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Chiffre_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkGray;
            this.button9.Location = new System.Drawing.Point(3, 203);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 42);
            this.button9.TabIndex = 1;
            this.button9.Text = "0";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Chiffre_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkGray;
            this.button10.Location = new System.Drawing.Point(92, 155);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(83, 42);
            this.button10.TabIndex = 1;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Chiffre_Click);
            // 
            // egal
            // 
            this.egal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.egal.Location = new System.Drawing.Point(92, 203);
            this.egal.Name = "egal";
            this.egal.Size = new System.Drawing.Size(83, 42);
            this.egal.TabIndex = 1;
            this.egal.Text = "=";
            this.egal.UseVisualStyleBackColor = false;
            this.egal.Click += new System.EventHandler(this.egal_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DarkGray;
            this.button12.Location = new System.Drawing.Point(181, 155);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(83, 42);
            this.button12.TabIndex = 1;
            this.button12.Text = "3";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Chiffre_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button13.Location = new System.Drawing.Point(181, 203);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(83, 42);
            this.button13.TabIndex = 1;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Operation_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button14.Location = new System.Drawing.Point(270, 155);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(83, 42);
            this.button14.TabIndex = 1;
            this.button14.Text = "X";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Operation_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button15.Location = new System.Drawing.Point(270, 203);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(83, 42);
            this.button15.TabIndex = 1;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Operation_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.effacer);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.egal);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btn);
            this.panel1.Controls.Add(this.ecran);
            this.panel1.Location = new System.Drawing.Point(27, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 252);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ecran;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button effacer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button egal;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Panel panel1;
    }
}

