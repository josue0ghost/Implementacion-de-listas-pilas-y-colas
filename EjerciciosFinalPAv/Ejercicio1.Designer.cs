﻿namespace EjerciciosFinalPAv
{
    partial class Ejercicio1
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
            this.txbIngreso = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lbLDE1 = new System.Windows.Forms.ListBox();
            this.lbLDE2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbIngreso
            // 
            this.txbIngreso.Location = new System.Drawing.Point(12, 42);
            this.txbIngreso.Name = "txbIngreso";
            this.txbIngreso.Size = new System.Drawing.Size(437, 20);
            this.txbIngreso.TabIndex = 0;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(12, 77);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lbLDE1
            // 
            this.lbLDE1.FormattingEnabled = true;
            this.lbLDE1.Location = new System.Drawing.Point(16, 139);
            this.lbLDE1.Name = "lbLDE1";
            this.lbLDE1.Size = new System.Drawing.Size(120, 95);
            this.lbLDE1.TabIndex = 2;
            // 
            // lbLDE2
            // 
            this.lbLDE2.FormattingEnabled = true;
            this.lbLDE2.Location = new System.Drawing.Point(169, 139);
            this.lbLDE2.Name = "lbLDE2";
            this.lbLDE2.Size = new System.Drawing.Size(120, 95);
            this.lbLDE2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese una cadena separando por comas cada elemento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista ingresada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista resultante:";
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 245);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLDE2);
            this.Controls.Add(this.lbLDE1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txbIngreso);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIngreso;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ListBox lbLDE1;
        private System.Windows.Forms.ListBox lbLDE2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}