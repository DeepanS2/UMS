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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StafForm stafForm = new StafForm();
            stafForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LectureForm lectureForm = new LectureForm();
            lectureForm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SubjectFrom subjectFrom = new SubjectFrom();
            subjectFrom.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ExamFrom examFrom = new ExamFrom();
            examFrom.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MarksFrom marksFrom = new MarksFrom();
            marksFrom.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TimetableFrom timetableFrom = new TimetableFrom();
            timetableFrom.Show();
        }
    }
}
