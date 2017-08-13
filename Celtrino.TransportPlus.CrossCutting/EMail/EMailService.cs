using System;
using System.Collections.Generic;
using System.Text;
using Celtrino.TransportPlus.Domain.Interfaces;

namespace Celtrino.TransportPlus.CrossCutting.EMail
{
    public class EMailService : IEMailService
    {
        public bool SendMessage(string to, string subject, string message)
        {
            throw new NotImplementedException();
        }
    }
}
