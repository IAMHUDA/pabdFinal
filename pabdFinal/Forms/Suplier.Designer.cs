namespace pabdFinal.Forms
{
    partial class Suplier
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
            this.tlpbox = new System.Windows.Forms.TextBox();
            this.suplierDistributorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penjualanPadiBerasDataSet = new pabdFinal.penjualanPadiBerasDataSet();
            this.almtbox = new System.Windows.Forms.TextBox();
            this.namabox = new System.Windows.Forms.TextBox();
            this.IDsdbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.suplier_DistributorTableAdapter = new pabdFinal.penjualanPadiBerasDataSetTableAdapters.Suplier_DistributorTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.ImprtBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDistributorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanPadiBerasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "NO Telpon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nama Suplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID Suplier distributor";
            // 
            // tlpbox
            // 
            this.tlpbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suplierDistributorBindingSource, "No_Telpon", true));
            this.tlpbox.Location = new System.Drawing.Point(249, 259);
            this.tlpbox.Name = "tlpbox";
            this.tlpbox.Size = new System.Drawing.Size(217, 22);
            this.tlpbox.TabIndex = 23;
            // 
            // suplierDistributorBindingSource
            // 
            this.suplierDistributorBindingSource.DataMember = "Suplier_Distributor";
            this.suplierDistributorBindingSource.DataSource = this.penjualanPadiBerasDataSet;
            // 
            // penjualanPadiBerasDataSet
            // 
            this.penjualanPadiBerasDataSet.DataSetName = "penjualanPadiBerasDataSet";
            this.penjualanPadiBerasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // almtbox
            // 
            this.almtbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suplierDistributorBindingSource, "Alamat", true));
            this.almtbox.Location = new System.Drawing.Point(249, 207);
            this.almtbox.Name = "almtbox";
            this.almtbox.Size = new System.Drawing.Size(217, 22);
            this.almtbox.TabIndex = 22;
            // 
            // namabox
            // 
            this.namabox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suplierDistributorBindingSource, "Nama_Suplier", true));
            this.namabox.Location = new System.Drawing.Point(249, 156);
            this.namabox.Name = "namabox";
            this.namabox.Size = new System.Drawing.Size(217, 22);
            this.namabox.TabIndex = 21;
            // 
            // IDsdbox
            // 
            this.IDsdbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suplierDistributorBindingSource, "ID_s_d", true));
            this.IDsdbox.Location = new System.Drawing.Point(249, 114);
            this.IDsdbox.Name = "IDsdbox";
            this.IDsdbox.Size = new System.Drawing.Size(217, 22);
            this.IDsdbox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "suplier / distributor";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(546, 209);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 32;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(546, 164);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 31;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(546, 121);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 30;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(364, 333);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 34;
            this.button_cancel.Text = "cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(237, 333);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 33;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // suplier_DistributorTableAdapter
            // 
            this.suplier_DistributorTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "S-PD-xxxx/D-BR-xxxx (x adalah angka)";
            // 
            // ImprtBttn
            // 
            this.ImprtBttn.Location = new System.Drawing.Point(546, 246);
            this.ImprtBttn.Name = "ImprtBttn";
            this.ImprtBttn.Size = new System.Drawing.Size(75, 47);
            this.ImprtBttn.TabIndex = 37;
            this.ImprtBttn.Text = "Import data";
            this.ImprtBttn.UseVisualStyleBackColor = true;
            this.ImprtBttn.Click += new System.EventHandler(this.ImprtBttn_Click);
            // 
            // Suplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImprtBttn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tlpbox);
            this.Controls.Add(this.almtbox);
            this.Controls.Add(this.namabox);
            this.Controls.Add(this.IDsdbox);
            this.Controls.Add(this.label1);
            this.Name = "Suplier";
            this.Text = "Suplier";
            this.Load += new System.EventHandler(this.Suplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suplierDistributorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanPadiBerasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tlpbox;
        private System.Windows.Forms.TextBox almtbox;
        private System.Windows.Forms.TextBox namabox;
        private System.Windows.Forms.TextBox IDsdbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private penjualanPadiBerasDataSet penjualanPadiBerasDataSet;
        private System.Windows.Forms.BindingSource suplierDistributorBindingSource;
        private penjualanPadiBerasDataSetTableAdapters.Suplier_DistributorTableAdapter suplier_DistributorTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ImprtBttn;
    }
}