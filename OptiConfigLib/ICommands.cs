using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptiConfigLib.Models;

namespace OptiConfigLib
{
    public interface ICommands
    {
        string[] UserAdd(UserModel model);

        string[] SecPolEdit(SecpolModel model);

        string[] BitlockerEdit(BitlockerModel model);
    }
}
