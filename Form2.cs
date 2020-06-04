using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txt1.ForeColor = Color.Gray;
            txt1.Text = "Please Enter Name";
            this.txt1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.txt1.Enter += new System.EventHandler(this.textBox1_Enter);

            txt2.ForeColor = Color.Gray;
            txt2.Text = "Please Enter Address";
            this.txt2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.txt2.Enter += new System.EventHandler(this.textBox2_Enter);
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                txt1.Text = "Please Enter Name";
                txt1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txt1.Text == "Please Enter Name")
            {
                txt1.Text = "";
                txt1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txt2.Text == "Please Enter Address")
            {
                txt2.Text = "";
                txt2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txt2.Text == "")
            {
                txt2.Text = "Please Enter Address";
                txt2.ForeColor = Color.Gray;
            }
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            txt1.ForeColor = Color.Gray;
            txt1.Text = "Please Enter Name";
            this.txt1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.txt1.Enter += new System.EventHandler(this.textBox1_Enter);

            txt2.ForeColor = Color.Gray;
            txt2.Text = "Please Enter Address";
            this.txt2.Leave += new System.EventHandler(this.textBox2_Leave);
            //this.txt2.MouseLeave += new System.EventHandler(this.textBox1_Leave);
            this.txt2.Enter += new System.EventHandler(this.textBox2_Enter);
        }
    }
}
