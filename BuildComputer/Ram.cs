using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputer
{
    public class Ram
    {
        public double totalGigabytes;
        public string brand;

        public Ram(double totalGigabytes, string brand)
        {
            this.totalGigabytes = totalGigabytes;
            this.brand = brand;
        }
    }
}
