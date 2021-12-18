using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentMichaelSingh.Model;
using System.IO;

namespace AssignmentMichaelSingh
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadDataFile readDataFile = new ReadDataFile();

            RDFListbox.DataSource = readDataFile.getAllBooks().ToList();
        }

        private void RDFListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RDFListbox.HorizontalScrollbar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessBooksData processBooks = new ProcessBooksData();

            MathematicsListbox.DataSource = processBooks.mathematicsCategory();
            SoftwareDevelopmentListbox.DataSource = processBooks.softwareDevelopmentCategory();
            NetworkingListbox.DataSource = processBooks.networkingCategory();
            ComputerScienceListbox.DataSource = processBooks.computerScienceCategory();

        }

        private void ComputerScienceListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComputerScienceListbox.HorizontalScrollbar = true;
        }

        private void NetworkingListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NetworkingListbox.HorizontalScrollbar = true;
        }

        private void MathematicsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MathematicsListbox.HorizontalScrollbar = true;
        }

        private void SoftwareDevelopmentListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoftwareDevelopmentListbox.HorizontalScrollbar = true;
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            SaveData save = new SaveData();
            save.save();
            MessageBox.Show("Information has successfully saved to database");
            
        }
        
    }
}
