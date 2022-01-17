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
    public partial class EditForm : Form
    {
        public int Id { get { return (int)numericUpDown_Id.Value; } }
        public string FullName { get { return textBox1.Text; } }
        public int Year { get { return (int)numericUpDown_Year.Value; } }
        public string Address { get { return textBox2.Text; } }

        public EditForm(int Id, string name, int year, string address)
        {
            InitializeComponent();

            numericUpDown_Id.Value = Id;
            numericUpDown_Year.Value = year;
            textBox1.Text = name;
            textBox2.Text = address;
        }
    }
}
