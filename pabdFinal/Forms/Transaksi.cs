using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace pabdFinal.Forms
{
    public partial class Transaksi : Form
    {
        DataTable dt;
        DataRow dr;
        int bttn;
        Image curImage;
        string curFileName;
        string strKoneksi = "Data Source = LAPTOP-E2NL0H6I\\MIFTAHUL_HUDA; " +
            "Initial Catalog = penjualanPadiBeras; " +
            "Integrated Security = True; MultipleActiveResultSets=true";

        public Transaksi()
        {
            InitializeComponent();
            this.jumlahkg.LostFocus += new System.EventHandler(this.jumlahkg_LostFocus);
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            IDtr.TextChanged += new EventHandler(IDtr_TextChanged);

            IDtr.Enabled = true;
            jumlahkg.Enabled = false;
            totaltr.Enabled = false;
            idpb.Enabled = false;
            idsd.Enabled = false;
            invcpath.Enabled = false;

            Uploadbttn.Enabled = false;
            button_save.Enabled = false;
            button_cancel.Enabled = false;

            SqlConnection connection = new SqlConnection(strKoneksi);
            connection.Open();
            string query = "SELECT * FROM Suplier_Distributor";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            string query1 = "SELECT * FROM Padi_Beras";
            SqlCommand cmd1 = new SqlCommand(query1, connection);
            cmd1.CommandType = CommandType.Text;
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);

            dataGridView2.DataSource = dataTable1;

            connection.Close();
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
            Uploadbttn.Enabled = true;
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
            Uploadbttn.Enabled = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (bttn == 1)
            {
                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    connection.Open();

                    if (int.TryParse(jumlahkg.Text, out int jumlahBerat) &&
                        decimal.TryParse(GetHarga(idpb.Text), out decimal harga))
                    {
                        string bKT = invcpath.Text;
                        string exd = Path.GetExtension(bKT);
                        string pth = @"D:\_pabd\invoice\";
                        string BBayar = pth + IDtr.Text + "_BuktiBayar_" + exd;
                        decimal totalTransaksi = jumlahBerat * harga;

                        string query = "INSERT INTO Transaksi (Jumlah_Berat, Total_Transaksi, ID_p_b, ID_s_d, Invoice) " +
                                       "VALUES (@JumlahBerat, @TotalTransaksi, @IDpb, @IDsid, @Invoice)";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@JumlahBerat", jumlahBerat);
                            cmd.Parameters.AddWithValue("@TotalTransaksi", totalTransaksi);
                            cmd.Parameters.AddWithValue("@IDpb", idpb.Text);
                            cmd.Parameters.AddWithValue("@IDsid", idsd.Text);
                            cmd.Parameters.AddWithValue("@Invoice", BBayar);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Jumlah Berat harus berupa angka dan ID p_b harus valid.");
                        return;
                    }
                }
            }
            else if (bttn == 2)
            {
                if (dr != null)
                {
                    using (SqlConnection connection = new SqlConnection(strKoneksi))
                    {
                        connection.Open();

                        if (int.TryParse(jumlahkg.Text, out int jumlahBerat) &&
                            decimal.TryParse(GetHarga(idpb.Text), out decimal harga))
                        {
                            string bKT = invcpath.Text;
                            string exd = Path.GetExtension(bKT);
                            string pth = @"D:\_pabd\invoice\";
                            string BBayar = pth + IDtr.Text + "_BuktiBayar_" + exd;
                            decimal totalTransaksi = jumlahBerat * harga;

                            string query = "INSERT INTO Transaksi (Jumlah_Berat, Total_Transaksi, ID_p_b, ID_s_d, Invoice) " +
                                           "VALUES (@JumlahBerat, @TotalTransaksi, @IDpb, @IDsid, @Invoice)";

                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@JumlahBerat", jumlahBerat);
                                cmd.Parameters.AddWithValue("@TotalTransaksi", totalTransaksi);
                                cmd.Parameters.AddWithValue("@IDpb", idpb.Text);
                                cmd.Parameters.AddWithValue("@IDsid", idsd.Text);
                                cmd.Parameters.AddWithValue("@Invoice", BBayar);

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Jumlah Berat harus berupa angka dan ID p_b harus valid.");
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Data dengan ID Transaksi tersebut tidak ditemukan.");
                    return;
                }
            }

            IDtr.Enabled = false;
            jumlahkg.Enabled = false;
            totaltr.Enabled = false;
            idpb.Enabled = false;
            idsd.Enabled = false;

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
            dr = penjualanPadiBerasDataSet3.Tables["Transaksi"].Rows.Find(code);
            // Menghapus Data
            dr.Delete();
            transaksiTableAdapter1.Update(penjualanPadiBerasDataSet3);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            IDtr.Enabled = false;
            jumlahkg.Enabled = false;
            totaltr.Enabled = false;
            idpb.Enabled = false;
            idsd.Enabled = false;

            this.transaksiTableAdapter1.Fill(this.penjualanPadiBerasDataSet3.Transaksi);
            button_add.Enabled = true;
            button_edit.Enabled = true;
            button_delete.Enabled = true;
            button_save.Enabled = false;
            button_cancel.Enabled = false;
        }

        //validasi
        private void jumlahkg_LostFocus(object sender, EventArgs e)
        {
            int jumlahBerat;
            if (!int.TryParse(jumlahkg.Text, out jumlahBerat))
            {
                MessageBox.Show(this, "Jumlah berat harus berupa angka atau tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                jumlahkg.Focus(); // Fokus kembali ke barang_jumlahbrt untuk pengisian ulang
            }
        }

        private void IDtr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Uploadbttn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                if (invcpath.Text == null)
                {
                    invcpath.Text = dlg.FileName;
                }
                else
                {
                    invcpath.Clear();
                    invcpath.Text = dlg.FileName;
                }
            }
        }
    }
}
