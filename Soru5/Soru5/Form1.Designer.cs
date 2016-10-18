namespace Soru5
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
            this.lblSayiGir = new System.Windows.Forms.Label();
            this.txtSayiGir = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSayiGir
            // 
            this.lblSayiGir.AutoSize = true;
            this.lblSayiGir.Location = new System.Drawing.Point(34, 47);
            this.lblSayiGir.Name = "lblSayiGir";
            this.lblSayiGir.Size = new System.Drawing.Size(49, 13);
            this.lblSayiGir.TabIndex = 0;
            this.lblSayiGir.Text = "Sayı Gir :";
            this.lblSayiGir.Click += new System.EventHandler(this.lblSayiGir_Click);
            // 
            // txtSayiGir
            // 
            this.txtSayiGir.Location = new System.Drawing.Point(107, 47);
            this.txtSayiGir.Name = "txtSayiGir";
            this.txtSayiGir.Size = new System.Drawing.Size(126, 20);
            this.txtSayiGir.TabIndex = 1;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(119, 120);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(34, 192);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(44, 13);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "Sonuc :";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(107, 185);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(126, 20);
            this.txtSonuc.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 305);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtSayiGir);
            this.Controls.Add(this.lblSayiGir);
            this.Name = "Form1";
            this.Text = "Asal Sayılar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayiGir;
        private System.Windows.Forms.TextBox txtSayiGir;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtSonuc;
    }
}

