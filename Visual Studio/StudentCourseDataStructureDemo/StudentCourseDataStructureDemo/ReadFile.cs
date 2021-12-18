using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace StudentCourseDataStructureDemo
{
    class ReadFile
    {

       static public  List<Student> students = new List<Student>();

        public List<Student> readStudent()
        {
            StreamReader reader = new StreamReader("data.txt");
            string line = "";
            while (  (line = reader.ReadLine()  ) != null)
            {
                string[] words = line.Split(',');
                Student st = new Student();
                st.ID = int.Parse(words[0]);
                st.Name = words[1];
                st.Address = words[2];
                st.Gender = words[3];
                st.Course = words[4];
                //save student object to list 
                students.Add(st);
            }
            return students;
            
        }

        public List<Student> groupBySoftwareTestingCourse()
        {
            List<Student> data = new List<Student>();


            foreach (Student st in students)
            {
                string course = st.Course.ToLower();
                if (st.Course.Equals("Software Testing"))
                {
                    data.Add(st);
                }
            }
            return data;
        }

        public List<Student> groupByAppliedDataStructureCourse()
        {
            List<Student> data = new List<Student>();
            foreach (Student st in students)
            {
                if (st.Course.Equals("Applied Data Structure"))
                {
                    data.Add(st);
                }
            }
            return data;
        }

        public List<Student> groupByProfessionalPracticeCourse()
        {
            List<Student> data = new List<Student>();
            foreach (Student st in students)
            {
                if (st.Course.Equals("Professional Practice"))
                {
                    data.Add(st);
                }
            }
            return data;
        }

        public List<Student> groupByIntroductionToDatabaseCourse()
        {
            List<Student> data = new List<Student>();
            foreach (Student st in students)
            {
                if (st.Course.Equals("Introduction to Database"))
                {
                    data.Add(st);
                }
            }
            return data;
        }

        public List<Student> groupByDatabaseApplicationDevelopmentCourse()
        {
            List<Student> data = new List<Student>();
            foreach (Student st in students)
            {
                if (st.Course.Equals("Database Application Developement"))
                {
                    data.Add(st);
                }
            }
            return data;
        }
    }
}
