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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K7S62OP5;Initial Catalog=DB_Tanaman;TrustServerCertificate=True;Integrated Security=True;");
            SqlCommand cnn = new SqlCommand("SELECT * FROM Tanaman", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K7S62OP5;Initial Catalog=DB_Tanaman;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("INSERT INTO Tanaman (JenisTanaman, MerekTanaman, KualitasTanaman) VALUES (@JenisTanaman, @MerekTanaman, @KualitasTanaman)", con);
            cnn.Parameters.AddWithValue("@JenisTanaman", textBox1.Text);
            cnn.Parameters.AddWithValue("@MerekTanaman", textBox2.Text);
            cnn.Parameters.AddWithValue("@KualitasTanaman", textBox3.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil disimpan!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K7S62OP5;InitialCatalog=DB_Tanaman;TrustServerCertificate=True;IntegratedSecurity=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("DELETE FROM Tanaman WHERE JenisTanaman = @JenisTanaman", con);
            cnn.Parameters.AddWithValue("@JenisTanaman", textBox1.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil dihapus!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K7S62OP5;InitialCatalog=DB_Tanaman;TrustServerCertificate=True;IntegratedSecurity=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("UPDATE Tanaman SET MerekTanaman = @MerekTanaman, KualitasTanaman = @KualitasTanaman WHERE JenisTanaman = @JenisTanaman", con);
            cnn.Parameters.AddWithValue("@JenisTanaman", textBox1.Text);
            cnn.Parameters.AddWithValue("@MerekTanaman", textBox2.Text);
            cnn.Parameters.AddWithValue("@KualitasTanaman", textBox3.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil diupdate!");
        }
    }
}
