namespace pabdFinal.Forms
{
    partial class FormDataBarang
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.barang_id_log = new System.Windows.Forms.TextBox();
            this.dataBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penjualanPadiBerasDataSet = new pabdFinal.penjualanPadiBerasDataSet();
            this.barang_id_pb = new System.Windows.Forms.TextBox();
            this.barang_jumlahbrt = new System.Windows.Forms.TextBox();
            this.barang_id_admin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.data_BarangTableAdapter = new pabdFinal.penjualanPadiBerasDataSetTableAdapters.Data_BarangTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDpbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenispbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahpbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.padiBerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.padi_BerasTableAdapter = new pabdFinal.penjualanPadiBerasDataSetTableAdapters.Padi_BerasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanPadiBerasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padiBerasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATA BARANG";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(229, 332);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(356, 332);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(538, 122);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // barang_id_log
            // 
            this.barang_id_log.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBarangBindingSource, "ID_log", true));
            this.barang_id_log.Location = new System.Drawing.Point(229, 81);
            this.barang_id_log.Name = "barang_id_log";
            this.barang_id_log.Size = new System.Drawing.Size(217, 22);
            this.barang_id_log.TabIndex = 5;
            this.barang_id_log.TextChanged += new System.EventHandler(this.barang_id_log_TextChanged);
            // 
            // dataBarangBindingSource
            // 
            this.dataBarangBindingSource.DataMember = "Data_Barang";
            this.dataBarangBindingSource.DataSource = this.penjualanPadiBerasDataSet;
            // 
            // penjualanPadiBerasDataSet
            // 
            this.penjualanPadiBerasDataSet.DataSetName = "penjualanPadiBerasDataSet";
            this.penjualanPadiBerasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barang_id_pb
            // 
            this.barang_id_pb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBarangBindingSource, "ID_p_b", true));
            this.barang_id_pb.Location = new System.Drawing.Point(229, 126);
            this.barang_id_pb.Name = "barang_id_pb";
            this.barang_id_pb.Size = new System.Drawing.Size(217, 22);
            this.barang_id_pb.TabIndex = 6;
            // 
            // barang_jumlahbrt
            // 
            this.barang_jumlahbrt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBarangBindingSource, "Jumlah_Berat", true));
            this.barang_jumlahbrt.Location = new System.Drawing.Point(229, 177);
            this.barang_jumlahbrt.Name = "barang_jumlahbrt";
            this.barang_jumlahbrt.Size = new System.Drawing.Size(217, 22);
            this.barang_jumlahbrt.TabIndex = 7;
            // 
            // barang_id_admin
            // 
            this.barang_id_admin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBarangBindingSource, "ID_Admin", true));
            this.barang_id_admin.Location = new System.Drawing.Point(229, 278);
            this.barang_id_admin.Name = "barang_id_admin";
            this.barang_id_admin.Size = new System.Drawing.Size(217, 22);
            this.barang_id_admin.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID log";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID Padi Beras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Jumlah Berat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tanggal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID admin";
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(538, 173);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 15;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(538, 228);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // data_BarangTableAdapter
            // 
            this.data_BarangTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBarangBindingSource, "Tanggal", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDpbDataGridViewTextBoxColumn,
            this.jenispbDataGridViewTextBoxColumn,
            this.jumlahpbDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.padiBerasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(101, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(589, 137);
            this.dataGridView1.TabIndex = 39;
            // 
            // iDpbDataGridViewTextBoxColumn
            // 
            this.iDpbDataGridViewTextBoxColumn.DataPropertyName = "ID_p_b";
            this.iDpbDataGridViewTextBoxColumn.HeaderText = "ID_p_b";
            this.iDpbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDpbDataGridViewTextBoxColumn.Name = "iDpbDataGridViewTextBoxColumn";
            this.iDpbDataGridViewTextBoxColumn.Width = 125;
            // 
            // jenispbDataGridViewTextBoxColumn
            // 
            this.jenispbDataGridViewTextBoxColumn.DataPropertyName = "Jenis_p_b";
            this.jenispbDataGridViewTextBoxColumn.HeaderText = "Jenis_p_b";
            this.jenispbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenispbDataGridViewTextBoxColumn.Name = "jenispbDataGridViewTextBoxColumn";
            this.jenispbDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahpbDataGridViewTextBoxColumn
            // 
            this.jumlahpbDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_p_b";
            this.jumlahpbDataGridViewTextBoxColumn.HeaderText = "Jumlah_p_b";
            this.jumlahpbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahpbDataGridViewTextBoxColumn.Name = "jumlahpbDataGridViewTextBoxColumn";
            this.jumlahpbDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 125;
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
            // FormDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 521);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barang_id_admin);
            this.Controls.Add(this.barang_jumlahbrt);
            this.Controls.Add(this.barang_id_pb);
            this.Controls.Add(this.barang_id_log);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label1);
            this.Name = "FormDataBarang";
            this.Text = "FormDataBarang";
            this.Load += new System.EventHandler(this.FormDataBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanPadiBerasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padiBerasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox barang_id_log;
        private System.Windows.Forms.TextBox barang_id_pb;
        private System.Windows.Forms.TextBox barang_jumlahbrt;
        private System.Windows.Forms.TextBox barang_id_admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private penjualanPadiBerasDataSet penjualanPadiBerasDataSet;
        private System.Windows.Forms.BindingSource dataBarangBindingSource;
        private penjualanPadiBerasDataSetTableAdapters.Data_BarangTableAdapter data_BarangTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource padiBerasBindingSource;
        private penjualanPadiBerasDataSetTableAdapters.Padi_BerasTableAdapter padi_BerasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenispbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahpbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
    }
}