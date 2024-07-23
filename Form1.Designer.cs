namespace _210601046_ŞilanEkin_ödev2_veri
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dersekle = new System.Windows.Forms.Button();
            this.dersisil = new System.Windows.Forms.Button();
            this.dersiguncelle = new System.Windows.Forms.Button();
            this.GridListele = new System.Windows.Forms.DataGridView();
            this.gano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridListele)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 287);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "GANO HESAPLA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "LİSTELE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dersekle
            // 
            this.dersekle.Location = new System.Drawing.Point(447, 84);
            this.dersekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dersekle.Name = "dersekle";
            this.dersekle.Size = new System.Drawing.Size(116, 37);
            this.dersekle.TabIndex = 12;
            this.dersekle.Text = "DERS EKLE";
            this.dersekle.UseVisualStyleBackColor = true;
            this.dersekle.Click += new System.EventHandler(this.dersekle_Click);
            // 
            // dersisil
            // 
            this.dersisil.Location = new System.Drawing.Point(279, 239);
            this.dersisil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dersisil.Name = "dersisil";
            this.dersisil.Size = new System.Drawing.Size(116, 31);
            this.dersisil.TabIndex = 11;
            this.dersisil.Text = "DERSİ SİL";
            this.dersisil.UseVisualStyleBackColor = true;
            this.dersisil.Click += new System.EventHandler(this.dersisil_Click);
            // 
            // dersiguncelle
            // 
            this.dersiguncelle.Location = new System.Drawing.Point(447, 239);
            this.dersiguncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dersiguncelle.Name = "dersiguncelle";
            this.dersiguncelle.Size = new System.Drawing.Size(116, 33);
            this.dersiguncelle.TabIndex = 10;
            this.dersiguncelle.Text = "DERSİ GÜNCELLE";
            this.dersiguncelle.UseVisualStyleBackColor = true;
            this.dersiguncelle.Click += new System.EventHandler(this.dersiguncelle_Click);
            // 
            // GridListele
            // 
            this.GridListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListele.Location = new System.Drawing.Point(9, 10);
            this.GridListele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridListele.Name = "GridListele";
            this.GridListele.RowHeadersWidth = 51;
            this.GridListele.RowTemplate.Height = 24;
            this.GridListele.Size = new System.Drawing.Size(372, 195);
            this.GridListele.TabIndex = 19;
            // 
            // gano
            // 
            this.gano.Location = new System.Drawing.Point(125, 287);
            this.gano.Margin = new System.Windows.Forms.Padding(2);
            this.gano.Name = "gano";
            this.gano.Size = new System.Drawing.Size(66, 20);
            this.gano.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "GANO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.gano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridListele);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dersekle);
            this.Controls.Add(this.dersisil);
            this.Controls.Add(this.dersiguncelle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dersekle;
        private System.Windows.Forms.Button dersisil;
        private System.Windows.Forms.Button dersiguncelle;
        private System.Windows.Forms.DataGridView GridListele;
        private System.Windows.Forms.TextBox gano;
        private System.Windows.Forms.Label label1;
    }
}

