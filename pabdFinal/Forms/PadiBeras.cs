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
    public partial class PadiBeras : Form
    {
        DataTable dt;
        DataRow dr;
        int bttn;
        string strKoneksi = "Data Source = LAPTOP-E2NL0H6I\\MIFTAHUL_HUDA; " +
            "Initial Catalog = penjualanPadiBeras; " +
            "Integrated Security = True; MultipleActiveResultSets=true";
        public PadiBeras()
        {
            InitializeComponent();
            this.jenis.LostFocus += new System.EventHandler(this.jenis_LostFocus);
        }

        private void PadiBeras_Load(object sender, EventArgs e)
        {
            IDpb.TextChanged += new EventHandler(IDpb_TextChanged);

            IDpb.Enabled = true;
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
            IDpb.Enabled = false;
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
            if (bttn == 1) // Mode tambah
            {
                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    connection.Open();
                    string str = "INSERT INTO Padi_Beras (ID_p_b, Jenis_p_b, Jumlah_p_b, Harga) " +
                                 "VALUES (@id, @jenispb, @jumlahpb, @hrg)";

                    using (SqlCommand cm = new SqlCommand(str, connection))
                    {
                        cm.CommandType = CommandType.Text;

                        cm.Parameters.AddWithValue("@id", IDpb.Text);
                        cm.Parameters.AddWithValue("@jenispb", jenis.Text);
                        cm.Parameters.AddWithValue("@jumlahpb", jumlah.Text);
                        cm.Parameters.AddWithValue("@hrg", harga.Text);

                        cm.ExecuteNonQuery();
                    }
                }
            }
            else if (bttn == 2) // Mode edit
            {
                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    connection.Open();
                    string str = "UPDATE Padi_Beras SET Jenis_p_b =  @jenispb, Jumlah_p_b = @jumlahpb ,Harga = @hrg " +
                                 "WHERE ID_p_b = @id;";

                    using (SqlCommand cm = new SqlCommand(str, connection))
                    {
                        cm.CommandType = CommandType.Text;

                        cm.Parameters.AddWithValue("@id", IDpb.Text);
                        cm.Parameters.AddWithValue("@jenispb", jenis.Text);
                        cm.Parameters.AddWithValue("@jumlahpb", jumlah.Text);
                        cm.Parameters.AddWithValue("@hrg", harga.Text);

                        cm.ExecuteNonQuery();
                    }
                }
            }

           
            IDpb.Enabled = true;
            jenis.Enabled = false;
            jumlah.Enabled = false;
            harga.Enabled = false;

            
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
            string code = IDpb.Text;
            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                connection.Open();
                string str = "DELETE FROM Padi_Beras WHERE ID_p_b = @id";

                using (SqlCommand cm = new SqlCommand(str, connection))
                {
                    cm.CommandType = CommandType.Text;
                    cm.Parameters.AddWithValue("@id", code);
                    cm.ExecuteNonQuery();
                }
            }
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

        //validasi
        private void jenis_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(jenis.Text))
            {
                MessageBox.Show(this, "jenis  padi/beras boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                jenis.Focus(); // Fokus kembali ke namabox untuk pengisian ulang
            }
        }

        private void IDpb_TextChanged(object sender, EventArgs e)
        {

            if (IDpb.Text.Length > 0)
            {
                string sql = "SELECT * FROM Padi_Beras WHERE ID_p_b = @id";

                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@id", IDpb.Text);

                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    jenis.Text = dr["Jenis_p_b"].ToString();
                                    jumlah.Text = dr["Jumlah_p_b"].ToString();
                                    harga.Text = dr["Harga"].ToString();
                                }
                                else
                                {
                                    ClearFields(); // Mengosongkan field jika data tidak ditemukan
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                ClearFields(); // Mengosongkan field jika IDsdbox kosong
            }
        }
        private void ClearFields()
        {
            jenis.Text = "";
            jumlah.Text = "";
            harga.Text = "";
        }
    }
}
