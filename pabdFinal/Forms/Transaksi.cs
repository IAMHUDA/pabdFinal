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
    public partial class Transaksi : Form
    {
        DataTable dt;
        DataRow dr;
        int bttn;

        public Transaksi()
        {
            InitializeComponent();
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'penjualanPadiBerasDataSet.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.penjualanPadiBerasDataSet.Transaksi);
            // TODO: This line of code loads data into the 'penjualanPadiBerasDataSet.Suplier_Distributor' table. You can move, or remove it, as needed.
            this.suplier_DistributorTableAdapter.Fill(this.penjualanPadiBerasDataSet.Suplier_Distributor);
            // TODO: This line of code loads data into the 'penjualanPadiBerasDataSet.Padi_Beras' table. You can move, or remove it, as needed.
            this.padi_BerasTableAdapter.Fill(this.penjualanPadiBerasDataSet.Padi_Beras);

            IDtr.Enabled = false;
            jumlahkg.Enabled = false;
            totaltr.Enabled = false;
            idpb.Enabled = false;
            idsd.Enabled = false;

            button_save.Enabled = false;
            button_cancel.Enabled = false;
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            bttn = 2;

            button_save.Enabled = true;
            IDtr.Enabled = false;
            jumlahkg.Enabled = true;
            totaltr.Enabled = false;  // Total transaction is calculated, not manually entered
            idpb.Enabled = true;
            idsd.Enabled = true;

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
            IDtr.Enabled = false;
            jumlahkg.Enabled = true;
            totaltr.Enabled = false;  // Total transaction is calculated, not manually entered
            idpb.Enabled = true;
            idsd.Enabled = true;

            IDtr.Text = "";
            jumlahkg.Text = "";
            totaltr.Text = "";
            idpb.Text = "";
            idsd.Text = "";

            button_add.Enabled = false;
            button_delete.Enabled = false;
            button_edit.Enabled = false;
            button_cancel.Enabled = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            dt = penjualanPadiBerasDataSet.Tables["Transaksi"];
            if (bttn == 1)
            {
                // Menyimpan data kedalam database
                dr = dt.NewRow();

                // Ensure these values are correctly parsed to their respective types
                if (int.TryParse(jumlahkg.Text, out int jumlahBerat) &&
                    decimal.TryParse(GetHarga(idpb.Text), out decimal harga))
                {
                    decimal totalTransaksi = jumlahBerat * harga;
                    dr["Jumlah_Berat"] = jumlahBerat;
                    dr["Total_Transaksi"] = totalTransaksi;
                    dr["ID_p_b"] = idpb.Text;
                    dr["ID_s_d"] = idsd.Text;
                    dt.Rows.Add(dr);
                }
                else
                {
                    MessageBox.Show("Jumlah Berat harus berupa angka dan ID p_b harus valid.");
                    return;
                }
            }
            else
            {
                // mencari primary key yang akan diubah datanya
                dr = dt.Rows.Find(IDtr.Text);

                // Mengubah data Kedalam database
                if (int.TryParse(jumlahkg.Text, out int jumlahBerat) &&
                    decimal.TryParse(GetHarga(idpb.Text), out decimal harga))
                {
                    decimal totalTransaksi = jumlahBerat * harga;
                    dr.BeginEdit();
                    dr["Jumlah_Berat"] = jumlahBerat;
                    dr["Total_Transaksi"] = totalTransaksi;
                    dr["ID_p_b"] = idpb.Text;
                    dr["ID_s_d"] = idsd.Text;
                    dr.EndEdit();
                }
                else
                {
                    MessageBox.Show("Jumlah Berat harus berupa angka dan ID p_b harus valid.");
                    return;
                }
            }

            transaksiTableAdapter.Update(penjualanPadiBerasDataSet);
            IDtr.Enabled = false;
            jumlahkg.Enabled = false;
            totaltr.Enabled = false;
            idpb.Enabled = false;
            idsd.Enabled = false;

            this.transaksiTableAdapter.Fill(this.penjualanPadiBerasDataSet.Transaksi);
            button_add.Enabled = true;
            button_edit.Enabled = true;
            button_delete.Enabled = true;
            button_save.Enabled = false;
            button_cancel.Enabled = false;
        }

        private string GetHarga(string idpb)
        {
            // Retrieve the Harga from Padi_Beras table for the given ID_p_b
            DataRow[] rows = penjualanPadiBerasDataSet.Padi_Beras.Select($"ID_p_b = '{idpb}'");
            if (rows.Length > 0)
            {
                return rows[0]["Harga"].ToString();
            }
            return "0"; // Return a default value if not found
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
            code = IDtr.Text;
            // mencari data yang akan dihapus berdasarkan primarykey
            dr = penjualanPadiBerasDataSet.Tables["Transaksi"].Rows.Find(code);
            // Menghapus Data
            dr.Delete();
            transaksiTableAdapter.Update(penjualanPadiBerasDataSet);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            IDtr.Enabled = false;
            jumlahkg.Enabled = false;
            totaltr.Enabled = false;
            idpb.Enabled = false;
            idsd.Enabled = false;

            this.transaksiTableAdapter.Fill(this.penjualanPadiBerasDataSet.Transaksi);
            button_add.Enabled = true;
            button_edit.Enabled = true;
            button_delete.Enabled = true;
            button_save.Enabled = false;
            button_cancel.Enabled = false;
        }
    }
}
