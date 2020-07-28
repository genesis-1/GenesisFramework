using GenesisFramework.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenesisFramework.Domain.Core.Commands
{
    public class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {

        }
    }
}
