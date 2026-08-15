using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    sealed class Processors: Printer
    {
        public int Id { get; set; }
        public int Core { get; set; }
        public string Name { get; set; }
    }

    //class ultraProcessor : Processors
    //{

    //}
}
