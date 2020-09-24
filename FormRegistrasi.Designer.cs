namespace fingerprint
{
    partial class FormRegistrasi
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
            this.txtnama = new System.Windows.Forms.TextBox();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(102, 63);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(222, 20);
            this.txtnama.TabIndex = 1;
            // 
            // btnsimpan
            // 
            this.btnsimpan.Enabled = false;
            this.btnsimpan.Location = new System.Drawing.Point(44, 128);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(75, 23);
            this.btnsimpan.TabIndex = 2;
            this.btnsimpan.Text = "Save";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(102, 89);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(222, 20);
            this.txtcode.TabIndex = 4;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(125, 128);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(75, 23);
            this.btnregister.TabIndex = 5;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // dgvlist
            // 
            this.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlist.Location = new System.Drawing.Point(44, 157);
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.Size = new System.Drawing.Size(387, 175);
            this.dgvlist.TabIndex = 6;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(102, 37);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(222, 20);
            this.txtid.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // FormRegistrasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 342);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvlist);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistrasi";
            this.Text = "FormRegistrasi";
            this.Load += new System.EventHandler(this.FormRegistrasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.DataGridView dgvlist;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
    }
}