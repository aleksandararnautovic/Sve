using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPresentationLayer
{
    public partial class Test1 : System.Web.UI.Page
    {
        private StudentBusiness studentBusiness;

        public Test1()
        {
            this.studentBusiness = new StudentBusiness();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void RefreshData()
        {
            List<Student> students = this.studentBusiness.GetAllStudents();
            ListBox1.Items.Clear();
            foreach (Student s in students)
            {
                ListBox1.Items.Add(s.Name + "\t" + s.IndexNumber + "\t" + s.AverageMark);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = TextBox1.Text;
            s.IndexNumber = TextBox2.Text;
            s.AverageMark = Convert.ToDecimal(TextBox3.Text);
            this.studentBusiness.InsertStudent(s);
            RefreshData();
        }
    }
}