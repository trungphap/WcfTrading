using Models;
using Commands;
using System;
using System.Windows.Input;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CommandService : ICommandService
    {
        public ICommand GetQueueCommand(IShell queueShell)
        {
            return new QueueCommandG<string>(queueShell);
        }

        public ICommand GetStopCommand(IShell queueShell)
        {
            throw new NotImplementedException();
        }
    }
}
