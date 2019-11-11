using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string string_to_save = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string_to_save = textBox1.Text;
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();

        }
    }
}
