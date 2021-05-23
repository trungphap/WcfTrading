using Models;
using System.ServiceModel;
using System.Windows.Input;

namespace WcfService
{   
    [ServiceContract]
    public interface ICommandService
    {

        [OperationContract]
        ICommand GetQueueCommand(IShell queueShell);

        [OperationContract]
        ICommand GetStopCommand(IShell queueShell);

        [OperationContract]
        ICommand GetStopTask(IShell taskShell);

        [OperationContract]
        ICommand GetProduceCommand(IShell produceShell, IShell queueShell);

        [OperationContract]
        ICommand GetConsumeCommand(IShell consumeShell, IShell queueShell);

        [OperationContract]
        IShell GetShell(bool statusExecutable);


    }
}
