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
    public partial class Suplier : Form
    {
        DataTable dt;
        DataRow dr;
        int bttn;
        public Suplier()
        {
            InitializeComponent();
        }

        private void Suplier_Load(object sender, EventArgs e)
        {
                // TODO: This line of code loads data into the 'penjualanPadiBerasDataSet.Suplier_Distributor' table. You can move, or remove it, as needed.
                this.suplier_DistributorTableAdapter.Fill(this.penjualanPadiBerasDataSet.Suplier_Distributor);

            IDsdbox.Enabled =  false;
            namabox.Enabled = false;
            almtbox.Enabled = false;
            tlpbox.Enabled = false;

            button_save.Enabled = false;
            button_cancel.Enabled = false;
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            bttn = 2;

            button_save.Enabled = true;
            IDsdbox.Enabled = true;
            namabox.Enabled = true;
            almtbox.Enabled = true;
            tlpbox.Enabled = true;

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

        public void tambah () 
        {


            button_save.Enabled = true;
            IDsdbox.Enabled = true;
            namabox.Enabled = true;
            almtbox.Enabled = true;
            tlpbox.Enabled = true;

            IDsdbox.Text = "";
            namabox.Text = "";
            almtbox.Text = "";
            tlpbox.Text = "";

            button_add.Enabled = false;
            button_delete.Enabled = false;
            button_edit.Enabled = false;
            button_cancel.Enabled = true;

          
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (bttn == 1)
            {
                dt = penjualanPadiBerasDataSet.Tables["Suplier_Distributor"];
                //Menyimpan data kedalam database
                dr = dt.NewRow();
                dr[0] = IDsdbox.Text;
                dr[1] = namabox.Text;
                dr[2] = almtbox.Text;
                dr[3] = tlpbox.Text;
                dt.Rows.Add(dr);
            }
            else
            {
                dt = penjualanPadiBerasDataSet.Tables["Suplier_Distributor"];
                //mencari primary key yang akan diubah datanya
                dr = dt.Rows.Find(IDsdbox.Text);

                //Mengubah data Kedalam database
                dr.BeginEdit();
                dr["ID_s_d"] = IDsdbox.Text;
                dr["Nama_Suplier"] = namabox.Text;
                dr["Alamat"] = almtbox.Text;
                dr["No_Telpon"] = tlpbox.Text;
                dr.EndEdit();
            }

            suplier_DistributorTableAdapter.Update(penjualanPadiBerasDataSet);
            IDsdbox.Text = System.Convert.ToString(dr[0]);
            IDsdbox.Enabled = false;
            namabox.Enabled = false;
            almtbox.Enabled = false;
            tlpbox.Enabled = false;

            this.suplier_DistributorTableAdapter.Fill(this.penjualanPadiBerasDataSet.Suplier_Distributor);
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
            code = IDsdbox.Text;
            //mencari data yang akan dihapus berdasarkan primarykey
            dr = penjualanPadiBerasDataSet.Tables["Suplier_Distributor"].Rows.Find(code);
            //Menghapus Data
            dr.Delete();
            suplier_DistributorTableAdapter.Update(penjualanPadiBerasDataSet);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            IDsdbox.Enabled = false;
            namabox.Enabled = false;
            almtbox.Enabled = false;
            tlpbox.Enabled = false;

            this.suplier_DistributorTableAdapter.Fill(this.penjualanPadiBerasDataSet.Suplier_Distributor);
            button_add.Enabled = true;
            button_edit.Enabled = true;
            button_delete.Enabled = true;
            button_save.Enabled = false;
            button_cancel.Enabled = false;
        }
    }
}
