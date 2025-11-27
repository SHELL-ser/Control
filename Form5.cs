using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public partial class Form5 : Form
    {
        Student s = new Student();
        public Form5(Student student)
        {
            InitializeComponent();
            this.s = student;

            label2.Text = s.name + ", ваша оценка: " + Convert.ToString(s.ball);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("out.txt", true))
            {
                writer.WriteLine(s.name);
                writer.WriteLine(s.ball.ToString());
                writer.WriteLine(s.day.ToShortDateString());
                writer.Close();
            }
            Application.Exit();
        }
    }
}
