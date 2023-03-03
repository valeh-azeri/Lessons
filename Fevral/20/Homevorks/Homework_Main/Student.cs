using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Main
{
    class Student
    {
        private string _name;
        private string _surname;
        private string _email;

        public Student()
        {

        }

        public string Name
        {
            get
            {
                return _email="";
             }
            set
            {
                if (value == "")
                {
                   
                    _email = "";
                    _name = "";
                }
                else
                {
                    this._name = value;
                    _email = "";
                }
            }
        }
        public string Surname
        {
            get
            {
                return _email;
            }
            set
            {
                if (value == "" || _name=="")
                {
                   
                    _email = "";
                    _surname = "";
                }
                else
                {
                    this._surname = value;
                    if (_surname=="")
                    {
                        _email = "";
                    }else 
                    this._email = _name + "." + _surname + "@gmail.com";
                }
            }
        }

    }
}
