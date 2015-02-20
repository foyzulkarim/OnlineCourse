using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostalCodeApplication
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        List<PostalCode> allPostalCodes = new List<PostalCode>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // read from notepad
            StreamReader reader = new StreamReader("postal codes.txt");
            string line = reader.ReadLine();
         
           
            while (line!=null)
            {
                string[] strings = line.Split(new[] { '\t' });
                PostalCode p1 = new PostalCode();
                p1.District = strings[0];
                p1.PoliceStation = strings[1];
                p1.SubOffice = strings[2];
                p1.PostCode = strings[3];
                allPostalCodes.Add(p1);
                line = reader.ReadLine();
            }
 
            dataGridView1.DataSource = allPostalCodes;
            // show in gridview
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // we want to filter on the main data set
            // get the input into a variable
            string query = textBox1.Text.ToUpper();
            // filter on the data set
            var postalCodes = from code in allPostalCodes
                where
                    code.PoliceStation.ToUpper().Contains(query) || 
                    code.SubOffice.ToUpper().Contains(query) ||
                    code.PostCode.ToUpper().Contains(query)
                select code;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = postalCodes.ToList();
        }
    }
}
