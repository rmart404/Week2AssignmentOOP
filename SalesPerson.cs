using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    public abstract class Salesperson 
    {
        protected string fName;
        protected string lName;

        #region Properties
        public string FName
        {
            get
            {
                return fName; 
            }
            set
            {
                fName = value;
            }
        
        }

        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }

        }
        #endregion end Properties

        public Salesperson(string firstName, string lastName)
        {
            fName = firstName;
            lName = lastName;
        }


        public abstract void SalesPersonInfo();
    }
}