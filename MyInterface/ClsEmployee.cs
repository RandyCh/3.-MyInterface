using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyInterface
{

    enum JobTitle
    {
        Manager,
        Engineer,
        Tester
    }
    class ClsEmployee:IComparable<ClsEmployee>
    {
        public string EmpName { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public JobTitle JobTitle { get; set; }

        public int CompareTo(ClsEmployee other  )
        {
            //this vs other
            if (this.Salary < other.Salary)
            {
                return -1;
            }
            else if (this.Salary > other.Salary)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return this.EmpName;
        }

    }
}
