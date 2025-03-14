using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_01
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();
        public void AddCPU(string cpu) => computer.CPU = cpu;
        public void AddRAM(string ram) => computer.RAM = ram;
        public void AddHDD(string hdd) => computer.HDD = hdd;
        public void AddGPU(string gpu) => computer.GPU = gpu;
        public void AddOS(string os) => computer.OS = os;
        public Computer GetComputer()
        {
            return computer;
        }
    }
}
