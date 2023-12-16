using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsociacionCivil
{
    class EmailCredentials
    {
        public string Sender { get; private set; }
        public string To { get; private set; }
        public string Password { get; private set; }
        public string Subject { get; private set; }
        public string Body { get; private set; }

        public EmailCredentials(string sender, string to, string passwd, string subject, string body)
        {
            Sender = sender;
            To = to;
            Password = passwd;
            Subject = subject;
            Body = body;
        }
    }
}
