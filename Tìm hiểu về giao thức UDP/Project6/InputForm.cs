using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project6
{
    public partial class InputForm : Form
    {
        public string FullName { get { return textBox1.Text; } }
        public int Year { get { return (int)numericUpDown1.Value; } }
        public string Address { get { return textBox2.Text; } }

        public InputForm()
        {
            InitializeComponent();
        }
    }
}
