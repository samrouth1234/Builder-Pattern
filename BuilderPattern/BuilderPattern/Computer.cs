using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_01
{
    public class Computer
    {
        public string? CPU { get; set; }
        public string? RAM { get; set; }
        public string? HDD { get; set; }
        public string? GPU { get; set; }
        public string? OS { get; set; }

        public override string ToString()
        {
            return $"CPU: {CPU}\n RAM: {RAM}\n HDD: {HDD}\n GPU: {GPU}\n OS: {OS}";
        }
    }
}
