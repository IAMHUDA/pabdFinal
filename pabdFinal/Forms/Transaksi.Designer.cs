namespace pabdFinal.Forms
{
    partial class Transaksi
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idsd = new System.Windows.Forms.TextBox();
            this.transaksiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.penjualanPadiBerasDataSet3 = new pabdFinal.penjualanPadiBerasDataSet3();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penjualanPadiBerasDataSet = new pabdFinal.penjualanPadiBerasDataSet();
            this.idpb = new System.Windows.Forms.TextBox();
            this.totaltr = new System.Windows.Forms.TextBox();
            this.jumlahkg = new System.Windows.Forms.TextBox();
            this.IDtr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.padiBerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.padi_BerasTableAdapter = new pabdFinal.penjualanPadiBerasDataSetTableAdapters.Padi_BerasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.suplierDistributorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.suplierDistributorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.suplierDistributorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suplier_DistributorTableAdapter = new pabdFinal.penjualanPadiBerasDataSetTableAdapters.Suplier_DistributorTableAdapter();
            this.transaksiTableAdapter = new pabdFinal.penjualanPadiBerasDataSetTableAdapters.TransaksiTableAdapter();
            this.transaksiTableAdapter1 = new pabdFinal.penjualanPadiBerasDataSet3TableAdapters.TransaksiTableAdapter();
            this.invcpath = new System.Windows.Forms.TextBox();
            this.Uploadbttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanPadiBerasDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanPadiBerasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padiBerasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDistributorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDistributorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDistributorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "ID Suplier distributor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID padi beras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Total Transaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Jumlah Berat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID Transaksi";
            // 
            // idsd
            // 
            this.idsd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource1, "ID_s_d", true));
            this.idsd.Location = new System.Drawing.Point(152, 264);
            this.idsd.Name = "idsd";
            this.idsd.Size = new System.Drawing.Size(217, 22);
            this.idsd.TabIndex = 24;
            // 
            // transaksiBindingSource1
            // 
            this.transaksiBindingSource1.DataMember = "Transaksi";
            this.transaksiBindingSource1.DataSource = this.penjualanPadiBerasDataSet3;
            // 
            // penjualanPadiBerasDataSet3
            // 
            this.penjualanPadiBerasDataSet3.DataSetName = "penjualanPadiBerasDataSet3";
            this.penjualanPadiBerasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "Transaksi";
            this.transaksiBindingSource.DataSource = this.penjualanPadiBerasDataSet;
            // 
            // penjualanPadiBerasDataSet
            // 
            this.penjualanPadiBerasDataSet.DataSetName = "penjualanPadiBerasDataSet";
            this.penjualanPadiBerasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idpb
            // 
            this.idpb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource1, "ID_p_b", true));
            this.idpb.Location = new System.Drawing.Point(152, 214);
            this.idpb.Name = "idpb";
            this.idpb.Size = new System.Drawing.Size(217, 22);
            this.idpb.TabIndex = 23;
            // 
            // totaltr
            // 
            this.totaltr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource1, "Total_Transaksi", true));
            this.totaltr.Location = new System.Drawing.Point(152, 163);
            this.totaltr.Name = "totaltr";
            this.totaltr.Size = new System.Drawing.Size(217, 22);
            this.totaltr.TabIndex = 22;
            // 
            // jumlahkg
            // 
            this.jumlahkg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource1, "Jumlah_Berat", true));
            this.jumlahkg.Location = new System.Drawing.Point(152, 112);
            this.jumlahkg.Name = "jumlahkg";
            this.jumlahkg.Size = new System.Drawing.Size(217, 22);
            this.jumlahkg.TabIndex = 21;
            // 
            // IDtr
            // 
            this.IDtr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource1, "ID_Transaksi", true));
            this.IDtr.Location = new System.Drawing.Point(152, 70);
            this.IDtr.Name = "IDtr";
            this.IDtr.Size = new System.Drawing.Size(217, 22);
            this.IDtr.TabIndex = 20;
            this.IDtr.TextChanged += new System.EventHandler(this.IDtr_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "melihat data Transaksi";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(442, 263);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 35;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(442, 208);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 34;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(442, 157);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 33;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(294, 294);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 29);
            this.button_cancel.TabIndex = 37;
            this.button_cancel.Text = "cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(167, 294);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 29);
            this.button_save.TabIndex = 36;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // padiBerasBindingSource
            // 
            this.padiBerasBindingSource.DataMember = "Padi_Beras";
            this.padiBerasBindingSource.DataSource = this.penjualanPadiBerasDataSet;
            // 
            // padi_BerasTableAdapter
            // 
            this.padi_BerasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 466);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(565, 143);
            this.dataGridView1.TabIndex = 38;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 329);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(565, 117);
            this.dataGridView2.TabIndex = 39;
            // 
            // suplierDistributorBindingSource2
            // 
            this.suplierDistributorBindingSource2.DataMember = "Suplier_Distributor";
            this.suplierDistributorBindingSource2.DataSource = this.penjualanPadiBerasDataSet;
            // 
            // suplierDistributorBindingSource1
            // 
            this.suplierDistributorBindingSource1.DataMember = "Suplier_Distributor";
            this.suplierDistributorBindingSource1.DataSource = this.penjualanPadiBerasDataSet;
            // 
            // suplierDistributorBindingSource
            // 
            this.suplierDistributorBindingSource.DataMember = "Suplier_Distributor";
            this.suplierDistributorBindingSource.DataSource = this.penjualanPadiBerasDataSet;
            // 
            // suplier_DistributorTableAdapter
            // 
            this.suplier_DistributorTableAdapter.ClearBeforeFill = true;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // transaksiTableAdapter1
            // 
            this.transaksiTableAdapter1.ClearBeforeFill = true;
            // 
            // invcpath
            // 
            this.invcpath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource1, "ID_Transaksi", true));
            this.invcpath.Location = new System.Drawing.Point(386, 70);
            this.invcpath.Name = "invcpath";
            this.invcpath.Size = new System.Drawing.Size(131, 22);
            this.invcpath.TabIndex = 40;
            // 
            // Uploadbttn
            // 
            this.Uploadbttn.Location = new System.Drawing.Point(442, 108);
            this.Uploadbttn.Name = "Uploadbttn";
            this.Uploadbttn.Size = new System.Drawing.Size(75, 23);
            this.Uploadbttn.TabIndex = 41;
            this.Uploadbttn.Text = "upload";
            this.Uploadbttn.UseVisualStyleBackColor = true;
            this.Uploadbttn.Click += new System.EventHandler(this.Uploadbttn_Click);
            // 
            // Transaksi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(943, 621);
            this.Controls.Add(this.Uploadbttn);
            this.Controls.Add(this.invcpath);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idsd);
            this.Controls.Add(this.idpb);
            this.Controls.Add(this.totaltr);
            this.Controls.Add(this.jumlahkg);
            this.Controls.Add(this.IDtr);
            this.Controls.Add(this.label1);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanPadiBerasDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanPadiBerasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padiBerasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDistributorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDistributorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDistributorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idsd;
        private System.Windows.Forms.TextBox idpb;
        private System.Windows.Forms.TextBox totaltr;
        private System.Windows.Forms.TextBox jumlahkg;
        private System.Windows.Forms.TextBox IDtr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private penjualanPadiBerasDataSet penjualanPadiBerasDataSet;
        private System.Windows.Forms.BindingSource padiBerasBindingSource;
        private penjualanPadiBerasDataSetTableAdapters.Padi_BerasTableAdapter padi_BerasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource suplierDistributorBindingSource;
        private penjualanPadiBerasDataSetTableAdapters.Suplier_DistributorTableAdapter suplier_DistributorTableAdapter;
        private System.Windows.Forms.BindingSource suplierDistributorBindingSource1;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private penjualanPadiBerasDataSetTableAdapters.TransaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.BindingSource suplierDistributorBindingSource2;
        private penjualanPadiBerasDataSet3 penjualanPadiBerasDataSet3;
        private System.Windows.Forms.BindingSource transaksiBindingSource1;
        private penjualanPadiBerasDataSet3TableAdapters.TransaksiTableAdapter transaksiTableAdapter1;
        private System.Windows.Forms.TextBox invcpath;
        private System.Windows.Forms.Button Uploadbttn;
    }
}