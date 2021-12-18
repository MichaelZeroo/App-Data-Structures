using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetDemo
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Marks { get; set; }

        public override string ToString()
        {
            return "ID: " + ID + ", Name: " + Name + ", Address: " + Address;
        }

        public override bool Equals(object obj)
        {

            if (Convert.IsDBNull(obj))
            {
                return false;
            }
            else
            {
                Student s = (Student)obj;
                if (s.ID == ID)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
