using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Manager : Employee
    {
        protected internal int GetPromotion(Employee employee)
        {
            employee.Salary += 100;
            return employee.Salary;
        }
    }
}
