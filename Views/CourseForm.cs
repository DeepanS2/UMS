using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagement_Project.Controllers;

namespace UnicomTICManagement_Project.Views
{
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string courseName = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Please enter a course name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = CourseController.AddCourse(courseName); // Replace with your actual class

            if (success)
            {
                MessageBox.Show("Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear(); // Clear the textbox after adding
            }
            else
            {
                MessageBox.Show("Failed to add course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
