﻿namespace Kaya_go_market.UI
{
    partial class FrmSatis
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
            this.nmFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMüşteriSeç = new System.Windows.Forms.Button();
            this.btnÜrünSeç = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nmFiyat
            // 
            this.nmFiyat.Location = new System.Drawing.Point(97, 106);
            this.nmFiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmFiyat.Name = "nmFiyat";
            this.nmFiyat.Size = new System.Drawing.Size(244, 20);
            this.nmFiyat.TabIndex = 3;
            this.nmFiyat.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(266, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "iptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(185, 162);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Tamam";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Urun";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(97, 54);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(163, 20);
            this.txtMusteri.TabIndex = 1;
            this.txtMusteri.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Musteri";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 28);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(244, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID";
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(97, 79);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(163, 20);
            this.txtUrun.TabIndex = 2;
            this.txtUrun.TabStop = false;
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(97, 136);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(244, 20);
            this.dtTarih.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMüşteriSeç
            // 
            this.btnMüşteriSeç.Location = new System.Drawing.Point(266, 51);
            this.btnMüşteriSeç.Name = "btnMüşteriSeç";
            this.btnMüşteriSeç.Size = new System.Drawing.Size(75, 23);
            this.btnMüşteriSeç.TabIndex = 43;
            this.btnMüşteriSeç.Text = "Müşteri Seç";
            this.btnMüşteriSeç.UseVisualStyleBackColor = true;
            this.btnMüşteriSeç.Click += new System.EventHandler(this.btnMüşteriSeç_Click);
            // 
            // btnÜrünSeç
            // 
            this.btnÜrünSeç.Location = new System.Drawing.Point(266, 77);
            this.btnÜrünSeç.Name = "btnÜrünSeç";
            this.btnÜrünSeç.Size = new System.Drawing.Size(75, 23);
            this.btnÜrünSeç.TabIndex = 44;
            this.btnÜrünSeç.Text = "Ürün Seç";
            this.btnÜrünSeç.UseVisualStyleBackColor = true;
            this.btnÜrünSeç.Click += new System.EventHandler(this.btnÜrünSeç_Click);
            // 
            // FrmSatis
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(396, 201);
            this.Controls.Add(this.btnÜrünSeç);
            this.Controls.Add(this.btnMüşteriSeç);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.nmFiyat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSatis";
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmFiyat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnÜrünSeç;
        private System.Windows.Forms.Button btnMüşteriSeç;
    }
}