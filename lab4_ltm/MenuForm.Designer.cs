﻿namespace lab4_ltm
{
    partial class MenuForm
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
            this.btnBai1 = new System.Windows.Forms.Button();
            this.btnBai2 = new System.Windows.Forms.Button();
            this.btnBai3 = new System.Windows.Forms.Button();
            this.btnBai4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBai1
            // 
            this.btnBai1.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai1.Location = new System.Drawing.Point(51, 39);
            this.btnBai1.Name = "btnBai1";
            this.btnBai1.Size = new System.Drawing.Size(123, 41);
            this.btnBai1.TabIndex = 0;
            this.btnBai1.Text = "Bài 1";
            this.btnBai1.UseVisualStyleBackColor = true;
            this.btnBai1.Click += new System.EventHandler(this.btnBai1_Click);
            // 
            // btnBai2
            // 
            this.btnBai2.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai2.Location = new System.Drawing.Point(279, 39);
            this.btnBai2.Name = "btnBai2";
            this.btnBai2.Size = new System.Drawing.Size(123, 41);
            this.btnBai2.TabIndex = 0;
            this.btnBai2.Text = "Bài 2 ";
            this.btnBai2.UseVisualStyleBackColor = true;
            this.btnBai2.Click += new System.EventHandler(this.btnBai2_Click);
            // 
            // btnBai3
            // 
            this.btnBai3.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai3.Location = new System.Drawing.Point(51, 168);
            this.btnBai3.Name = "btnBai3";
            this.btnBai3.Size = new System.Drawing.Size(123, 41);
            this.btnBai3.TabIndex = 0;
            this.btnBai3.Text = "Bài 3";
            this.btnBai3.UseVisualStyleBackColor = true;
            this.btnBai3.Click += new System.EventHandler(this.btnBai3_Click);
            // 
            // btnBai4
            // 
            this.btnBai4.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai4.Location = new System.Drawing.Point(279, 168);
            this.btnBai4.Name = "btnBai4";
            this.btnBai4.Size = new System.Drawing.Size(123, 41);
            this.btnBai4.TabIndex = 0;
            this.btnBai4.Text = "Bài 4";
            this.btnBai4.UseVisualStyleBackColor = true;
            this.btnBai4.Click += new System.EventHandler(this.btnBai4_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 278);
            this.Controls.Add(this.btnBai2);
            this.Controls.Add(this.btnBai4);
            this.Controls.Add(this.btnBai3);
            this.Controls.Add(this.btnBai1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBai1;
        private System.Windows.Forms.Button btnBai2;
        private System.Windows.Forms.Button btnBai3;
        private System.Windows.Forms.Button btnBai4;
    }
}