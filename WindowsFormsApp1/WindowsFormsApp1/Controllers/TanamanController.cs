using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers
{
    internal class TanamanController
    {
        public void InsertTanaman(string jenis, string merek, string kualitas)
        {
            TanamanRepository.InsertTanaman(jenis, merek, kualitas);
        }

        public void UpdateTanaman(string jenis, string merek, string kualitas)
        {
            TanamanRepository.UpdateTanaman(jenis, merek, kualitas);
        }

        public void DeleteTanaman(string jenis)
        {
            TanamanRepository.DeleteTanaman(jenis);
        }

        public DataTable GetAllTanaman()
        {
            return TanamanRepository.GetAllTanaman();
        }
    }
}
