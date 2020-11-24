using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new pubsEntities();

            var employee = context.employees.Where(i => i.hire_date.Year > 1991).ToList();

            dataGridView1.DataSource = employee;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var context = new pubsEntities();

            var words = context.authors.Where(a => a.city == "Oakland").ToList();

            dataGridView1.DataSource = words;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var context = new pubsEntities();

            var state = context.authors.Where(a => a.state == "UT").ToList();

            dataGridView1.DataSource = state;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var context = new pubsEntities();

            var pd = context.sales.Where(a => a.ord_date.Year == 1993 & a.payterms == "Net 30").ToList();

            dataGridView1.DataSource = pd;
        }
    }
}
