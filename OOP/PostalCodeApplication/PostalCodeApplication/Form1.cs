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

        private void Form1_Load(object sender, EventArgs e)
        {
            // read from notepad
            StreamReader reader = new StreamReader("postal codes.txt");
            string line = reader.ReadLine();
            List<PostalCode> postalCodes = new List<PostalCode>();
           
            while (line!=null)
            {
                string[] strings = line.Split(new[] { '\t' });
                PostalCode p1 = new PostalCode();
                p1.District = strings[0];
                p1.PoliceStation = strings[1];
                p1.SubOffice = strings[2];
                p1.PostCode = strings[3];
                postalCodes.Add(p1);
                line = reader.ReadLine();
            }
 
            dataGridView1.DataSource = postalCodes;
            // show in gridview
        }
    }
}
