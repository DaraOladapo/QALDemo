using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.DoubleClick += Button2_DoubleClick;
            button2.MouseDoubleClick += Button2_MouseDoubleClick;
        }

        private void Button2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hello there. This button was double clicked.");
        }

        private void Button2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hello there. This button was double clicked.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello there");
        }
    }
}
