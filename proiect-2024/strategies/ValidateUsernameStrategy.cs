using proiect_2024.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_2024.strategies
{
    public class ValidateUsernameStrategy : IStrategy
    {
        public bool Check(string username)
        {
            for(int i = 0; i < username.Length; i++)
            {
                if (username[i] == ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
