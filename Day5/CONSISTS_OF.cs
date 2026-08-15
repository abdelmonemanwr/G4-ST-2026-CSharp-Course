using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Processor
    {
        public string Provider { get; set; }
        public int Cores { get; set; }
        public Processor(int Cores, string provider)
        {
            this.Cores = Cores;
            Provider = provider;
        }
    }

    class Computer
    {
        //Processor p = new Processor(4); // modify

        public Processor Processor { get; set; }

        public Computer(Processor processor)
        {
            Processor = processor;
        }
    }
}
