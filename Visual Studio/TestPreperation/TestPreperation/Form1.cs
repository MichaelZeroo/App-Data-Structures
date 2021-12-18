using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPreperation
{
    public partial class Form1 : Form
    {
        StudentDataStructure data = new StudentDataStructure();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(iDTextBox.Text);
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string gender = genderTextBox.Text;
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;

            Student st = new Student()
            {
                ID = id,
                Name = name,
                Address = address,
                Gender = gender,
                Phone = phone,
                Email = email

            };
            data.addStudent(st);

            MessageBox.Show("Student data added successfully");

            nameTextBox.Clear();
            iDTextBox.Clear();
            addressTextBox.Clear();
            genderTextBox.Clear();
            phoneTextBox.Clear();
            emailTextBox.Clear();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(sidTextbox.Text);
            Student st = data.searchStudent(id);

            if(st == null)
            {
                MessageBox.Show("Enter correct information");
            }
            else
            {
                List<Student> students = new List<Student>();
                students.Add(st);
                studentDataGridView.DataSource = students;
            }
        }
    }
}
