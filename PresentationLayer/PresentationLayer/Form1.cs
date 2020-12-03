using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private StudentBusiness studentBusiness;
        public Form1()
        {
            this.studentBusiness = new StudentBusiness();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void RefreshData()
        {
            List<Student> students = this.studentBusiness.GetAllStudents();
            listBox1.Items.Clear();
            foreach(Student s in students)
            {
                listBox1.Items.Add(s.Name + "\t" + s.IndexNumber + "\t" + s.AverageMark);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = textBox1.Text;
            s.IndexNumber = textBox2.Text;
            s.AverageMark = Convert.ToDecimal(textBox3.Text);
            this.studentBusiness.InsertStudent(s);
            RefreshData();
        }
    }
}
