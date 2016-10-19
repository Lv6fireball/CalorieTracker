using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTracker
{
    class AccountCreator
    {
        public string name { set; get; }
        public double calorieLim { set; get; }

        public AccountCreator()
        {
            name = "No name";
            calorieLim = 0.0;
        }

        public AccountCreator(string accName, double calLimit)
        {
            name = accName;
            calorieLim = calLimit;
        }
    }
}
