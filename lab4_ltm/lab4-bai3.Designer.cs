namespace lab4_ltm
{
    partial class Bai03
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
        private void InitializeComponent()
        {
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btDOWLOAD = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btOPEN = new System.Windows.Forms.Button();
            this.btDELETE = new System.Windows.Forms.Button();
            this.btCLOSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(64, 104);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(577, 301);
            this.rtbContent.TabIndex = 8;
            this.rtbContent.Text = "";
            this.rtbContent.TextChanged += new System.EventHandler(this.rtbContent_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "URL:";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(64, 20);
            this.tbURL.Name = "txtURL";
            this.tbURL.Size = new System.Drawing.Size(577, 22);
            this.tbURL.TabIndex = 10;
            // 
            // btDownload
            // 
            this.btDOWLOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDOWLOAD.Location = new System.Drawing.Point(647, 13);
            this.btDOWLOAD.Name = "btDownload";
            this.btDOWLOAD.Size = new System.Drawing.Size(140, 35);
            this.btDOWLOAD.TabIndex = 11;
            this.btDOWLOAD.Text = "DOWNLOAD";
            this.btDOWLOAD.UseVisualStyleBackColor = true;
            this.btDOWLOAD.Click += new System.EventHandler(this.btDOWLOAD_Click);
            // 
            // txtPath
            // 
            this.tbPath.Location = new System.Drawing.Point(64, 62);
            this.tbPath.Name = "txtPath";
            this.tbPath.Size = new System.Drawing.Size(577, 22);
            this.tbPath.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Path:";
            // 
            // btOpen
            // 
            this.btOPEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOPEN.Location = new System.Drawing.Point(647, 62);
            this.btOPEN.Name = "btOpen";
            this.btOPEN.Size = new System.Drawing.Size(140, 35);
            this.btOPEN.TabIndex = 15;
            this.btOPEN.Text = "OPEN";
            this.btOPEN.UseVisualStyleBackColor = true;
            this.btOPEN.Click += new System.EventHandler(this.btOPEN_Click);
            // 
            // btDelete
            // 
            this.btDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDELETE.Location = new System.Drawing.Point(647, 114);
            this.btDELETE.Name = "btDelete";
            this.btDELETE.Size = new System.Drawing.Size(140, 35);
            this.btDELETE.TabIndex = 16;
            this.btDELETE.Text = "DELETE";
            this.btDELETE.UseVisualStyleBackColor = true;
            this.btDELETE.Click += new System.EventHandler(this.btDELETE_Click);
            // 
            // btClose
            // 
            this.btCLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCLOSE.Location = new System.Drawing.Point(647, 166);
            this.btCLOSE.Name = "btClose";
            this.btCLOSE.Size = new System.Drawing.Size(140, 35);
            this.btCLOSE.TabIndex = 17;
            this.btCLOSE.Text = "CLOSE";
            this.btCLOSE.UseVisualStyleBackColor = true;
            this.btCLOSE.Click += new System.EventHandler(this.btCLOSE_Click);
            // 
            // Bai3_Lab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCLOSE);
            this.Controls.Add(this.btDELETE);
            this.Controls.Add(this.btOPEN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btDOWLOAD);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbContent);
            this.Name = "Bai3_Lab4";
            this.Text = "Bai3_Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox rtbContent;
        private TextBox tbPath;
        private TextBox tbURL;
        private Button btDOWLOAD;
        private Button btOPEN;
        private Button btDELETE;
        private Button btCLOSE;
    }
}
