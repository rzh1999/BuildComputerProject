using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputer
{
    class TextEditor : Applications
    {
        public TextEditor(string applicationName, string applicationType, double requiredRam, double requiredStorage)
        {
            this.applicationName = applicationName;
            this.applicationType = applicationType;
            this.requiredRam = requiredRam;
            this.requiredStorage = requiredStorage;
        }

    }
}

