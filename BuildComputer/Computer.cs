using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputer
{
    public class Computer
    {
        
        
        public Computer()
        {
            Cpu cpu = new Cpu("amd", "amd cpu");
            Gpu gpu = new Gpu("nvidia", 1.0);
            Ram ram = new Ram(4.0, "onyo");
            HardDrive hardDrive = new HardDrive(300.00, 200.00);
            MotherBoard motherBoard = new MotherBoard("avia", cpu,   );
        }
        //Games game = new Games("Call of Duty");

    }
}
