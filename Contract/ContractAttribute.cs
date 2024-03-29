using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ContractAttribute : Attribute
    {
        public string CreatedBy { get; set; }
        public string Year { get; set; }
    }
}
