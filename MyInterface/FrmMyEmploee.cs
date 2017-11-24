using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyInterface
{
    public partial class FrmMyEmploee : Form
    {
        public FrmMyEmploee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = { 2, 4, 6, 8, 1 };
            Array.Sort(nums);

            List<ClsEmployee> emplist = new List<ClsEmployee>();
            emplist.Add(new ClsEmployee { EmpName = "aaa", HireDate = DateTime.Now.AddDays(-7), JobTitle =JobTitle.Engineer , Salary = 40000 });
            emplist.Add(new ClsEmployee { EmpName = "bbb", HireDate = DateTime.Now.AddDays(-7), JobTitle =JobTitle.Engineer, Salary = 40000 });
            emplist.Add(new ClsEmployee { EmpName = "ccc", HireDate = DateTime.Now.AddDays(-7), JobTitle =JobTitle.Manager, Salary = 40000 });
            emplist.Add(new ClsEmployee { EmpName = "ddd", HireDate = DateTime.Now.AddDays(-7), JobTitle =JobTitle.Tester, Salary = 40000 });

            emplist.Sort();

            this.dataGridView1.DataSource = emplist;
            this.listBox1.DataSource = emplist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsEmployee a = new ClsEmployee { EmpName = "ddd", HireDate = DateTime.Now.AddDays(-7), JobTitle = JobTitle.Tester, Salary = 40000 };
            ClsEmployee b = new ClsEmployee { EmpName = "ddd", HireDate = DateTime.Now.AddDays(-7), JobTitle = JobTitle.Tester, Salary = 50000 };
            int result = a.CompareTo(b);
            if (result > 0)
            { MessageBox.Show("a>b"); }
            else if (result < 0)
            { MessageBox.Show("a<b"); }
            else
            { MessageBox.Show("a=b"); }

        }
    }
}
