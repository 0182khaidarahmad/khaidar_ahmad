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
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly TanamanController _controller;
        public Form1()
        {
            InitializeComponent();
            _controller = new TanamanController();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _controller.GetAllTanaman();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.InsertTanaman(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show("Data berhasil disimpan!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _controller.DeleteTanaman(textBox1.Text);
            MessageBox.Show("Data berhasil dihapus!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _controller.UpdateTanaman(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show("Data berhasil diupdate!");
        }
    }
}
