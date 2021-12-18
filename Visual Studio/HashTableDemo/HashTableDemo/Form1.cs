using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HashTableDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<int, Room> rooms = new Dictionary<int, Room>();

            Room room1 = new Room()
            {
                Number = 101,
                Name = "Room 101",
                Floor = "First Floor",
                Size = "small"
            };

            Room room2 = new Room()
            {
                Number = 202,
                Name = "Room 202",
                Floor = "Second Floor",
                Size = "big"
            };

            Room room3 = new Room()
            {
                Number = 303,
                Name = "Room 303",
                Floor = "Third FLoor",
                Size = "medium"
            };

            rooms.Add(room1.Number, room1);
            rooms.Add(room2.Number, room2);
            rooms.Add(room3.Number, room3);

            if (rooms.ContainsKey(303))
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("No");
            }


            listBox1.DataSource = rooms.ToList();

        }
    }
}
