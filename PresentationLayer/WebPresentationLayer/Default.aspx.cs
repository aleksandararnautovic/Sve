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
    public partial class _Default : Page
    {
        private StudentBusiness studentBusiness;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            this.studentBusiness = new StudentBusiness();
            RefreshData();
        }
        public void RefreshData()
        {
            List<Student> students = this.studentBusiness.GetAllStudents();
            listBox1.Items.Clear();
            foreach (Student s in students)
            {
                listBox1.Items.Add(s.Name + "\t" + s.IndexNumber + "\t" + s.AverageMark);
            }
        }
    }
}