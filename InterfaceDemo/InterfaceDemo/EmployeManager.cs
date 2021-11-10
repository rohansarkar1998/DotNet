using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class EmployeManager : IEmployeManager
    {
        List<IEmploye> empList = new List<IEmploye>();
        public void addEmploye(IEmploye e)
        {
            empList.Add(e);
        }

        public List<IEmploye> DisplayEmploye()
        {
            return (empList);
        }
    }
}
