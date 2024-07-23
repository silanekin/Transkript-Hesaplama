namespace _210601046_ŞilanEkin_ödev2_veri
{
    partial class Form5
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
            this.derskod = new System.Windows.Forms.Label();
            this.dersSildersKodu = new System.Windows.Forms.TextBox();
            this.dersSilBtn = new System.Windows.Forms.Button();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.dersSilGridListele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dersSilGridListele)).BeginInit();
            this.SuspendLayout();
            // 
            // derskod
            // 
            this.derskod.AutoSize = true;
            this.derskod.Location = new System.Drawing.Point(97, 205);
            this.derskod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.derskod.Name = "derskod";
            this.derskod.Size = new System.Drawing.Size(71, 13);
            this.derskod.TabIndex = 18;
            this.derskod.Text = "DERS KODU";
            // 
            // dersSildersKodu
            // 
            this.dersSildersKodu.Location = new System.Drawing.Point(189, 202);
            this.dersSildersKodu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dersSildersKodu.Name = "dersSildersKodu";
            this.dersSildersKodu.Size = new System.Drawing.Size(76, 20);
            this.dersSildersKodu.TabIndex = 17;
            // 
            // dersSilBtn
            // 
            this.dersSilBtn.Location = new System.Drawing.Point(301, 197);
            this.dersSilBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dersSilBtn.Name = "dersSilBtn";
            this.dersSilBtn.Size = new System.Drawing.Size(92, 28);
            this.dersSilBtn.TabIndex = 19;
            this.dersSilBtn.Text = "DERSİ SİL";
            this.dersSilBtn.UseVisualStyleBackColor = true;
            this.dersSilBtn.Click += new System.EventHandler(this.dersSilBtn_Click);
            // 
            // iptalBtn
            // 
            this.iptalBtn.Location = new System.Drawing.Point(398, 196);
            this.iptalBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(90, 30);
            this.iptalBtn.TabIndex = 20;
            this.iptalBtn.Text = "İPTAL";
            this.iptalBtn.UseVisualStyleBackColor = true;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // dersSilGridListele
            // 
            this.dersSilGridListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dersSilGridListele.Location = new System.Drawing.Point(20, 10);
            this.dersSilGridListele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dersSilGridListele.Name = "dersSilGridListele";
            this.dersSilGridListele.RowHeadersWidth = 51;
            this.dersSilGridListele.RowTemplate.Height = 24;
            this.dersSilGridListele.Size = new System.Drawing.Size(448, 181);
            this.dersSilGridListele.TabIndex = 21;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 280);
            this.Controls.Add(this.dersSilGridListele);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.dersSilBtn);
            this.Controls.Add(this.derskod);
            this.Controls.Add(this.dersSildersKodu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dersSilGridListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label derskod;
        private System.Windows.Forms.TextBox dersSildersKodu;
        private System.Windows.Forms.Button dersSilBtn;
        private System.Windows.Forms.Button iptalBtn;
        private System.Windows.Forms.DataGridView dersSilGridListele;
    }
}