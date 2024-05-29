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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaksi));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idsd = new System.Windows.Forms.TextBox();
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
            this.iDpbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenispbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahpbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDsdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaSuplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplierDistributorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.suplierDistributorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suplier_DistributorTableAdapter = new pabdFinal.penjualanPadiBerasDataSetTableAdapters.Suplier_DistributorTableAdapter();
            this.transaksiTableAdapter = new pabdFinal.penjualanPadiBerasDataSetTableAdapters.TransaksiTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.suplierDistributorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanPadiBerasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padiBerasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDistributorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDistributorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDistributorBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "ID Suplier distributor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID padi beras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Total Transaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Jumlah Berat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID Transaksi";
            // 
            // idsd
            // 
            this.idsd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "ID_s_d", true));
            this.idsd.Location = new System.Drawing.Point(222, 278);
            this.idsd.Name = "idsd";
            this.idsd.Size = new System.Drawing.Size(217, 22);
            this.idsd.TabIndex = 24;
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
            this.idpb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "ID_p_b", true));
            this.idpb.Location = new System.Drawing.Point(222, 228);
            this.idpb.Name = "idpb";
            this.idpb.Size = new System.Drawing.Size(217, 22);
            this.idpb.TabIndex = 23;
            // 
            // totaltr
            // 
            this.totaltr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "Total_Transaksi", true));
            this.totaltr.Location = new System.Drawing.Point(222, 177);
            this.totaltr.Name = "totaltr";
            this.totaltr.Size = new System.Drawing.Size(217, 22);
            this.totaltr.TabIndex = 22;
            // 
            // jumlahkg
            // 
            this.jumlahkg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "Jumlah_Berat", true));
            this.jumlahkg.Location = new System.Drawing.Point(222, 126);
            this.jumlahkg.Name = "jumlahkg";
            this.jumlahkg.Size = new System.Drawing.Size(217, 22);
            this.jumlahkg.TabIndex = 21;
            // 
            // IDtr
            // 
            this.IDtr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "ID_Transaksi", true));
            this.IDtr.Location = new System.Drawing.Point(222, 84);
            this.IDtr.Name = "IDtr";
            this.IDtr.Size = new System.Drawing.Size(217, 22);
            this.IDtr.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "melihat data Transaksi";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(536, 221);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 35;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(536, 166);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 34;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(536, 115);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 33;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(364, 332);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 37;
            this.button_cancel.Text = "cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(237, 332);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDpbDataGridViewTextBoxColumn,
            this.jenispbDataGridViewTextBoxColumn,
            this.jumlahpbDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.padiBerasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(91, 491);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 86);
            this.dataGridView1.TabIndex = 38;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDsdDataGridViewTextBoxColumn,
            this.namaSuplierDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.noTelponDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.suplierDistributorBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(90, 368);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(554, 94);
            this.dataGridView2.TabIndex = 39;
            // 
            // iDsdDataGridViewTextBoxColumn
            // 
            this.iDsdDataGridViewTextBoxColumn.DataPropertyName = "ID_s_d";
            this.iDsdDataGridViewTextBoxColumn.HeaderText = "ID_s_d";
            this.iDsdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDsdDataGridViewTextBoxColumn.Name = "iDsdDataGridViewTextBoxColumn";
            this.iDsdDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaSuplierDataGridViewTextBoxColumn
            // 
            this.namaSuplierDataGridViewTextBoxColumn.DataPropertyName = "Nama_Suplier";
            this.namaSuplierDataGridViewTextBoxColumn.HeaderText = "Nama_Suplier";
            this.namaSuplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaSuplierDataGridViewTextBoxColumn.Name = "namaSuplierDataGridViewTextBoxColumn";
            this.namaSuplierDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // noTelponDataGridViewTextBoxColumn
            // 
            this.noTelponDataGridViewTextBoxColumn.DataPropertyName = "No_Telpon";
            this.noTelponDataGridViewTextBoxColumn.HeaderText = "No_Telpon";
            this.noTelponDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noTelponDataGridViewTextBoxColumn.Name = "noTelponDataGridViewTextBoxColumn";
            this.noTelponDataGridViewTextBoxColumn.Width = 125;
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
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.transaksiBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 27);
            this.bindingNavigator1.TabIndex = 40;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // suplierDistributorBindingSource2
            // 
            this.suplierDistributorBindingSource2.DataMember = "Suplier_Distributor";
            this.suplierDistributorBindingSource2.DataSource = this.penjualanPadiBerasDataSet;
            // 
            // Transaksi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.bindingNavigator1);
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
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanPadiBerasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padiBerasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDistributorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDistributorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suplierDistributorBindingSource2)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenispbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahpbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource suplierDistributorBindingSource;
        private penjualanPadiBerasDataSetTableAdapters.Suplier_DistributorTableAdapter suplier_DistributorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDsdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSuplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelponDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource suplierDistributorBindingSource1;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private penjualanPadiBerasDataSetTableAdapters.TransaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource suplierDistributorBindingSource2;
    }
}