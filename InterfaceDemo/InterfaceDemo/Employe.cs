using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Employe : IEmploye
    {
        public int iD;
        public string name;
        public DateTime doj;

        public Employe(int iD,string name,DateTime doj)
        {
            this.iD = iD;
            this.name = name;
            this.doj = doj;
        }
        public int ID
        {
            get
            {
                return (iD);
            }

            set
            {
                iD = value;
            }
        }

        public string Name
        {
            get
            {
                return (name);
            }

            set
            {
                name = value;
            }

        }

        public DateTime Doj
        {
            get
            {
                return (doj);
            }

            set
            {
                doj = value;
            }
        }
    }
}
