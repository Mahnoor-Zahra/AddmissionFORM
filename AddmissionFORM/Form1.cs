using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddmissionFORM
{
    public partial class Form1 : Form
    {
        DataTable data = new DataTable();
        public Form1()
        {
            InitializeComponent();
            data.Columns.Add("Surname");
            data.Columns.Add("Name");
            data.Columns.Add("Fathername");
            data.Columns.Add("Email");
            data.Columns.Add("gender");
            data.Columns.Add("Language");
            data.Columns.Add("Country");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row1 = data.NewRow();
            row1["Surname"] = textBox1.Text;
            row1["Name"] = textBox2.Text;
            row1["Fathername"] = textBox3.Text;
            row1["Email"] = textBox4.Text;
            row1["gender"] = radioButton1.Checked;
            row1["Language"] = checkBox1.Checked;
            row1["Country"] = comboBox1.SelectedItem;
            data.Rows.Add(row1);
            dataGridView1.DataSource = data;




        }
    }
}
