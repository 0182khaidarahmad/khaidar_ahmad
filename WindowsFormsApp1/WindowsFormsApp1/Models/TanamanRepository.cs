using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class TanamanRepository
    {
        public static void InsertTanaman(string jenis, string merek, string kualitas)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Tanaman (JenisTanaman, MerekTanaman, KualitasTanaman) VALUES (@Jenis, @Merek, @Kualitas)", con);
                cmd.Parameters.AddWithValue("@Jenis", jenis);
                cmd.Parameters.AddWithValue("@Merek", merek);
                cmd.Parameters.AddWithValue("@Kualitas", kualitas);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateTanaman(string jenis, string merek, string kualitas)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Tanaman SET MerekTanaman = @Merek, KualitasTanaman = @Kualitas WHERE JenisTanaman = @Jenis", con);
                cmd.Parameters.AddWithValue("@Jenis", jenis);
                cmd.Parameters.AddWithValue("@Merek", merek);
                cmd.Parameters.AddWithValue("@Kualitas", kualitas);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteTanaman(string jenis)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Tanaman WHERE JenisTanaman = @Jenis", con);
                cmd.Parameters.AddWithValue("@Jenis", jenis);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAllTanaman()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tanaman", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}