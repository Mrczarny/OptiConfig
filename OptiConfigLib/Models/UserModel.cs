using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace OptiConfigLib.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public SecureString UserPassword { get; set; }
        public string UserPasswordHashed { get; set; }
        public string UserLocalGroup { get; set; }
        public bool UserNeverExpires { get; set; }
        public DateTime UserExpires { get; set; }
        public bool UserPasswordNeverExpires { get; set; }
        public bool UserCantChangePassword { get; set;}
        public string UserFullName { get; set; }
        public bool UserIsDisabled { get; set; }
        public string UserDescription { get; set; }
        
    }

}
