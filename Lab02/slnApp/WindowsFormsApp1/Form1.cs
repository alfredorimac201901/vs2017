using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chinook.Data;
using Chinook.Entities;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvlistado.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            var da = new ArtistDA();
            var model = da.GetsWithParam($"{textBox1.Text.Trim()}%");
            dgvlistado.DataSource = model;
            dgvlistado.Refresh();
        }

        private void dgvlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
