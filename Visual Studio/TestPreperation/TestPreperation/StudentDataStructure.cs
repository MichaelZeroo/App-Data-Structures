using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPreperation
{
    class StudentDataStructure
    {
        private Dictionary<int, Student> students = new Dictionary<int, Student>();

        public void addStudent(Student st)
        {
            students.Add(st.ID, st);
        }

        public Student searchStudent(int sid)
        {
            if (students.ContainsKey(sid))
            {
                return[sid];
            }
            else
            {
                return null;
            }

            
        }

        public void removeStudent(int sid)
        {
            students.Remove(sid);
        }
    }
}
