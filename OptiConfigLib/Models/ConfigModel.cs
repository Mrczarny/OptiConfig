using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiConfigLib.Models
{
    public class ConfigModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BitlockerModel BitlockerConfig { get; set; }
        public SecpolModel SecpolConfig { get; set; }
        public UserModel UserConfig { get; set; }


    }
}
