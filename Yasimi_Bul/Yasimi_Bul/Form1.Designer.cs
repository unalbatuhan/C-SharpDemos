namespace Yasimi_Bul
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
            this.dtDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYasimiBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtDogumTarih
            // 
            this.dtDogumTarih.Location = new System.Drawing.Point(139, 105);
            this.dtDogumTarih.Name = "dtDogumTarih";
            this.dtDogumTarih.Size = new System.Drawing.Size(200, 20);
            this.dtDogumTarih.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doğum Tarihinizi Seçiniz!";
            // 
            // txtYas
            // 
            this.txtYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtYas.Location = new System.Drawing.Point(185, 177);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 38);
            this.txtYas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yaşınız :";
            // 
            // btnYasimiBul
            // 
            this.btnYasimiBul.Location = new System.Drawing.Point(196, 273);
            this.btnYasimiBul.Name = "btnYasimiBul";
            this.btnYasimiBul.Size = new System.Drawing.Size(75, 23);
            this.btnYasimiBul.TabIndex = 4;
            this.btnYasimiBul.Text = "Yaşımı Bul";
            this.btnYasimiBul.UseVisualStyleBackColor = true;
            this.btnYasimiBul.Click += new System.EventHandler(this.btnYasimiBul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 371);
            this.Controls.Add(this.btnYasimiBul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDogumTarih);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDogumTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYasimiBul;
    }
}

