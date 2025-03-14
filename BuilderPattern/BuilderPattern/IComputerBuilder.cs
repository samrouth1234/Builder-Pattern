using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_01
{
    public interface IComputerBuilder
    {
        void AddCPU(string cpu); // Central Processing Unit (CPU) it is a processor
        void AddRAM(string ram); // Random Access Memory (RAM) it is a memory device
        void AddHDD(string hdd); // Hard Disk Drive (HDD) it is storage device
        void AddGPU(string gpu); // Graphics Processing Unit (GPU) it is a video card
        void AddOS(string os); // Operating System (OS) it is a system software

        Computer GetComputer();
    }
}
