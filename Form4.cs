using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public partial class Form4 : Form
    {
        Student s = new Student();
        public Form4(Student student)
        {
            InitializeComponent();
            this.s = student;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) s.ball += 1;

            Form5 f = new Form5(s);
            f.ShowDialog();
            this.Hide();
        }
    }
}
