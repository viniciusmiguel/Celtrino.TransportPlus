using System;
using System.Collections.Generic;
using System.Text;

namespace Celtrino.TransportPlus.Domain.Interfaces
{
    public interface ISMSService
    {
        IEnumerable<string> GetMessages();
        bool SendMessage(string number, string message);
    }
}
