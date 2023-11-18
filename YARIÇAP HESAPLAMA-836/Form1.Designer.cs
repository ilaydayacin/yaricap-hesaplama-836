namespace YARIÇAP_HESAPLAMA_836
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesap = new System.Windows.Forms.Button();
            this.lblAlan = new System.Windows.Forms.Label();
            this.lblCevre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCap
            // 
            this.txtCap.Location = new System.Drawing.Point(94, 41);
            this.txtCap.Name = "txtCap";
            this.txtCap.Size = new System.Drawing.Size(167, 20);
            this.txtCap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yarıçap";
            // 
            // btnHesap
            // 
            this.btnHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesap.Location = new System.Drawing.Point(84, 90);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(169, 159);
            this.btnHesap.TabIndex = 2;
            this.btnHesap.Text = "Alan Çevre bulun";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlan.Location = new System.Drawing.Point(12, 292);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(61, 25);
            this.lblAlan.TabIndex = 3;
            this.lblAlan.Text = "Alan:";
            // 
            // lblCevre
            // 
            this.lblCevre.AutoSize = true;
            this.lblCevre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCevre.Location = new System.Drawing.Point(12, 333);
            this.lblCevre.Name = "lblCevre";
            this.lblCevre.Size = new System.Drawing.Size(75, 25);
            this.lblCevre.TabIndex = 4;
            this.lblCevre.Text = "Çevre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCevre);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label lblCevre;
    }
}

