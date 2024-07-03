using pabdFinal.penjualanPadiBerasDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            this.barang_jumlahbrt.LostFocus += new System.EventHandler(this.barang_jumlahbrt_LostFocus);
        }

        private void FormDataBarang_Load(object sender, EventArgs e)
        {

            barang_id_log.Enabled = true;
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
            barang_id_admin.Enabled = false;

            barang_id_log.Text = "";
            barang_id_pb.Text = "";
            barang_jumlahbrt.Text = "";
            barang_id_admin.Text = "ADM49";

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

        private void barang_id_log_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(barang_id_log.Text, out int logID))
            {
                DataRow[] rows = penjualanPadiBerasDataSet.Data_Barang.Select($"ID_log = {logID}");

                if (rows.Length > 0)
                {
                    DataRow row = rows[0];

                    // Set nilai kontrol-kontrol lainnya sesuai dengan data yang ditemukan
                    barang_id_pb.Text = row["ID_p_b"].ToString();
                    barang_jumlahbrt.Text = row["Jumlah_Berat"].ToString();
                    dateTimePicker1.Value = (DateTime)row["Tanggal"];
                    barang_id_admin.Text = row["ID_Admin"].ToString();
                }
                else
                {
                    // Bersihkan nilai kontrol-kontrol lainnya jika data tidak ditemukan
                    barang_id_pb.Text = "";
                    barang_jumlahbrt.Text = "";
                    dateTimePicker1.Value = DateTime.Today;
                    barang_id_admin.Text = "";
                }
            }
            else
            {
                // Reset nilai kontrol jika input tidak valid
                barang_id_pb.Text = "";
                barang_jumlahbrt.Text = "";
                dateTimePicker1.Value = DateTime.Today;
                barang_id_admin.Text = "";
            }
        }

        //validsi
        private void barang_jumlahbrt_LostFocus(object sender, EventArgs e)
        {
            int jumlahBerat;
            if (!int.TryParse(barang_jumlahbrt.Text, out jumlahBerat))
            {
                MessageBox.Show(this, "Jumlah berat harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barang_jumlahbrt.Focus(); // Fokus kembali ke barang_jumlahbrt untuk pengisian ulang
            }
        }
    }
}
