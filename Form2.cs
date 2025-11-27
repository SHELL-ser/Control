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
    public partial class Form2 : Form
    {
        Student s = new Student();
        public Form2(Student student)
        {
            InitializeComponent();
            this.s = student;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.ball = 0;
            if (radioButton3.Checked == true) s.ball = 1;
            Form3 f = new Form3(s);
            f.ShowDialog();
            this.Hide();
        }
    }
}
