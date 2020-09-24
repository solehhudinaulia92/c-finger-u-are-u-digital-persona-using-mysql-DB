namespace fingerprint
{
    partial class FormMain
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
            this.btnregistrasi = new System.Windows.Forms.Button();
            this.btnverify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnregistrasi
            // 
            this.btnregistrasi.Location = new System.Drawing.Point(190, 53);
            this.btnregistrasi.Name = "btnregistrasi";
            this.btnregistrasi.Size = new System.Drawing.Size(75, 23);
            this.btnregistrasi.TabIndex = 0;
            this.btnregistrasi.Text = "register";
            this.btnregistrasi.UseVisualStyleBackColor = true;
            this.btnregistrasi.Click += new System.EventHandler(this.btnregistrasi_Click);
            // 
            // btnverify
            // 
            this.btnverify.Location = new System.Drawing.Point(190, 101);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(75, 23);
            this.btnverify.TabIndex = 1;
            this.btnverify.Text = "verify";
            this.btnverify.UseVisualStyleBackColor = true;
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 254);
            this.Controls.Add(this.btnverify);
            this.Controls.Add(this.btnregistrasi);
            this.Name = "FormMain";
            this.Text = "Form Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnregistrasi;
        private System.Windows.Forms.Button btnverify;
    }
}

