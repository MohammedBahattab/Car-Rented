using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rented
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Car Rented.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Form add_Form = new Add_Form();
            add_Form.Show();
        }
    }
}
