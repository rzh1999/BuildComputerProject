using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputer
{
    public class Games : Applications
    {
        public double requiredEffectiveMemory;
        
        public Games(string applicationName, string applicationType, double requiredRam, double requiredStorage, double requiredEffectiveMemory)
        {
            this.applicationName = applicationName;
            this.applicationType = applicationType;
            this.requiredRam = requiredRam;
            this.requiredStorage = requiredStorage;
            this.requiredEffectiveMemory = requiredEffectiveMemory;
        }


    }
}
