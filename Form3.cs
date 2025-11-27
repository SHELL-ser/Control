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
    }
}
