
namespace Proje5._31_ButonYakalamaOyunu
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lBasariliTiklamaSayisi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lBasarisizTiklamaSayisi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lGecenSure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(51, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bana Tıkla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başarılı Tıklama Sayısı:";
            // 
            // lBasariliTiklamaSayisi
            // 
            this.lBasariliTiklamaSayisi.AutoSize = true;
            this.lBasariliTiklamaSayisi.Location = new System.Drawing.Point(163, 422);
            this.lBasariliTiklamaSayisi.Name = "lBasariliTiklamaSayisi";
            this.lBasariliTiklamaSayisi.Size = new System.Drawing.Size(14, 16);
            this.lBasariliTiklamaSayisi.TabIndex = 2;
            this.lBasariliTiklamaSayisi.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başarısız Tıklama Sayısı:";
            // 
            // lBasarisizTiklamaSayisi
            // 
            this.lBasarisizTiklamaSayisi.AutoSize = true;
            this.lBasarisizTiklamaSayisi.Location = new System.Drawing.Point(426, 422);
            this.lBasarisizTiklamaSayisi.Name = "lBasarisizTiklamaSayisi";
            this.lBasarisizTiklamaSayisi.Size = new System.Drawing.Size(14, 16);
            this.lBasarisizTiklamaSayisi.TabIndex = 4;
            this.lBasarisizTiklamaSayisi.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Geçen Süre:";
            // 
            // lGecenSure
            // 
            this.lGecenSure.AutoSize = true;
            this.lGecenSure.Location = new System.Drawing.Point(667, 421);
            this.lGecenSure.Name = "lGecenSure";
            this.lGecenSure.Size = new System.Drawing.Size(14, 16);
            this.lGecenSure.TabIndex = 6;
            this.lGecenSure.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lGecenSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lBasarisizTiklamaSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lBasariliTiklamaSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lBasariliTiklamaSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lBasarisizTiklamaSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lGecenSure;
        private System.Windows.Forms.Timer timer1;
    }
}

