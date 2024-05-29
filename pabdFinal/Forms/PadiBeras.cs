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
    public partial class PadiBeras : Form
    {
        DataTable dt;
        DataRow dr;
        int bttn;
        public PadiBeras()
        {
            InitializeComponent();
        }

        private void PadiBeras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'penjualanPadiBerasDataSet.Padi_Beras' table. You can move, or remove it, as needed.
            this.padi_BerasTableAdapter.Fill(this.penjualanPadiBerasDataSet.Padi_Beras);

            IDpb.Enabled = false;
            jenis.Enabled = false;
            jumlah.Enabled = false;
            harga.Enabled = false;

            button_save.Enabled = false;
            button_cancel.Enabled = false;
        }
        private void button_edit_Click(object sender, EventArgs e)
        {
            bttn = 2;

            button_save.Enabled = true;
            IDpb.Enabled = true;
            jenis.Enabled = true;
            jumlah.Enabled = true;
            harga.Enabled = true;

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
            IDpb.Enabled = true;
            jenis.Enabled = true;
            jumlah.Enabled = true;
            harga.Enabled = true;

            IDpb.Text = "";
            jenis.Text = "";
            jumlah.Text = "";
            harga.Text = "";

            button_add.Enabled = false;
            button_delete.Enabled = false;
            button_edit.Enabled = false;
            button_cancel.Enabled = true;


        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (bttn == 1)
            {
                dt = penjualanPadiBerasDataSet.Tables["Padi_Beras"];
                //Menyimpan data kedalam database
                dr = dt.NewRow();
                dr[0] = IDpb.Text;
                dr[1] = jenis.Text;
                dr[2] = jumlah.Text;
                dr[3] = harga.Text;
                dt.Rows.Add(dr);
            }
            else
            {
                dt = penjualanPadiBerasDataSet.Tables["Padi_Beras"];
                //mencari primary key yang akan diubah datanya
                dr = dt.Rows.Find(IDpb.Text);

                //Mengubah data Kedalam database
                dr.BeginEdit();
                dr["ID_p_b"] = IDpb.Text;
                dr["Jenis_p_b"] = jenis.Text;
                dr["Jumlah_p_b"] = jumlah.Text;
                dr["Harga"] = harga.Text;
                dr.EndEdit();
            }

            padi_BerasTableAdapter.Update(penjualanPadiBerasDataSet);
            IDpb.Enabled = false;
            jenis.Enabled = false;
            jumlah.Enabled = false;
            harga.Enabled = false;

            this.padi_BerasTableAdapter.Fill(this.penjualanPadiBerasDataSet.Padi_Beras);
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
            code = IDpb.Text;
            //mencari data yang akan dihapus berdasarkan primarykey
            dr = penjualanPadiBerasDataSet.Tables["Padi_Beras"].Rows.Find(code);
            //Menghapus Data
            dr.Delete();
            padi_BerasTableAdapter.Update(penjualanPadiBerasDataSet);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            IDpb.Enabled = false;
            jenis.Enabled = false;
            jumlah.Enabled = false;
            harga.Enabled = false;

            this.padi_BerasTableAdapter.Fill(this.penjualanPadiBerasDataSet.Padi_Beras);
            button_add.Enabled = true;
            button_edit.Enabled = true;
            button_delete.Enabled = true;
            button_save.Enabled = false;
            button_cancel.Enabled = false;
        }
    }
}
