using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐACNPM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //textBox3.Text = textBox3.AutoCompleteCustomSource[0];
            cbb_ngay.SelectedIndex = 17;
            cbb_thang.SelectedIndex = 2;
            
            for(int i=2020;i>=1905;i--)
            {
                cbb_nam.Items.Add(i);
            }
            cbb_nam.SelectedIndex = 21;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
