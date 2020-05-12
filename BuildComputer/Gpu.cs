using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputer
{
    public class Gpu
    {
        public string manufactuer;
        public double effectiveMemory;

        public Gpu(string manufactuer, double effectiveMemory)
        {
            this.manufactuer = manufactuer;
            this.effectiveMemory = effectiveMemory;
        }
    }
}
