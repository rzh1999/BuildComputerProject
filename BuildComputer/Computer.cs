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
            //Cpu cpu = new Cpu("amd", "amd cpu");
            //Gpu gpu = new Gpu("nvidia", 1.0);
            //Ram ram = new Ram(4.0, "onyo");
            //HardDrive hardDrive = new HardDrive(300.00, 200.00);
            //MotherBoard motherBoard = new MotherBoard("avia", cpu,  ram, hardDrive, gpu );
            //Games game = new Games("Call of Duty", "Shooter", 1.0, 30.0,2.0);
            //int cpu.CheckVideoRequirements(game, gpu);
        }

        public void UseComputer()
        {
            Cpu cpu = new Cpu("amd", "amd cpu");
            Gpu gpu = new Gpu("nvidia", 1.0);
            Ram ram = new Ram(4.0, "onyo");
            HardDrive hardDrive = new HardDrive(300.00, 200.00);
            MotherBoard motherBoard = new MotherBoard("avia", cpu, ram, hardDrive, gpu);
            Games game = new Games("Call of Duty", "Shooter", 1.0, 30.0, 2.0);
            bool videoOk =  cpu.CheckVideoRequirements(game, gpu);
            bool appOk = cpu.CheckRequirements(game, hardDrive, ram);
            if (videoOk && appOk)
            {
                cpu.ProcessInstall(game,hardDrive,ram);
            }
        }
        //Games game = new Games("Call of Duty");

    }
}
