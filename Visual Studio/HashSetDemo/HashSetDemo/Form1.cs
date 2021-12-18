using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashSetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HashSet<Student> students = new HashSet<Student>();

            Student s1 = new Student()
            {
                ID = 1,
            Name = "Louis",
            Address = "GayLand",
                Marks = 50
            };
            Student s2 = new Student()
            {
                ID = 2,
                Name = "Louis",
                Address = "GayLand",
                Marks = 50
            };
            Student s3 = new Student()
            {
                ID = 3,
                Name = "Louis",
                Address = "GayLand",
                Marks = 50
            };

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);


            listBox1.DataSource = students.ToList();
        }
    }
}
