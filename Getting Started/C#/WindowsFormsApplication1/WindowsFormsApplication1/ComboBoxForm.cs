using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ComboBoxForm : Form
    {
        List<string> values = new List<string>(){"First","Second","Third"};
        int index;
        public ComboBoxForm()
        {
            InitializeComponent();
        }

        private void ComboBoxForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = values;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            values.Add(textBox1.Text);
            ReloadComboBox();
        }

        private void ReloadComboBox()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = values;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
            
            index = comboBox1.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // get the item which is selected
            
            // replace the selected item with the new text
            values[index] = textBox1.Text;
            ReloadComboBox();
        }
    }
}
