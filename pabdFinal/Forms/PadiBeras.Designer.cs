namespace pabdFinal.Forms
{
    partial class PadiBeras
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.TextBox();
            this.padiBerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penjualanPadiBerasDataSet = new pabdFinal.penjualanPadiBerasDataSet();
            this.jumlah = new System.Windows.Forms.TextBox();
            this.jenis = new System.Windows.Forms.TextBox();
            this.IDpb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.padi_BerasTableAdapter = new pabdFinal.penjualanPadiBerasDataSetTableAdapters.Padi_BerasTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.padiBerasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanPadiBerasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Harga (Rp)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "jumlah (Kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Jenis padi beras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID Padi beras";
            // 
            // harga
            // 
            this.harga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.padiBerasBindingSource, "Harga", true));
            this.harga.Location = new System.Drawing.Point(222, 230);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(217, 22);
            this.harga.TabIndex = 23;
            // 
            // padiBerasBindingSource
            // 
            this.padiBerasBindingSource.DataMember = "Padi_Beras";
            this.padiBerasBindingSource.DataSource = this.penjualanPadiBerasDataSet;
            // 
            // penjualanPadiBerasDataSet
            // 
            this.penjualanPadiBerasDataSet.DataSetName = "penjualanPadiBerasDataSet";
            this.penjualanPadiBerasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jumlah
            // 
            this.jumlah.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.padiBerasBindingSource, "Jumlah_p_b", true));
            this.jumlah.Location = new System.Drawing.Point(222, 179);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(217, 22);
            this.jumlah.TabIndex = 22;
            // 
            // jenis
            // 
            this.jenis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.padiBerasBindingSource, "Jenis_p_b", true));
            this.jenis.Location = new System.Drawing.Point(222, 128);
            this.jenis.Name = "jenis";
            this.jenis.Size = new System.Drawing.Size(217, 22);
            this.jenis.TabIndex = 21;
            // 
            // IDpb
            // 
            this.IDpb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDpb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.padiBerasBindingSource, "ID_p_b", true));
            this.IDpb.Location = new System.Drawing.Point(222, 86);
            this.IDpb.Name = "IDpb";
            this.IDpb.Size = new System.Drawing.Size(217, 22);
            this.IDpb.TabIndex = 20;
            this.IDpb.TextChanged += new System.EventHandler(this.IDpb_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "PADI / BERAS";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(355, 304);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 33;
            this.button_cancel.Text = "cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.MouseCaptureChanged += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(228, 304);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 32;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.MouseCaptureChanged += new System.EventHandler(this.button_save_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(534, 234);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 36;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(534, 179);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 35;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(534, 128);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 34;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // padi_BerasTableAdapter
            // 
            this.padi_BerasTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "BR-xx/PD-xx (x adalah initial menggunakan huruf)";
            // 
            // PadiBeras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.jenis);
            this.Controls.Add(this.IDpb);
            this.Controls.Add(this.label1);
            this.Name = "PadiBeras";
            this.Text = "PadiBeras";
            this.Load += new System.EventHandler(this.PadiBeras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.padiBerasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanPadiBerasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.TextBox jumlah;
        private System.Windows.Forms.TextBox jenis;
        private System.Windows.Forms.TextBox IDpb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private penjualanPadiBerasDataSet penjualanPadiBerasDataSet;
        private System.Windows.Forms.BindingSource padiBerasBindingSource;
        private penjualanPadiBerasDataSetTableAdapters.Padi_BerasTableAdapter padi_BerasTableAdapter;
        private System.Windows.Forms.Label label6;
    }
}