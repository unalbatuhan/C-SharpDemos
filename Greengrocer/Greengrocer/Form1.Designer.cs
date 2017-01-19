namespace Greengrocer
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
            this.label1 = new System.Windows.Forms.Label();
            this.numTomatoKilo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numTomatoPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpToplamFiyat = new System.Windows.Forms.GroupBox();
            this.numTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTomatoKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTomatoPrice)).BeginInit();
            this.grpToplamFiyat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tomato";
            // 
            // numTomatoKilo
            // 
            this.numTomatoKilo.Location = new System.Drawing.Point(189, 62);
            this.numTomatoKilo.Name = "numTomatoKilo";
            this.numTomatoKilo.Size = new System.Drawing.Size(120, 20);
            this.numTomatoKilo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kilo";
            // 
            // numTomatoPrice
            // 
            this.numTomatoPrice.Location = new System.Drawing.Point(338, 62);
            this.numTomatoPrice.Name = "numTomatoPrice";
            this.numTomatoPrice.ReadOnly = true;
            this.numTomatoPrice.Size = new System.Drawing.Size(120, 20);
            this.numTomatoPrice.TabIndex = 3;
            this.numTomatoPrice.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(513, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpToplamFiyat
            // 
            this.grpToplamFiyat.Controls.Add(this.label4);
            this.grpToplamFiyat.Controls.Add(this.numTotalPrice);
            this.grpToplamFiyat.Location = new System.Drawing.Point(74, 176);
            this.grpToplamFiyat.Name = "grpToplamFiyat";
            this.grpToplamFiyat.Size = new System.Drawing.Size(534, 100);
            this.grpToplamFiyat.TabIndex = 6;
            this.grpToplamFiyat.TabStop = false;
            this.grpToplamFiyat.Text = "Total Price";
            // 
            // numTotalPrice
            // 
            this.numTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTotalPrice.Location = new System.Drawing.Point(95, 48);
            this.numTotalPrice.Name = "numTotalPrice";
            this.numTotalPrice.Size = new System.Drawing.Size(120, 30);
            this.numTotalPrice.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "₺";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(701, 303);
            this.Controls.Add(this.grpToplamFiyat);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTomatoPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numTomatoKilo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Grocer";
            ((System.ComponentModel.ISupportInitialize)(this.numTomatoKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTomatoPrice)).EndInit();
            this.grpToplamFiyat.ResumeLayout(false);
            this.grpToplamFiyat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTomatoKilo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTomatoPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpToplamFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTotalPrice;
    }
}

