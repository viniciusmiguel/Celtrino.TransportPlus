using System;
using System.Collections.Generic;
using System.Text;

namespace Celtrino.TransportPlus.Domain.Interfaces
{
    public interface IEMailService
    {
        bool SendMessage(string to, string subject, string message);
    }
}
