using pabdFinal.penjualanPadiBerasDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pabdFinal.Forms
{
    public partial class FormDataBarang : Form
    {
        DataTable dt;
        DataRow dr;
        int bttn;

        public FormDataBarang()
        {
            InitializeComponent();
        }

        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'penjualanPadiBerasDataSet.Padi_Beras' table. You can move, or remove it, as needed.
            this.padi_BerasTableAdapter.Fill(this.penjualanPadiBerasDataSet.Padi_Beras);
            // TODO: This line of code loads data into the 'penjualanPadiBerasDataSet.Data_Barang' table. You can move, or remove it, as needed.
            this.data_BarangTableAdapter.Fill(this.penjualanPadiBerasDataSet.Data_Barang);

            barang_id_log.Enabled = false;
            barang_id_pb.Enabled = false;
            barang_jumlahbrt.Enabled = false;
            dateTimePicker1.Enabled = false;
            barang_id_admin.Enabled = false;


            button_save.Enabled = false;
            button_cancel.Enabled = false;
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            bttn = 2;

            button_save.Enabled = true;
                    barang_id_log.Enabled = false;
            barang_id_pb.Enabled = true;
            barang_jumlahbrt.Enabled = true;
            dateTimePicker1.Enabled = true;
            barang_id_admin.Enabled = true;

            button_add.Enabled = false;
            button_delete.Enabled = false;
            button_edit.Enabled = false;
            button_cancel.Enabled = true;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            bttn = 1;
            tambah();
        }

        public void tambah()
        {
            button_save.Enabled = true;
            barang_id_log.Enabled = false;
            barang_id_pb.Enabled = true;
            barang_jumlahbrt.Enabled = true;
            dateTimePicker1.Enabled = true;
            barang_id_admin.Enabled = true;

            barang_id_log.Text = "";
            barang_id_pb.Text = "";
            barang_jumlahbrt.Text = "";
            barang_id_admin.Text = "";

            button_add.Enabled = false;
            button_delete.Enabled = false;
            button_edit.Enabled = false;
            button_cancel.Enabled = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (bttn == 1)
            {
                dt = penjualanPadiBerasDataSet.Tables["Data_Barang"];
                //Menyimpan data kedalam database
                dr = dt.NewRow();
                dr["ID_p_b"] = barang_id_pb.Text;
                dr["Jumlah_Berat"] = barang_jumlahbrt.Text;
                dr["Tanggal"] = dateTimePicker1.Value;
                dr["ID_Admin"] = barang_id_admin.Text;
                dt.Rows.Add(dr);
            }
            else
            {
                dt = penjualanPadiBerasDataSet.Tables["Data_Barang"];
                //mencari primary key yang akan diubah datanya
                dr = dt.Rows.Find(barang_id_log.Text);

                //Mengubah data Kedalam database
                dr.BeginEdit();
                dr["ID_p_b"] = barang_id_pb.Text;
                dr["Jumlah_Berat"] = barang_jumlahbrt.Text;
                dr["Tanggal"] = dateTimePicker1.Text;
                dr["ID_Admin"] = barang_id_admin.Text;
                dr.EndEdit();
            }

            data_BarangTableAdapter.Update(penjualanPadiBerasDataSet);
            barang_id_log.Enabled = false;
            barang_id_pb.Enabled = false;
            barang_jumlahbrt.Enabled = false;
            dateTimePicker1.Enabled = false;
            barang_id_admin.Enabled = false;

            this.data_BarangTableAdapter.Fill(this.penjualanPadiBerasDataSet.Data_Barang);
            button_add.Enabled = true;
            button_edit.Enabled = true;
            button_delete.Enabled = true;
            button_save.Enabled = false;
            button_cancel.Enabled = false;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show(this, "Apakah Anda ingin menghapus data ini?",
                "Konfirmasi Ubah Data",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                hapus();
            }
        }

        public void hapus()
        {
            string code;
            code = barang_id_log.Text;
            //mencari data yang akan dihapus berdasarkan primarykey
            dr = penjualanPadiBerasDataSet.Tables["Data_Barang"].Rows.Find(code);
            //Menghapus Data
            dr.Delete();
            data_BarangTableAdapter.Update(penjualanPadiBerasDataSet);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {

            barang_id_log.Enabled = false;
            barang_id_pb.Enabled = false;
            barang_jumlahbrt.Enabled = false;
            dateTimePicker1.Enabled = false;
            barang_id_admin.Enabled = false;

            this.data_BarangTableAdapter.Fill(this.penjualanPadiBerasDataSet.Data_Barang);
            button_add.Enabled = true;
            button_edit.Enabled = true;
            button_delete.Enabled = true;
            button_save.Enabled = false;
            button_cancel.Enabled = false;
        }
    }
}
