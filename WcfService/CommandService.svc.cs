using Commands;
using Interfaces;
using System.Windows.Input;
using Models;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CommandService : ICommandService
    {
        public ICommand GetConsumeCommand(IShell consumeShell, IShell queueShell)
        {
            return new ConsumeCommand(consumeShell, queueShell);
        }

        public ICommand GetProduceCommand(IShell produceShell, IShell queueShell)
        {
           return new ProduceCommand(produceShell, queueShell);
        }

        public ICommand GetQueueCommand(IShell queueShell)
        {
            return new QueueCommandG<string>(queueShell);
        }

        public IShell GetShell(bool statusExecutable)
        {
            return new Shell() { StatusExecutable = statusExecutable };
        }

        public ICommand GetStopCommand(IShell queueShell)
        {
            return new StopCommand(queueShell);
        }

        public ICommand GetStopTask(IShell taskShell)
        {
            return new StopTask(taskShell);
        }
    }
}
