using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildComputer
{
    public class MotherBoard
    {
        public string manufactuer;
        Cpu Processor;
        Ram TemporaryMemory;
        HardDrive Storage;
        Gpu Graphics;

        public MotherBoard(string manufactuer, Cpu processor, Ram temporaryMemory, HardDrive storage, Gpu graphics)
        {
            this.manufactuer = manufactuer;
            Processor = processor;
            TemporaryMemory = temporaryMemory;
            Storage = storage;
            Graphics = graphics;
        }
    }

}
