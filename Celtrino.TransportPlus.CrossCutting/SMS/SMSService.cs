using System;
using System.Collections.Generic;
using Celtrino.TransportPlus.Domain.Interfaces;

namespace Celtrino.TransportPlus.CrossCutting.SMS
{
    public class SMSService : ISMSService
    {
        public IEnumerable<string> GetMessages()
        {
            throw new NotImplementedException();
        }

        public bool SendMessage(string number, string message)
        {
            throw new NotImplementedException();
        }
    }
}
