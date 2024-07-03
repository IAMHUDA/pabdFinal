using System.Data;
using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;
using ExcelDataReader;


namespace pabdFinal.Forms
{
    public partial class Suplier : Form
    {
        DataTable dt;
        DataRow dr;
        int bttn;

        string strKoneksi = "Data Source = LAPTOP-E2NL0H6I\\MIFTAHUL_HUDA; " +
            "Initial Catalog = penjualanPadiBeras; " +
            "Integrated Security = True; MultipleActiveResultSets=true";

        public Suplier()
        {
            InitializeComponent();
            this.namabox.LostFocus += new System.EventHandler(this.namabox_LostFocus);
        }

        private void Suplier_Load(object sender, EventArgs e)
        {
            IDsdbox.TextChanged += new EventHandler(IDsdbox_TextChanged);

            IDsdbox.Enabled = true;
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
            IDsdbox.Enabled = false; // Disable IDsdbox saat edit untuk mencegah perubahan ID
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

        public void tambah()
        {
            IDsdbox.Enabled = true;
            namabox.Enabled = true;
            almtbox.Enabled = true;
            tlpbox.Enabled = true;

            IDsdbox.Text = "";
            namabox.Text = "";
            almtbox.Text = "";
            tlpbox.Text = "";

            button_save.Enabled = true;
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
                    string str = "INSERT INTO Suplier_Distributor (ID_s_d, Nama_Suplier, Alamat, No_Telpon) " +
                                 "VALUES (@id, @nm, @almt, @nt)";

                    using (SqlCommand cm = new SqlCommand(str, connection))
                    {
                        cm.CommandType = CommandType.Text;

                        cm.Parameters.AddWithValue("@id", IDsdbox.Text);
                        cm.Parameters.AddWithValue("@nm", namabox.Text);
                        cm.Parameters.AddWithValue("@almt", almtbox.Text);
                        cm.Parameters.AddWithValue("@nt", tlpbox.Text);

                        cm.ExecuteNonQuery();
                    }
                }
            }
            else if (bttn == 2) // Mode edit
            {
                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    connection.Open();
                    string str = "UPDATE Suplier_Distributor SET Nama_Suplier = @nm, Alamat = @almt, No_Telpon = @nt " +
                                 "WHERE ID_s_d = @id";

                    using (SqlCommand cm = new SqlCommand(str, connection))
                    {
                        cm.CommandType = CommandType.Text;

                        cm.Parameters.AddWithValue("@id", IDsdbox.Text);
                        cm.Parameters.AddWithValue("@nm", namabox.Text);
                        cm.Parameters.AddWithValue("@almt", almtbox.Text);
                        cm.Parameters.AddWithValue("@nt", tlpbox.Text);

                        cm.ExecuteNonQuery();
                    }
                }
            }

            // Disable kontrol setelah penyimpanan/selesai
            IDsdbox.Enabled = true;
            namabox.Enabled = false;
            almtbox.Enabled = false;
            tlpbox.Enabled = false;

            // Enable tombol yang sesuai
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
                "Konfirmasi Hapus Data",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                hapus();
            }
        }

        public void hapus()
        {
            string code = IDsdbox.Text;
            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                connection.Open();
                string str = "DELETE FROM Suplier_Distributor WHERE ID_s_d = @id";

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
            // Disable kontrol saat pembatalan
            IDsdbox.Enabled = true;
            namabox.Enabled = false;
            almtbox.Enabled = false;
            tlpbox.Enabled = false;

            // Enable tombol yang sesuai
            button_add.Enabled = true;
            button_edit.Enabled = true;
            button_delete.Enabled = true;
            button_save.Enabled = false;
            button_cancel.Enabled = false;
        }
        private void ImprtBttn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });

                            DataTable dataTable = result.Tables[0];


                            using (SqlConnection conn = new SqlConnection(strKoneksi))
                            {
                                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                                {
                                    bulkCopy.DestinationTableName = "dbo.Suplier_Distributor";
                                    conn.Open();
                                    bulkCopy.WriteToServer(dataTable);
                                    MessageBox.Show("Data Unported and displayed succesfully.");
                                }
                            }
                        }
                    }
                }
            }
        }

        //search
        private void IDsdbox_TextChanged(object sender, EventArgs e)
        {
            if (IDsdbox.Text.Length > 0)
            {
                string sql = "SELECT * FROM Suplier_Distributor WHERE ID_s_d = @id";

                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@id", IDsdbox.Text);

                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    namabox.Text = dr["Nama_Suplier"].ToString();
                                    almtbox.Text = dr["Alamat"].ToString();
                                    tlpbox.Text = dr["No_Telpon"].ToString();
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
            namabox.Text = "";
            almtbox.Text = "";
            tlpbox.Text = "";
        }


        private void namabox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namabox.Text))
            {
                MessageBox.Show(this, "Nama tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                namabox.Focus(); // Fokus kembali ke namabox untuk pengisian ulang
            }
        }


        /*private void  almtbox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(almtbox.Text))
            {
                MessageBox.Show(this, "alamat tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                almtbox.Focus(); // Fokus kembali ke namabox untuk pengisian ulang
            }
        }*/

        /*private void tlpbox_LostFocus(object sender, EventArgs e)
        {
            int nomertlp;
            if (!int.TryParse(tlpbox.Text, out nomertlp))
            {
                MessageBox.Show(this, "no telp harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tlpbox.Focus(); // Fokus kembali ke namabox untuk pengisian ulang
            }
        }*/
    }
}
