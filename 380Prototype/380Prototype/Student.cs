using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _380Prototype
{
    public class Student
    {

        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Major _major;

        public Major Major
        {
            get { return _major; }
            set { _major = value; }
        }



    }
}