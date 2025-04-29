using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rented
{
    public partial class Add_Form : Form
    {
        string connectionString;
        public Add_Form()
        {
            InitializeComponent();
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Car Rented.mdf");
             connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True";
            LoadTop5Cars();
        }
        string query = "SELECT Car_Name,  Car_Company,  Car_Year,  Car_Color,  Car_Pleat  FROM Cars";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Form_Load(object sender, EventArgs e)
        {
            LoadTop5Cars();
        }
        private void LoadTop5Cars()
        {
           

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                   
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "Cars");

                    // ربط البيانات بـ DataGridView
                    dataGridView1.DataSource = dataSet.Tables["Cars"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل البيانات: " + ex.Message);
            }
        }
    }
}
