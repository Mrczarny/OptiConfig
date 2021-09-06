using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiConfigLib.Models
{
    public class SecpolModel
    {
        public bool SecpolEnabled { get; set; }
        public bool PasswordComplexity { get; set; }
        public int MinimumPasswordLength { get; set; }
        public int MaximumPasswordAge { get; set; }
        public int PasswordHistorySize { get; set; }

    }
}
