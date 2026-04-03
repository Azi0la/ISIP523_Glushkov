using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_PC_Builder
{
    partial class assembly_
    {
        public string FullPrice 
        { get 
            
            {
               return partassembly_.Sum(p => p.basepart_.price).ToString();
               // List<basepart_> baseparts = Core.Context.basepart_.ToList();
               // baseparts = baseparts.Where(b => b.partassembly_.Where(a => a.assemblyid == id).ToList() != new List<partassembly_>()).ToList();
               // return baseparts.Select(b => b.price).ToList().Sum().ToString();
            }
        }
    }
}
