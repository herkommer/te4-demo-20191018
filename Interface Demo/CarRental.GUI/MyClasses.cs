using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.GUI
{
    public partial class Car 
    {
        public override string ToString()
        {
            return string.Format("{0} {1}", Make, Model);
        }
    }
}
