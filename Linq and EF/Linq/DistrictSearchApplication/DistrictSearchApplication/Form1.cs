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

namespace DistrictSearchApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> districts = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("districts.txt");
           var line = sr.ReadLine();
           while (line != null)
           {
              // add the line into the list
               districts.Add(line);
               //Read the next line
               line = sr.ReadLine();
           }


            listBox1.DataSource = districts;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<string> result = new List<string>();
            //foreach (string district in districts)
            //{
            //    // catch the input of the textbox and store it in a variable
            //    string input = textBox1.Text;

            //    // check the variable with the temporary value of the districts (district)
            //    if (district.StartsWith(input))
            //    {
            //        // add this temporary variable (district) into the result
            //        result.Add(district);
            //    }              
            //}

             //  there should be a plural (list, array, collection ..)
            //  there should be a logic check of boolean ( method, operator check, multiple operator, multiple method)
            //   select appropriate data into a new list

            //  from aVariable in a plural 
            // where theConditionIsTrue
            // select theVariable

             result = (from d in districts
                 where d.StartsWith(textBox1.Text)
                 select d).ToList();


            // reload , re datasource to the listbox
            listBox1.DataSource = null;
            listBox1.DataSource = result;

            label1.Text = result.Count.ToString();
        }
    }
}
