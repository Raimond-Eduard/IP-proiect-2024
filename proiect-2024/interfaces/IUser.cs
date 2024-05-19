using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_2024.interfaces
{
    public interface IUser
    {
        string _username {  get; set; }
        string _hashedPassword { set; }

        string _role { get; }

    }
}
