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
using System.Windows.Forms.DataVisualization.Charting;

namespace pabdFinal.Forms
{
    public partial class home : Form
    {
        string strKoneksi = "Data Source = LAPTOP-E2NL0H6I\\MIFTAHUL_HUDA; " +
            "Initial Catalog = penjualanPadiBeras; " +
            "Integrated Security = True; MultipleActiveResultSets=true";
        public home()
        {
            InitializeComponent();
            display();
        }

        private void display()
        {
            string strKoneksi = "Data Source = LAPTOP-E2NL0H6I\\MIFTAHUL_HUDA; " +
                                "Initial Catalog = penjualanPadiBeras; " +
                                "Integrated Security = True; MultipleActiveResultSets=true";

            string query = "SELECT TOP (1000) [ID_p_b], [Jenis_p_b], [Jumlah_p_b], [Harga] " +
                           "FROM [penjualanPadiBeras].[dbo].[Padi_Beras]";

            SqlConnection connection = new SqlConnection(strKoneksi);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr;

            try
            {
                connection.Open();
                dr = cmd.ExecuteReader();

                // List untuk menyimpan hasil
                List<string> hasil_arr = new List<string>();
                List<decimal> jumlah_arr = new List<decimal>();

                // Loop untuk membaca hasil dari query
                while (dr.Read())
                {
                    string jenis = dr["Jenis_p_b"].ToString();
                    // Ganti "Padi" dengan "PD" dan "Beras" dengan "BR"
                    if (jenis == "Padi")
                        jenis = "PD";
                    else if (jenis == "Beras")
                        jenis = "BR";

                    hasil_arr.Add(jenis); // Menambahkan jenis yang sudah diganti
                    jumlah_arr.Add(Convert.ToDecimal(dr["Jumlah_p_b"])); // Contoh pengambilan data
                }
                dr.Close();

                // Menampilkan data ke dalam chart (contoh menggunakan chart1)
                chart1.Series.Clear(); // Membersihkan data sebelum menambahkan data baru

                for (int i = 0; i < hasil_arr.Count; i++)
                {
                    chart1.Series.Add(hasil_arr[i]);
                    chart1.Series[i].Points.AddXY(hasil_arr[i], jumlah_arr[i]);
                }

                chart1.ChartAreas[0].AxisX.Interval = 1; // Mengatur interval sumbu X jika diperlukan
                chart1.ChartAreas[0].AxisX.Title = "Jenis Padi Beras"; // Judul sumbu X
                chart1.ChartAreas[0].AxisY.Title = "Jumlah (kg)"; // Judul sumbu Y

                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Menonaktifkan gridlines pada sumbu X
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false; // Menonaktifkan gridlines pada sumbu Y

                chart1.Series[0].ChartType = SeriesChartType.Column; // Menentukan tipe chart (kolom)

                // Menampilkan label nilai pada chart
                foreach (var series in chart1.Series)
                {
                    series.IsValueShownAsLabel = true;
                }

                chart1.Legends[0].Enabled = true; // Menampilkan legend

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
