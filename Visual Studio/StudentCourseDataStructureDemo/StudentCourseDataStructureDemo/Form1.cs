using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentCourseDataStructureDemo.Models;

namespace StudentCourseDataStructureDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadFile file = new ReadFile();
            ReadStudents.DataSource = file.readStudent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadFile file = new ReadFile();

            STListbox.DataSource = file.groupBySoftwareTestingCourse();
            PPListbox.DataSource = file.groupByProfessionalPracticeCourse();
            DADListbox.DataSource = file.groupByDatabaseApplicationDevelopmentCourse();
            IDListbox.DataSource = file.groupByIntroductionToDatabaseCourse();
            ADSListbox.DataSource = file.groupByAppliedDataStructureCourse();
        }
        
        //Button Function which doesnt work. Explained in NotePad file
        /*
        private void button3_Click(object sender, EventArgs e)
        {
            DAD_context ctx = new DAD_Context();
            ReadFile file = new ReadFile();

            foreach (Student st in ReadFile.students)
            {
                Models.Student s = new Models.Student();
                s.id = st.ID;
                s.name = st.Name;
                s.address = st.Address;
                s.gender = st.Gender;

                Models.Course c = new Models.Course();
                c.name = st.Course();

                s.Course = c;
                ctx.Add(s);
            }
            ctx.SaveChanges();
            MessageBox.Show("Data Saved Successfully");
        }
        */
    }
}
