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
    public partial class Form6 : Form
    {
        public Student[] student = new Student[100];
        int n;
        void enterData()
        {
            using (StreamReader reader = new StreamReader("out.txt"))
            {
                int n = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    student[n] = new Student();
                    student[n].name = line;
                    line = reader.ReadLine();
                    student[n].ball = Convert.ToInt32(line);
                    line = reader.ReadLine();
                    student[n].day = Convert.ToDateTime(line);
                    line= reader.ReadLine();
                    enterTable(n, student[n]);
                    n++;
                }
                reader.Close();
            }
        }

        void enterTable(int i, Student s)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[0].Value = i + 1;
            dataGridView1.Rows[i].Cells[1].Value = s.name;
            dataGridView1.Rows[i].Cells[2].Value = s.ball;
            dataGridView1.Rows[i].Cells[3].Value = s.day.ToShortDateString();
        }

        public Form6()
        {
            InitializeComponent();
            enterData();
        }
    }
}
