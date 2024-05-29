namespace pabdFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.button1_barang = new System.Windows.Forms.Button();
            this.button2_suplier = new System.Windows.Forms.Button();
            this.button3_padi = new System.Windows.Forms.Button();
            this.button4_transaksi = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.button4_transaksi);
            this.panel1.Controls.Add(this.button3_padi);
            this.panel1.Controls.Add(this.button2_suplier);
            this.panel1.Controls.Add(this.button1_barang);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 585);
            this.panel1.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // button1_barang
            // 
            this.button1_barang.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1_barang.FlatAppearance.BorderSize = 0;
            this.button1_barang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_barang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1_barang.Image = ((System.Drawing.Image)(resources.GetObject("button1_barang.Image")));
            this.button1_barang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_barang.Location = new System.Drawing.Point(0, 80);
            this.button1_barang.Name = "button1_barang";
            this.button1_barang.Size = new System.Drawing.Size(220, 60);
            this.button1_barang.TabIndex = 1;
            this.button1_barang.Text = "Data Barang";
            this.button1_barang.UseVisualStyleBackColor = true;
            this.button1_barang.Click += new System.EventHandler(this.button1_barang_Click);
            // 
            // button2_suplier
            // 
            this.button2_suplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2_suplier.FlatAppearance.BorderSize = 0;
            this.button2_suplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_suplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2_suplier.Image = ((System.Drawing.Image)(resources.GetObject("button2_suplier.Image")));
            this.button2_suplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2_suplier.Location = new System.Drawing.Point(0, 140);
            this.button2_suplier.Name = "button2_suplier";
            this.button2_suplier.Size = new System.Drawing.Size(220, 60);
            this.button2_suplier.TabIndex = 2;
            this.button2_suplier.Text = "suplier";
            this.button2_suplier.UseVisualStyleBackColor = true;
            this.button2_suplier.Click += new System.EventHandler(this.button2_suplier_Click);
            // 
            // button3_padi
            // 
            this.button3_padi.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3_padi.FlatAppearance.BorderSize = 0;
            this.button3_padi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_padi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3_padi.Image = ((System.Drawing.Image)(resources.GetObject("button3_padi.Image")));
            this.button3_padi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3_padi.Location = new System.Drawing.Point(0, 200);
            this.button3_padi.Name = "button3_padi";
            this.button3_padi.Size = new System.Drawing.Size(220, 60);
            this.button3_padi.TabIndex = 3;
            this.button3_padi.Text = "padi/beras";
            this.button3_padi.UseVisualStyleBackColor = true;
            this.button3_padi.Click += new System.EventHandler(this.button3_padi_Click);
            // 
            // button4_transaksi
            // 
            this.button4_transaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4_transaksi.FlatAppearance.BorderSize = 0;
            this.button4_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4_transaksi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4_transaksi.Image = ((System.Drawing.Image)(resources.GetObject("button4_transaksi.Image")));
            this.button4_transaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4_transaksi.Location = new System.Drawing.Point(0, 260);
            this.button4_transaksi.Name = "button4_transaksi";
            this.button4_transaksi.Size = new System.Drawing.Size(220, 60);
            this.button4_transaksi.TabIndex = 4;
            this.button4_transaksi.Text = "Transaksi";
            this.button4_transaksi.UseVisualStyleBackColor = true;
            this.button4_transaksi.Click += new System.EventHandler(this.button4_transaksi_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(842, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(372, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(86, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "padi beras";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(842, 505);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 585);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1_barang;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button2_suplier;
        private System.Windows.Forms.Button button4_transaksi;
        private System.Windows.Forms.Button button3_padi;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}

