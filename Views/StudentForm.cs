using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagement_Project.Views
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
                // Setup DataGridView
                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "Name";
                dataGridView1.Columns[1].Name = "Course Name";

                 // Load course list into comboBox1
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox3_TextChanged(object sender, EventArgs e)
            {

            }

            private void ManageStudent_Load(object sender, EventArgs e)
            {

            }

        
        private void StudentForm_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
