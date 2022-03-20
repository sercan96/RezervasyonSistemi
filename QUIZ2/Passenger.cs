using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ2
{
    class Passenger
    {
        private int _seatNooo;
        private string _anyClasses;
        private string _nameandSurname;

        public string NameSurname
        {
            get => _nameandSurname;
            set => _nameandSurname = value;
           
        }

        public string anyClass {

            get => _anyClasses;
            set
            {
                if(value == "1")
                {
                    _anyClasses = "EconomyClass";
                }
                else if (value == "2")
                {
                    _anyClasses = "BusinessClass";
                }
                else
                {
                    Console.WriteLine("Lütfen 2 sayidan birini seçiniz.");
                }
            }
        }

        public int seatNo
        {
            get
            {
                return _seatNooo;
            }
            set
            {      
                if(_anyClasses == "EconomyClass")
                {
                    if (Program.EconomyClass.ContainsKey(value) && Program.EconomyClass[value] != "")
                    {
                        Program.Failed(value, this.NameSurname);
                    }
                    else if (!Program.EconomyClass.ContainsKey(value))
                    {
                        Program.FailedValue();
                    }
                    else
                    {
                        _seatNooo = value;
                    }
                }
                else if(_anyClasses == "BusinessClass")
                {
                    if (Program.BusinessClass.ContainsKey(value) && Program.BusinessClass[value] != "")
                    {
                        Program.Failed(value, this.NameSurname);
                    }
                    else if (!Program.BusinessClass.ContainsKey(value))
                    {
                        Program.FailedValue();
                    }
                    else
                    {
                        _seatNooo = value;
                    }
                }
               
               
            }
        }
      
    }
}
