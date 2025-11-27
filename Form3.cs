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
    public partial class Form3 : Form
    {
        Student s = new Student();
        public Form3(Student student)
        {
            InitializeComponent();
            this.s = student;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) s.ball += 1;
            if (checkBox2.Checked == true) s.ball += 1;
            if (checkBox3.Checked == true) s.ball += 1;

            Form4 f = new Form4(s);
            f.ShowDialog();
        }
    }
}
