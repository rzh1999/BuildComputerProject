using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputer
{
    public class Cpu
    {
        public string manufactuer;
        public string name;


        public Cpu(string manufactuer, string name)
        {
            this.manufactuer = manufactuer;
            this.name = name;
        }

        public void ProcessInstall(Applications app, HardDrive hardDrive, Ram ram)
        {

            hardDrive.applicationsInHardDrive.Add(app);
            hardDrive.totalStorage -= app.requiredStorage;

        }

        public bool CheckRequirements(Applications app, HardDrive hardDrive, Ram ram)
        {
            if (ram.totalGigabytes > app.requiredRam && hardDrive.availableStorage > app.requiredStorage)
            {
                return true;
            }
            else { return false; }
        }

        public bool CheckVideoRequirements(Games games, Gpu gpu)
        {
            if (games.requiredEffectiveMemory < gpu.effectiveMemory)
            {
                return true;
            }
            else { return false; }
        }
    }
}
