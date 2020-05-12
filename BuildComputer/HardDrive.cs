using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputer
{
    public class HardDrive
    {
        public double totalStorage;
        public double availableStorage;
        public List<Applications> applicationsInHardDrive;

        public HardDrive(double totalStorage, double availableStorage)
        {
            this.totalStorage = totalStorage;
            this.availableStorage = availableStorage;
        }
    }
}
