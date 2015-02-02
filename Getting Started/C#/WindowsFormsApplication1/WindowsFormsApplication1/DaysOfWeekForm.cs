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
    public partial class DaysOfWeekForm : Form
    {
        public DaysOfWeekForm()
        {
            InitializeComponent();
        }

        private void DaysOfWeekForm_Load(object sender, EventArgs e)
        {
            Type myType = typeof(ComboBoxStyle);
            string[] styles = Enum.GetNames(myType);
            comboBox1.DataSource = styles;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle =
              (ComboBoxStyle)  Enum.Parse(typeof (ComboBoxStyle), comboBox1.SelectedItem.ToString());
        }     
    }
}
