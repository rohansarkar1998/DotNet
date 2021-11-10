using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    interface IEmployeManager
    {
        void addEmploye(IEmploye e);
        List<IEmploye> DisplayEmploye();

    }
}
