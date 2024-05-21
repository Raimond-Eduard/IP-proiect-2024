using proiect_2024.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace proiect_2024.strategies
{
    public class ValidateEmailStrategy : IStrategy
    {
        public bool Check(string text)
        {
            try
            {
                MailAddress mail = new MailAddress(text);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

    }
}
