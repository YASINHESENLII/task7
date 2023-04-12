using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Assistant : Employee
    {
        public void GetFeedback(Employee employee)
        {
            if (employee.IsSuccessful)
            {
                Manager manager = new Manager();
                manager.GetPromotion(employee);
            }
        }
    }
}
